namespace ConfigurationFile
{
    partial class AddRule
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
            this.txtSettingName = new System.Windows.Forms.TextBox();
            this.txtSettingValue = new System.Windows.Forms.TextBox();
            this.lblSettingName = new System.Windows.Forms.Label();
            this.lblSettingValue = new System.Windows.Forms.Label();
            this.lblIsEnabled = new System.Windows.Forms.Label();
            this.btnAddToDB = new System.Windows.Forms.Button();
            this.cbIsOn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSettingName
            // 
            this.txtSettingName.Location = new System.Drawing.Point(218, 54);
            this.txtSettingName.Name = "txtSettingName";
            this.txtSettingName.Size = new System.Drawing.Size(193, 29);
            this.txtSettingName.TabIndex = 2;
            // 
            // txtSettingValue
            // 
            this.txtSettingValue.Location = new System.Drawing.Point(218, 133);
            this.txtSettingValue.Name = "txtSettingValue";
            this.txtSettingValue.Size = new System.Drawing.Size(193, 29);
            this.txtSettingValue.TabIndex = 3;
            // 
            // lblSettingName
            // 
            this.lblSettingName.AutoSize = true;
            this.lblSettingName.Location = new System.Drawing.Point(12, 54);
            this.lblSettingName.Name = "lblSettingName";
            this.lblSettingName.Size = new System.Drawing.Size(136, 25);
            this.lblSettingName.TabIndex = 4;
            this.lblSettingName.Text = "Setting Name:";
            // 
            // lblSettingValue
            // 
            this.lblSettingValue.AutoSize = true;
            this.lblSettingValue.Location = new System.Drawing.Point(12, 133);
            this.lblSettingValue.Name = "lblSettingValue";
            this.lblSettingValue.Size = new System.Drawing.Size(135, 25);
            this.lblSettingValue.TabIndex = 5;
            this.lblSettingValue.Text = "Setting Value:";
            // 
            // lblIsEnabled
            // 
            this.lblIsEnabled.AutoSize = true;
            this.lblIsEnabled.Location = new System.Drawing.Point(12, 197);
            this.lblIsEnabled.Name = "lblIsEnabled";
            this.lblIsEnabled.Size = new System.Drawing.Size(184, 25);
            this.lblIsEnabled.TabIndex = 7;
            this.lblIsEnabled.Text = "Is This Active Now?";
            // 
            // btnAddToDB
            // 
            this.btnAddToDB.BackColor = System.Drawing.Color.Maroon;
            this.btnAddToDB.Font = new System.Drawing.Font("Calibri", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToDB.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddToDB.Location = new System.Drawing.Point(17, 279);
            this.btnAddToDB.Name = "btnAddToDB";
            this.btnAddToDB.Size = new System.Drawing.Size(394, 70);
            this.btnAddToDB.TabIndex = 8;
            this.btnAddToDB.Text = "Add to Configuration Settings";
            this.btnAddToDB.UseVisualStyleBackColor = false;
            this.btnAddToDB.Click += new System.EventHandler(this.btnAddToDB_Click);
            // 
            // cbIsOn
            // 
            this.cbIsOn.AutoSize = true;
            this.cbIsOn.Location = new System.Drawing.Point(218, 193);
            this.cbIsOn.Name = "cbIsOn";
            this.cbIsOn.Size = new System.Drawing.Size(171, 29);
            this.cbIsOn.TabIndex = 9;
            this.cbIsOn.Text = "Yes, it is active.";
            this.cbIsOn.UseVisualStyleBackColor = true;
            // 
            // AddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(437, 378);
            this.Controls.Add(this.cbIsOn);
            this.Controls.Add(this.btnAddToDB);
            this.Controls.Add(this.lblIsEnabled);
            this.Controls.Add(this.lblSettingValue);
            this.Controls.Add(this.lblSettingName);
            this.Controls.Add(this.txtSettingValue);
            this.Controls.Add(this.txtSettingName);
            this.Name = "AddRule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddRule";
            this.Load += new System.EventHandler(this.AddRule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSettingName;
        private System.Windows.Forms.TextBox txtSettingValue;
        private System.Windows.Forms.Label lblSettingName;
        private System.Windows.Forms.Label lblSettingValue;
        private System.Windows.Forms.Label lblIsEnabled;
        private System.Windows.Forms.Button btnAddToDB;
        private System.Windows.Forms.CheckBox cbIsOn;
    }
}