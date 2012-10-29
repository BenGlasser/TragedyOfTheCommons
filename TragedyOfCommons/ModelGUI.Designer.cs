namespace TragedyOfCommons
{
    partial class ModelGUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolTip toolTip;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelGUI));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.photoButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.setupButton = new System.Windows.Forms.Button();
            this.goOnceButton = new System.Windows.Forms.Button();
            this.trackBar_Speed = new System.Windows.Forms.TrackBar();
            this.trackBar_Agents = new System.Windows.Forms.TrackBar();
            this.goButton = new System.Windows.Forms.CheckBox();
            this.trackBar_PEC = new System.Windows.Forms.TrackBar();
            this.textBox_Speed = new System.Windows.Forms.TextBox();
            this.groupBox_Speed = new System.Windows.Forms.GroupBox();
            this.groupBox_Agents = new System.Windows.Forms.GroupBox();
            this.textBox_Agents = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.savePictureDialog = new System.Windows.Forms.SaveFileDialog();
            this.PollutionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GraphTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MovesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listView_AgentData = new System.Windows.Forms.ListView();
            this.columnHeader_Agent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Income = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Pollution = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Grow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Moves = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PECBox = new System.Windows.Forms.GroupBox();
            this.textBox_PEC = new System.Windows.Forms.TextBox();
            this.groupBox_Buttons = new System.Windows.Forms.GroupBox();
            this.IncomeBox = new System.Windows.Forms.GroupBox();
            this.textBox_Income = new System.Windows.Forms.TextBox();
            this.trackBar_Income = new System.Windows.Forms.TrackBar();
            toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Agents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_PEC)).BeginInit();
            this.groupBox_Speed.SuspendLayout();
            this.groupBox_Agents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PollutionChart)).BeginInit();
            this.GraphTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovesChart)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.PECBox.SuspendLayout();
            this.groupBox_Buttons.SuspendLayout();
            this.IncomeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Income)).BeginInit();
            this.SuspendLayout();
            // 
            // photoButton
            // 
            this.photoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photoButton.Enabled = false;
            this.photoButton.Image = ((System.Drawing.Image)(resources.GetObject("photoButton.Image")));
            this.photoButton.Location = new System.Drawing.Point(123, 19);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(50, 50);
            this.photoButton.TabIndex = 10;
            toolTip.SetToolTip(this.photoButton, "save an image of the current screen");
            this.photoButton.UseVisualStyleBackColor = true;
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveButton.Enabled = false;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(67, 20);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(50, 50);
            this.SaveButton.TabIndex = 15;
            toolTip.SetToolTip(this.SaveButton, "save data on current screen to CSV File");
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.Control;
            this.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetButton.Enabled = false;
            this.ResetButton.Image = ((System.Drawing.Image)(resources.GetObject("ResetButton.Image")));
            this.ResetButton.Location = new System.Drawing.Point(11, 20);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(50, 50);
            this.ResetButton.TabIndex = 16;
            toolTip.SetToolTip(this.ResetButton, "reset data");
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(12, 12);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(70, 40);
            this.setupButton.TabIndex = 1;
            this.setupButton.Text = "Setup";
            toolTip.SetToolTip(this.setupButton, "setup model with current values");
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // goOnceButton
            // 
            this.goOnceButton.Enabled = false;
            this.goOnceButton.Location = new System.Drawing.Point(88, 12);
            this.goOnceButton.Name = "goOnceButton";
            this.goOnceButton.Size = new System.Drawing.Size(70, 40);
            this.goOnceButton.TabIndex = 2;
            this.goOnceButton.Text = "Go Once";
            toolTip.SetToolTip(this.goOnceButton, "complete just one iteration");
            this.goOnceButton.UseVisualStyleBackColor = true;
            this.goOnceButton.Click += new System.EventHandler(this.goOnceButton_Click);
            // 
            // trackBar_Speed
            // 
            this.trackBar_Speed.LargeChange = 10;
            this.trackBar_Speed.Location = new System.Drawing.Point(6, 19);
            this.trackBar_Speed.Maximum = 100;
            this.trackBar_Speed.Minimum = 1;
            this.trackBar_Speed.Name = "trackBar_Speed";
            this.trackBar_Speed.Size = new System.Drawing.Size(160, 45);
            this.trackBar_Speed.TabIndex = 4;
            this.trackBar_Speed.TickFrequency = 10;
            toolTip.SetToolTip(this.trackBar_Speed, "adjust the running speed");
            this.trackBar_Speed.Value = 50;
            this.trackBar_Speed.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // trackBar_Agents
            // 
            this.trackBar_Agents.LargeChange = 10;
            this.trackBar_Agents.Location = new System.Drawing.Point(6, 19);
            this.trackBar_Agents.Maximum = 100;
            this.trackBar_Agents.Minimum = 1;
            this.trackBar_Agents.Name = "trackBar_Agents";
            this.trackBar_Agents.Size = new System.Drawing.Size(159, 45);
            this.trackBar_Agents.TabIndex = 5;
            this.trackBar_Agents.TickFrequency = 10;
            toolTip.SetToolTip(this.trackBar_Agents, "number of agents");
            this.trackBar_Agents.Value = 50;
            this.trackBar_Agents.Scroll += new System.EventHandler(this.trackBar_Agents_Scroll);
            this.trackBar_Agents.ValueChanged += new System.EventHandler(this.trackBar_Agents_ValueChanged);
            // 
            // goButton
            // 
            this.goButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.goButton.Enabled = false;
            this.goButton.Location = new System.Drawing.Point(164, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(70, 40);
            this.goButton.TabIndex = 9;
            this.goButton.Text = "Go";
            this.goButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip.SetToolTip(this.goButton, "toggle continuous run");
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.CheckedChanged += new System.EventHandler(this.goButton_CheckedChanged);
            // 
            // trackBar_PEC
            // 
            this.trackBar_PEC.LargeChange = 10;
            this.trackBar_PEC.Location = new System.Drawing.Point(7, 20);
            this.trackBar_PEC.Maximum = 255;
            this.trackBar_PEC.Minimum = 1;
            this.trackBar_PEC.Name = "trackBar_PEC";
            this.trackBar_PEC.Size = new System.Drawing.Size(159, 45);
            this.trackBar_PEC.TabIndex = 5;
            this.trackBar_PEC.TickFrequency = 10;
            toolTip.SetToolTip(this.trackBar_PEC, "global Pollution Emissions Cap");
            this.trackBar_PEC.Value = 50;
            this.trackBar_PEC.ValueChanged += new System.EventHandler(this.trackBar_PEC_ValueChanged);
            // 
            // textBox_Speed
            // 
            this.textBox_Speed.Location = new System.Drawing.Point(172, 19);
            this.textBox_Speed.Name = "textBox_Speed";
            this.textBox_Speed.Size = new System.Drawing.Size(38, 20);
            this.textBox_Speed.TabIndex = 6;
            this.textBox_Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Speed.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox_Speed
            // 
            this.groupBox_Speed.Controls.Add(this.trackBar_Speed);
            this.groupBox_Speed.Controls.Add(this.textBox_Speed);
            this.groupBox_Speed.Location = new System.Drawing.Point(12, 58);
            this.groupBox_Speed.Name = "groupBox_Speed";
            this.groupBox_Speed.Size = new System.Drawing.Size(220, 70);
            this.groupBox_Speed.TabIndex = 7;
            this.groupBox_Speed.TabStop = false;
            this.groupBox_Speed.Text = "Speed";
            // 
            // groupBox_Agents
            // 
            this.groupBox_Agents.Controls.Add(this.textBox_Agents);
            this.groupBox_Agents.Controls.Add(this.trackBar_Agents);
            this.groupBox_Agents.Location = new System.Drawing.Point(13, 134);
            this.groupBox_Agents.Name = "groupBox_Agents";
            this.groupBox_Agents.Size = new System.Drawing.Size(220, 70);
            this.groupBox_Agents.TabIndex = 8;
            this.groupBox_Agents.TabStop = false;
            this.groupBox_Agents.Text = "Agents";
            // 
            // textBox_Agents
            // 
            this.textBox_Agents.Location = new System.Drawing.Point(172, 20);
            this.textBox_Agents.Name = "textBox_Agents";
            this.textBox_Agents.Size = new System.Drawing.Size(38, 20);
            this.textBox_Agents.TabIndex = 6;
            this.textBox_Agents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Agents.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PollutionChart
            // 
            this.PollutionChart.BorderlineWidth = 0;
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisY.Title = "Pollution";
            chartArea1.Name = "ChartArea1";
            this.PollutionChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.PollutionChart.Legends.Add(legend1);
            this.PollutionChart.Location = new System.Drawing.Point(6, 6);
            this.PollutionChart.Name = "PollutionChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Pollution";
            this.PollutionChart.Series.Add(series1);
            this.PollutionChart.Size = new System.Drawing.Size(500, 500);
            this.PollutionChart.TabIndex = 12;
            this.PollutionChart.Text = "Total Polution";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Total Pollution";
            title1.Text = "Total Pollution";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.PollutionChart.Titles.Add(title1);
            // 
            // GraphTabs
            // 
            this.GraphTabs.Controls.Add(this.tabPage1);
            this.GraphTabs.Controls.Add(this.tabPage2);
            this.GraphTabs.Controls.Add(this.tabPage3);
            this.GraphTabs.Controls.Add(this.tabPage4);
            this.GraphTabs.Location = new System.Drawing.Point(240, 12);
            this.GraphTabs.Name = "GraphTabs";
            this.GraphTabs.SelectedIndex = 0;
            this.GraphTabs.Size = new System.Drawing.Size(517, 533);
            this.GraphTabs.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(509, 507);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Vizualizatoin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PollutionChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(509, 507);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Pollution";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.MovesChart);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(509, 507);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Moves";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MovesChart
            // 
            chartArea2.AxisX.Title = "time";
            chartArea2.AxisY.Title = "Moves";
            chartArea2.Name = "ChartArea1";
            this.MovesChart.ChartAreas.Add(chartArea2);
            this.MovesChart.Location = new System.Drawing.Point(7, 4);
            this.MovesChart.Name = "MovesChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Name = "Moves";
            this.MovesChart.Series.Add(series2);
            this.MovesChart.Size = new System.Drawing.Size(500, 500);
            this.MovesChart.TabIndex = 0;
            this.MovesChart.Text = "Moves";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "TotalMoves";
            title2.Text = "Total Moves";
            title2.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.MovesChart.Titles.Add(title2);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listView_AgentData);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(509, 507);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Agent Data";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView_AgentData
            // 
            this.listView_AgentData.AllowColumnReorder = true;
            this.listView_AgentData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Agent,
            this.columnHeader_Income,
            this.columnHeader_Pollution,
            this.columnHeader_Grow,
            this.columnHeader_Moves});
            this.listView_AgentData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_AgentData.GridLines = true;
            this.listView_AgentData.Location = new System.Drawing.Point(0, 0);
            this.listView_AgentData.Name = "listView_AgentData";
            this.listView_AgentData.Size = new System.Drawing.Size(509, 507);
            this.listView_AgentData.TabIndex = 0;
            this.listView_AgentData.UseCompatibleStateImageBehavior = false;
            this.listView_AgentData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Agent
            // 
            this.columnHeader_Agent.Text = "Agent";
            // 
            // columnHeader_Income
            // 
            this.columnHeader_Income.Text = "Income";
            // 
            // columnHeader_Pollution
            // 
            this.columnHeader_Pollution.Text = "Pollution Max";
            this.columnHeader_Pollution.Width = 82;
            // 
            // columnHeader_Grow
            // 
            this.columnHeader_Grow.Text = "Grow Max";
            this.columnHeader_Grow.Width = 61;
            // 
            // columnHeader_Moves
            // 
            this.columnHeader_Moves.Text = "Moves";
            this.columnHeader_Moves.Width = 49;
            // 
            // PECBox
            // 
            this.PECBox.Controls.Add(this.textBox_PEC);
            this.PECBox.Controls.Add(this.trackBar_PEC);
            this.PECBox.Location = new System.Drawing.Point(12, 210);
            this.PECBox.Name = "PECBox";
            this.PECBox.Size = new System.Drawing.Size(220, 84);
            this.PECBox.TabIndex = 14;
            this.PECBox.TabStop = false;
            this.PECBox.Text = "PEC";
            // 
            // textBox_PEC
            // 
            this.textBox_PEC.Location = new System.Drawing.Point(171, 19);
            this.textBox_PEC.Name = "textBox_PEC";
            this.textBox_PEC.Size = new System.Drawing.Size(38, 20);
            this.textBox_PEC.TabIndex = 7;
            this.textBox_PEC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox_Buttons
            // 
            this.groupBox_Buttons.Controls.Add(this.ResetButton);
            this.groupBox_Buttons.Controls.Add(this.SaveButton);
            this.groupBox_Buttons.Controls.Add(this.photoButton);
            this.groupBox_Buttons.Location = new System.Drawing.Point(26, 469);
            this.groupBox_Buttons.Name = "groupBox_Buttons";
            this.groupBox_Buttons.Size = new System.Drawing.Size(184, 76);
            this.groupBox_Buttons.TabIndex = 17;
            this.groupBox_Buttons.TabStop = false;
            this.groupBox_Buttons.Text = "Actions";
            // 
            // IncomeBox
            // 
            this.IncomeBox.Controls.Add(this.textBox_Income);
            this.IncomeBox.Controls.Add(this.trackBar_Income);
            this.IncomeBox.Location = new System.Drawing.Point(12, 300);
            this.IncomeBox.Name = "IncomeBox";
            this.IncomeBox.Size = new System.Drawing.Size(220, 84);
            this.IncomeBox.TabIndex = 18;
            this.IncomeBox.TabStop = false;
            this.IncomeBox.Text = "Max Income";
            // 
            // textBox_Income
            // 
            this.textBox_Income.Location = new System.Drawing.Point(171, 19);
            this.textBox_Income.Name = "textBox_Income";
            this.textBox_Income.Size = new System.Drawing.Size(38, 20);
            this.textBox_Income.TabIndex = 9;
            this.textBox_Income.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Income.TextChanged += new System.EventHandler(this.textBox_Income_TextChanged);
            // 
            // trackBar_Income
            // 
            this.trackBar_Income.LargeChange = 10;
            this.trackBar_Income.Location = new System.Drawing.Point(7, 19);
            this.trackBar_Income.Maximum = 255;
            this.trackBar_Income.Minimum = 1;
            this.trackBar_Income.Name = "trackBar_Income";
            this.trackBar_Income.Size = new System.Drawing.Size(158, 45);
            this.trackBar_Income.TabIndex = 8;
            this.trackBar_Income.TickFrequency = 10;
            this.trackBar_Income.Value = 100;
            this.trackBar_Income.ValueChanged += new System.EventHandler(this.trackBar_Income_ValueChanged);
            // 
            // ModelGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(762, 550);
            this.Controls.Add(this.IncomeBox);
            this.Controls.Add(this.groupBox_Buttons);
            this.Controls.Add(this.PECBox);
            this.Controls.Add(this.GraphTabs);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.groupBox_Agents);
            this.Controls.Add(this.groupBox_Speed);
            this.Controls.Add(this.goOnceButton);
            this.Controls.Add(this.setupButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(778, 588);
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "ModelGUI";
            this.Text = "Tragedy of the Commons";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Agents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_PEC)).EndInit();
            this.groupBox_Speed.ResumeLayout(false);
            this.groupBox_Speed.PerformLayout();
            this.groupBox_Agents.ResumeLayout(false);
            this.groupBox_Agents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PollutionChart)).EndInit();
            this.GraphTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MovesChart)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.PECBox.ResumeLayout(false);
            this.PECBox.PerformLayout();
            this.groupBox_Buttons.ResumeLayout(false);
            this.IncomeBox.ResumeLayout(false);
            this.IncomeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Income)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.Button goOnceButton;
        private System.Windows.Forms.TrackBar trackBar_Speed;
        private System.Windows.Forms.TrackBar trackBar_Agents;
        private System.Windows.Forms.TextBox textBox_Speed;
        private System.Windows.Forms.GroupBox groupBox_Speed;
        private System.Windows.Forms.GroupBox groupBox_Agents;
        private System.Windows.Forms.TextBox textBox_Agents;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox goButton;
        private System.Windows.Forms.Button photoButton;
        private System.Windows.Forms.SaveFileDialog savePictureDialog;
        private System.Windows.Forms.DataVisualization.Charting.Chart PollutionChart;
        private System.Windows.Forms.TabControl GraphTabs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart MovesChart;
        private System.Windows.Forms.GroupBox PECBox;
        private System.Windows.Forms.TextBox textBox_PEC;
        private System.Windows.Forms.TrackBar trackBar_PEC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox groupBox_Buttons;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListView listView_AgentData;
        private System.Windows.Forms.ColumnHeader columnHeader_Agent;
        private System.Windows.Forms.ColumnHeader columnHeader_Income;
        private System.Windows.Forms.ColumnHeader columnHeader_Pollution;
        private System.Windows.Forms.ColumnHeader columnHeader_Grow;
        private System.Windows.Forms.ColumnHeader columnHeader_Moves;
        private System.Windows.Forms.GroupBox IncomeBox;
        private System.Windows.Forms.TrackBar trackBar_Income;
        private System.Windows.Forms.TextBox textBox_Income;
    }
}

