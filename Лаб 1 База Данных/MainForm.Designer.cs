namespace Лаб_1_База_данных
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.fd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSurname_2 = new System.Windows.Forms.TextBox();
            this.tbSurname_Professor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Bus_Number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Grade_students = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.task1ToolStripMenuItem,
            this.task2ToolStripMenuItem,
            this.task3ToolStripMenuItem,
            this.task4ToolStripMenuItem,
            this.task5ToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(478, 34);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // task1ToolStripMenuItem
            // 
            this.task1ToolStripMenuItem.Name = "task1ToolStripMenuItem";
            this.task1ToolStripMenuItem.Size = new System.Drawing.Size(478, 34);
            this.task1ToolStripMenuItem.Text = "Task 1:Знайти викладачів студента ";
            this.task1ToolStripMenuItem.Click += new System.EventHandler(this.task1ToolStripMenuItem_Click);
            // 
            // task2ToolStripMenuItem
            // 
            this.task2ToolStripMenuItem.Name = "task2ToolStripMenuItem";
            this.task2ToolStripMenuItem.Size = new System.Drawing.Size(478, 34);
            this.task2ToolStripMenuItem.Text = "Task 2:Знайти автобус студента";
            this.task2ToolStripMenuItem.Click += new System.EventHandler(this.task2ToolStripMenuItem_Click);
            // 
            // task3ToolStripMenuItem
            // 
            this.task3ToolStripMenuItem.Name = "task3ToolStripMenuItem";
            this.task3ToolStripMenuItem.Size = new System.Drawing.Size(478, 34);
            this.task3ToolStripMenuItem.Text = "Task 3:Знайти учнів преподователя ";
            this.task3ToolStripMenuItem.Click += new System.EventHandler(this.task3ToolStripMenuItem_Click);
            // 
            // task4ToolStripMenuItem
            // 
            this.task4ToolStripMenuItem.Name = "task4ToolStripMenuItem";
            this.task4ToolStripMenuItem.Size = new System.Drawing.Size(478, 34);
            this.task4ToolStripMenuItem.Text = "Task 4:Знайті автобус яким користуются учні";
            this.task4ToolStripMenuItem.Click += new System.EventHandler(this.task4ToolStripMenuItem_Click);
            // 
            // task5ToolStripMenuItem
            // 
            this.task5ToolStripMenuItem.Name = "task5ToolStripMenuItem";
            this.task5ToolStripMenuItem.Size = new System.Drawing.Size(478, 34);
            this.task5ToolStripMenuItem.Text = "Task 5:Знайти учнів за рівнем класу ";
            this.task5ToolStripMenuItem.Click += new System.EventHandler(this.task5ToolStripMenuItem_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelNumber,
            this.toolStripStatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 447);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(966, 32);
            this.statusStrip2.TabIndex = 1;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 25);
            this.toolStripStatusLabel1.Text = "Line count:";
            // 
            // toolStripStatusLabelNumber
            // 
            this.toolStripStatusLabelNumber.Name = "toolStripStatusLabelNumber";
            this.toolStripStatusLabelNumber.Size = new System.Drawing.Size(77, 25);
            this.toolStripStatusLabelNumber.Text = "Number";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 25);
            // 
            // tbResult
            // 
            this.tbResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbResult.Location = new System.Drawing.Point(541, 33);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(425, 414);
            this.tbResult.TabIndex = 2;
            this.tbResult.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.tbSurname);
            this.groupBox1.Controls.Add(this.fd);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 75);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task 1";
            // 
            // tbSurname
            // 
            this.tbSurname.AutoCompleteCustomSource.AddRange(new string[] {
            "Student"});
            this.tbSurname.Location = new System.Drawing.Point(122, 27);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.PlaceholderText = "Student";
            this.tbSurname.Size = new System.Drawing.Size(382, 31);
            this.tbSurname.TabIndex = 1;
            // 
            // fd
            // 
            this.fd.AutoSize = true;
            this.fd.Location = new System.Drawing.Point(6, 27);
            this.fd.Name = "fd";
            this.fd.Size = new System.Drawing.Size(82, 25);
            this.fd.TabIndex = 0;
            this.fd.Text = "Surname";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbSurname_2);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 75);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Task 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surname";
            // 
            // tbSurname_2
            // 
            this.tbSurname_2.Location = new System.Drawing.Point(122, 24);
            this.tbSurname_2.Name = "tbSurname_2";
            this.tbSurname_2.PlaceholderText = "StudentBus";
            this.tbSurname_2.Size = new System.Drawing.Size(382, 31);
            this.tbSurname_2.TabIndex = 0;
            // 
            // tbSurname_Professor
            // 
            this.tbSurname_Professor.Location = new System.Drawing.Point(122, 30);
            this.tbSurname_Professor.Name = "tbSurname_Professor";
            this.tbSurname_Professor.PlaceholderText = "Professor";
            this.tbSurname_Professor.Size = new System.Drawing.Size(382, 31);
            this.tbSurname_Professor.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbSurname_Professor);
            this.groupBox3.Location = new System.Drawing.Point(12, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 75);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Task 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Surname";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.Bus_Number);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(12, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(510, 75);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Task 4";
            // 
            // Bus_Number
            // 
            this.Bus_Number.Location = new System.Drawing.Point(122, 27);
            this.Bus_Number.Name = "Bus_Number";
            this.Bus_Number.PlaceholderText = "Bus used by students";
            this.Bus_Number.Size = new System.Drawing.Size(382, 31);
            this.Bus_Number.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bus_numbeR";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox5.Controls.Add(this.Grade_students);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(12, 361);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(510, 75);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Task 5";
            // 
            // Grade_students
            // 
            this.Grade_students.Location = new System.Drawing.Point(122, 27);
            this.Grade_students.Name = "Grade_students";
            this.Grade_students.PlaceholderText = "Grade";
            this.Grade_students.Size = new System.Drawing.Size(382, 31);
            this.Grade_students.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 479);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabelNumber;
        private RichTextBox tbResult;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem task1ToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox tbSurname;
        private Label fd;
        private ToolStripMenuItem task2ToolStripMenuItem;
        private ToolStripMenuItem task3ToolStripMenuItem;
        private ToolStripMenuItem task4ToolStripMenuItem;
        private ToolStripMenuItem task5ToolStripMenuItem;
        private GroupBox groupBox2;
        private TextBox tbSurname_2;
        private Label label1;
        private TextBox tbSurname_Professor;
        private GroupBox groupBox3;
        private Label label2;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label3;
        private Label label4;
        private TextBox Bus_Number;
        private TextBox Grade_students;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}