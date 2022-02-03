namespace IPChange
{
    partial class IpConfigViewForm
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
            this.textBoxIpconfig = new System.Windows.Forms.TextBox();
            this.labelLastUpdate = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIpconfig
            // 
            this.textBoxIpconfig.Location = new System.Drawing.Point(12, 12);
            this.textBoxIpconfig.Multiline = true;
            this.textBoxIpconfig.Name = "textBoxIpconfig";
            this.textBoxIpconfig.ReadOnly = true;
            this.textBoxIpconfig.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxIpconfig.Size = new System.Drawing.Size(529, 413);
            this.textBoxIpconfig.TabIndex = 0;
            // 
            // labelLastUpdate
            // 
            this.labelLastUpdate.AutoSize = true;
            this.labelLastUpdate.Location = new System.Drawing.Point(12, 444);
            this.labelLastUpdate.Name = "labelLastUpdate";
            this.labelLastUpdate.Size = new System.Drawing.Size(84, 12);
            this.labelLastUpdate.TabIndex = 1;
            this.labelLastUpdate.Text = "Last Update : ";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(460, 433);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(81, 34);
            this.buttonOk.TabIndex = 29;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(334, 433);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(81, 34);
            this.buttonRefresh.TabIndex = 30;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // IpConfigViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 473);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelLastUpdate);
            this.Controls.Add(this.textBoxIpconfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "IpConfigViewForm";
            this.Text = "IpConfig View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIpconfig;
        private System.Windows.Forms.Label labelLastUpdate;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonRefresh;
    }
}