namespace SecurityDetail
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnToContract = new System.Windows.Forms.Button();
            this.btnToApplication = new System.Windows.Forms.Button();
            this.btnToAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnToContract
            // 
            this.btnToContract.BackColor = System.Drawing.Color.CadetBlue;
            this.btnToContract.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnToContract.Location = new System.Drawing.Point(412, 342);
            this.btnToContract.Name = "btnToContract";
            this.btnToContract.Size = new System.Drawing.Size(205, 72);
            this.btnToContract.TabIndex = 0;
            this.btnToContract.Text = "Make a Contract";
            this.btnToContract.UseVisualStyleBackColor = false;
            // 
            // btnToApplication
            // 
            this.btnToApplication.BackColor = System.Drawing.Color.CadetBlue;
            this.btnToApplication.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnToApplication.Location = new System.Drawing.Point(412, 442);
            this.btnToApplication.Name = "btnToApplication";
            this.btnToApplication.Size = new System.Drawing.Size(205, 72);
            this.btnToApplication.TabIndex = 1;
            this.btnToApplication.Text = "Apply to Join the Organization";
            this.btnToApplication.UseVisualStyleBackColor = false;
            // 
            // btnToAdmin
            // 
            this.btnToAdmin.BackColor = System.Drawing.Color.CadetBlue;
            this.btnToAdmin.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnToAdmin.Location = new System.Drawing.Point(412, 542);
            this.btnToAdmin.Name = "btnToAdmin";
            this.btnToAdmin.Size = new System.Drawing.Size(205, 72);
            this.btnToAdmin.TabIndex = 2;
            this.btnToAdmin.Text = "Admin Log-in";
            this.btnToAdmin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(851, 130);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1028, 677);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToAdmin);
            this.Controls.Add(this.btnToApplication);
            this.Controls.Add(this.btnToContract);
            this.Name = "frmMain";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToContract;
        private System.Windows.Forms.Button btnToApplication;
        private System.Windows.Forms.Button btnToAdmin;
        private System.Windows.Forms.Label label1;
    }
}

