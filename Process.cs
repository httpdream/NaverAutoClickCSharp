using Microsoft.Win32;
using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaverAutoClick
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Process : Form
    {
        private BlockingCollection<string> completedDocumentList = new BlockingCollection<string>();
        private AutoResetEvent invokeScriptEvent = new AutoResetEvent(false);
        private string invokeScriptResult;

        public BlockingCollection<string> CompletedDocumentList
        {
          get { return completedDocumentList; }
        }

        public Process()
        {
            InitializeComponent();
            webBrowserProcess.ObjectForScripting = this;
            webBrowserProcess.ScriptErrorsSuppressed = true;
        }

        private void Process_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void textBoxWebBrowserProcessUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(textBoxWebBrowserProcessUrl.Text);
            }
        }

        private void webBrowserProcess_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBoxWebBrowserProcessUrl.Text = e.Url.ToString();
            completedDocumentList.TryAdd(e.Url.ToString());
        }

        public void SimpleInvoke(Control control, MethodInvoker invoker)
        {
            if (control.InvokeRequired)
            {
                this.Invoke(invoker);
            }
            else
            {
                invoker();
            }
        }

        public string Navigate(string url, bool wait = false)
        {
            SimpleInvoke(webBrowserProcess, () => { webBrowserProcess.Navigate(url, null, null, ""); });
            if (wait)
            {
                return WaitNavigate();
            }
            else
            {
                return url;
            }
        }

        public string WaitNavigate()
        {
            string url;
            completedDocumentList.TryTake(out url, -1);
            return url;
        }

        public string InvokeScript(string script)
        {
            while (true) {
                int start = script.IndexOf("$(") + 2;
                if (start == -1 + 2) break;
                int end = script.IndexOf(')');
                string query = script.Substring(start, end - start);
                script = script.Replace("$(" + query + ")", "document.querySelectorAll(\"" + query + "\")");
            }

            SimpleInvoke(webBrowserProcess, () => {
                webBrowserProcess.Document.InvokeScript("eval", new object[] { "window.external.InvokeScriptResult(" + script + ");" });
            });

            invokeScriptEvent.WaitOne();
            return invokeScriptResult;
        }

        public void InvokeScriptResult(string result)
        {
            invokeScriptResult = result;
            invokeScriptEvent.Set();
        }
    }
}
