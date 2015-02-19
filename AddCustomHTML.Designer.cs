namespace FoxForms
{
    partial class AddCustomHTML
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
            this.html_code = new System.Windows.Forms.TextBox();
            this.b_OK = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // html_code
            // 
            this.html_code.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.html_code.Location = new System.Drawing.Point(12, 22);
            this.html_code.Multiline = true;
            this.html_code.Name = "html_code";
            this.html_code.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.html_code.Size = new System.Drawing.Size(544, 316);
            this.html_code.TabIndex = 0;
            // 
            // b_OK
            // 
            this.b_OK.Location = new System.Drawing.Point(12, 350);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(75, 23);
            this.b_OK.TabIndex = 1;
            this.b_OK.Text = "OK";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_cancel.Location = new System.Drawing.Point(481, 350);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 2;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // AddCustomHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b_cancel;
            this.ClientSize = new System.Drawing.Size(568, 385);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_OK);
            this.Controls.Add(this.html_code);
            this.Name = "AddCustomHTML";
            this.Text = "Add Custom HTML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox html_code;
        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.Button b_cancel;
    }
}