using System;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    /// <summary>
    /// Creates a MessageBox-style Form with instructions for app
    /// </summary>
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Formats instructions and prints them to text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpForm_Load(object sender, EventArgs e)
        {
            StringBuilder instructions = new StringBuilder();
            instructions.AppendLine(string.Format("{0, 72}","Instructions for Employee Management App\r\n"));
            instructions.AppendLine(string.Format("{0, 0}{1, 71}", "To:","Use:\r\n"));
            instructions.AppendLine(string.Format("{0, 0}{1, 78}", "Open a file", "Open button or File->Open"));
            instructions.AppendLine(string.Format("{0, 0}{1, 80}", "Close a file", "Close button or File->Close"));
            instructions.AppendLine(string.Format("{0, 0}{1, 57}", "Save data to current file", "Save button or File->Save"));
            instructions.AppendLine(string.Format("{0, 0}{1, 69}", "Save data to new file", "Save As button or File->Save As"));
            instructions.AppendLine(string.Format("{0, 0}{1, 71}", "Create a new employee", "Create New button or Edit->Create New"));
            instructions.AppendLine(string.Format("{0, 0}{1, 41}", "Add edited/new employee to list", "Add button or Edit->Add"));
            instructions.AppendLine(string.Format("{0, 0}{1, 58}", "View/edit employee properties", "Properties button or Edit->Properties"));
            instructions.AppendLine(string.Format("{0, 0}{1, 58}", "Delete employee from list", "Delete button or Edit->Delete"));
            instructions.AppendLine(string.Format("{0, 0}{1, 62}", "View app instructions", "Help button or Help->About"));
            txtBxInstructions.Text = instructions.ToString();
        }
    }
}
