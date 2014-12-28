using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaverAutoClick
{
    public partial class Main : Form
    {
        private Process process = new Process();
        private List<SearchData> searchList = new List<SearchData>();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (new Login().ShowDialog() == System.Windows.Forms.DialogResult.No)
            {
                this.Close();
            }

            searchList.AddRange(new SearchData[] {
                new SearchData("Realize", "안녕", 1, DateTime.Now, DateTime.Now, "http://cafe.naver.com/saekdongwoods/760")
            });
        }

        private void buttonShowProcess_Click(object sender, EventArgs e)
        {
            process.Show();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            process.Start(searchList);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            process.Stop();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            process.Stop();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row != 0)
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);

            Rectangle cellBounds = e.CellBounds;
            if (e.Row == (sender as TableLayoutPanel).RowCount - 1)
                cellBounds.Height -= 1;
            if (e.Column == (sender as TableLayoutPanel).ColumnCount - 1)
                cellBounds.Width -= 1;
            e.Graphics.DrawRectangle(Pens.DeepSkyBlue, cellBounds);
        }

        private void tableLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
            if (files.Length == 1)
            {
                List<SearchData> searchList = (List<SearchData>) new DataContractJsonSerializer(typeof(List<SearchData>)).ReadObject(File.OpenRead(files[0]));
                foreach (SearchData searchData in searchList)
                {
                    this.searchList.Add(searchData);
                }
            }
        }

        private void tableLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
