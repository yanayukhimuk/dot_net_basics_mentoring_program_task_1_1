namespace WindowsFormsApp_task1
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
            this.btnAddName = new System.Windows.Forms.Button();
            this.listNames = new System.Windows.Forms.ListBox();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddName
            // 
            this.btnAddName.AutoSize = true;
            this.btnAddName.Location = new System.Drawing.Point(409, 284);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(169, 56);
            this.btnAddName.TabIndex = 0;
            this.btnAddName.Text = "Add Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // listNames
            // 
            this.listNames.FormattingEnabled = true;
            this.listNames.ItemHeight = 16;
            this.listNames.Location = new System.Drawing.Point(60, 96);
            this.listNames.Name = "listNames";
            this.listNames.Size = new System.Drawing.Size(323, 244);
            this.listNames.TabIndex = 1;
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(409, 205);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(169, 22);
            this.txtNames.TabIndex = 2;
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(60, 47);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(45, 16);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 442);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.listNames);
            this.Controls.Add(this.btnAddName);
            this.Name = "Form1";
            this.Text = "Hello!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.ListBox listNames;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.Label Output;
    }
}

