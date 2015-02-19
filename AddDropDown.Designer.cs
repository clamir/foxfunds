namespace FoxForms
{
    partial class AddDropDown
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
            this.components = new System.ComponentModel.Container();
            this.values = new System.Windows.Forms.DataGridView();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Display = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_OK = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.values)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // values
            // 
            this.values.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.values.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value,
            this.Display});
            this.values.ContextMenuStrip = this.contextMenuStrip1;
            this.values.Location = new System.Drawing.Point(12, 69);
            this.values.MultiSelect = false;
            this.values.Name = "values";
            this.values.Size = new System.Drawing.Size(377, 403);
            this.values.TabIndex = 0;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // Display
            // 
            this.Display.HeaderText = "Display As";
            this.Display.Name = "Display";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(63, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(127, 20);
            this.name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // b_OK
            // 
            this.b_OK.Location = new System.Drawing.Point(12, 487);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(75, 23);
            this.b_OK.TabIndex = 3;
            this.b_OK.Text = "OK";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(314, 487);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 4;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // AddDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 597);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.values);
            this.Name = "AddDropDown";
            this.Text = "AddDropDown";
            ((System.ComponentModel.ISupportInitialize)(this.values)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView values;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Display;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}