namespace ToDoList
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTimeLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.todoLabel = new System.Windows.Forms.Label();
            this.todoTextBox = new System.Windows.Forms.TextBox();
            this.todoGroup = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.priorityLabel2 = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.todoListBox = new System.Windows.Forms.ListBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.todoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuNew,
            this.subMenuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // subMenuNew
            // 
            this.subMenuNew.Name = "subMenuNew";
            this.subMenuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.subMenuNew.Size = new System.Drawing.Size(141, 22);
            this.subMenuNew.Text = "New";
            this.subMenuNew.Click += new System.EventHandler(this.subMenuNew_Click);
            // 
            // subMenuExit
            // 
            this.subMenuExit.Name = "subMenuExit";
            this.subMenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.subMenuExit.Size = new System.Drawing.Size(141, 22);
            this.subMenuExit.Text = "Exit";
            this.subMenuExit.Click += new System.EventHandler(this.subMenuExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            // 
            // subMenuAbout
            // 
            this.subMenuAbout.Name = "subMenuAbout";
            this.subMenuAbout.Size = new System.Drawing.Size(107, 22);
            this.subMenuAbout.Text = "About";
            this.subMenuAbout.Click += new System.EventHandler(this.subMenuAbout_Click);
            // 
            // dataTimeLabel
            // 
            this.dataTimeLabel.AutoSize = true;
            this.dataTimeLabel.Location = new System.Drawing.Point(13, 40);
            this.dataTimeLabel.Name = "dataTimeLabel";
            this.dataTimeLabel.Size = new System.Drawing.Size(73, 13);
            this.dataTimeLabel.TabIndex = 1;
            this.dataTimeLabel.Text = "Date and time";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(92, 35);
            this.dateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(458, 20);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.Value = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(598, 43);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(38, 13);
            this.priorityLabel.TabIndex = 3;
            this.priorityLabel.Text = "Priority";
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Location = new System.Drawing.Point(651, 35);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(137, 21);
            this.priorityComboBox.TabIndex = 4;
            // 
            // todoLabel
            // 
            this.todoLabel.AutoSize = true;
            this.todoLabel.Location = new System.Drawing.Point(13, 69);
            this.todoLabel.Name = "todoLabel";
            this.todoLabel.Size = new System.Drawing.Size(35, 13);
            this.todoLabel.TabIndex = 5;
            this.todoLabel.Text = "To do";
            // 
            // todoTextBox
            // 
            this.todoTextBox.Location = new System.Drawing.Point(92, 66);
            this.todoTextBox.Name = "todoTextBox";
            this.todoTextBox.Size = new System.Drawing.Size(696, 20);
            this.todoTextBox.TabIndex = 6;
            // 
            // todoGroup
            // 
            this.todoGroup.Controls.Add(this.descriptionLabel);
            this.todoGroup.Controls.Add(this.priorityLabel2);
            this.todoGroup.Controls.Add(this.hourLabel);
            this.todoGroup.Controls.Add(this.dateLabel);
            this.todoGroup.Controls.Add(this.todoListBox);
            this.todoGroup.ForeColor = System.Drawing.Color.ForestGreen;
            this.todoGroup.Location = new System.Drawing.Point(16, 124);
            this.todoGroup.Name = "todoGroup";
            this.todoGroup.Size = new System.Drawing.Size(772, 288);
            this.todoGroup.TabIndex = 7;
            this.todoGroup.TabStop = false;
            this.todoGroup.Text = "To Do";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(379, 28);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description";
            // 
            // priorityLabel2
            // 
            this.priorityLabel2.AutoSize = true;
            this.priorityLabel2.Location = new System.Drawing.Point(257, 28);
            this.priorityLabel2.Name = "priorityLabel2";
            this.priorityLabel2.Size = new System.Drawing.Size(38, 13);
            this.priorityLabel2.TabIndex = 3;
            this.priorityLabel2.Text = "Priority";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(160, 28);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(30, 13);
            this.hourLabel.TabIndex = 2;
            this.hourLabel.Text = "Hour";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(6, 28);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date";
            // 
            // todoListBox
            // 
            this.todoListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoListBox.FormattingEnabled = true;
            this.todoListBox.Location = new System.Drawing.Point(7, 44);
            this.todoListBox.Name = "todoListBox";
            this.todoListBox.Size = new System.Drawing.Size(759, 238);
            this.todoListBox.TabIndex = 0;
            this.todoListBox.SelectedIndexChanged += new System.EventHandler(this.todoListBox_SelectedIndexChanged);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(653, 415);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(135, 32);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer_Seconds_Tick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(92, 95);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(398, 95);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(99, 23);
            this.changeButton.TabIndex = 10;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(683, 95);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.todoGroup);
            this.Controls.Add(this.todoTextBox);
            this.Controls.Add(this.todoLabel);
            this.Controls.Add(this.priorityComboBox);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dataTimeLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "To Do Reminder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.todoGroup.ResumeLayout(false);
            this.todoGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem subMenuNew;
        private System.Windows.Forms.ToolStripMenuItem subMenuExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem subMenuAbout;
        private System.Windows.Forms.Label dataTimeLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.Label todoLabel;
        private System.Windows.Forms.TextBox todoTextBox;
        private System.Windows.Forms.GroupBox todoGroup;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label priorityLabel2;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ListBox todoListBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

