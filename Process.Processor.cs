using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NaverAutoClick
{
    public partial class Process
    {
        private Thread processThread;
        private bool isProcessThreadStopRequested;
        private List<SearchData> searchList;
        private SearchData currentSearchData;

        public void InitializeProcessor()
        {
        }

        public void Start(List<SearchData> searchList)
        {
            isProcessThreadStopRequested = false;
            this.searchList = searchList;
            processThread = new Thread(new ThreadStart(Processor));
            processThread.Start();
        }

        public void Stop()
        {
            if (processThread != null && processThread.IsAlive)
            {
                isProcessThreadStopRequested = true;
                processThread.Interrupt();
                processThread.Join();
            }
        }

        private void Processor()
        {
            try
            {
                while (true)
                {
                    List<SearchData>.Enumerator searchListEnumerator = searchList.GetEnumerator();
                    while (searchListEnumerator.MoveNext())
                    {
                        if (isProcessThreadStopRequested) return;

                        currentSearchData = searchListEnumerator.Current;

                        Search();
                        Find();
                    }
                }
            }
            catch (ThreadInterruptedException)
            {
                return;
            }
        }

        private void Search()
        {
            Navigate("http://m.naver.com/", true);

            InvokeScript("$(#query)[0].click()");
            InvokeScript("$(#query)[0].value = '" + currentSearchData.Keyword + "'");
            InvokeScript("$(button[type=submit])[0].click()");
            WaitNavigate();
        }

        private void Find()
        {
            for (int page = 1; page <= 14; page++)
            {
                if (int.Parse(InvokeScript("$(a[href='" + currentSearchData.Url + "']).length")) >= 1)
                {
                    InvokeScript("$(a[href='" + currentSearchData.Url + "'])[0].click()");
                    WaitNavigate();
                    break;
                }
                else
                {
                    if (InvokeScript("$(.pg2b_btn).length") == "0" || InvokeScript("$(.pg2b_btn)[1].getAttribute('class')").Contains("pg_dim"))
                        break;

                    InvokeScript("$(.pg2b_btn)[1].click()");
                    WaitNavigate();
                }
            }
        }
    }
}
