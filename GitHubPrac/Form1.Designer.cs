namespace GitHubPrac
{
    partial class Form1
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtDragonName = new System.Windows.Forms.TextBox();
            this.lblDragonName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Location = new System.Drawing.Point(13, 24);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(868, 30);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(13, 69);
            this.txtPlayerName.Multiline = true;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(868, 50);
            this.txtPlayerName.TabIndex = 1;
            // 
            // txtDragonName
            // 
            this.txtDragonName.Location = new System.Drawing.Point(10, 194);
            this.txtDragonName.Multiline = true;
            this.txtDragonName.Name = "txtDragonName";
            this.txtDragonName.Size = new System.Drawing.Size(868, 50);
            this.txtDragonName.TabIndex = 3;
            // 
            // lblDragonName
            // 
            this.lblDragonName.Location = new System.Drawing.Point(10, 149);
            this.lblDragonName.Name = "lblDragonName";
            this.lblDragonName.Size = new System.Drawing.Size(868, 30);
            this.lblDragonName.TabIndex = 2;
            this.lblDragonName.Text = "Dragon Name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(868, 70);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(10, 391);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(868, 107);
            this.rtbLog.TabIndex = 5;
            this.rtbLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 525);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDragonName);
            this.Controls.Add(this.lblDragonName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtDragonName;
        private System.Windows.Forms.Label lblDragonName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}

