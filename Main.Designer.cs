namespace NaverAutoClick
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShowProcess = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMiss = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonShowProcessing = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowProcess
            // 
            this.buttonShowProcess.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonShowProcess.ForeColor = System.Drawing.Color.White;
            this.buttonShowProcess.Location = new System.Drawing.Point(162, 0);
            this.buttonShowProcess.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonShowProcess.Name = "buttonShowProcess";
            this.buttonShowProcess.Size = new System.Drawing.Size(75, 33);
            this.buttonShowProcess.TabIndex = 4;
            this.buttonShowProcess.Text = "진행 창";
            this.buttonShowProcess.UseVisualStyleBackColor = false;
            this.buttonShowProcess.Click += new System.EventHandler(this.buttonShowProcess_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(0, 0);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 33);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "시작";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonStop.Enabled = false;
            this.buttonStop.ForeColor = System.Drawing.Color.White;
            this.buttonStop.Location = new System.Drawing.Point(81, 0);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 33);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "중지";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 19);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "건";
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.Color.SkyBlue;
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(29, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(41, 19);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "100";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "총";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labelMiss);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(117, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 19);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "건";
            // 
            // labelMiss
            // 
            this.labelMiss.BackColor = System.Drawing.Color.SkyBlue;
            this.labelMiss.ForeColor = System.Drawing.Color.White;
            this.labelMiss.Location = new System.Drawing.Point(43, 0);
            this.labelMiss.Name = "labelMiss";
            this.labelMiss.Size = new System.Drawing.Size(41, 19);
            this.labelMiss.TabIndex = 1;
            this.labelMiss.Text = "100";
            this.labelMiss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "누락";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxEnd);
            this.panel3.Controls.Add(this.textBoxStart);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(236, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 25);
            this.panel3.TabIndex = 3;
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.BackColor = System.Drawing.Color.SkyBlue;
            this.textBoxEnd.ForeColor = System.Drawing.Color.White;
            this.textBoxEnd.Location = new System.Drawing.Point(141, 0);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(41, 25);
            this.textBoxEnd.TabIndex = 1;
            this.textBoxEnd.Text = "1000";
            this.textBoxEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStart
            // 
            this.textBoxStart.BackColor = System.Drawing.Color.SkyBlue;
            this.textBoxStart.ForeColor = System.Drawing.Color.White;
            this.textBoxStart.Location = new System.Drawing.Point(43, 0);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(41, 25);
            this.textBoxStart.TabIndex = 0;
            this.textBoxStart.Text = "1";
            this.textBoxStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(90, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "~";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "끝";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "시작";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "업체명",
            "키워드"});
            this.comboBoxSearch.Location = new System.Drawing.Point(0, 5);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(87, 25);
            this.comboBoxSearch.TabIndex = 5;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(93, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(120, 25);
            this.textBoxSearch.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(219, 0);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 33);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonStart);
            this.panel4.Controls.Add(this.buttonStop);
            this.panel4.Controls.Add(this.buttonShowProcess);
            this.panel4.Location = new System.Drawing.Point(579, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 33);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.comboBoxSearch);
            this.panel5.Controls.Add(this.textBoxSearch);
            this.panel5.Controls.Add(this.buttonSearch);
            this.panel5.Location = new System.Drawing.Point(974, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(294, 33);
            this.panel5.TabIndex = 8;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AllowDrop = true;
            this.tableLayoutPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.tableLayoutPanel.ColumnCount = 12;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel.Controls.Add(this.checkBox1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.label12, 4, 0);
            this.tableLayoutPanel.Controls.Add(this.label13, 5, 0);
            this.tableLayoutPanel.Controls.Add(this.label14, 6, 0);
            this.tableLayoutPanel.Controls.Add(this.label15, 7, 0);
            this.tableLayoutPanel.Controls.Add(this.label16, 8, 0);
            this.tableLayoutPanel.Controls.Add(this.label17, 9, 0);
            this.tableLayoutPanel.Controls.Add(this.label18, 10, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 50);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1256, 713);
            this.tableLayoutPanel.TabIndex = 9;
            this.tableLayoutPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel_CellPaint);
            this.tableLayoutPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.tableLayoutPanel_DragDrop);
            this.tableLayoutPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.tableLayoutPanel_DragEnter);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.ThreeState = true;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "번호";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(166, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "업체명";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(393, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "키워드";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(535, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "순위";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(590, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "1/2/3 시간전";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(701, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "페이지";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(764, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "로그";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(814, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "횟수";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(857, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 19);
            this.label17.TabIndex = 2;
            this.label17.Text = "작성일/업데이트";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.label18, 2);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(1080, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 19);
            this.label18.TabIndex = 2;
            this.label18.Text = "제목/URL";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonDeleteSelected);
            this.panel6.Controls.Add(this.buttonShowAll);
            this.panel6.Controls.Add(this.buttonShowProcessing);
            this.panel6.Location = new System.Drawing.Point(12, 771);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(312, 33);
            this.panel6.TabIndex = 8;
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDeleteSelected.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteSelected.Location = new System.Drawing.Point(0, 0);
            this.buttonDeleteSelected.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(100, 33);
            this.buttonDeleteSelected.TabIndex = 2;
            this.buttonDeleteSelected.Text = "선택 삭제";
            this.buttonDeleteSelected.UseVisualStyleBackColor = false;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonShowAll.Enabled = false;
            this.buttonShowAll.ForeColor = System.Drawing.Color.White;
            this.buttonShowAll.Location = new System.Drawing.Point(106, 0);
            this.buttonShowAll.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(100, 33);
            this.buttonShowAll.TabIndex = 3;
            this.buttonShowAll.Text = "전체보기";
            this.buttonShowAll.UseVisualStyleBackColor = false;
            // 
            // buttonShowProcessing
            // 
            this.buttonShowProcessing.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonShowProcessing.ForeColor = System.Drawing.Color.White;
            this.buttonShowProcessing.Location = new System.Drawing.Point(212, 0);
            this.buttonShowProcessing.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonShowProcessing.Name = "buttonShowProcessing";
            this.buttonShowProcessing.Size = new System.Drawing.Size(100, 33);
            this.buttonShowProcessing.TabIndex = 4;
            this.buttonShowProcessing.Text = "진행만 보기";
            this.buttonShowProcessing.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1154, 778);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "222.222.222.222";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AcceptButton = this.buttonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 816);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "네이버 자동 클릭";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowProcess;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMiss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonShowProcessing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;

    }
}