namespace FinalProject
{
    partial class HelpForm
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
            this.txtBxInstructions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBxInstructions
            // 
            this.txtBxInstructions.BackColor = System.Drawing.Color.CadetBlue;
            this.txtBxInstructions.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxInstructions.ForeColor = System.Drawing.Color.Azure;
            this.txtBxInstructions.Location = new System.Drawing.Point(20, 18);
            this.txtBxInstructions.Multiline = true;
            this.txtBxInstructions.Name = "txtBxInstructions";
            this.txtBxInstructions.ReadOnly = true;
            this.txtBxInstructions.Size = new System.Drawing.Size(552, 226);
            this.txtBxInstructions.TabIndex = 0;
            this.txtBxInstructions.TabStop = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(593, 262);
            this.Controls.Add(this.txtBxInstructions);
            this.Name = "HelpForm";
            this.Text = "App Instructions";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxInstructions;
    }
}