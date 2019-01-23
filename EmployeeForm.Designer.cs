namespace FinalProject
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolbtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolBtnCreate = new System.Windows.Forms.ToolStripButton();
            this.toolBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolBtnProperties = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstBxEmployees = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxSalary = new System.Windows.Forms.TextBox();
            this.txtBxEmployeeType = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtBxMessage = new System.Windows.Forms.TextBox();
            this.employeeFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(443, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.closeMenuItem});
            this.fileMenu.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenu.ForeColor = System.Drawing.Color.Azure;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(41, 20);
            this.fileMenu.Text = "&File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.toolBtnOpen_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Enabled = false;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.toolBtnSave_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Enabled = false;
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsMenuItem.Text = "Save As";
            this.saveAsMenuItem.Click += new System.EventHandler(this.toolBtnSaveAs_Click);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Enabled = false;
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(121, 22);
            this.closeMenuItem.Text = "Close";
            this.closeMenuItem.Click += new System.EventHandler(this.toolbtnClose_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem,
            this.addMenuItem,
            this.propertiesMenuItem,
            this.deleteMenuItem});
            this.editMenu.ForeColor = System.Drawing.Color.Azure;
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(43, 20);
            this.editMenu.Text = "&Edit";
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.createNewToolStripMenuItem.Text = "Create New";
            this.createNewToolStripMenuItem.Click += new System.EventHandler(this.toolBtnCreate_Click);
            // 
            // addMenuItem
            // 
            this.addMenuItem.Enabled = false;
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addMenuItem.Text = "Add";
            this.addMenuItem.Click += new System.EventHandler(this.toolBtnAdd_Click);
            // 
            // propertiesMenuItem
            // 
            this.propertiesMenuItem.Enabled = false;
            this.propertiesMenuItem.Name = "propertiesMenuItem";
            this.propertiesMenuItem.Size = new System.Drawing.Size(143, 22);
            this.propertiesMenuItem.Text = "Properties";
            this.propertiesMenuItem.Click += new System.EventHandler(this.toolBtnProperties_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Enabled = false;
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(143, 22);
            this.deleteMenuItem.Text = "Delete";
            this.deleteMenuItem.Click += new System.EventHandler(this.toolBtnDelete_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenu.ForeColor = System.Drawing.Color.Azure;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(47, 20);
            this.helpMenu.Text = "&Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.toolBtnHelp_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.toolStrip1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnOpen,
            this.toolbtnClose,
            this.toolBtnSave,
            this.toolBtnSaveAs,
            this.toolBtnCreate,
            this.toolBtnAdd,
            this.toolBtnProperties,
            this.toolBtnDelete,
            this.toolBtnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(443, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnOpen
            // 
            this.toolBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnOpen.Image")));
            this.toolBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnOpen.Name = "toolBtnOpen";
            this.toolBtnOpen.Size = new System.Drawing.Size(23, 22);
            this.toolBtnOpen.Text = "Open";
            this.toolBtnOpen.ToolTipText = "Open";
            this.toolBtnOpen.Click += new System.EventHandler(this.toolBtnOpen_Click);
            this.toolBtnOpen.EnabledChanged += new System.EventHandler(this.toolBtnOpen_EnabledChanged);
            // 
            // toolbtnClose
            // 
            this.toolbtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnClose.Enabled = false;
            this.toolbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnClose.Image")));
            this.toolbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnClose.Name = "toolbtnClose";
            this.toolbtnClose.Size = new System.Drawing.Size(23, 22);
            this.toolbtnClose.Text = "Close";
            this.toolbtnClose.Click += new System.EventHandler(this.toolbtnClose_Click);
            this.toolbtnClose.EnabledChanged += new System.EventHandler(this.toolbtnClose_EnabledChanged);
            // 
            // toolBtnSave
            // 
            this.toolBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSave.Enabled = false;
            this.toolBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnSave.Image")));
            this.toolBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSave.Name = "toolBtnSave";
            this.toolBtnSave.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSave.Text = "Save";
            this.toolBtnSave.ToolTipText = "Save";
            this.toolBtnSave.Click += new System.EventHandler(this.toolBtnSave_Click);
            this.toolBtnSave.EnabledChanged += new System.EventHandler(this.toolBtnSave_EnabledChanged);
            // 
            // toolBtnSaveAs
            // 
            this.toolBtnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSaveAs.Enabled = false;
            this.toolBtnSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnSaveAs.Image")));
            this.toolBtnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSaveAs.Name = "toolBtnSaveAs";
            this.toolBtnSaveAs.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSaveAs.Text = "Save As";
            this.toolBtnSaveAs.ToolTipText = "Save As";
            this.toolBtnSaveAs.Click += new System.EventHandler(this.toolBtnSaveAs_Click);
            this.toolBtnSaveAs.EnabledChanged += new System.EventHandler(this.toolBtnSaveAs_EnabledChanged);
            // 
            // toolBtnCreate
            // 
            this.toolBtnCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnCreate.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnCreate.Image")));
            this.toolBtnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnCreate.Name = "toolBtnCreate";
            this.toolBtnCreate.Size = new System.Drawing.Size(23, 22);
            this.toolBtnCreate.Text = "Create New";
            this.toolBtnCreate.ToolTipText = "Create New";
            this.toolBtnCreate.Click += new System.EventHandler(this.toolBtnCreate_Click);
            // 
            // toolBtnAdd
            // 
            this.toolBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAdd.Enabled = false;
            this.toolBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnAdd.Image")));
            this.toolBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAdd.Text = "Add";
            this.toolBtnAdd.ToolTipText = "Add";
            this.toolBtnAdd.Click += new System.EventHandler(this.toolBtnAdd_Click);
            this.toolBtnAdd.EnabledChanged += new System.EventHandler(this.toolBtnAdd_EnabledChanged);
            // 
            // toolBtnProperties
            // 
            this.toolBtnProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnProperties.Enabled = false;
            this.toolBtnProperties.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnProperties.Image")));
            this.toolBtnProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnProperties.Name = "toolBtnProperties";
            this.toolBtnProperties.Size = new System.Drawing.Size(23, 22);
            this.toolBtnProperties.Text = "Properties";
            this.toolBtnProperties.ToolTipText = "Properties";
            this.toolBtnProperties.Click += new System.EventHandler(this.toolBtnProperties_Click);
            this.toolBtnProperties.EnabledChanged += new System.EventHandler(this.toolBtnProperties_EnabledChanged);
            // 
            // toolBtnDelete
            // 
            this.toolBtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelete.Enabled = false;
            this.toolBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnDelete.Image")));
            this.toolBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelete.Name = "toolBtnDelete";
            this.toolBtnDelete.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelete.Text = "Delete";
            this.toolBtnDelete.ToolTipText = "Delete";
            this.toolBtnDelete.Click += new System.EventHandler(this.toolBtnDelete_Click);
            this.toolBtnDelete.EnabledChanged += new System.EventHandler(this.toolBtnDelete_EnabledChanged);
            // 
            // toolBtnHelp
            // 
            this.toolBtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnHelp.Image")));
            this.toolBtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnHelp.Name = "toolBtnHelp";
            this.toolBtnHelp.Size = new System.Drawing.Size(23, 22);
            this.toolBtnHelp.Text = "Help";
            this.toolBtnHelp.ToolTipText = "Help";
            this.toolBtnHelp.Click += new System.EventHandler(this.toolBtnHelp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(22, 69);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(398, 509);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage1.Controls.Add(this.lstBxEmployees);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(390, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employees";
            // 
            // lstBxEmployees
            // 
            this.lstBxEmployees.BackColor = System.Drawing.Color.Azure;
            this.lstBxEmployees.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxEmployees.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lstBxEmployees.FormattingEnabled = true;
            this.lstBxEmployees.ItemHeight = 27;
            this.lstBxEmployees.Location = new System.Drawing.Point(21, 16);
            this.lstBxEmployees.Name = "lstBxEmployees";
            this.lstBxEmployees.Size = new System.Drawing.Size(348, 463);
            this.lstBxEmployees.TabIndex = 0;
            this.lstBxEmployees.SelectedIndexChanged += new System.EventHandler(this.lstBxEmployees_SelectedIndexChanged);
            this.lstBxEmployees.DoubleClick += new System.EventHandler(this.toolBtnProperties_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.btnCancel);
            this.tabPage2.Controls.Add(this.btnOK);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtBxSalary);
            this.tabPage2.Controls.Add(this.txtBxEmployeeType);
            this.tabPage2.Controls.Add(this.txtBxLastName);
            this.tabPage2.Controls.Add(this.txtBxFirstName);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(390, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Properties";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancel.Location = new System.Drawing.Point(211, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 41);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Turquoise;
            this.btnOK.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnOK.Location = new System.Drawing.Point(29, 428);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(151, 41);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.toolBtnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(128, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Employee Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(128, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(101, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(104, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee Last Name";
            // 
            // txtBxSalary
            // 
            this.txtBxSalary.BackColor = System.Drawing.Color.Azure;
            this.txtBxSalary.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSalary.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtBxSalary.Location = new System.Drawing.Point(30, 347);
            this.txtBxSalary.Multiline = true;
            this.txtBxSalary.Name = "txtBxSalary";
            this.txtBxSalary.Size = new System.Drawing.Size(329, 49);
            this.txtBxSalary.TabIndex = 3;
            this.txtBxSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxEmployeeType
            // 
            this.txtBxEmployeeType.BackColor = System.Drawing.Color.Azure;
            this.txtBxEmployeeType.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxEmployeeType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtBxEmployeeType.Location = new System.Drawing.Point(29, 258);
            this.txtBxEmployeeType.Multiline = true;
            this.txtBxEmployeeType.Name = "txtBxEmployeeType";
            this.txtBxEmployeeType.Size = new System.Drawing.Size(329, 49);
            this.txtBxEmployeeType.TabIndex = 2;
            this.txtBxEmployeeType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.BackColor = System.Drawing.Color.Azure;
            this.txtBxLastName.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxLastName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtBxLastName.Location = new System.Drawing.Point(29, 80);
            this.txtBxLastName.Multiline = true;
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(329, 49);
            this.txtBxLastName.TabIndex = 0;
            this.txtBxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.BackColor = System.Drawing.Color.Azure;
            this.txtBxFirstName.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxFirstName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtBxFirstName.Location = new System.Drawing.Point(29, 169);
            this.txtBxFirstName.Multiline = true;
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(329, 49);
            this.txtBxFirstName.TabIndex = 1;
            this.txtBxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // txtBxMessage
            // 
            this.txtBxMessage.BackColor = System.Drawing.Color.CadetBlue;
            this.txtBxMessage.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxMessage.ForeColor = System.Drawing.Color.White;
            this.txtBxMessage.Location = new System.Drawing.Point(22, 600);
            this.txtBxMessage.Multiline = true;
            this.txtBxMessage.Name = "txtBxMessage";
            this.txtBxMessage.ReadOnly = true;
            this.txtBxMessage.Size = new System.Drawing.Size(398, 85);
            this.txtBxMessage.TabIndex = 3;
            this.txtBxMessage.TabStop = false;
            this.txtBxMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // employeeFormBindingSource
            // 
            this.employeeFormBindingSource.DataSource = typeof(FinalProject.EmployeeForm);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(443, 707);
            this.Controls.Add(this.txtBxMessage);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeeForm";
            this.Text = "Employee Management App";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstBxEmployees;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem addMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripButton toolBtnOpen;
        private System.Windows.Forms.ToolStripButton toolBtnSave;
        private System.Windows.Forms.ToolStripButton toolBtnSaveAs;
        private System.Windows.Forms.ToolStripButton toolBtnAdd;
        private System.Windows.Forms.ToolStripButton toolBtnProperties;
        private System.Windows.Forms.ToolStripButton toolBtnDelete;
        private System.Windows.Forms.TextBox txtBxSalary;
        private System.Windows.Forms.TextBox txtBxEmployeeType;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.ToolStripButton toolBtnHelp;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtBxMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolBtnCreate;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ToolStripButton toolbtnClose;
        private System.Windows.Forms.BindingSource employeeFormBindingSource;
    }
}

