namespace KClient
{
    partial class FormSettings
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
            this.labelOPCURL = new System.Windows.Forms.Label();
            this.textBoxOPCURL = new System.Windows.Forms.TextBox();
            this.textBoxRamp = new System.Windows.Forms.TextBox();
            this.labelRamp = new System.Windows.Forms.Label();
            this.textBoxRandom = new System.Windows.Forms.TextBox();
            this.labelRandom = new System.Windows.Forms.Label();
            this.textBoxSin = new System.Windows.Forms.TextBox();
            this.labelSin = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOPCURL
            // 
            this.labelOPCURL.AutoSize = true;
            this.labelOPCURL.Location = new System.Drawing.Point(11, 16);
            this.labelOPCURL.Name = "labelOPCURL";
            this.labelOPCURL.Size = new System.Drawing.Size(54, 13);
            this.labelOPCURL.TabIndex = 0;
            this.labelOPCURL.Text = "OPC URL";
            // 
            // textBoxOPCURL
            // 
            this.textBoxOPCURL.Location = new System.Drawing.Point(88, 12);
            this.textBoxOPCURL.Name = "textBoxOPCURL";
            this.textBoxOPCURL.Size = new System.Drawing.Size(300, 20);
            this.textBoxOPCURL.TabIndex = 1;
            // 
            // textBoxRamp
            // 
            this.textBoxRamp.Location = new System.Drawing.Point(88, 57);
            this.textBoxRamp.Name = "textBoxRamp";
            this.textBoxRamp.Size = new System.Drawing.Size(300, 20);
            this.textBoxRamp.TabIndex = 3;
            // 
            // labelRamp
            // 
            this.labelRamp.AutoSize = true;
            this.labelRamp.Location = new System.Drawing.Point(11, 61);
            this.labelRamp.Name = "labelRamp";
            this.labelRamp.Size = new System.Drawing.Size(35, 13);
            this.labelRamp.TabIndex = 2;
            this.labelRamp.Text = "Ramp";
            // 
            // textBoxRandom
            // 
            this.textBoxRandom.Location = new System.Drawing.Point(88, 83);
            this.textBoxRandom.Name = "textBoxRandom";
            this.textBoxRandom.Size = new System.Drawing.Size(300, 20);
            this.textBoxRandom.TabIndex = 5;
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Location = new System.Drawing.Point(11, 87);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(47, 13);
            this.labelRandom.TabIndex = 4;
            this.labelRandom.Text = "Random";
            // 
            // textBoxSin
            // 
            this.textBoxSin.Location = new System.Drawing.Point(88, 109);
            this.textBoxSin.Name = "textBoxSin";
            this.textBoxSin.Size = new System.Drawing.Size(300, 20);
            this.textBoxSin.TabIndex = 7;
            // 
            // labelSin
            // 
            this.labelSin.AutoSize = true;
            this.labelSin.Location = new System.Drawing.Point(11, 113);
            this.labelSin.Name = "labelSin";
            this.labelSin.Size = new System.Drawing.Size(22, 13);
            this.labelSin.TabIndex = 6;
            this.labelSin.Text = "Sin";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(232, 195);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(313, 195);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 230);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxSin);
            this.Controls.Add(this.labelSin);
            this.Controls.Add(this.textBoxRandom);
            this.Controls.Add(this.labelRandom);
            this.Controls.Add(this.textBoxRamp);
            this.Controls.Add(this.labelRamp);
            this.Controls.Add(this.textBoxOPCURL);
            this.Controls.Add(this.labelOPCURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOPCURL;
        private System.Windows.Forms.TextBox textBoxOPCURL;
        private System.Windows.Forms.TextBox textBoxRamp;
        private System.Windows.Forms.Label labelRamp;
        private System.Windows.Forms.TextBox textBoxRandom;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.TextBox textBoxSin;
        private System.Windows.Forms.Label labelSin;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}