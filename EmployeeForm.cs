using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace FinalProject
{
    ///==================================================================================
    /// <summary>
    /// Project: Final Project
    /// Tasks: Creates an App that stores, retrieves, edits, and deletes Employee objects
    /// Dev: Justin Mangan
    /// Date: 7 May 2018
    /// </summary>
    ///==================================================================================
    public partial class EmployeeForm : Form
    {
        List<Employee> employees = new List<Employee>();
        string fileName = "";
        bool isNew = true;
       
        /// <summary>
        /// 
        /// </summary>
        public EmployeeForm()
        {
            InitializeComponent();
        }

        #region Event Handlers
        /// <summary>
        /// Initializes message and focus on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            ////================ USEFUL CODE FOR GETTING CURRENT PROJECT FOLDER ===========================
            //string fils = "";
            //List<string> files = new List<string>();
            //string currentFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            //string[] projectFolders = Directory.GetDirectories(currentFolder, "EmployeesFiles*");
            ////txtBxMessage.Text = currentFolder + "\n";
            //foreach (string folder in projectFolders)
            //{
            //    //txtBxMessage.Text = folders + folder + "\n";
            //    string[] file = Directory.GetFiles(folder, "*.txt");
            //    foreach (string fil in file)
            //    {
            //        files.Add(fil);
            //    }
            //}
            //foreach (string file in files)
            //{
            //    txtBxMessage.Text = fils + "\n" + file + "\n";
            //}
            ////===========================================================================================

            txtBxMessage.Text = "\r\nOpen File or Create New";
            toolStrip1.Focus();
        }

        /// <summary>
        /// Opens a dialog box for opening a txt file, converts data into Employee objects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBtnOpen_Click(object sender, EventArgs e)
        {
            string inputRecord;
            string[] fields;
            try
            {
                openFileDialog1.FileName = fileName;
                if(openFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    txtBxMessage.Text = "\r\nOpen File cancelled"; 
                }
                else
                {
                    CloseFile();
                    fileName = openFileDialog1.FileName;
                    StreamReader inFile = new StreamReader(fileName);

                    inputRecord = inFile.ReadLine();
                    while (inputRecord != null)
                    {
                        fields = inputRecord.Split(',');
                        Employee anEmployee = new Employee();
                        anEmployee.LastName = fields[0];
                        anEmployee.FirstName = fields[1];
                        anEmployee.EmployeeType = fields[2];
                        anEmployee.Salary = Convert.ToDouble(fields[3]);
                        employees.Add(anEmployee);
                        inputRecord = inFile.ReadLine();
                    }
                    RefreshList();
                    inFile.Close();
                    txtBxMessage.Text = "\r\nSelect an Employee to Edit Properties";
                    CheckControls();
                }
            }
            catch (Exception exc)
            {
                txtBxMessage.Text = exc.Message;
            }
        }

        /// <summary>
        /// On closing file, displays a message box to confirm, calls CloseFile() if "yes", 
        /// returns control if "cancel" or "no"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolbtnClose_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to close file?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (answer == DialogResult.Cancel)
            {
                return;
            }
            else if (answer == DialogResult.Yes)
            {
                CloseFile();
            }
        }

        /// <summary>
        /// Event handler saves modified List to current open txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outFile = new StreamWriter(fileName);

                foreach (Employee employee in employees)
                {
                    outFile.WriteLine(employee.ToFileString());
                }
                outFile.Close();
                txtBxMessage.Text = "\r\nFile saved";
            }
            catch (Exception exc)
            {
                txtBxMessage.Text = exc.Message;
            }
            CheckControls();
        } 

        /// <summary>
        /// Event handler opens dialog box to save employee objects to a txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBtnSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = fileName;
                if(saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    txtBxMessage.Text = "\r\nSave As cancelled";
                }
                else
                {
                    fileName = saveFileDialog1.FileName;
                    StreamWriter outFile = new StreamWriter(fileName);

                    foreach (Employee employee in employees)
                    {
                        outFile.WriteLine(employee.ToFileString());
                    }
                    outFile.Close();
                    txtBxMessage.Text = "\r\nFile saved";
                    CheckControls();
                }  
            }
            catch (Exception exc)
            {
                txtBxMessage.Text = exc.Message;
            }
        }

        /// <summary>
        /// Event handler switches active tab and focus for creating or editing employee objects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBtnCreate_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            ClearBox();
            txtBxLastName.Focus();
            isNew = true;
            txtBxMessage.Text = "";
            CheckControls();
        }

        /// <summary>
        /// Event handler validates and adds the new or edited employee to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBtnAdd_Click(object sender, EventArgs e)
        {
            double salary = 0;
            bool isValid = true;
            txtBxMessage.Text = "";

            if (txtBxFirstName.Text == "")
            {
                txtBxMessage.Text += "Last name required.\r\n";
                isValid = false;
            }
            if (txtBxLastName.Text == "")
            {
                txtBxMessage.Text += "First Name required.\r\n ";
                isValid = false;
            }

            if (txtBxEmployeeType.Text == "")
            {
                txtBxMessage.Text += "Employee Type required.\r\n";
                isValid = false;
            }

            if (txtBxSalary.Text == "")
            {
                txtBxMessage.Text += "Salary required.\r\n";
                isValid = false;
            }

            else if (double.TryParse(txtBxSalary.Text.Trim('$'), out salary) == false)
            {
                txtBxMessage.Text += "\r\nSalary must be numeric";
                isValid = false;
            }

            if (isValid)
            {
                if (isNew)
                {
                    Employee anEmployee = new Employee(txtBxFirstName.Text, txtBxLastName.Text, txtBxEmployeeType.Text, Convert.ToDouble(txtBxSalary.Text.Trim('$')));
                    employees.Add(anEmployee);
                    lstBxEmployees.Items.Add(anEmployee.ToString());
                    txtBxMessage.Text = "\r\nEmployee added";
                    ClearBox();
                }
                else
                {
                    Employee anEmployee = employees[lstBxEmployees.SelectedIndex];
                    anEmployee.LastName = txtBxFirstName.Text;
                    anEmployee.FirstName = txtBxLastName.Text;
                    anEmployee.EmployeeType = txtBxEmployeeType.Text;
                    anEmployee.Salary = Convert.ToDouble(txtBxSalary.Text.Trim('$'));
                    txtBxMessage.Text = "\r\nEmployee properties edited";
                }
            
                RefreshList();
                isNew = false;
                CheckControls();
            }
        }

        /// <summary>
        /// Event handler switches active tab and focus for viewing or editing employee object properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBtnProperties_Click(object sender, EventArgs e)
        {
            isNew = false;
            tabControl1.SelectedIndex = 1;
            Employee anEmployee = employees[lstBxEmployees.SelectedIndex];
            txtBxFirstName.Text = anEmployee.LastName;
            txtBxLastName.Text = anEmployee.FirstName;
            txtBxEmployeeType.Text = anEmployee.EmployeeType;
            txtBxSalary.Text = anEmployee.Salary.ToString("C", new CultureInfo("en-US"));
            txtBxLastName.Focus();
            txtBxMessage.Text = "";
            CheckControls();
        }

        /// <summary>
        /// Event handler removes employee object from the List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBtnDelete_Click(object sender, EventArgs e)
        {
            Employee anEmployee = employees[lstBxEmployees.SelectedIndex];
            employees.Remove(anEmployee);
            RefreshList();
            txtBxMessage.Text = "\r\nEmployee deleted from list";
            CheckControls();
        }

        /// <summary>
        /// Displays a MessageBox with info and instructions for the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBtnHelp_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.FormClosed += help_FormClosed;
            help.Show();
            CheckControls();
        }

        /// <summary>
        /// Event handler enables help button via CheckControls() when help form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void help_FormClosed(object sender, FormClosedEventArgs e)
        {
            CheckControls();
        }

        /// <summary>
        /// Event handler switches active tabs to the ListBox view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CheckControls();
            RefreshList();
            txtBxMessage.Text = "";
        }

        /// <summary>
        /// Event handler toggles enabled properties for buttons based on selected index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxEmployees.SelectedIndex == -1)
            {
                toolBtnProperties.Enabled = false;
                toolBtnDelete.Enabled = false;
            }
            else
            {
                toolBtnProperties.Enabled = true;
                toolBtnDelete.Enabled = true;
            }
        }

        /// <summary>
        /// Event handlers binding menu items' enabled states to tool buttons' enabled states
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBtnOpen_EnabledChanged(object sender, EventArgs e)
        {
            openMenuItem.Enabled = toolBtnOpen.Enabled;
        }

        private void toolbtnClose_EnabledChanged(object sender, EventArgs e)
        {
            closeMenuItem.Enabled = toolbtnClose.Enabled;
        }

        private void toolBtnSave_EnabledChanged(object sender, EventArgs e)
        {
            saveMenuItem.Enabled = toolBtnSave.Enabled;
        }

        private void toolBtnSaveAs_EnabledChanged(object sender, EventArgs e)
        {
            saveAsMenuItem.Enabled = toolBtnSaveAs.Enabled;
        }

        private void toolBtnAdd_EnabledChanged(object sender, EventArgs e)
        {
            addMenuItem.Enabled = toolBtnAdd.Enabled;
        }

        private void toolBtnProperties_EnabledChanged(object sender, EventArgs e)
        {
            propertiesMenuItem.Enabled = toolBtnProperties.Enabled;
        }

        private void toolBtnDelete_EnabledChanged(object sender, EventArgs e)
        {
            deleteMenuItem.Enabled = toolBtnDelete.Enabled;
        }

        #endregion

        /// <summary>
        /// Clears textBox input fields
        /// </summary>
        private void ClearBox()
        {
            txtBxFirstName.Clear();
            txtBxLastName.Clear();
            txtBxEmployeeType.Clear();
            txtBxSalary.Clear();
            txtBxLastName.Focus();
        }

        /// <summary>
        /// Clears List and input fields, effectively closing the current open file data
        /// </summary>
        private void CloseFile()
        {
            employees.Clear();
            ClearBox();
            RefreshList();
            fileName = "";
            txtBxMessage.Text = "\r\nOpen File or Create New";
            CheckControls();
        }

        /// <summary>
        /// Switches active tab, clears ListBox, creates a new ordered List, 
        /// assigns old List to new reference, displays refreshed List in ListBox
        /// </summary>
        private void RefreshList()
        {
            tabControl1.SelectedIndex = 0;
            var sort = employees.OrderBy(employee => employee.LastName, StringComparer.CurrentCultureIgnoreCase).ToList();
            List<Employee> sorted = new List<Employee>(sort);
            employees = sorted;
            lstBxEmployees.Items.Clear();
            foreach(Employee employee in employees)
            {
                lstBxEmployees.Items.Add(employee.ToString());
            }
        }

        /// <summary>
        /// Sets controls' enabled property according to the control that calls this method
        /// </summary>
        /// <param name="memberName"></param>
        public void CheckControls([CallerMemberName] string memberName = "")
        {
            switch (memberName)
            {
                case "toolBtnOpen_Click":
                    toolBtnOpen.Enabled = false;
                    toolbtnClose.Enabled = true;
                    toolBtnSave.Enabled = false;
                    toolBtnSaveAs.Enabled = false;
                    toolBtnCreate.Enabled = true;
                    toolBtnAdd.Enabled = false;
                    break;
                case "toolBtnSave_Click":
                    toolBtnSave.Enabled = false;
                    break;
                case "toolBtnSaveAs_Click":
                    toolbtnClose.Enabled = true;
                    break;
                case "toolBtnCreate_Click":
                    toolBtnCreate.Enabled = false;
                    toolBtnAdd.Enabled = true;
                    break;
                case "toolBtnAdd_Click":
                    toolBtnSave.Enabled = fileName != "";
                    toolBtnSaveAs.Enabled = true;
                    toolBtnCreate.Enabled = true;
                    toolBtnAdd.Enabled = false;
                    toolBtnProperties.Enabled = false;
                    toolBtnDelete.Enabled = false;
                    break;
                case "toolBtnProperties_Click":
                    toolBtnProperties.Enabled = false;
                    toolBtnAdd.Enabled = true;
                    break;
                case "toolBtnDelete_Click":
                    toolBtnProperties.Enabled = false;
                    toolBtnDelete.Enabled = false;
                    toolBtnAdd.Enabled = false;
                    toolBtnSave.Enabled = fileName != "";
                    toolBtnSaveAs.Enabled = true;
                    break;
                case "btnCancel_Click":
                    toolBtnCreate.Enabled = true;
                    toolBtnAdd.Enabled = false;
                    toolBtnProperties.Enabled = false;
                    toolBtnDelete.Enabled = false;
                    break;
                case "toolBtnHelp_Click":
                    toolBtnHelp.Enabled = false;
                    break;
                case "help_FormClosed":
                    toolBtnHelp.Enabled = true;
                    break;
                case "CloseFile":
                    toolBtnOpen.Enabled = true;
                    toolbtnClose.Enabled = false;
                    toolBtnSave.Enabled = false;
                    toolBtnSaveAs.Enabled = false;
                    toolBtnCreate.Enabled = true;
                    toolBtnAdd.Enabled = false;
                    toolBtnProperties.Enabled = false;
                    toolBtnDelete.Enabled = false;
                    break;
            }
        }
    }
}
