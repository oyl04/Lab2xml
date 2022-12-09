namespace Lab2xml
{
    partial class Lab2
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

        #region Windows Form Designer genedepartmentd code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioButtonDOM = new System.Windows.Forms.RadioButton();
            this.radioButtonSAX = new System.Windows.Forms.RadioButton();
            this.radioButtonLINQ = new System.Windows.Forms.RadioButton();
            this.authorNameBox = new System.Windows.Forms.ComboBox();
            this.facultyBox = new System.Windows.Forms.ComboBox();
            this.dateBox = new System.Windows.Forms.ComboBox();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.volumeBox = new System.Windows.Forms.ComboBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.authorNameCheckBox = new System.Windows.Forms.CheckBox();
            this.facultyCheckBox = new System.Windows.Forms.CheckBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.departmentCheckBox = new System.Windows.Forms.CheckBox();
            this.volumeCheckBox = new System.Windows.Forms.CheckBox();
            this.typeCheckBox = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnToHTML = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(446, 38);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(568, 533);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // radioButtonDOM
            // 
            this.radioButtonDOM.AutoSize = true;
            this.radioButtonDOM.Location = new System.Drawing.Point(165, 390);
            this.radioButtonDOM.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDOM.Name = "radioButtonDOM";
            this.radioButtonDOM.Size = new System.Drawing.Size(65, 24);
            this.radioButtonDOM.TabIndex = 1;
            this.radioButtonDOM.TabStop = true;
            this.radioButtonDOM.Text = "DOM";
            this.radioButtonDOM.UseVisualStyleBackColor = true;
            this.radioButtonDOM.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSAX
            // 
            this.radioButtonSAX.AutoSize = true;
            this.radioButtonSAX.Location = new System.Drawing.Point(165, 430);
            this.radioButtonSAX.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSAX.Name = "radioButtonSAX";
            this.radioButtonSAX.Size = new System.Drawing.Size(57, 24);
            this.radioButtonSAX.TabIndex = 2;
            this.radioButtonSAX.TabStop = true;
            this.radioButtonSAX.Text = "SAX";
            this.radioButtonSAX.UseVisualStyleBackColor = true;
            this.radioButtonSAX.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonLINQ
            // 
            this.radioButtonLINQ.AutoSize = true;
            this.radioButtonLINQ.Location = new System.Drawing.Point(165, 470);
            this.radioButtonLINQ.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonLINQ.Name = "radioButtonLINQ";
            this.radioButtonLINQ.Size = new System.Drawing.Size(114, 24);
            this.radioButtonLINQ.TabIndex = 3;
            this.radioButtonLINQ.TabStop = true;
            this.radioButtonLINQ.Text = "LINQ to XML";
            this.radioButtonLINQ.UseVisualStyleBackColor = true;
            this.radioButtonLINQ.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // authorNameBox
            // 
            this.authorNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.authorNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorNameBox.Enabled = false;
            this.authorNameBox.FormattingEnabled = true;
            this.authorNameBox.Location = new System.Drawing.Point(122, 38);
            this.authorNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.authorNameBox.Name = "authorNameBox";
            this.authorNameBox.Size = new System.Drawing.Size(321, 28);
            this.authorNameBox.TabIndex = 4;
            this.authorNameBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            // 
            // facultyBox
            // 
            this.facultyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyBox.Enabled = false;
            this.facultyBox.FormattingEnabled = true;
            this.facultyBox.Location = new System.Drawing.Point(121, 82);
            this.facultyBox.Margin = new System.Windows.Forms.Padding(2);
            this.facultyBox.Name = "facultyBox";
            this.facultyBox.Size = new System.Drawing.Size(321, 28);
            this.facultyBox.TabIndex = 5;
            this.facultyBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            // 
            // dateBox
            // 
            this.dateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateBox.Enabled = false;
            this.dateBox.FormattingEnabled = true;
            this.dateBox.Location = new System.Drawing.Point(122, 258);
            this.dateBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(321, 28);
            this.dateBox.TabIndex = 6;
            this.dateBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            // 
            // departmentBox
            // 
            this.departmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentBox.Enabled = false;
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(121, 126);
            this.departmentBox.Margin = new System.Windows.Forms.Padding(2);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(321, 28);
            this.departmentBox.TabIndex = 7;
            this.departmentBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            // 
            // volumeBox
            // 
            this.volumeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.volumeBox.Enabled = false;
            this.volumeBox.FormattingEnabled = true;
            this.volumeBox.Location = new System.Drawing.Point(122, 214);
            this.volumeBox.Margin = new System.Windows.Forms.Padding(2);
            this.volumeBox.Name = "volumeBox";
            this.volumeBox.Size = new System.Drawing.Size(321, 28);
            this.volumeBox.TabIndex = 8;
            this.volumeBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.DropDownWidth = 500;
            this.typeBox.Enabled = false;
            this.typeBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeBox.FormattingEnabled = true;
            this.typeBox.ItemHeight = 20;
            this.typeBox.Location = new System.Drawing.Point(122, 170);
            this.typeBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(321, 28);
            this.typeBox.TabIndex = 9;
            this.typeBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            // 
            // authorNameCheckBox
            // 
            this.authorNameCheckBox.AutoSize = true;
            this.authorNameCheckBox.Location = new System.Drawing.Point(7, 38);
            this.authorNameCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.authorNameCheckBox.Name = "authorNameCheckBox";
            this.authorNameCheckBox.Size = new System.Drawing.Size(109, 24);
            this.authorNameCheckBox.TabIndex = 10;
            this.authorNameCheckBox.Text = "Ім\'я автора";
            this.authorNameCheckBox.UseVisualStyleBackColor = true;
            this.authorNameCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // facultyCheckBox
            // 
            this.facultyCheckBox.AutoSize = true;
            this.facultyCheckBox.Location = new System.Drawing.Point(7, 82);
            this.facultyCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.facultyCheckBox.Name = "facultyCheckBox";
            this.facultyCheckBox.Size = new System.Drawing.Size(100, 24);
            this.facultyCheckBox.TabIndex = 11;
            this.facultyCheckBox.Text = "Факультет";
            this.facultyCheckBox.UseVisualStyleBackColor = true;
            this.facultyCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(7, 258);
            this.dateCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(63, 24);
            this.dateCheckBox.TabIndex = 12;
            this.dateCheckBox.Text = "Дата";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // departmentCheckBox
            // 
            this.departmentCheckBox.AutoSize = true;
            this.departmentCheckBox.Location = new System.Drawing.Point(7, 126);
            this.departmentCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.departmentCheckBox.Name = "departmentCheckBox";
            this.departmentCheckBox.Size = new System.Drawing.Size(91, 24);
            this.departmentCheckBox.TabIndex = 13;
            this.departmentCheckBox.Text = "Кафедра";
            this.departmentCheckBox.UseVisualStyleBackColor = true;
            this.departmentCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // volumeCheckBox
            // 
            this.volumeCheckBox.AutoSize = true;
            this.volumeCheckBox.Location = new System.Drawing.Point(7, 214);
            this.volumeCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.volumeCheckBox.Name = "volumeCheckBox";
            this.volumeCheckBox.Size = new System.Drawing.Size(72, 24);
            this.volumeCheckBox.TabIndex = 14;
            this.volumeCheckBox.Text = "Обсяг";
            this.volumeCheckBox.UseVisualStyleBackColor = true;
            this.volumeCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.AutoSize = true;
            this.typeCheckBox.Location = new System.Drawing.Point(7, 170);
            this.typeCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(112, 24);
            this.typeCheckBox.TabIndex = 15;
            this.typeCheckBox.Text = "Вид роботи";
            this.typeCheckBox.UseVisualStyleBackColor = true;
            this.typeCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(10, 424);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 27);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnToHTML
            // 
            this.btnToHTML.Location = new System.Drawing.Point(309, 424);
            this.btnToHTML.Margin = new System.Windows.Forms.Padding(2);
            this.btnToHTML.Name = "btnToHTML";
            this.btnToHTML.Size = new System.Drawing.Size(89, 27);
            this.btnToHTML.TabIndex = 17;
            this.btnToHTML.Text = "В HTML";
            this.btnToHTML.UseVisualStyleBackColor = true;
            this.btnToHTML.Click += new System.EventHandler(this.btnToHTML_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.допомогаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1022, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            this.допомогаToolStripMenuItem.Click += new System.EventHandler(this.допомогаToolStripMenuItem_Click);
            // 
            // Lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 595);
            this.Controls.Add(this.btnToHTML);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.typeCheckBox);
            this.Controls.Add(this.volumeCheckBox);
            this.Controls.Add(this.departmentCheckBox);
            this.Controls.Add(this.dateCheckBox);
            this.Controls.Add(this.facultyCheckBox);
            this.Controls.Add(this.authorNameCheckBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.volumeBox);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.facultyBox);
            this.Controls.Add(this.authorNameBox);
            this.Controls.Add(this.radioButtonLINQ);
            this.Controls.Add(this.radioButtonSAX);
            this.Controls.Add(this.radioButtonDOM);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lab2";
            this.Text = "Lab2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lab2_FormClosing);
            this.Load += new System.EventHandler(this.Lab2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private RadioButton radioButtonDOM;
        private RadioButton radioButtonSAX;
        private RadioButton radioButtonLINQ;
        private ComboBox authorNameBox;
        private ComboBox facultyBox;
        private ComboBox dateBox;
        private ComboBox departmentBox;
        private ComboBox volumeBox;
        private ComboBox typeBox;
        private CheckBox authorNameCheckBox;
        private CheckBox facultyCheckBox;
        private CheckBox dateCheckBox;
        private CheckBox departmentCheckBox;
        private CheckBox volumeCheckBox;
        private CheckBox typeCheckBox;
        private Button btnSearch;
        private Button btnToHTML;
        private OpenFileDialog openFileDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem допомогаToolStripMenuItem;
        private FontDialog fontDialog1;
    }
}