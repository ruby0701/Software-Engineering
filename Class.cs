using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace SchoolHelper
{
    public partial class Class : Form
    {
        private int hr, min, sec, year, mon, day;
        
        public Class()
        {
            InitializeComponent();
            hr = DateTime.UtcNow.Hour;
            min = DateTime.UtcNow.Minute;
            sec = DateTime.UtcNow.Second;

            comboBoxClassName.Items.Add("乖乖上課不要翹課唷");
            comboBoxClassName.SelectedIndex = 0;

            string path = @"D:\absent";
            string collecttemp = "";
            int count = 0;
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "");
            }
            collecttemp = File.ReadAllText(path);
            labelRecordListabsent.Text = collecttemp;
            StreamReader sr = new StreamReader(path);
            char[] a = collecttemp.ToCharArray();
            for (int i = 0; i < collecttemp.Length; i++)
            {
                if (a[i] == '\n')
                    count++;
            }
            sr.Close();
            textBoxCountsabsent.Text = (count).ToString();
        }

        int absent = 0;
        string[] temp = new string[20];
        string[] test = new string[20];
        
        /*private void button1_Click(object sender, EventArgs e)
        {
            absent++;

            absent++;
            test[absent] = comboBoxClassName.SelectedItem.ToString();
            textBoxCountsabsent.Text = (absent).ToString();
            //test[absent] = textBoxClassNameabsent.Text;
            temp[absent] = dateTimePickerabsent.Text;
            string collecttemp = "";
       

            for (int i = absent; i > 0; i--)
            {
                
                collecttemp = collecttemp + test[i] + " : " + temp[i] + "\n";
            }
            //textBox2.Text + " : " +
            labelRecordListabsent.Text = collecttemp;

        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            absent++;
            string path = @"D:\absent";
            string collecttemp = "";
            int count = 0;
            if (comboBoxClassName.SelectedItem != null)
            {
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, comboBoxClassName.SelectedItem.ToString() + " : " + dateTimePickerabsent.Text + "\n");
                    collecttemp = File.ReadAllText(path);
                    labelRecordListabsent.Text = collecttemp;
                    StreamReader sr = new StreamReader(path);
                    char[] a = collecttemp.ToCharArray();
                    for (int i = 0; i < collecttemp.Length; i++)
                    {
                        if (a[i] == '\n')
                            count++;
                    }
                    sr.Close();
                    comboBoxClassName.Text = (count).ToString();
                    textBoxCountsabsent.Text = (absent).ToString();
                }
                else
                {
                    comboBoxClassName.Text = (count).ToString();
                    collecttemp = File.ReadAllText(path);
                    collecttemp = collecttemp + comboBoxClassName.SelectedItem.ToString() + " : " + dateTimePickerabsent.Text + "\n";
                    labelRecordListabsent.Text = collecttemp;
                    StreamReader sr = new StreamReader(path);
                    char[] a = collecttemp.ToCharArray();
                    for (int i = 0; i < collecttemp.Length; i++)
                    {
                        if (a[i] == '\n')
                            count++;
                    }
                    comboBoxClassName.Text = (count).ToString();
                    sr.Close();
                    StreamWriter sw = new StreamWriter(path);
                    sw.Write(collecttemp);
                    textBoxCountsabsent.Text = (absent).ToString();
                    sw.Close();

                }
            }
        }
            /*absent++;
            test[absent] = comboBox1.SelectedItem.ToString();
            textBox1.Text = (absent).ToString();
            temp[absent] = AbsentdateTimePicker.Text;
            string collecttemp = "";
            for (int i = absent; i > 0; i--)
            {
                collecttemp = collecttemp + test[i] + " : " + temp[i] + "\n";
            }
            //textBox2.Text + " : " +*/
            //AbsentRecord.Text = collecttemp;

        int Day = 100, Time1 = 100, Time2 = 100;
        public void GetDay()
        {
            if (weekChoiceButton1.Checked == true)
            {
                Day = 0;
                return;
            }
            else if (weekChoiceButton2.Checked == true)
            {
                Day = 1;
                return;
            }
            else if (weekChoiceButton3.Checked == true)
            {
                Day = 2;
                return;
            }
            else if (weekChoiceButton4.Checked == true)
            {
                Day = 3;
                return;
            }
            else if (weekChoiceButton5.Checked == true)
            {
                Day = 4;
                return;
            }
        }
        public void GetTime1()
        {
            if (startClassCombo.Text == "第1節") { Time1 = 0; }
            else if (startClassCombo.Text == "第2節") { Time1 = 1; }
            else if (startClassCombo.Text == "第3節") { Time1 = 2; }
            else if (startClassCombo.Text == "第4節") { Time1 = 3; }
            else if (startClassCombo.Text == "第5節") { Time1 = 4; }
            else if (startClassCombo.Text == "第6節") { Time1 = 5; }
            else if (startClassCombo.Text == "第7節") { Time1 = 6; }
            else if (startClassCombo.Text == "第8節") { Time1 = 7; }
            return;
        }

        public void GetTime2()
        {
            if (endClassCombo.Text == "第1節") { Time2 = 0; }
            else if (endClassCombo.Text == "第2節") { Time2 = 1; }
            else if (endClassCombo.Text == "第3節") { Time2 = 2; }
            else if (endClassCombo.Text == "第4節") { Time2 = 3; }
            else if (endClassCombo.Text == "第5節") { Time2 = 4; }
            else if (endClassCombo.Text == "第6節") { Time2 = 5; }
            else if (endClassCombo.Text == "第7節") { Time2 = 6; }
            else if (endClassCombo.Text == "第8節") { Time2 = 7; }
            return;
        }

        #region Windows Form 設計工具產生的程式碼



        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟課表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增課表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存課表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新課表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.結束XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢視VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.軟體導覽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於SchoolHelperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.DateStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.eventTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.absentListPanel = new System.Windows.Forms.Panel();
            this.labelRecordListabsent = new System.Windows.Forms.Label();
            this.labelRecordabsent = new System.Windows.Forms.Label();
            this.absentBox = new System.Windows.Forms.GroupBox();
            this.buttonConfirmabsent = new System.Windows.Forms.Button();
            this.labelClassNameabsent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCountsabsent = new System.Windows.Forms.TextBox();
            this.dateTimePickerabsent = new System.Windows.Forms.DateTimePicker();
            this.labelAbsentTimesAccumulationabsent = new System.Windows.Forms.Label();
            this.comboBoxClassName = new System.Windows.Forms.ComboBox();
            this.newEventControlGroup = new System.Windows.Forms.GroupBox();
            this.comboBoxClassName2 = new System.Windows.Forms.ComboBox();
            this.labelClassNameToDo = new System.Windows.Forms.Label();
            this.textBoxTaskDetail = new System.Windows.Forms.TextBox();
            this.buttonAddNewToDo = new System.Windows.Forms.Button();
            this.dateTimePickerTaskTimetodo = new System.Windows.Forms.DateTimePicker();
            this.labelDueDaytodo = new System.Windows.Forms.Label();
            this.textBoxTaskTypetodo = new System.Windows.Forms.TextBox();
            this.labeltaskdetail = new System.Windows.Forms.Label();
            this.labelTaskTypetodo = new System.Windows.Forms.Label();
            this.labelToDoList = new System.Windows.Forms.Label();
            this.AbsentdataGridView = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finaltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleTab = new System.Windows.Forms.TabPage();
            this.labelNewCLassTitletimetable = new System.Windows.Forms.Label();
            this.newClassControlGroup = new System.Windows.Forms.GroupBox();
            this.delectclass = new System.Windows.Forms.Button();
            this.labelCLassNametimetable = new System.Windows.Forms.Label();
            this.textBoxClassroomNametimetable = new System.Windows.Forms.TextBox();
            this.buttonAddClasstimetable = new System.Windows.Forms.Button();
            this.labelClassTimetimetable = new System.Windows.Forms.Label();
            this.classroomNameLabel = new System.Windows.Forms.Label();
            this.textBoxClassNametimetable = new System.Windows.Forms.TextBox();
            this.textBoxTeacherNametimetable = new System.Windows.Forms.TextBox();
            this.weekPickBox = new System.Windows.Forms.GroupBox();
            this.weekChoiceButton5 = new System.Windows.Forms.RadioButton();
            this.weekChoiceButton4 = new System.Windows.Forms.RadioButton();
            this.weekChoiceButton3 = new System.Windows.Forms.RadioButton();
            this.weekChoiceButton2 = new System.Windows.Forms.RadioButton();
            this.weekChoiceButton1 = new System.Windows.Forms.RadioButton();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.classPickGroup = new System.Windows.Forms.GroupBox();
            this.endClassLabel = new System.Windows.Forms.Label();
            this.startClassLabel = new System.Windows.Forms.Label();
            this.startClassCombo = new System.Windows.Forms.ComboBox();
            this.endClassCombo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelTimeTable = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.x1y2 = new System.Windows.Forms.Label();
            this.x1y3 = new System.Windows.Forms.Label();
            this.x1y4 = new System.Windows.Forms.Label();
            this.x1y5 = new System.Windows.Forms.Label();
            this.x2y1 = new System.Windows.Forms.Label();
            this.x2y2 = new System.Windows.Forms.Label();
            this.x2y3 = new System.Windows.Forms.Label();
            this.x2y4 = new System.Windows.Forms.Label();
            this.x2y5 = new System.Windows.Forms.Label();
            this.x3y1 = new System.Windows.Forms.Label();
            this.x3y2 = new System.Windows.Forms.Label();
            this.x3y3 = new System.Windows.Forms.Label();
            this.x3y4 = new System.Windows.Forms.Label();
            this.x3y5 = new System.Windows.Forms.Label();
            this.x4y1 = new System.Windows.Forms.Label();
            this.x4y2 = new System.Windows.Forms.Label();
            this.x4y3 = new System.Windows.Forms.Label();
            this.x4y4 = new System.Windows.Forms.Label();
            this.x4y5 = new System.Windows.Forms.Label();
            this.x5y1 = new System.Windows.Forms.Label();
            this.x5y2 = new System.Windows.Forms.Label();
            this.x5y3 = new System.Windows.Forms.Label();
            this.x5y4 = new System.Windows.Forms.Label();
            this.x5y5 = new System.Windows.Forms.Label();
            this.x6y1 = new System.Windows.Forms.Label();
            this.x6y2 = new System.Windows.Forms.Label();
            this.x6y3 = new System.Windows.Forms.Label();
            this.x6y4 = new System.Windows.Forms.Label();
            this.x6y5 = new System.Windows.Forms.Label();
            this.x7y1 = new System.Windows.Forms.Label();
            this.x7y2 = new System.Windows.Forms.Label();
            this.x7y3 = new System.Windows.Forms.Label();
            this.x7y4 = new System.Windows.Forms.Label();
            this.x7y5 = new System.Windows.Forms.Label();
            this.x8y1 = new System.Windows.Forms.Label();
            this.x8y2 = new System.Windows.Forms.Label();
            this.x8y3 = new System.Windows.Forms.Label();
            this.x8y4 = new System.Windows.Forms.Label();
            this.x8y5 = new System.Windows.Forms.Label();
            this.labelx1y1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.eventTab.SuspendLayout();
            this.absentListPanel.SuspendLayout();
            this.absentBox.SuspendLayout();
            this.newEventControlGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbsentdataGridView)).BeginInit();
            this.scheduleTab.SuspendLayout();
            this.newClassControlGroup.SuspendLayout();
            this.weekPickBox.SuspendLayout();
            this.classPickGroup.SuspendLayout();
            this.tableLayoutPanelTimeTable.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案FToolStripMenuItem,
            this.編輯FToolStripMenuItem,
            this.檢視VToolStripMenuItem,
            this.說明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案FToolStripMenuItem
            // 
            this.檔案FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟課表ToolStripMenuItem,
            this.新增課表ToolStripMenuItem,
            this.儲存課表ToolStripMenuItem,
            this.另存新課表ToolStripMenuItem,
            this.toolStripSeparator1,
            this.結束XToolStripMenuItem});
            this.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem";
            this.檔案FToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.檔案FToolStripMenuItem.Text = "檔案(F)";
            // 
            // 開啟課表ToolStripMenuItem
            // 
            this.開啟課表ToolStripMenuItem.CheckOnClick = true;
            this.開啟課表ToolStripMenuItem.Name = "開啟課表ToolStripMenuItem";
            this.開啟課表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.開啟課表ToolStripMenuItem.Text = "開啟課表(N)";
            this.開啟課表ToolStripMenuItem.Click += new System.EventHandler(this.開啟課表ToolStripMenuItem_Click_1);
            // 
            // 新增課表ToolStripMenuItem
            // 
            this.新增課表ToolStripMenuItem.Name = "新增課表ToolStripMenuItem";
            this.新增課表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新增課表ToolStripMenuItem.Text = "新增課表(O)";
            this.新增課表ToolStripMenuItem.Click += new System.EventHandler(this.新增課表ToolStripMenuItem_Click);
            // 
            // 儲存課表ToolStripMenuItem
            // 
            this.儲存課表ToolStripMenuItem.Name = "儲存課表ToolStripMenuItem";
            this.儲存課表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.儲存課表ToolStripMenuItem.Text = "儲存課表(S)";
            this.儲存課表ToolStripMenuItem.Click += new System.EventHandler(this.儲存課表ToolStripMenuItem_Click);
            // 
            // 另存新課表ToolStripMenuItem
            // 
            this.另存新課表ToolStripMenuItem.Name = "另存新課表ToolStripMenuItem";
            this.另存新課表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.另存新課表ToolStripMenuItem.Text = "另存新課表(A)";
            this.另存新課表ToolStripMenuItem.Click += new System.EventHandler(this.另存新課表ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // 結束XToolStripMenuItem
            // 
            this.結束XToolStripMenuItem.Name = "結束XToolStripMenuItem";
            this.結束XToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.結束XToolStripMenuItem.Text = "結束(X)";
            this.結束XToolStripMenuItem.Click += new System.EventHandler(this.結束XToolStripMenuItem_Click);
            // 
            // 編輯FToolStripMenuItem
            // 
            this.編輯FToolStripMenuItem.Name = "編輯FToolStripMenuItem";
            this.編輯FToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.編輯FToolStripMenuItem.Text = "編輯(F)";
            this.編輯FToolStripMenuItem.Click += new System.EventHandler(this.編輯FToolStripMenuItem_Click);
            // 
            // 檢視VToolStripMenuItem
            // 
            this.檢視VToolStripMenuItem.Name = "檢視VToolStripMenuItem";
            this.檢視VToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.檢視VToolStripMenuItem.Text = "檢視(V)";
            this.檢視VToolStripMenuItem.Click += new System.EventHandler(this.檢視VToolStripMenuItem_Click);
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.軟體導覽ToolStripMenuItem,
            this.關於SchoolHelperToolStripMenuItem});
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.說明ToolStripMenuItem.Text = "說明(H)";
            // 
            // 軟體導覽ToolStripMenuItem
            // 
            this.軟體導覽ToolStripMenuItem.Name = "軟體導覽ToolStripMenuItem";
            this.軟體導覽ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.軟體導覽ToolStripMenuItem.Text = "軟體說明";
            this.軟體導覽ToolStripMenuItem.Click += new System.EventHandler(this.軟體導覽ToolStripMenuItem_Click_1);
            // 
            // 關於SchoolHelperToolStripMenuItem
            // 
            this.關於SchoolHelperToolStripMenuItem.Name = "關於SchoolHelperToolStripMenuItem";
            this.關於SchoolHelperToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.關於SchoolHelperToolStripMenuItem.Text = "關於School Helper";
            this.關於SchoolHelperToolStripMenuItem.Click += new System.EventHandler(this.關於SchoolHelperToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(888, 25);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DateStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 599);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(888, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // DateStatusLabel
            // 
            this.DateStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DateStatusLabel.Name = "DateStatusLabel";
            this.DateStatusLabel.Size = new System.Drawing.Size(129, 17);
            this.DateStatusLabel.Text = "Date And Time Status";
            this.DateStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // eventTab
            // 
            this.eventTab.Controls.Add(this.label8);
            this.eventTab.Controls.Add(this.absentListPanel);
            this.eventTab.Controls.Add(this.labelRecordabsent);
            this.eventTab.Controls.Add(this.absentBox);
            this.eventTab.Controls.Add(this.newEventControlGroup);
            this.eventTab.Controls.Add(this.labelToDoList);
            this.eventTab.Controls.Add(this.AbsentdataGridView);
            this.eventTab.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.eventTab.Location = new System.Drawing.Point(4, 22);
            this.eventTab.Name = "eventTab";
            this.eventTab.Padding = new System.Windows.Forms.Padding(3);
            this.eventTab.Size = new System.Drawing.Size(876, 518);
            this.eventTab.TabIndex = 1;
            this.eventTab.Text = "待辦事項";
            this.eventTab.UseVisualStyleBackColor = true;
            this.eventTab.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(15, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "新增缺席記錄";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // absentListPanel
            // 
            this.absentListPanel.AutoScroll = true;
            this.absentListPanel.Controls.Add(this.labelRecordListabsent);
            this.absentListPanel.Location = new System.Drawing.Point(290, 318);
            this.absentListPanel.Name = "absentListPanel";
            this.absentListPanel.Size = new System.Drawing.Size(569, 183);
            this.absentListPanel.TabIndex = 34;
            // 
            // labelRecordListabsent
            // 
            this.labelRecordListabsent.AutoSize = true;
            this.labelRecordListabsent.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRecordListabsent.Location = new System.Drawing.Point(3, 3);
            this.labelRecordListabsent.Name = "labelRecordListabsent";
            this.labelRecordListabsent.Size = new System.Drawing.Size(32, 17);
            this.labelRecordListabsent.TabIndex = 9;
            this.labelRecordListabsent.Text = "N/A";
            this.labelRecordListabsent.Click += new System.EventHandler(this.label22_Click);
            // 
            // labelRecordabsent
            // 
            this.labelRecordabsent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRecordabsent.AutoSize = true;
            this.labelRecordabsent.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRecordabsent.ForeColor = System.Drawing.Color.Black;
            this.labelRecordabsent.Location = new System.Drawing.Point(286, 293);
            this.labelRecordabsent.Name = "labelRecordabsent";
            this.labelRecordabsent.Size = new System.Drawing.Size(69, 19);
            this.labelRecordabsent.TabIndex = 9;
            this.labelRecordabsent.Text = "缺席記錄";
            // 
            // absentBox
            // 
            this.absentBox.Controls.Add(this.buttonConfirmabsent);
            this.absentBox.Controls.Add(this.labelClassNameabsent);
            this.absentBox.Controls.Add(this.label2);
            this.absentBox.Controls.Add(this.textBoxCountsabsent);
            this.absentBox.Controls.Add(this.dateTimePickerabsent);
            this.absentBox.Controls.Add(this.labelAbsentTimesAccumulationabsent);
            this.absentBox.Controls.Add(this.comboBoxClassName);
            this.absentBox.Location = new System.Drawing.Point(14, 318);
            this.absentBox.Name = "absentBox";
            this.absentBox.Size = new System.Drawing.Size(253, 183);
            this.absentBox.TabIndex = 36;
            this.absentBox.TabStop = false;
            this.absentBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonConfirmabsent
            // 
            this.buttonConfirmabsent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonConfirmabsent.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonConfirmabsent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfirmabsent.Location = new System.Drawing.Point(13, 137);
            this.buttonConfirmabsent.Name = "buttonConfirmabsent";
            this.buttonConfirmabsent.Size = new System.Drawing.Size(199, 23);
            this.buttonConfirmabsent.TabIndex = 0;
            this.buttonConfirmabsent.Text = "缺席";
            this.buttonConfirmabsent.UseVisualStyleBackColor = true;
            this.buttonConfirmabsent.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelClassNameabsent
            // 
            this.labelClassNameabsent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelClassNameabsent.AutoSize = true;
            this.labelClassNameabsent.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelClassNameabsent.ForeColor = System.Drawing.Color.Black;
            this.labelClassNameabsent.Location = new System.Drawing.Point(8, 29);
            this.labelClassNameabsent.Name = "labelClassNameabsent";
            this.labelClassNameabsent.Size = new System.Drawing.Size(84, 19);
            this.labelClassNameabsent.TabIndex = 2;
            this.labelClassNameabsent.Text = "課程名稱：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "缺席日期：";
            // 
            // textBoxCountsabsent
            // 
            this.textBoxCountsabsent.Location = new System.Drawing.Point(118, 92);
            this.textBoxCountsabsent.Name = "textBoxCountsabsent";
            this.textBoxCountsabsent.Size = new System.Drawing.Size(103, 23);
            this.textBoxCountsabsent.TabIndex = 1;
            this.textBoxCountsabsent.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePickerabsent
            // 
            this.dateTimePickerabsent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerabsent.Location = new System.Drawing.Point(98, 62);
            this.dateTimePickerabsent.Name = "dateTimePickerabsent";
            this.dateTimePickerabsent.Size = new System.Drawing.Size(123, 23);
            this.dateTimePickerabsent.TabIndex = 3;
            this.dateTimePickerabsent.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // labelAbsentTimesAccumulationabsent
            // 
            this.labelAbsentTimesAccumulationabsent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAbsentTimesAccumulationabsent.AutoSize = true;
            this.labelAbsentTimesAccumulationabsent.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAbsentTimesAccumulationabsent.ForeColor = System.Drawing.Color.Black;
            this.labelAbsentTimesAccumulationabsent.Location = new System.Drawing.Point(6, 97);
            this.labelAbsentTimesAccumulationabsent.Name = "labelAbsentTimesAccumulationabsent";
            this.labelAbsentTimesAccumulationabsent.Size = new System.Drawing.Size(114, 19);
            this.labelAbsentTimesAccumulationabsent.TabIndex = 2;
            this.labelAbsentTimesAccumulationabsent.Text = "累積缺席次數：";
            // 
            // comboBoxClassName
            // 
            this.comboBoxClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClassName.FormattingEnabled = true;
            this.comboBoxClassName.Location = new System.Drawing.Point(98, 23);
            this.comboBoxClassName.Name = "comboBoxClassName";
            this.comboBoxClassName.Size = new System.Drawing.Size(123, 24);
            this.comboBoxClassName.TabIndex = 3;
            // 
            // newEventControlGroup
            // 
            this.newEventControlGroup.Controls.Add(this.comboBoxClassName2);
            this.newEventControlGroup.Controls.Add(this.labelClassNameToDo);
            this.newEventControlGroup.Controls.Add(this.textBoxTaskDetail);
            this.newEventControlGroup.Controls.Add(this.buttonAddNewToDo);
            this.newEventControlGroup.Controls.Add(this.dateTimePickerTaskTimetodo);
            this.newEventControlGroup.Controls.Add(this.labelDueDaytodo);
            this.newEventControlGroup.Controls.Add(this.textBoxTaskTypetodo);
            this.newEventControlGroup.Controls.Add(this.labeltaskdetail);
            this.newEventControlGroup.Controls.Add(this.labelTaskTypetodo);
            this.newEventControlGroup.Location = new System.Drawing.Point(14, 51);
            this.newEventControlGroup.Name = "newEventControlGroup";
            this.newEventControlGroup.Size = new System.Drawing.Size(253, 220);
            this.newEventControlGroup.TabIndex = 28;
            this.newEventControlGroup.TabStop = false;
            // 
            // comboBoxClassName2
            // 
            this.comboBoxClassName2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClassName2.FormattingEnabled = true;
            this.comboBoxClassName2.Location = new System.Drawing.Point(98, 17);
            this.comboBoxClassName2.Name = "comboBoxClassName2";
            this.comboBoxClassName2.Size = new System.Drawing.Size(114, 24);
            this.comboBoxClassName2.TabIndex = 29;
            this.comboBoxClassName2.SelectedIndexChanged += new System.EventHandler(this.comboBoxClassName2_SelectedIndexChanged);
            // 
            // labelClassNameToDo
            // 
            this.labelClassNameToDo.AutoSize = true;
            this.labelClassNameToDo.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelClassNameToDo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelClassNameToDo.Location = new System.Drawing.Point(6, 22);
            this.labelClassNameToDo.Name = "labelClassNameToDo";
            this.labelClassNameToDo.Size = new System.Drawing.Size(84, 19);
            this.labelClassNameToDo.TabIndex = 20;
            this.labelClassNameToDo.Text = "課程名稱：";
            // 
            // textBoxTaskDetail
            // 
            this.textBoxTaskDetail.Location = new System.Drawing.Point(98, 86);
            this.textBoxTaskDetail.Name = "textBoxTaskDetail";
            this.textBoxTaskDetail.Size = new System.Drawing.Size(114, 23);
            this.textBoxTaskDetail.TabIndex = 27;
            // 
            // buttonAddNewToDo
            // 
            this.buttonAddNewToDo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewToDo.Location = new System.Drawing.Point(137, 181);
            this.buttonAddNewToDo.Name = "buttonAddNewToDo";
            this.buttonAddNewToDo.Size = new System.Drawing.Size(75, 33);
            this.buttonAddNewToDo.TabIndex = 15;
            this.buttonAddNewToDo.TabStop = false;
            this.buttonAddNewToDo.Text = "新增事項";
            this.buttonAddNewToDo.UseVisualStyleBackColor = true;
            this.buttonAddNewToDo.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePickerTaskTimetodo
            // 
            this.dateTimePickerTaskTimetodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTaskTimetodo.Location = new System.Drawing.Point(98, 119);
            this.dateTimePickerTaskTimetodo.Name = "dateTimePickerTaskTimetodo";
            this.dateTimePickerTaskTimetodo.Size = new System.Drawing.Size(114, 23);
            this.dateTimePickerTaskTimetodo.TabIndex = 19;
            this.dateTimePickerTaskTimetodo.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged_1);
            // 
            // labelDueDaytodo
            // 
            this.labelDueDaytodo.AutoSize = true;
            this.labelDueDaytodo.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelDueDaytodo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDueDaytodo.Location = new System.Drawing.Point(6, 121);
            this.labelDueDaytodo.Name = "labelDueDaytodo";
            this.labelDueDaytodo.Size = new System.Drawing.Size(84, 19);
            this.labelDueDaytodo.TabIndex = 22;
            this.labelDueDaytodo.Text = "最終期限：";
            // 
            // textBoxTaskTypetodo
            // 
            this.textBoxTaskTypetodo.Location = new System.Drawing.Point(98, 53);
            this.textBoxTaskTypetodo.Name = "textBoxTaskTypetodo";
            this.textBoxTaskTypetodo.Size = new System.Drawing.Size(114, 23);
            this.textBoxTaskTypetodo.TabIndex = 18;
            this.textBoxTaskTypetodo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labeltaskdetail
            // 
            this.labeltaskdetail.AutoSize = true;
            this.labeltaskdetail.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labeltaskdetail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labeltaskdetail.Location = new System.Drawing.Point(6, 88);
            this.labeltaskdetail.Name = "labeltaskdetail";
            this.labeltaskdetail.Size = new System.Drawing.Size(84, 19);
            this.labeltaskdetail.TabIndex = 26;
            this.labeltaskdetail.Text = "關於內容：";
            // 
            // labelTaskTypetodo
            // 
            this.labelTaskTypetodo.AutoSize = true;
            this.labelTaskTypetodo.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTaskTypetodo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTaskTypetodo.Location = new System.Drawing.Point(6, 55);
            this.labelTaskTypetodo.Name = "labelTaskTypetodo";
            this.labelTaskTypetodo.Size = new System.Drawing.Size(84, 19);
            this.labelTaskTypetodo.TabIndex = 21;
            this.labelTaskTypetodo.Text = "事務種類：";
            this.labelTaskTypetodo.Click += new System.EventHandler(this.label18_Click);
            // 
            // labelToDoList
            // 
            this.labelToDoList.AutoSize = true;
            this.labelToDoList.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelToDoList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelToDoList.Location = new System.Drawing.Point(14, 28);
            this.labelToDoList.Name = "labelToDoList";
            this.labelToDoList.Size = new System.Drawing.Size(124, 24);
            this.labelToDoList.TabIndex = 23;
            this.labelToDoList.Text = "新增待辦事項";
            // 
            // AbsentdataGridView
            // 
            this.AbsentdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AbsentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbsentdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.Type,
            this.text,
            this.Deadline,
            this.finaltime});
            this.AbsentdataGridView.Location = new System.Drawing.Point(290, 28);
            this.AbsentdataGridView.Name = "AbsentdataGridView";
            this.AbsentdataGridView.RowTemplate.Height = 24;
            this.AbsentdataGridView.Size = new System.Drawing.Size(569, 243);
            this.AbsentdataGridView.TabIndex = 17;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject name";
            this.Subject.Name = "Subject";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // text
            // 
            this.text.HeaderText = "About";
            this.text.Name = "text";
            // 
            // Deadline
            // 
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.Name = "Deadline";
            // 
            // finaltime
            // 
            this.finaltime.HeaderText = "Last time";
            this.finaltime.Name = "finaltime";
            // 
            // scheduleTab
            // 
            this.scheduleTab.Controls.Add(this.labelNewCLassTitletimetable);
            this.scheduleTab.Controls.Add(this.newClassControlGroup);
            this.scheduleTab.Controls.Add(this.tableLayoutPanelTimeTable);
            this.scheduleTab.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.scheduleTab.Location = new System.Drawing.Point(4, 22);
            this.scheduleTab.Name = "scheduleTab";
            this.scheduleTab.Padding = new System.Windows.Forms.Padding(3);
            this.scheduleTab.Size = new System.Drawing.Size(876, 518);
            this.scheduleTab.TabIndex = 0;
            this.scheduleTab.Text = "功課表";
            this.scheduleTab.UseVisualStyleBackColor = true;
            this.scheduleTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // labelNewCLassTitletimetable
            // 
            this.labelNewCLassTitletimetable.AutoSize = true;
            this.labelNewCLassTitletimetable.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelNewCLassTitletimetable.ForeColor = System.Drawing.Color.Black;
            this.labelNewCLassTitletimetable.Location = new System.Drawing.Point(18, 21);
            this.labelNewCLassTitletimetable.Name = "labelNewCLassTitletimetable";
            this.labelNewCLassTitletimetable.Size = new System.Drawing.Size(86, 24);
            this.labelNewCLassTitletimetable.TabIndex = 23;
            this.labelNewCLassTitletimetable.Text = "新增課程";
            // 
            // newClassControlGroup
            // 
            this.newClassControlGroup.Controls.Add(this.delectclass);
            this.newClassControlGroup.Controls.Add(this.labelCLassNametimetable);
            this.newClassControlGroup.Controls.Add(this.textBoxClassroomNametimetable);
            this.newClassControlGroup.Controls.Add(this.buttonAddClasstimetable);
            this.newClassControlGroup.Controls.Add(this.labelClassTimetimetable);
            this.newClassControlGroup.Controls.Add(this.classroomNameLabel);
            this.newClassControlGroup.Controls.Add(this.textBoxClassNametimetable);
            this.newClassControlGroup.Controls.Add(this.textBoxTeacherNametimetable);
            this.newClassControlGroup.Controls.Add(this.weekPickBox);
            this.newClassControlGroup.Controls.Add(this.teacherNameLabel);
            this.newClassControlGroup.Controls.Add(this.classPickGroup);
            this.newClassControlGroup.Location = new System.Drawing.Point(14, 45);
            this.newClassControlGroup.Name = "newClassControlGroup";
            this.newClassControlGroup.Size = new System.Drawing.Size(290, 282);
            this.newClassControlGroup.TabIndex = 43;
            this.newClassControlGroup.TabStop = false;
            // 
            // delectclass
            // 
            this.delectclass.ForeColor = System.Drawing.Color.Black;
            this.delectclass.Location = new System.Drawing.Point(100, 243);
            this.delectclass.Name = "delectclass";
            this.delectclass.Size = new System.Drawing.Size(69, 25);
            this.delectclass.TabIndex = 43;
            this.delectclass.Text = "刪除";
            this.delectclass.UseVisualStyleBackColor = true;
            this.delectclass.Click += new System.EventHandler(this.delectclass_Click);
            // 
            // labelCLassNametimetable
            // 
            this.labelCLassNametimetable.AutoSize = true;
            this.labelCLassNametimetable.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCLassNametimetable.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelCLassNametimetable.Location = new System.Drawing.Point(6, 27);
            this.labelCLassNametimetable.Name = "labelCLassNametimetable";
            this.labelCLassNametimetable.Size = new System.Drawing.Size(84, 19);
            this.labelCLassNametimetable.TabIndex = 24;
            this.labelCLassNametimetable.Text = "課程名稱：";
            // 
            // textBoxClassroomNametimetable
            // 
            this.textBoxClassroomNametimetable.Location = new System.Drawing.Point(96, 88);
            this.textBoxClassroomNametimetable.Name = "textBoxClassroomNametimetable";
            this.textBoxClassroomNametimetable.Size = new System.Drawing.Size(114, 23);
            this.textBoxClassroomNametimetable.TabIndex = 42;
            // 
            // buttonAddClasstimetable
            // 
            this.buttonAddClasstimetable.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAddClasstimetable.ForeColor = System.Drawing.Color.Black;
            this.buttonAddClasstimetable.Location = new System.Drawing.Point(196, 243);
            this.buttonAddClasstimetable.Name = "buttonAddClasstimetable";
            this.buttonAddClasstimetable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAddClasstimetable.Size = new System.Drawing.Size(69, 25);
            this.buttonAddClasstimetable.TabIndex = 31;
            this.buttonAddClasstimetable.Text = "增加";
            this.buttonAddClasstimetable.UseVisualStyleBackColor = true;
            this.buttonAddClasstimetable.Click += new System.EventHandler(this.add_class_Click);
            // 
            // labelClassTimetimetable
            // 
            this.labelClassTimetimetable.AutoSize = true;
            this.labelClassTimetimetable.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelClassTimetimetable.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelClassTimetimetable.Location = new System.Drawing.Point(6, 122);
            this.labelClassTimetimetable.Name = "labelClassTimetimetable";
            this.labelClassTimetimetable.Size = new System.Drawing.Size(90, 19);
            this.labelClassTimetimetable.TabIndex = 25;
            this.labelClassTimetimetable.Text = "時間/節次：";
            // 
            // classroomNameLabel
            // 
            this.classroomNameLabel.AutoSize = true;
            this.classroomNameLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classroomNameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.classroomNameLabel.Location = new System.Drawing.Point(6, 89);
            this.classroomNameLabel.Name = "classroomNameLabel";
            this.classroomNameLabel.Size = new System.Drawing.Size(84, 19);
            this.classroomNameLabel.TabIndex = 41;
            this.classroomNameLabel.Text = "教室編號：";
            // 
            // textBoxClassNametimetable
            // 
            this.textBoxClassNametimetable.Location = new System.Drawing.Point(96, 24);
            this.textBoxClassNametimetable.Name = "textBoxClassNametimetable";
            this.textBoxClassNametimetable.Size = new System.Drawing.Size(114, 23);
            this.textBoxClassNametimetable.TabIndex = 26;
            this.textBoxClassNametimetable.TextChanged += new System.EventHandler(this.classname_TextChanged);
            // 
            // textBoxTeacherNametimetable
            // 
            this.textBoxTeacherNametimetable.Location = new System.Drawing.Point(96, 57);
            this.textBoxTeacherNametimetable.Name = "textBoxTeacherNametimetable";
            this.textBoxTeacherNametimetable.Size = new System.Drawing.Size(114, 23);
            this.textBoxTeacherNametimetable.TabIndex = 40;
            // 
            // weekPickBox
            // 
            this.weekPickBox.Controls.Add(this.weekChoiceButton5);
            this.weekPickBox.Controls.Add(this.weekChoiceButton4);
            this.weekPickBox.Controls.Add(this.weekChoiceButton3);
            this.weekPickBox.Controls.Add(this.weekChoiceButton2);
            this.weekPickBox.Controls.Add(this.weekChoiceButton1);
            this.weekPickBox.Location = new System.Drawing.Point(96, 116);
            this.weekPickBox.Name = "weekPickBox";
            this.weekPickBox.Size = new System.Drawing.Size(84, 112);
            this.weekPickBox.TabIndex = 37;
            this.weekPickBox.TabStop = false;
            // 
            // weekChoiceButton5
            // 
            this.weekChoiceButton5.AutoSize = true;
            this.weekChoiceButton5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.weekChoiceButton5.Location = new System.Drawing.Point(11, 86);
            this.weekChoiceButton5.Name = "weekChoiceButton5";
            this.weekChoiceButton5.Size = new System.Drawing.Size(62, 20);
            this.weekChoiceButton5.TabIndex = 4;
            this.weekChoiceButton5.TabStop = true;
            this.weekChoiceButton5.Text = "星期五";
            this.weekChoiceButton5.UseVisualStyleBackColor = true;
            // 
            // weekChoiceButton4
            // 
            this.weekChoiceButton4.AutoSize = true;
            this.weekChoiceButton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.weekChoiceButton4.Location = new System.Drawing.Point(11, 67);
            this.weekChoiceButton4.Name = "weekChoiceButton4";
            this.weekChoiceButton4.Size = new System.Drawing.Size(62, 20);
            this.weekChoiceButton4.TabIndex = 3;
            this.weekChoiceButton4.TabStop = true;
            this.weekChoiceButton4.Text = "星期四";
            this.weekChoiceButton4.UseVisualStyleBackColor = true;
            // 
            // weekChoiceButton3
            // 
            this.weekChoiceButton3.AutoSize = true;
            this.weekChoiceButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.weekChoiceButton3.Location = new System.Drawing.Point(11, 48);
            this.weekChoiceButton3.Name = "weekChoiceButton3";
            this.weekChoiceButton3.Size = new System.Drawing.Size(62, 20);
            this.weekChoiceButton3.TabIndex = 2;
            this.weekChoiceButton3.TabStop = true;
            this.weekChoiceButton3.Text = "星期三";
            this.weekChoiceButton3.UseVisualStyleBackColor = true;
            // 
            // weekChoiceButton2
            // 
            this.weekChoiceButton2.AutoSize = true;
            this.weekChoiceButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.weekChoiceButton2.Location = new System.Drawing.Point(11, 29);
            this.weekChoiceButton2.Name = "weekChoiceButton2";
            this.weekChoiceButton2.Size = new System.Drawing.Size(62, 20);
            this.weekChoiceButton2.TabIndex = 1;
            this.weekChoiceButton2.TabStop = true;
            this.weekChoiceButton2.Text = "星期二";
            this.weekChoiceButton2.UseVisualStyleBackColor = true;
            // 
            // weekChoiceButton1
            // 
            this.weekChoiceButton1.AutoSize = true;
            this.weekChoiceButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.weekChoiceButton1.Location = new System.Drawing.Point(11, 11);
            this.weekChoiceButton1.Name = "weekChoiceButton1";
            this.weekChoiceButton1.Size = new System.Drawing.Size(62, 20);
            this.weekChoiceButton1.TabIndex = 0;
            this.weekChoiceButton1.TabStop = true;
            this.weekChoiceButton1.Text = "星期一";
            this.weekChoiceButton1.UseVisualStyleBackColor = true;
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherNameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.teacherNameLabel.Location = new System.Drawing.Point(6, 58);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(84, 19);
            this.teacherNameLabel.TabIndex = 39;
            this.teacherNameLabel.Text = "老師名稱：";
            this.teacherNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // classPickGroup
            // 
            this.classPickGroup.Controls.Add(this.endClassLabel);
            this.classPickGroup.Controls.Add(this.startClassLabel);
            this.classPickGroup.Controls.Add(this.startClassCombo);
            this.classPickGroup.Controls.Add(this.endClassCombo);
            this.classPickGroup.Location = new System.Drawing.Point(190, 116);
            this.classPickGroup.Name = "classPickGroup";
            this.classPickGroup.Size = new System.Drawing.Size(82, 112);
            this.classPickGroup.TabIndex = 38;
            this.classPickGroup.TabStop = false;
            // 
            // endClassLabel
            // 
            this.endClassLabel.AutoSize = true;
            this.endClassLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.endClassLabel.Location = new System.Drawing.Point(12, 63);
            this.endClassLabel.Name = "endClassLabel";
            this.endClassLabel.Size = new System.Drawing.Size(56, 16);
            this.endClassLabel.TabIndex = 37;
            this.endClassLabel.Text = "結束堂數";
            // 
            // startClassLabel
            // 
            this.startClassLabel.AutoSize = true;
            this.startClassLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.startClassLabel.Location = new System.Drawing.Point(12, 14);
            this.startClassLabel.Name = "startClassLabel";
            this.startClassLabel.Size = new System.Drawing.Size(56, 16);
            this.startClassLabel.TabIndex = 36;
            this.startClassLabel.Text = "起始堂數";
            this.startClassLabel.Click += new System.EventHandler(this.startClassLabel_Click);
            // 
            // startClassCombo
            // 
            this.startClassCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startClassCombo.FormattingEnabled = true;
            this.startClassCombo.Items.AddRange(new object[] {
            "第1節",
            "第2節",
            "第3節",
            "第4節",
            "第5節",
            "第6節",
            "第7節",
            "第8節"});
            this.startClassCombo.Location = new System.Drawing.Point(6, 34);
            this.startClassCombo.Name = "startClassCombo";
            this.startClassCombo.Size = new System.Drawing.Size(69, 24);
            this.startClassCombo.TabIndex = 34;
            // 
            // endClassCombo
            // 
            this.endClassCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endClassCombo.FormattingEnabled = true;
            this.endClassCombo.Items.AddRange(new object[] {
            "第1節",
            "第2節",
            "第3節",
            "第4節",
            "第5節",
            "第6節",
            "第7節",
            "第8節"});
            this.endClassCombo.Location = new System.Drawing.Point(6, 82);
            this.endClassCombo.Name = "endClassCombo";
            this.endClassCombo.Size = new System.Drawing.Size(69, 24);
            this.endClassCombo.TabIndex = 35;
            // 
            // tableLayoutPanelTimeTable
            // 
            this.tableLayoutPanelTimeTable.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanelTimeTable.ColumnCount = 6;
            this.tableLayoutPanelTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.18213F));
            this.tableLayoutPanelTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.18213F));
            this.tableLayoutPanelTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.18213F));
            this.tableLayoutPanelTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.18213F));
            this.tableLayoutPanelTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.18213F));
            this.tableLayoutPanelTimeTable.Controls.Add(this.label7, 5, 0);
            this.tableLayoutPanelTimeTable.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanelTimeTable.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanelTimeTable.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanelTimeTable.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanelTimeTable.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanelTimeTable.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanelTimeTable.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanelTimeTable.Controls.Add(this.label13, 0, 5);
            this.tableLayoutPanelTimeTable.Controls.Add(this.label14, 0, 6);
            this.tableLayoutPanelTimeTable.Controls.Add(this.label15, 0, 7);
            this.tableLayoutPanelTimeTable.Controls.Add(this.label16, 0, 8);
            this.tableLayoutPanelTimeTable.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x1y2, 2, 1);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x1y3, 3, 1);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x1y4, 4, 1);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x1y5, 5, 1);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x2y1, 1, 2);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x2y2, 2, 2);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x2y3, 3, 2);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x2y4, 4, 2);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x2y5, 5, 2);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x3y1, 1, 3);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x3y2, 2, 3);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x3y3, 3, 3);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x3y4, 4, 3);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x3y5, 5, 3);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x4y1, 1, 4);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x4y2, 2, 4);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x4y3, 3, 4);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x4y4, 4, 4);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x4y5, 5, 4);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x5y1, 1, 5);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x5y2, 2, 5);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x5y3, 3, 5);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x5y4, 4, 5);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x5y5, 5, 5);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x6y1, 1, 6);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x6y2, 2, 6);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x6y3, 3, 6);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x6y4, 4, 6);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x6y5, 5, 6);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x7y1, 1, 7);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x7y2, 2, 7);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x7y3, 3, 7);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x7y4, 4, 7);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x7y5, 5, 7);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x8y1, 1, 8);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x8y2, 2, 8);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x8y3, 3, 8);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x8y4, 4, 8);
            this.tableLayoutPanelTimeTable.Controls.Add(this.x8y5, 5, 8);
            this.tableLayoutPanelTimeTable.Controls.Add(this.labelx1y1, 1, 1);
            this.tableLayoutPanelTimeTable.Location = new System.Drawing.Point(321, 8);
            this.tableLayoutPanelTimeTable.Name = "tableLayoutPanelTimeTable";
            this.tableLayoutPanelTimeTable.RowCount = 9;
            this.tableLayoutPanelTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTimeTable.Size = new System.Drawing.Size(547, 502);
            this.tableLayoutPanelTimeTable.TabIndex = 32;
            this.tableLayoutPanelTimeTable.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel1_CellPaint);
            this.tableLayoutPanelTimeTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(470, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "星期五";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(365, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "星期四";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(260, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "星期三";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "星期一";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(155, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "星期二";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(3, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "1";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(3, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "3";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(3, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "4";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(3, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "5";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(3, 349);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "6";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(3, 404);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "7";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(3, 463);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 16);
            this.label16.TabIndex = 19;
            this.label16.Text = "8";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(3, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "2";
            // 
            // x1y2
            // 
            this.x1y2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x1y2.AutoSize = true;
            this.x1y2.Location = new System.Drawing.Point(178, 74);
            this.x1y2.Name = "x1y2";
            this.x1y2.Size = new System.Drawing.Size(0, 16);
            this.x1y2.TabIndex = 21;
            // 
            // x1y3
            // 
            this.x1y3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x1y3.AutoSize = true;
            this.x1y3.Location = new System.Drawing.Point(283, 74);
            this.x1y3.Name = "x1y3";
            this.x1y3.Size = new System.Drawing.Size(0, 16);
            this.x1y3.TabIndex = 22;
            // 
            // x1y4
            // 
            this.x1y4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x1y4.AutoSize = true;
            this.x1y4.Location = new System.Drawing.Point(388, 74);
            this.x1y4.Name = "x1y4";
            this.x1y4.Size = new System.Drawing.Size(0, 16);
            this.x1y4.TabIndex = 23;
            // 
            // x1y5
            // 
            this.x1y5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x1y5.AutoSize = true;
            this.x1y5.Location = new System.Drawing.Point(494, 74);
            this.x1y5.Name = "x1y5";
            this.x1y5.Size = new System.Drawing.Size(0, 16);
            this.x1y5.TabIndex = 24;
            // 
            // x2y1
            // 
            this.x2y1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x2y1.AutoSize = true;
            this.x2y1.Location = new System.Drawing.Point(73, 129);
            this.x2y1.Name = "x2y1";
            this.x2y1.Size = new System.Drawing.Size(0, 16);
            this.x2y1.TabIndex = 25;
            // 
            // x2y2
            // 
            this.x2y2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x2y2.AutoSize = true;
            this.x2y2.Location = new System.Drawing.Point(178, 129);
            this.x2y2.Name = "x2y2";
            this.x2y2.Size = new System.Drawing.Size(0, 16);
            this.x2y2.TabIndex = 26;
            // 
            // x2y3
            // 
            this.x2y3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x2y3.AutoSize = true;
            this.x2y3.Location = new System.Drawing.Point(283, 129);
            this.x2y3.Name = "x2y3";
            this.x2y3.Size = new System.Drawing.Size(0, 16);
            this.x2y3.TabIndex = 27;
            // 
            // x2y4
            // 
            this.x2y4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x2y4.AutoSize = true;
            this.x2y4.Location = new System.Drawing.Point(388, 129);
            this.x2y4.Name = "x2y4";
            this.x2y4.Size = new System.Drawing.Size(0, 16);
            this.x2y4.TabIndex = 28;
            // 
            // x2y5
            // 
            this.x2y5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x2y5.AutoSize = true;
            this.x2y5.Location = new System.Drawing.Point(494, 129);
            this.x2y5.Name = "x2y5";
            this.x2y5.Size = new System.Drawing.Size(0, 16);
            this.x2y5.TabIndex = 29;
            // 
            // x3y1
            // 
            this.x3y1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x3y1.AutoSize = true;
            this.x3y1.Location = new System.Drawing.Point(73, 184);
            this.x3y1.Name = "x3y1";
            this.x3y1.Size = new System.Drawing.Size(0, 16);
            this.x3y1.TabIndex = 30;
            // 
            // x3y2
            // 
            this.x3y2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x3y2.AutoSize = true;
            this.x3y2.Location = new System.Drawing.Point(178, 184);
            this.x3y2.Name = "x3y2";
            this.x3y2.Size = new System.Drawing.Size(0, 16);
            this.x3y2.TabIndex = 31;
            // 
            // x3y3
            // 
            this.x3y3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x3y3.AutoSize = true;
            this.x3y3.Location = new System.Drawing.Point(283, 184);
            this.x3y3.Name = "x3y3";
            this.x3y3.Size = new System.Drawing.Size(0, 16);
            this.x3y3.TabIndex = 32;
            // 
            // x3y4
            // 
            this.x3y4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x3y4.AutoSize = true;
            this.x3y4.Location = new System.Drawing.Point(388, 184);
            this.x3y4.Name = "x3y4";
            this.x3y4.Size = new System.Drawing.Size(0, 16);
            this.x3y4.TabIndex = 33;
            // 
            // x3y5
            // 
            this.x3y5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x3y5.AutoSize = true;
            this.x3y5.Location = new System.Drawing.Point(494, 184);
            this.x3y5.Name = "x3y5";
            this.x3y5.Size = new System.Drawing.Size(0, 16);
            this.x3y5.TabIndex = 34;
            // 
            // x4y1
            // 
            this.x4y1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x4y1.AutoSize = true;
            this.x4y1.Location = new System.Drawing.Point(73, 239);
            this.x4y1.Name = "x4y1";
            this.x4y1.Size = new System.Drawing.Size(0, 16);
            this.x4y1.TabIndex = 35;
            // 
            // x4y2
            // 
            this.x4y2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x4y2.AutoSize = true;
            this.x4y2.Location = new System.Drawing.Point(178, 239);
            this.x4y2.Name = "x4y2";
            this.x4y2.Size = new System.Drawing.Size(0, 16);
            this.x4y2.TabIndex = 36;
            // 
            // x4y3
            // 
            this.x4y3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x4y3.AutoSize = true;
            this.x4y3.Location = new System.Drawing.Point(283, 239);
            this.x4y3.Name = "x4y3";
            this.x4y3.Size = new System.Drawing.Size(0, 16);
            this.x4y3.TabIndex = 37;
            // 
            // x4y4
            // 
            this.x4y4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x4y4.AutoSize = true;
            this.x4y4.Location = new System.Drawing.Point(388, 239);
            this.x4y4.Name = "x4y4";
            this.x4y4.Size = new System.Drawing.Size(0, 16);
            this.x4y4.TabIndex = 38;
            // 
            // x4y5
            // 
            this.x4y5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x4y5.AutoSize = true;
            this.x4y5.Location = new System.Drawing.Point(494, 239);
            this.x4y5.Name = "x4y5";
            this.x4y5.Size = new System.Drawing.Size(0, 16);
            this.x4y5.TabIndex = 39;
            // 
            // x5y1
            // 
            this.x5y1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x5y1.AutoSize = true;
            this.x5y1.Location = new System.Drawing.Point(73, 294);
            this.x5y1.Name = "x5y1";
            this.x5y1.Size = new System.Drawing.Size(0, 16);
            this.x5y1.TabIndex = 40;
            // 
            // x5y2
            // 
            this.x5y2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x5y2.AutoSize = true;
            this.x5y2.Location = new System.Drawing.Point(178, 294);
            this.x5y2.Name = "x5y2";
            this.x5y2.Size = new System.Drawing.Size(0, 16);
            this.x5y2.TabIndex = 41;
            // 
            // x5y3
            // 
            this.x5y3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x5y3.AutoSize = true;
            this.x5y3.Location = new System.Drawing.Point(283, 294);
            this.x5y3.Name = "x5y3";
            this.x5y3.Size = new System.Drawing.Size(0, 16);
            this.x5y3.TabIndex = 42;
            // 
            // x5y4
            // 
            this.x5y4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x5y4.AutoSize = true;
            this.x5y4.Location = new System.Drawing.Point(388, 294);
            this.x5y4.Name = "x5y4";
            this.x5y4.Size = new System.Drawing.Size(0, 16);
            this.x5y4.TabIndex = 43;
            // 
            // x5y5
            // 
            this.x5y5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x5y5.AutoSize = true;
            this.x5y5.Location = new System.Drawing.Point(494, 294);
            this.x5y5.Name = "x5y5";
            this.x5y5.Size = new System.Drawing.Size(0, 16);
            this.x5y5.TabIndex = 44;
            // 
            // x6y1
            // 
            this.x6y1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x6y1.AutoSize = true;
            this.x6y1.Location = new System.Drawing.Point(73, 349);
            this.x6y1.Name = "x6y1";
            this.x6y1.Size = new System.Drawing.Size(0, 16);
            this.x6y1.TabIndex = 45;
            // 
            // x6y2
            // 
            this.x6y2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x6y2.AutoSize = true;
            this.x6y2.Location = new System.Drawing.Point(178, 349);
            this.x6y2.Name = "x6y2";
            this.x6y2.Size = new System.Drawing.Size(0, 16);
            this.x6y2.TabIndex = 46;
            // 
            // x6y3
            // 
            this.x6y3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x6y3.AutoSize = true;
            this.x6y3.Location = new System.Drawing.Point(283, 349);
            this.x6y3.Name = "x6y3";
            this.x6y3.Size = new System.Drawing.Size(0, 16);
            this.x6y3.TabIndex = 47;
            // 
            // x6y4
            // 
            this.x6y4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x6y4.AutoSize = true;
            this.x6y4.Location = new System.Drawing.Point(388, 349);
            this.x6y4.Name = "x6y4";
            this.x6y4.Size = new System.Drawing.Size(0, 16);
            this.x6y4.TabIndex = 48;
            // 
            // x6y5
            // 
            this.x6y5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x6y5.AutoSize = true;
            this.x6y5.Location = new System.Drawing.Point(494, 349);
            this.x6y5.Name = "x6y5";
            this.x6y5.Size = new System.Drawing.Size(0, 16);
            this.x6y5.TabIndex = 49;
            // 
            // x7y1
            // 
            this.x7y1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x7y1.AutoSize = true;
            this.x7y1.Location = new System.Drawing.Point(73, 404);
            this.x7y1.Name = "x7y1";
            this.x7y1.Size = new System.Drawing.Size(0, 16);
            this.x7y1.TabIndex = 50;
            // 
            // x7y2
            // 
            this.x7y2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x7y2.AutoSize = true;
            this.x7y2.Location = new System.Drawing.Point(178, 404);
            this.x7y2.Name = "x7y2";
            this.x7y2.Size = new System.Drawing.Size(0, 16);
            this.x7y2.TabIndex = 51;
            // 
            // x7y3
            // 
            this.x7y3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x7y3.AutoSize = true;
            this.x7y3.Location = new System.Drawing.Point(283, 404);
            this.x7y3.Name = "x7y3";
            this.x7y3.Size = new System.Drawing.Size(0, 16);
            this.x7y3.TabIndex = 52;
            // 
            // x7y4
            // 
            this.x7y4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x7y4.AutoSize = true;
            this.x7y4.Location = new System.Drawing.Point(388, 404);
            this.x7y4.Name = "x7y4";
            this.x7y4.Size = new System.Drawing.Size(0, 16);
            this.x7y4.TabIndex = 53;
            // 
            // x7y5
            // 
            this.x7y5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x7y5.AutoSize = true;
            this.x7y5.Location = new System.Drawing.Point(494, 404);
            this.x7y5.Name = "x7y5";
            this.x7y5.Size = new System.Drawing.Size(0, 16);
            this.x7y5.TabIndex = 54;
            // 
            // x8y1
            // 
            this.x8y1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x8y1.AutoSize = true;
            this.x8y1.Location = new System.Drawing.Point(73, 463);
            this.x8y1.Name = "x8y1";
            this.x8y1.Size = new System.Drawing.Size(0, 16);
            this.x8y1.TabIndex = 55;
            // 
            // x8y2
            // 
            this.x8y2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x8y2.AutoSize = true;
            this.x8y2.Location = new System.Drawing.Point(178, 463);
            this.x8y2.Name = "x8y2";
            this.x8y2.Size = new System.Drawing.Size(0, 16);
            this.x8y2.TabIndex = 56;
            // 
            // x8y3
            // 
            this.x8y3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x8y3.AutoSize = true;
            this.x8y3.Location = new System.Drawing.Point(283, 463);
            this.x8y3.Name = "x8y3";
            this.x8y3.Size = new System.Drawing.Size(0, 16);
            this.x8y3.TabIndex = 57;
            // 
            // x8y4
            // 
            this.x8y4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x8y4.AutoSize = true;
            this.x8y4.Location = new System.Drawing.Point(388, 463);
            this.x8y4.Name = "x8y4";
            this.x8y4.Size = new System.Drawing.Size(0, 16);
            this.x8y4.TabIndex = 58;
            // 
            // x8y5
            // 
            this.x8y5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x8y5.AutoSize = true;
            this.x8y5.Location = new System.Drawing.Point(494, 463);
            this.x8y5.Name = "x8y5";
            this.x8y5.Size = new System.Drawing.Size(0, 16);
            this.x8y5.TabIndex = 59;
            // 
            // labelx1y1
            // 
            this.labelx1y1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelx1y1.AutoSize = true;
            this.labelx1y1.Location = new System.Drawing.Point(73, 74);
            this.labelx1y1.Name = "labelx1y1";
            this.labelx1y1.Size = new System.Drawing.Size(0, 16);
            this.labelx1y1.TabIndex = 20;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.scheduleTab);
            this.tabControl1.Controls.Add(this.eventTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 544);
            this.tabControl1.TabIndex = 34;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(888, 621);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Helper Beta";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.Load += new System.EventHandler(this.Class_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.eventTab.ResumeLayout(false);
            this.eventTab.PerformLayout();
            this.absentListPanel.ResumeLayout(false);
            this.absentListPanel.PerformLayout();
            this.absentBox.ResumeLayout(false);
            this.absentBox.PerformLayout();
            this.newEventControlGroup.ResumeLayout(false);
            this.newEventControlGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbsentdataGridView)).EndInit();
            this.scheduleTab.ResumeLayout(false);
            this.scheduleTab.PerformLayout();
            this.newClassControlGroup.ResumeLayout(false);
            this.newClassControlGroup.PerformLayout();
            this.weekPickBox.ResumeLayout(false);
            this.weekPickBox.PerformLayout();
            this.classPickGroup.ResumeLayout(false);
            this.classPickGroup.PerformLayout();
            this.tableLayoutPanelTimeTable.ResumeLayout(false);
            this.tableLayoutPanelTimeTable.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Class_Load(object sender, EventArgs e)
        {

        }

        private int lastd, lastm, lasty;
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            hr = DateTime.UtcNow.Hour - 4;
            min = DateTime.UtcNow.Minute;
            sec = DateTime.UtcNow.Second;
            mon = DateTime.UtcNow.Month;
            year = DateTime.UtcNow.Year;
            day = DateTime.UtcNow.Day;


            lastd = dateTimePickerTaskTimetodo.Value.Day - DateTime.UtcNow.Day;
            lastm = dateTimePickerTaskTimetodo.Value.Month - DateTime.UtcNow.Month;
            lasty = dateTimePickerTaskTimetodo.Value.Year - DateTime.UtcNow.Year;


            if (hr >= 12)
                hr = hr - 12;
            else if (hr < 12)
                hr = hr + 12;
            if (sec % 2 == 0)
            {
                DateStatusLabel.Text = year + "/" + mon + "/" + day + "      " + sec + " : " + min + " : " + hr;
            }
            else
            {
                DateStatusLabel.Text = year + "/" + mon + "/" + day + "      " + sec + " : " + min + " : " + hr;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView10_CellClick(object sender, DataGridViewCellEventArgs e)
        {               
        }

        private void add_class_Click(object sender, EventArgs e)
        {
            string s;
            s = textBoxClassNametimetable.Text;

            //comboBox1.Items.Add(textBoxClassNametimetable.Text);
            GetDay();
            GetTime1();
            GetTime2();
            int day = Day + 1;
            int time1 = Time1 + 1;
            int time2 = Time2 + 1;
            if (time1 > time2)
            {
                MessageBox.Show("結束堂數不能比起始堂數大喔！", "發生了一點錯誤><b");
            }
       
            else
            {
                comboBoxClassName.Items.Add(s);
                comboBoxClassName2.Items.Add(s);

                switch (day)
                {
                    case 1: //星期一
                        if (time1 == 1 && time2 >= time1)
                        {
                            labelx1y1.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        //labelx1y1.ForeColorChanged();

                        if (time1 == 2 && time2 >= time1)
                        {
                            x2y1.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 3 && time2 >= time1)
                        {
                            x3y1.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 4 && time2 >= time1)
                        {
                            x4y1.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 5 && time2 >= time1)
                        {
                            x5y1.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 6 && time2 >= time1)
                        {
                            x6y1.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 7 && time2 >= time1)
                        {
                            x7y1.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 8 && time2 >= time1)
                        {
                            x8y1.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        break;
                    case 2: //星期二
                        if (time1 == 1 && time2 >= time1)
                        {
                            x1y2.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 2 && time2 >= time1)
                        {
                            x2y2.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 3 && time2 >= time1)
                        {
                            x3y2.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 4 && time2 >= time1)
                        {
                            x4y2.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 5 && time2 >= time1)
                        {
                            x5y2.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 6 && time2 >= time1)
                        {
                            x6y2.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 7 && time2 >= time1)
                        {
                            x7y2.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 8 && time2 >= time1)
                        {
                            x8y2.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        break;
                    case 3: //星期三
                        if (time1 == 1 && time2 >= time1)
                        {
                            x1y3.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 2 && time2 >= time1)
                        {
                            x2y3.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 3 && time2 >= time1)
                        {
                            x3y3.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 4 && time2 >= time1)
                        {
                            x4y3.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 5 && time2 >= time1)
                        {
                            x5y3.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 6 && time2 >= time1)
                        {
                            x6y3.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 7 && time2 >= time1)
                        {
                            x7y3.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 8 && time2 >= time1)
                        {
                            x8y3.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        break;
                    case 4: //星期四
                        if (time1 == 1 && time2 >= time1)
                        {
                            x1y4.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 2 && time2 >= time1)
                        {
                            x2y4.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 3 && time2 >= time1)
                        {
                            x3y4.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 4 && time2 >= time1)
                        {
                            x4y4.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 5 && time2 >= time1)
                        {
                            x5y4.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 6 && time2 >= time1)
                        {
                            x6y4.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 7 && time2 >= time1)
                        {
                            x7y4.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 8 && time2 >= time1)
                        {
                            x8y4.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        break;
                    case 5: //星期五
                        if (time1 == 1 && time2 >= time1)
                        {
                            x1y5.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 2 && time2 >= time1)
                        {
                            x2y5.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 3 && time2 >= time1)
                        {
                            x3y5.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 4 && time2 >= time1)
                        {
                            x4y5.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 5 && time2 >= time1)
                        {
                            x5y5.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 6 && time2 >= time1)
                        {
                            x6y5.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 7 && time2 >= time1)
                        {
                            x7y5.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        if (time1 == 8 && time2 >= time1)
                        {
                            x8y5.Text = textBoxClassNametimetable.Text + "\n" + textBoxTeacherNametimetable.Text + " / " + textBoxClassroomNametimetable.Text;
                            ++time1;
                        }
                        break;
                    default:
                        break;
                }               

            }
        }

        private void classname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds);
            ControlPaint.DrawBorder(e.Graphics, (sender as Control).DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void tableLayoutPanel2_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds);
            ControlPaint.DrawBorder(e.Graphics, (sender as Control).DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonForInformation_Click(object sender, EventArgs e)
        {
            Instruction helpMe = new Instruction();
            helpMe.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string subject, type,about;
            int date, month, year, last;

            subject = comboBoxClassName2.SelectedItem.ToString();
            type = textBoxTaskTypetodo.Text;
            date = dateTimePickerTaskTimetodo.Value.Day;
            month = dateTimePickerTaskTimetodo.Value.Month;
            year = dateTimePickerTaskTimetodo.Value.Year;
            about = textBoxTaskDetail.Text;
            last = 30 * lastm + lastd + 365 * lasty;

            DataGridViewRowCollection rows = AbsentdataGridView.Rows;

            if (last > 0)
                rows.Add(new Object[] { subject, type, about, month + "- " + date + " - " + year, last + "-days" });
            else
                MessageBox.Show("新增事項的日期要在今天之後喔!", "糟糕，好像出了點問題> <b");


            /*
             * string[] row = new string[] { subject, type, month + "- " + date + " - " + year, last + "-days" };

            if (last > 0)
                AbsentdataGridView.Rows.Add(row);
            */
            textBoxTaskTypetodo.Clear();
            //textBoxClassNametodo.Clear();
            textBoxTaskDetail.Clear();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void 開啟課表ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 軟體導覽ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
    
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            hr = DateTime.UtcNow.Hour - 4;
            min = DateTime.UtcNow.Minute;
            sec = DateTime.UtcNow.Second;
            mon = DateTime.UtcNow.Month;
            year = DateTime.UtcNow.Year;
            day = DateTime.UtcNow.Day;



            if (hr >= 12)
                hr = hr - 12;
            else if (hr < 12)
                hr = hr + 12;
            if (sec % 2 == 0)
            {
                /*if (sec < 10 && min >= 10)
                {
                    DateLabel.Text = hr + " : " + min + " : " + "0" + sec;
                    TimeLabel.Text = year + "/" + mon + "/" + day;
                }
                if (sec < 10 && min < 10)
                {
                    DateLabel.Text = hr + " : " + "0" + min + " : " + "0" + sec;
                    TimeLabel.Text = year + "/" + mon + "/" + day;
                }
                if (sec >= 10 && min < 10)
                {
                    DateLabel.Text = hr + " : " + "0" + min + " : " + sec;
                    TimeLabel.Text = year + "/" + mon + "/" + day;
                }*/

                DateStatusLabel.Text = year + "/" + mon + "/" + day + " " + hr + " : " + min + " : " + sec;

            }
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 軟體導覽ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Instruction helpMe = new Instruction();
            helpMe.ShowDialog();
        }

        private void 開啟課表ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StillWorking working = new StillWorking();
            working.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void 另存新課表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StillWorking working = new StillWorking();
            working.ShowDialog();
        }

        private void 儲存課表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StillWorking working = new StillWorking();
            working.ShowDialog();
        }

        private void 新增課表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StillWorking working = new StillWorking();
            working.ShowDialog();
        }

        private void 編輯FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StillWorking working = new StillWorking();
            working.ShowDialog();
        }

        private void 檢視VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StillWorking working = new StillWorking();
            working.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            StillWorking working = new StillWorking();
            working.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            StillWorking working = new StillWorking();
            working.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            StillWorking working = new StillWorking();
            working.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            StillWorking working = new StillWorking();
            working.ShowDialog();
        }

        private void textBoxClassNameabsent_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startClassLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxClassName2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       private void delectclass_Click(object sender, EventArgs e)
        {
            GetDay();
            GetTime1();
            GetTime2();
            int day = Day + 1;
            int time1 = Time1 + 1;
            int time2 = Time2 + 1;
            if (time1 > time2)
            {
                MessageBox.Show("結束堂數不能比起始堂數大喔！", "發生了一點錯誤><b");
            }

            else
            {
                comboBoxClassName.Items.Remove(textBoxClassNametimetable.Text);
                comboBoxClassName2.Items.Remove(textBoxClassNametimetable.Text);
                switch (day)
                {
                    case 1: //星期一
                        if (time1 == 1 && time2 >= time1)
                        {
                            labelx1y1.Text = " ";
                            ++time1;
                        }
                        if (time1 == 2 && time2 >= time1)
                        {
                            x2y1.Text = " ";
                            ++time1;
                        }
                        if (time1 == 3 && time2 >= time1)
                        {
                            x3y1.Text = " ";
                            ++time1;
                        }
                        if (time1 == 4 && time2 >= time1)
                        {
                            x4y1.Text = " ";
                            ++time1;
                        }
                        if (time1 == 5 && time2 >= time1)
                        {
                            x5y1.Text = " ";
                            ++time1;
                        }
                        if (time1 == 6 && time2 >= time1)
                        {
                            x6y1.Text = " ";
                            ++time1;
                        }
                        if (time1 == 7 && time2 >= time1)
                        {
                            x7y1.Text = " ";
                            ++time1;
                        }
                        if (time1 == 8 && time2 >= time1)
                        {
                            x8y1.Text = " ";
                            ++time1;
                        }
                        break;
                    case 2: //星期二
                        if (time1 == 1 && time2 >= time1)
                        {
                            x1y2.Text = " ";
                            ++time1;
                        }
                        if (time1 == 2 && time2 >= time1)
                        {
                            x2y2.Text = " ";
                            ++time1;
                        }
                        if (time1 == 3 && time2 >= time1)
                        {
                            x3y2.Text = " ";
                            ++time1;
                        }
                        if (time1 == 4 && time2 >= time1)
                        {
                            x4y2.Text = " ";
                            ++time1;
                        }
                        if (time1 == 5 && time2 >= time1)
                        {
                            x5y2.Text = " ";
                            ++time1;
                        }
                        if (time1 == 6 && time2 >= time1)
                        {
                            x6y2.Text = " ";
                            ++time1;
                        }
                        if (time1 == 7 && time2 >= time1)
                        {
                            x7y2.Text = " ";
                            ++time1;
                        }
                        if (time1 == 8 && time2 >= time1)
                        {
                            x8y2.Text = " ";
                            ++time1;
                        }
                        break;
                    case 3: //星期三
                        if (time1 == 1 && time2 >= time1)
                        {
                            x1y3.Text = " ";
                            ++time1;
                        }
                        if (time1 == 2 && time2 >= time1)
                        {
                            x2y3.Text = " ";
                            ++time1;
                        }
                        if (time1 == 3 && time2 >= time1)
                        {
                            x3y3.Text = " ";
                            ++time1;
                        }
                        if (time1 == 4 && time2 >= time1)
                        {
                            x4y3.Text = " ";
                            ++time1;
                        }
                        if (time1 == 5 && time2 >= time1)
                        {
                            x5y3.Text = " ";
                            ++time1;
                        }
                        if (time1 == 6 && time2 >= time1)
                        {
                            x6y3.Text = " ";
                            ++time1;
                        }
                        if (time1 == 7 && time2 >= time1)
                        {
                            x7y3.Text = " ";
                            ++time1;
                        }
                        if (time1 == 8 && time2 >= time1)
                        {
                            x8y3.Text = " ";
                            ++time1;
                        }
                        break;
                    case 4: //星期四
                        if (time1 == 1 && time2 >= time1)
                        {
                            x1y4.Text = " ";
                            ++time1;
                        }
                        if (time1 == 2 && time2 >= time1)
                        {
                            x2y4.Text = " ";
                            ++time1;
                        }
                        if (time1 == 3 && time2 >= time1)
                        {
                            x3y4.Text = " ";
                            ++time1;
                        }
                        if (time1 == 4 && time2 >= time1)
                        {
                            x4y4.Text = " ";
                            ++time1;
                        }
                        if (time1 == 5 && time2 >= time1)
                        {
                            x5y4.Text = " ";
                            ++time1;
                        }
                        if (time1 == 6 && time2 >= time1)
                        {
                            x6y4.Text = " ";
                            ++time1;
                        }
                        if (time1 == 7 && time2 >= time1)
                        {
                            x7y4.Text = " ";
                            ++time1;
                        }
                        if (time1 == 8 && time2 >= time1)
                        {
                            x8y4.Text = " ";
                            ++time1;
                        }
                        break;
                    case 5: //星期五
                        if (time1 == 1 && time2 >= time1)
                        {
                            x1y5.Text = " ";
                            ++time1;
                        }
                        if (time1 == 2 && time2 >= time1)
                        {
                            x2y5.Text = " ";
                            ++time1;
                        }
                        if (time1 == 3 && time2 >= time1)
                        {
                            x3y5.Text = " ";
                            ++time1;
                        }
                        if (time1 == 4 && time2 >= time1)
                        {
                            x4y5.Text = " ";
                            ++time1;
                        }
                        if (time1 == 5 && time2 >= time1)
                        {
                            x5y5.Text = " ";
                            ++time1;
                        }
                        if (time1 == 6 && time2 >= time1)
                        {
                            x6y5.Text = " ";
                            ++time1;
                        }
                        if (time1 == 7 && time2 >= time1)
                        {
                            x7y5.Text = " ";
                            ++time1;
                        }
                        if (time1 == 8 && time2 >= time1)
                        {
                            x8y5.Text = " ";
                            ++time1;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

       private void presentTab_Click(object sender, EventArgs e)
       {

       }

       private void groupBox1_Enter(object sender, EventArgs e)
       {

       }

       private void label8_Click(object sender, EventArgs e)
       {

       }

       private void 關於SchoolHelperToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Main2 about = new Main2();
           about.ShowDialog();
       }
   
    }

   
    
}



