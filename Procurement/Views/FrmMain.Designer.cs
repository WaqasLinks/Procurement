namespace Procurement.Views
{
    partial class FrmMain
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
            this.lnkProjectsList = new System.Windows.Forms.LinkLabel();
            this.lnkOpenLastProject = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnkProjectsList
            // 
            this.lnkProjectsList.AutoSize = true;
            this.lnkProjectsList.Location = new System.Drawing.Point(56, 62);
            this.lnkProjectsList.Name = "lnkProjectsList";
            this.lnkProjectsList.Size = new System.Drawing.Size(85, 17);
            this.lnkProjectsList.TabIndex = 0;
            this.lnkProjectsList.TabStop = true;
            this.lnkProjectsList.Text = "Projects List";
            // 
            // lnkOpenLastProject
            // 
            this.lnkOpenLastProject.AutoSize = true;
            this.lnkOpenLastProject.Location = new System.Drawing.Point(56, 92);
            this.lnkOpenLastProject.Name = "lnkOpenLastProject";
            this.lnkOpenLastProject.Size = new System.Drawing.Size(122, 17);
            this.lnkOpenLastProject.TabIndex = 1;
            this.lnkOpenLastProject.TabStop = true;
            this.lnkOpenLastProject.Text = "Open Last Project";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Projects";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(58, 123);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 17);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "New Project";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkOpenLastProject);
            this.Controls.Add(this.lnkProjectsList);
            this.Name = "FrmMain";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkProjectsList;
        private System.Windows.Forms.LinkLabel lnkOpenLastProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}