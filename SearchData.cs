using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NaverAutoClick
{
    public class SearchData
    {
        public string Company;
        public string Keyword;
        private int rank = 0;
        public int TargetRank;
        private List<KeyValuePair<DateTime, int>> rankLogList = new List<KeyValuePair<DateTime, int>>();
        private int page = 0;
        public List<string> LogList = new List<string>();
        private int count = 0;
        public DateTime WrittenDate;
        public DateTime UpdatedDate;
        private string title = null;
        public string Url;
        public bool Exclude = false;

        public int Rank
        {
            get { return rank; }
        }

        public int GetRankBefore(int hours)
        {
            foreach (KeyValuePair<DateTime, int> rankLog in rankLogList)
            {
                if ((DateTime.Now - rankLog.Key).Hours == 0)
                {
                    return rankLog.Value;
                }
            }
            return 0;
        }

        public int Page
        {
            get { return page; }
        }

        public int Count
        {
            get { return count; }
        }

        public string Title
        {
            get
            {
                if (title == null)
                {
                    string source = new WebClient().DownloadString(Url);
                    int start = source.IndexOf("<title>") + 7;
                    int end = source.IndexOf("</title>");
                    if (start >= 0 && end >= 0 && end - start >= 0)
                    {
                        title = source.Substring(start, end - start);
                    }
                }
                return title;
            }
            set { title = Title; }
        }

        public SearchData(string company, string keyword, int targetRank, DateTime writtenDate, DateTime updatedDate, string url, Boolean exclude = false)
        {
            Company = company;
            Keyword = keyword;
            TargetRank = targetRank;
            WrittenDate = writtenDate;
            UpdatedDate = updatedDate;
            Url = url;
            Exclude = exclude;
        }
    }
}
