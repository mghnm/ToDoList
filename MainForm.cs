using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class MainForm : Form
    {

        private TaskManager manager;

        public MainForm()
        {
            this.manager = new TaskManager();
            InitializeComponent();
            InitializeGUI();
        }

        public Task GetTaskFromInput()
        {
            //Add a task to the task manager from the field

            return new Task(this.dateTimePicker.Value, (Priority) this.priorityComboBox.SelectedIndex, this.todoTextBox.Text);
        }

        public void InitializeGUI()
        {
          

            //Populate combobox disable the edit and remove buttons until selection is made new task manager
            this.todoTextBox.Text = string.Empty;

            this.priorityComboBox.DataSource = Enum.GetValues(typeof(Priority));
            this.priorityComboBox.SelectedIndex = (int) Priority.Normal;

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.dateTimePicker, "Click to open calendar for date, write in time here.");
            this.dateTimePicker.Format = DateTimePickerFormat.Custom; 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd    HH:mm";
            this.dateTimePicker.Value = DateTime.Today;

            this.todoListBox.SelectedIndex = -1;
            this.changeButton.Enabled = false;
            this.deleteButton.Enabled = false;


        }

        public void UpdateGUI()
        {
            //Update the listbox when item is added or when item is selected for editing or deletion
            this.todoListBox.Items.Clear();
            this.todoListBox.Items.AddRange(this.manager.LstToStrArr());
            this.todoListBox.SelectedIndex = -1;
            this.changeButton.Enabled = false;
            this.deleteButton.Enabled = false;

        }


        public bool ValidateTask() 
        {
            //Validate that the description is not empty
            if (string.IsNullOrEmpty(this.todoTextBox.Text))
            {
                MessageBox.Show("You can not have an empty description!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else 
            {
                return true;
            }
        }

        //--------------------- Event and Dialog Handlers ------------------------------------
        private void Timer_Seconds_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !ResultFromQuitDialog();
        }

        private bool ResultFromQuitDialog()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }



        private void subMenuNew_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        private void subMenuExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void subMenuAbout_Click(object sender, EventArgs e)
        {
            using (AboutBox box = new AboutBox()) 
            {
                box.ShowDialog(this);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateTask())
            {
                this.manager.Add(GetTaskFromInput());
                UpdateGUI();
            }
        }
        private void changeButton_Click(object sender, EventArgs e)
        {
            if (ValidateTask())
            {
                this.manager.Edit(GetTaskFromInput(), this.todoListBox.SelectedIndex);
                UpdateGUI();
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to remove task?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                this.manager.Remove(this.todoListBox.SelectedIndex);
                UpdateGUI();
            }
        }

        private void todoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.todoListBox.SelectedIndex != -1)
            {
                this.deleteButton.Enabled = true;
                this.changeButton.Enabled = true;
            } else 
            {
                this.deleteButton.Enabled = false;
                this.changeButton.Enabled = false;

            }
        }
    }
}
