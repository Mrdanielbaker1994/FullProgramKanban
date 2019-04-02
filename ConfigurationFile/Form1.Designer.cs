namespace ConfigurationFile
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
            this.dgConfigTableView = new System.Windows.Forms.DataGridView();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.lblEditInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgConfigTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgConfigTableView
            // 
            this.dgConfigTableView.AllowUserToAddRows = false;
            this.dgConfigTableView.AllowUserToDeleteRows = false;
            this.dgConfigTableView.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgConfigTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConfigTableView.Location = new System.Drawing.Point(12, 12);
            this.dgConfigTableView.Name = "dgConfigTableView";
            this.dgConfigTableView.ReadOnly = true;
            this.dgConfigTableView.RowTemplate.Height = 31;
            this.dgConfigTableView.Size = new System.Drawing.Size(919, 485);
            this.dgConfigTableView.TabIndex = 0;
            this.dgConfigTableView.SelectionChanged += new System.EventHandler(this.dg_selected);
            // 
            // btnAddRule
            // 
            this.btnAddRule.BackColor = System.Drawing.Color.Maroon;
            this.btnAddRule.Font = new System.Drawing.Font("Calibri", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRule.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddRule.Location = new System.Drawing.Point(9, 612);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(451, 59);
            this.btnAddRule.TabIndex = 1;
            this.btnAddRule.Text = "Add Rule";
            this.btnAddRule.UseVisualStyleBackColor = false;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // btnEditRule
            // 
            this.btnEditRule.BackColor = System.Drawing.Color.Maroon;
            this.btnEditRule.Font = new System.Drawing.Font("Calibri", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRule.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditRule.Location = new System.Drawing.Point(531, 612);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(397, 59);
            this.btnEditRule.TabIndex = 2;
            this.btnEditRule.Text = "Edit Rule";
            this.btnEditRule.UseVisualStyleBackColor = false;
            this.btnEditRule.Click += new System.EventHandler(this.btnEditRule_Click);
            // 
            // lblEditInstructions
            // 
            this.lblEditInstructions.AutoSize = true;
            this.lblEditInstructions.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblEditInstructions.Font = new System.Drawing.Font("Calibri", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditInstructions.Location = new System.Drawing.Point(559, 533);
            this.lblEditInstructions.MaximumSize = new System.Drawing.Size(397, 0);
            this.lblEditInstructions.Name = "lblEditInstructions";
            this.lblEditInstructions.Size = new System.Drawing.Size(342, 66);
            this.lblEditInstructions.TabIndex = 3;
            this.lblEditInstructions.Text = "To edit a row, please select a row\'s left-most cell.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(943, 680);
            this.Controls.Add(this.lblEditInstructions);
            this.Controls.Add(this.btnEditRule);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.dgConfigTableView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Kanban Configuration Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgConfigTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgConfigTableView;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Button btnEditRule;
        private System.Windows.Forms.Label lblEditInstructions;
    }
}

