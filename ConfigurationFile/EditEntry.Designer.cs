namespace ConfigurationFile
{
    partial class EditEntry
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
            this.cbIsOn = new System.Windows.Forms.CheckBox();
            this.btnEditEntry = new System.Windows.Forms.Button();
            this.lblIsEnabled = new System.Windows.Forms.Label();
            this.lblSettingValue = new System.Windows.Forms.Label();
            this.lblSettingName = new System.Windows.Forms.Label();
            this.txtSettingValue = new System.Windows.Forms.TextBox();
            this.txtSettingName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbIsOn
            // 
            this.cbIsOn.AutoSize = true;
            this.cbIsOn.Location = new System.Drawing.Point(223, 171);
            this.cbIsOn.Name = "cbIsOn";
            this.cbIsOn.Size = new System.Drawing.Size(171, 29);
            this.cbIsOn.TabIndex = 16;
            this.cbIsOn.Text = "Yes, it is active.";
            this.cbIsOn.UseVisualStyleBackColor = true;
            // 
            // btnEditEntry
            // 
            this.btnEditEntry.BackColor = System.Drawing.Color.Maroon;
            this.btnEditEntry.Font = new System.Drawing.Font("Calibri", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEntry.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditEntry.Location = new System.Drawing.Point(22, 257);
            this.btnEditEntry.Name = "btnEditEntry";
            this.btnEditEntry.Size = new System.Drawing.Size(394, 70);
            this.btnEditEntry.TabIndex = 15;
            this.btnEditEntry.Text = "Edit Entry";
            this.btnEditEntry.UseVisualStyleBackColor = false;
            this.btnEditEntry.Click += new System.EventHandler(this.btnEditEntry_Click);
            // 
            // lblIsEnabled
            // 
            this.lblIsEnabled.AutoSize = true;
            this.lblIsEnabled.Location = new System.Drawing.Point(17, 175);
            this.lblIsEnabled.Name = "lblIsEnabled";
            this.lblIsEnabled.Size = new System.Drawing.Size(184, 25);
            this.lblIsEnabled.TabIndex = 14;
            this.lblIsEnabled.Text = "Is This Active Now?";
            // 
            // lblSettingValue
            // 
            this.lblSettingValue.AutoSize = true;
            this.lblSettingValue.Location = new System.Drawing.Point(17, 111);
            this.lblSettingValue.Name = "lblSettingValue";
            this.lblSettingValue.Size = new System.Drawing.Size(135, 25);
            this.lblSettingValue.TabIndex = 13;
            this.lblSettingValue.Text = "Setting Value:";
            // 
            // lblSettingName
            // 
            this.lblSettingName.AutoSize = true;
            this.lblSettingName.Location = new System.Drawing.Point(17, 32);
            this.lblSettingName.Name = "lblSettingName";
            this.lblSettingName.Size = new System.Drawing.Size(136, 25);
            this.lblSettingName.TabIndex = 12;
            this.lblSettingName.Text = "Setting Name:";
            // 
            // txtSettingValue
            // 
            this.txtSettingValue.Location = new System.Drawing.Point(223, 111);
            this.txtSettingValue.Name = "txtSettingValue";
            this.txtSettingValue.Size = new System.Drawing.Size(193, 29);
            this.txtSettingValue.TabIndex = 11;
            // 
            // txtSettingName
            // 
            this.txtSettingName.Location = new System.Drawing.Point(223, 32);
            this.txtSettingName.Name = "txtSettingName";
            this.txtSettingName.Size = new System.Drawing.Size(193, 29);
            this.txtSettingName.TabIndex = 10;
            // 
            // EditEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(441, 364);
            this.Controls.Add(this.cbIsOn);
            this.Controls.Add(this.btnEditEntry);
            this.Controls.Add(this.lblIsEnabled);
            this.Controls.Add(this.lblSettingValue);
            this.Controls.Add(this.lblSettingName);
            this.Controls.Add(this.txtSettingValue);
            this.Controls.Add(this.txtSettingName);
            this.Name = "EditEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditEntry";
            this.Load += new System.EventHandler(this.EditEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbIsOn;
        private System.Windows.Forms.Button btnEditEntry;
        private System.Windows.Forms.Label lblIsEnabled;
        private System.Windows.Forms.Label lblSettingValue;
        private System.Windows.Forms.Label lblSettingName;
        private System.Windows.Forms.TextBox txtSettingValue;
        private System.Windows.Forms.TextBox txtSettingName;
    }
}