namespace Tyuiu.OsadetsAA.Sprint7.V7
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_OAA = new Panel();
            toolStripInstruments_OAA = new ToolStrip();
            toolStripLabelFind_OAA = new ToolStripLabel();
            toolStripTextBoxFind_OAA = new ToolStripTextBox();
            toolStripButtonSearch_OAA = new ToolStripButton();
            toolStripButtonCleanTable_OAA = new ToolStripButton();
            menuStripFileAndReference_OAA = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьФайлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьФайлToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            panelBottom_OAA = new Panel();
            groupBoxResult_OAA = new GroupBox();
            buttonDone_OAA = new Button();
            textBoxMiddle_OAA = new TextBox();
            textBoxMax_OAA = new TextBox();
            textBoxMin_OAA = new TextBox();
            labelMiddle_OAA = new Label();
            labelMax_OAA = new Label();
            labelMin_OAA = new Label();
            statusStripOfProg_OAA = new StatusStrip();
            panelLeft_OAA = new Panel();
            dataGridViewRecords_OAA = new DataGridView();
            panelRight_OAA = new Panel();
            splitter1 = new Splitter();
            comboBoxFunction_OAA = new ComboBox();
            chartStatistics_OAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            openFileDialogTask_OAA = new OpenFileDialog();
            toolTipHelp_OAA = new ToolTip(components);
            panelTop_OAA.SuspendLayout();
            toolStripInstruments_OAA.SuspendLayout();
            menuStripFileAndReference_OAA.SuspendLayout();
            panelBottom_OAA.SuspendLayout();
            groupBoxResult_OAA.SuspendLayout();
            panelLeft_OAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecords_OAA).BeginInit();
            panelRight_OAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartStatistics_OAA).BeginInit();
            SuspendLayout();
            // 
            // panelTop_OAA
            // 
            panelTop_OAA.Controls.Add(toolStripInstruments_OAA);
            panelTop_OAA.Controls.Add(menuStripFileAndReference_OAA);
            panelTop_OAA.Dock = DockStyle.Top;
            panelTop_OAA.Location = new Point(0, 0);
            panelTop_OAA.Name = "panelTop_OAA";
            panelTop_OAA.Size = new Size(1194, 58);
            panelTop_OAA.TabIndex = 1;
            // 
            // toolStripInstruments_OAA
            // 
            toolStripInstruments_OAA.ImageScalingSize = new Size(20, 20);
            toolStripInstruments_OAA.Items.AddRange(new ToolStripItem[] { toolStripLabelFind_OAA, toolStripTextBoxFind_OAA, toolStripButtonSearch_OAA, toolStripButtonCleanTable_OAA });
            toolStripInstruments_OAA.Location = new Point(0, 28);
            toolStripInstruments_OAA.Name = "toolStripInstruments_OAA";
            toolStripInstruments_OAA.Size = new Size(1194, 27);
            toolStripInstruments_OAA.TabIndex = 1;
            toolStripInstruments_OAA.Text = "toolStrip1";
            // 
            // toolStripLabelFind_OAA
            // 
            toolStripLabelFind_OAA.Name = "toolStripLabelFind_OAA";
            toolStripLabelFind_OAA.Size = new Size(55, 24);
            toolStripLabelFind_OAA.Text = "Поиск:";
            // 
            // toolStripTextBoxFind_OAA
            // 
            toolStripTextBoxFind_OAA.Name = "toolStripTextBoxFind_OAA";
            toolStripTextBoxFind_OAA.Size = new Size(100, 27);
            // 
            // toolStripButtonSearch_OAA
            // 
            toolStripButtonSearch_OAA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSearch_OAA.Image = (Image)resources.GetObject("toolStripButtonSearch_OAA.Image");
            toolStripButtonSearch_OAA.Name = "toolStripButtonSearch_OAA";
            toolStripButtonSearch_OAA.Size = new Size(29, 24);
            toolStripButtonSearch_OAA.Text = "Найти";
            toolStripButtonSearch_OAA.Click += toolStripButtonSearch_OAA_Click_1;
            // 
            // toolStripButtonCleanTable_OAA
            // 
            toolStripButtonCleanTable_OAA.BackColor = SystemColors.Control;
            toolStripButtonCleanTable_OAA.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonCleanTable_OAA.Image = (Image)resources.GetObject("toolStripButtonCleanTable_OAA.Image");
            toolStripButtonCleanTable_OAA.ImageTransparentColor = Color.Magenta;
            toolStripButtonCleanTable_OAA.Name = "toolStripButtonCleanTable_OAA";
            toolStripButtonCleanTable_OAA.Size = new Size(137, 24);
            toolStripButtonCleanTable_OAA.Text = "Очистить таблицу";
            toolStripButtonCleanTable_OAA.Click += toolStripButtonCleanTable_OAA_Click;
            // 
            // menuStripFileAndReference_OAA
            // 
            menuStripFileAndReference_OAA.ImageScalingSize = new Size(20, 20);
            menuStripFileAndReference_OAA.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStripFileAndReference_OAA.Location = new Point(0, 0);
            menuStripFileAndReference_OAA.Name = "menuStripFileAndReference_OAA";
            menuStripFileAndReference_OAA.Size = new Size(1194, 28);
            menuStripFileAndReference_OAA.TabIndex = 0;
            menuStripFileAndReference_OAA.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьФайлToolStripMenuItem, сохранитьФайлToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьФайлToolStripMenuItem
            // 
            открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            открытьФайлToolStripMenuItem.Size = new Size(205, 26);
            открытьФайлToolStripMenuItem.Text = "Открыть файл";
            открытьФайлToolStripMenuItem.Click += открытьФайлToolStripMenuItem_Click;
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            сохранитьФайлToolStripMenuItem.Size = new Size(205, 26);
            сохранитьФайлToolStripMenuItem.Text = "Сохранить файл";
            сохранитьФайлToolStripMenuItem.Click += сохранитьФайлToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, помощьToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(187, 26);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(187, 26);
            помощьToolStripMenuItem.Text = "Помощь";
            помощьToolStripMenuItem.Click += помощьToolStripMenuItem_Click;
            // 
            // panelBottom_OAA
            // 
            panelBottom_OAA.Controls.Add(groupBoxResult_OAA);
            panelBottom_OAA.Controls.Add(statusStripOfProg_OAA);
            panelBottom_OAA.Dock = DockStyle.Bottom;
            panelBottom_OAA.Location = new Point(0, 425);
            panelBottom_OAA.Name = "panelBottom_OAA";
            panelBottom_OAA.Size = new Size(1194, 120);
            panelBottom_OAA.TabIndex = 2;
            // 
            // groupBoxResult_OAA
            // 
            groupBoxResult_OAA.Controls.Add(buttonDone_OAA);
            groupBoxResult_OAA.Controls.Add(textBoxMiddle_OAA);
            groupBoxResult_OAA.Controls.Add(textBoxMax_OAA);
            groupBoxResult_OAA.Controls.Add(textBoxMin_OAA);
            groupBoxResult_OAA.Controls.Add(labelMiddle_OAA);
            groupBoxResult_OAA.Controls.Add(labelMax_OAA);
            groupBoxResult_OAA.Controls.Add(labelMin_OAA);
            groupBoxResult_OAA.Dock = DockStyle.Fill;
            groupBoxResult_OAA.Location = new Point(0, 0);
            groupBoxResult_OAA.Name = "groupBoxResult_OAA";
            groupBoxResult_OAA.Size = new Size(1194, 98);
            groupBoxResult_OAA.TabIndex = 1;
            groupBoxResult_OAA.TabStop = false;
            groupBoxResult_OAA.Text = "Результат:";
            // 
            // buttonDone_OAA
            // 
            buttonDone_OAA.BackColor = Color.LimeGreen;
            buttonDone_OAA.FlatStyle = FlatStyle.Flat;
            buttonDone_OAA.Location = new Point(462, 20);
            buttonDone_OAA.Name = "buttonDone_OAA";
            buttonDone_OAA.Size = new Size(121, 73);
            buttonDone_OAA.TabIndex = 6;
            buttonDone_OAA.Text = "Выполнить";
            buttonDone_OAA.UseVisualStyleBackColor = false;
            buttonDone_OAA.Click += buttonDone_OAA_Click;
            // 
            // textBoxMiddle_OAA
            // 
            textBoxMiddle_OAA.Location = new Point(331, 71);
            textBoxMiddle_OAA.Multiline = true;
            textBoxMiddle_OAA.Name = "textBoxMiddle_OAA";
            textBoxMiddle_OAA.ReadOnly = true;
            textBoxMiddle_OAA.Size = new Size(125, 22);
            textBoxMiddle_OAA.TabIndex = 5;
            // 
            // textBoxMax_OAA
            // 
            textBoxMax_OAA.Location = new Point(331, 45);
            textBoxMax_OAA.Multiline = true;
            textBoxMax_OAA.Name = "textBoxMax_OAA";
            textBoxMax_OAA.ReadOnly = true;
            textBoxMax_OAA.Size = new Size(125, 22);
            textBoxMax_OAA.TabIndex = 4;
            // 
            // textBoxMin_OAA
            // 
            textBoxMin_OAA.Location = new Point(331, 20);
            textBoxMin_OAA.Multiline = true;
            textBoxMin_OAA.Name = "textBoxMin_OAA";
            textBoxMin_OAA.ReadOnly = true;
            textBoxMin_OAA.Size = new Size(125, 22);
            textBoxMin_OAA.TabIndex = 3;
            // 
            // labelMiddle_OAA
            // 
            labelMiddle_OAA.AutoSize = true;
            labelMiddle_OAA.Location = new Point(12, 65);
            labelMiddle_OAA.Name = "labelMiddle_OAA";
            labelMiddle_OAA.Size = new Size(276, 20);
            labelMiddle_OAA.TabIndex = 2;
            labelMiddle_OAA.Text = "Средняя площадь среди всех квартир:";
            // 
            // labelMax_OAA
            // 
            labelMax_OAA.AutoSize = true;
            labelMax_OAA.Location = new Point(12, 45);
            labelMax_OAA.Name = "labelMax_OAA";
            labelMax_OAA.Size = new Size(321, 20);
            labelMax_OAA.TabIndex = 1;
            labelMax_OAA.Text = "Максимальная площадь среди всех квартир:";
            // 
            // labelMin_OAA
            // 
            labelMin_OAA.AutoSize = true;
            labelMin_OAA.Location = new Point(12, 25);
            labelMin_OAA.Name = "labelMin_OAA";
            labelMin_OAA.Size = new Size(317, 20);
            labelMin_OAA.TabIndex = 0;
            labelMin_OAA.Text = "Минимальная площадь среди всех квартир:";
            // 
            // statusStripOfProg_OAA
            // 
            statusStripOfProg_OAA.ImageScalingSize = new Size(20, 20);
            statusStripOfProg_OAA.Location = new Point(0, 98);
            statusStripOfProg_OAA.Name = "statusStripOfProg_OAA";
            statusStripOfProg_OAA.Size = new Size(1194, 22);
            statusStripOfProg_OAA.TabIndex = 0;
            // 
            // panelLeft_OAA
            // 
            panelLeft_OAA.Controls.Add(dataGridViewRecords_OAA);
            panelLeft_OAA.Dock = DockStyle.Left;
            panelLeft_OAA.Location = new Point(0, 58);
            panelLeft_OAA.Name = "panelLeft_OAA";
            panelLeft_OAA.Size = new Size(671, 367);
            panelLeft_OAA.TabIndex = 3;
            // 
            // dataGridViewRecords_OAA
            // 
            dataGridViewRecords_OAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecords_OAA.Dock = DockStyle.Fill;
            dataGridViewRecords_OAA.Location = new Point(0, 0);
            dataGridViewRecords_OAA.Name = "dataGridViewRecords_OAA";
            dataGridViewRecords_OAA.RowHeadersVisible = false;
            dataGridViewRecords_OAA.RowHeadersWidth = 51;
            dataGridViewRecords_OAA.Size = new Size(671, 367);
            dataGridViewRecords_OAA.TabIndex = 0;
            // 
            // panelRight_OAA
            // 
            panelRight_OAA.Controls.Add(splitter1);
            panelRight_OAA.Controls.Add(comboBoxFunction_OAA);
            panelRight_OAA.Controls.Add(chartStatistics_OAA);
            panelRight_OAA.Dock = DockStyle.Fill;
            panelRight_OAA.Location = new Point(671, 58);
            panelRight_OAA.Name = "panelRight_OAA";
            panelRight_OAA.Size = new Size(523, 367);
            panelRight_OAA.TabIndex = 4;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.RightToLeft = RightToLeft.Yes;
            splitter1.Size = new Size(4, 367);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // comboBoxFunction_OAA
            // 
            comboBoxFunction_OAA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxFunction_OAA.FormattingEnabled = true;
            comboBoxFunction_OAA.Location = new Point(349, 301);
            comboBoxFunction_OAA.Name = "comboBoxFunction_OAA";
            comboBoxFunction_OAA.Size = new Size(162, 28);
            comboBoxFunction_OAA.TabIndex = 2;
            comboBoxFunction_OAA.SelectedIndexChanged += comboBoxFunction_OAA_SelectedIndexChanged;
            // 
            // chartStatistics_OAA
            // 
            chartArea1.Name = "ChartArea1";
            chartStatistics_OAA.ChartAreas.Add(chartArea1);
            chartStatistics_OAA.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartStatistics_OAA.Legends.Add(legend1);
            chartStatistics_OAA.Location = new Point(0, 0);
            chartStatistics_OAA.Name = "chartStatistics_OAA";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartStatistics_OAA.Series.Add(series1);
            chartStatistics_OAA.Size = new Size(523, 367);
            chartStatistics_OAA.TabIndex = 0;
            // 
            // openFileDialogTask_OAA
            // 
            openFileDialogTask_OAA.FileName = "openFileDialog1";
            // 
            // toolTipHelp_OAA
            // 
            toolTipHelp_OAA.IsBalloon = true;
            toolTipHelp_OAA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 545);
            Controls.Add(panelRight_OAA);
            Controls.Add(panelLeft_OAA);
            Controls.Add(panelBottom_OAA);
            Controls.Add(panelTop_OAA);
            MinimumSize = new Size(1212, 567);
            Name = "FormMain";
            Text = "Спринт 7 | Домоуправление | Вариант 7 | Осадец А.А.";
            panelTop_OAA.ResumeLayout(false);
            panelTop_OAA.PerformLayout();
            toolStripInstruments_OAA.ResumeLayout(false);
            toolStripInstruments_OAA.PerformLayout();
            menuStripFileAndReference_OAA.ResumeLayout(false);
            menuStripFileAndReference_OAA.PerformLayout();
            panelBottom_OAA.ResumeLayout(false);
            panelBottom_OAA.PerformLayout();
            groupBoxResult_OAA.ResumeLayout(false);
            groupBoxResult_OAA.PerformLayout();
            panelLeft_OAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecords_OAA).EndInit();
            panelRight_OAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartStatistics_OAA).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTop_OAA;
        private Panel panelBottom_OAA;
        private Panel panelLeft_OAA;
        private Panel panelRight_OAA;
        private MenuStrip menuStripFileAndReference_OAA;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьФайлToolStripMenuItem;
        private ToolStripMenuItem сохранитьФайлToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStrip toolStripInstruments_OAA;
        private ToolStripLabel toolStripLabelFind_OAA;
        private ToolStripTextBox toolStripTextBoxFind_OAA;
        private ToolStripButton toolStripButtonSearch_OAA;
        private DataGridView dataGridViewRecords_OAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics_OAA;
        private StatusStrip statusStripOfProg_OAA;
        private OpenFileDialog openFileDialogTask_OAA;
        private ComboBox comboBoxFunction_OAA;
        private ToolTip toolTipHelp_OAA;
        private ToolStripButton toolStripButtonCleanTable_OAA;
        private Splitter splitter1;
        private GroupBox groupBoxResult_OAA;
        private Label labelMin_OAA;
        private TextBox textBoxMiddle_OAA;
        private TextBox textBoxMax_OAA;
        private TextBox textBoxMin_OAA;
        private Label labelMiddle_OAA;
        private Label labelMax_OAA;
        private Button buttonDone_OAA;
    }
}
