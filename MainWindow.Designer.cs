namespace FoxForms
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainFormBox = new System.Windows.Forms.RichTextBox();
            this.b_text_box = new System.Windows.Forms.Button();
            this.b_drop_down = new System.Windows.Forms.Button();
            this.b_generate = new System.Windows.Forms.Button();
            this.b_preview = new System.Windows.Forms.Button();
            this.b_radio_button = new System.Windows.Forms.Button();
            this.b_hidden_input = new System.Windows.Forms.Button();
            this.b_submit = new System.Windows.Forms.Button();
            this.b_custom_HTML = new System.Windows.Forms.Button();
            this.element_list = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HTML = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menu_strip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFormDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFormDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.form_name = new System.Windows.Forms.ToolStripStatusLabel();
            this.form_comment = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListViewMenu.SuspendLayout();
            this.main_menu_strip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormBox
            // 
            this.MainFormBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormBox.Location = new System.Drawing.Point(12, 27);
            this.MainFormBox.Name = "MainFormBox";
            this.MainFormBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.MainFormBox.Size = new System.Drawing.Size(879, 623);
            this.MainFormBox.TabIndex = 0;
            this.MainFormBox.Text = "";
            // 
            // b_text_box
            // 
            this.b_text_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_text_box.Location = new System.Drawing.Point(900, 185);
            this.b_text_box.Name = "b_text_box";
            this.b_text_box.Size = new System.Drawing.Size(96, 43);
            this.b_text_box.TabIndex = 1;
            this.b_text_box.Text = "Text Box";
            this.b_text_box.UseVisualStyleBackColor = true;
            this.b_text_box.Click += new System.EventHandler(this.b_text_box_Click);
            // 
            // b_drop_down
            // 
            this.b_drop_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_drop_down.Location = new System.Drawing.Point(900, 234);
            this.b_drop_down.Name = "b_drop_down";
            this.b_drop_down.Size = new System.Drawing.Size(96, 43);
            this.b_drop_down.TabIndex = 2;
            this.b_drop_down.Text = "Drop Down";
            this.b_drop_down.UseVisualStyleBackColor = true;
            this.b_drop_down.Click += new System.EventHandler(this.b_drop_down_Click);
            // 
            // b_generate
            // 
            this.b_generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_generate.Location = new System.Drawing.Point(900, 606);
            this.b_generate.Name = "b_generate";
            this.b_generate.Size = new System.Drawing.Size(96, 43);
            this.b_generate.TabIndex = 8;
            this.b_generate.Text = "Generate";
            this.b_generate.UseVisualStyleBackColor = true;
            this.b_generate.Click += new System.EventHandler(this.b_generate_Click);
            // 
            // b_preview
            // 
            this.b_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_preview.Location = new System.Drawing.Point(900, 557);
            this.b_preview.Name = "b_preview";
            this.b_preview.Size = new System.Drawing.Size(96, 43);
            this.b_preview.TabIndex = 10;
            this.b_preview.Text = "Preview";
            this.b_preview.UseVisualStyleBackColor = true;
            this.b_preview.Click += new System.EventHandler(this.b_preview_Click);
            // 
            // b_radio_button
            // 
            this.b_radio_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_radio_button.Location = new System.Drawing.Point(900, 283);
            this.b_radio_button.Name = "b_radio_button";
            this.b_radio_button.Size = new System.Drawing.Size(96, 43);
            this.b_radio_button.TabIndex = 12;
            this.b_radio_button.Text = "Radio Button";
            this.b_radio_button.UseVisualStyleBackColor = true;
            this.b_radio_button.Click += new System.EventHandler(this.b_radio_Click);
            // 
            // b_hidden_input
            // 
            this.b_hidden_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_hidden_input.Location = new System.Drawing.Point(900, 332);
            this.b_hidden_input.Name = "b_hidden_input";
            this.b_hidden_input.Size = new System.Drawing.Size(96, 43);
            this.b_hidden_input.TabIndex = 13;
            this.b_hidden_input.Text = "Hidden Input";
            this.b_hidden_input.UseVisualStyleBackColor = true;
            this.b_hidden_input.Click += new System.EventHandler(this.b_hidden_input_Click);
            // 
            // b_submit
            // 
            this.b_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_submit.Location = new System.Drawing.Point(900, 381);
            this.b_submit.Name = "b_submit";
            this.b_submit.Size = new System.Drawing.Size(96, 43);
            this.b_submit.TabIndex = 14;
            this.b_submit.Text = "Submit Button";
            this.b_submit.UseVisualStyleBackColor = true;
            this.b_submit.Click += new System.EventHandler(this.b_submit_Click);
            // 
            // b_custom_HTML
            // 
            this.b_custom_HTML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_custom_HTML.Location = new System.Drawing.Point(900, 430);
            this.b_custom_HTML.Name = "b_custom_HTML";
            this.b_custom_HTML.Size = new System.Drawing.Size(96, 43);
            this.b_custom_HTML.TabIndex = 15;
            this.b_custom_HTML.Text = "Custom HTML";
            this.b_custom_HTML.UseVisualStyleBackColor = true;
            this.b_custom_HTML.Click += new System.EventHandler(this.b_custom_HTML_Click);
            // 
            // element_list
            // 
            this.element_list.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.element_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.element_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.Type,
            this.HTML});
            this.element_list.ContextMenuStrip = this.ListViewMenu;
            this.element_list.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.element_list.FullRowSelect = true;
            this.element_list.GridLines = true;
            this.element_list.HideSelection = false;
            this.element_list.HotTracking = true;
            this.element_list.HoverSelection = true;
            this.element_list.Location = new System.Drawing.Point(12, 656);
            this.element_list.MultiSelect = false;
            this.element_list.Name = "element_list";
            this.element_list.ShowGroups = false;
            this.element_list.Size = new System.Drawing.Size(984, 155);
            this.element_list.TabIndex = 16;
            this.element_list.UseCompatibleStateImageBehavior = false;
            this.element_list.View = System.Windows.Forms.View.Details;
            this.element_list.DoubleClick += new System.EventHandler(this.element_list_DoubleClick);
            // 
            // Index
            // 
            this.Index.Text = "Index";
            this.Index.Width = 50;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 75;
            // 
            // HTML
            // 
            this.HTML.Text = "HTML";
            this.HTML.Width = 855;
            // 
            // ListViewMenu
            // 
            this.ListViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit});
            this.ListViewMenu.Name = "ListViewMenu";
            this.ListViewMenu.Size = new System.Drawing.Size(122, 26);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(121, 22);
            this.Edit.Text = "Edit Item";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // main_menu_strip
            // 
            this.main_menu_strip.BackColor = System.Drawing.Color.White;
            this.main_menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.main_menu_strip.Location = new System.Drawing.Point(0, 0);
            this.main_menu_strip.Name = "main_menu_strip";
            this.main_menu_strip.Size = new System.Drawing.Size(1008, 24);
            this.main_menu_strip.TabIndex = 17;
            this.main_menu_strip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFormDefinitionToolStripMenuItem,
            this.saveFormDefinitionToolStripMenuItem,
            this.exitProgramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFormDefinitionToolStripMenuItem
            // 
            this.openFormDefinitionToolStripMenuItem.Name = "openFormDefinitionToolStripMenuItem";
            this.openFormDefinitionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.openFormDefinitionToolStripMenuItem.Text = "Open Form Definition";
            // 
            // saveFormDefinitionToolStripMenuItem
            // 
            this.saveFormDefinitionToolStripMenuItem.Name = "saveFormDefinitionToolStripMenuItem";
            this.saveFormDefinitionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.saveFormDefinitionToolStripMenuItem.Text = "Save Form Definition";
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.exitProgramToolStripMenuItem.Text = "Exit";
            this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(913, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Actions";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(897, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Add Element";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form_name,
            this.form_comment});
            this.statusStrip1.Location = new System.Drawing.Point(0, 816);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // form_name
            // 
            this.form_name.Name = "form_name";
            this.form_name.Size = new System.Drawing.Size(49, 17);
            this.form_name.Text = "Untitled";
            // 
            // form_comment
            // 
            this.form_comment.Name = "form_comment";
            this.form_comment.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(900, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 838);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.element_list);
            this.Controls.Add(this.b_custom_HTML);
            this.Controls.Add(this.b_submit);
            this.Controls.Add(this.b_hidden_input);
            this.Controls.Add(this.b_radio_button);
            this.Controls.Add(this.b_preview);
            this.Controls.Add(this.b_generate);
            this.Controls.Add(this.b_drop_down);
            this.Controls.Add(this.b_text_box);
            this.Controls.Add(this.MainFormBox);
            this.Controls.Add(this.main_menu_strip);
            this.MainMenuStrip = this.main_menu_strip;
            this.Name = "MainWindow";
            this.Text = " FoxForms";
            this.ListViewMenu.ResumeLayout(false);
            this.main_menu_strip.ResumeLayout(false);
            this.main_menu_strip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MainFormBox;
        private System.Windows.Forms.Button b_text_box;
        private System.Windows.Forms.Button b_drop_down;
        private System.Windows.Forms.Button b_generate;
        private System.Windows.Forms.Button b_preview;
        private System.Windows.Forms.Button b_radio_button;
        private System.Windows.Forms.Button b_hidden_input;
        private System.Windows.Forms.Button b_submit;
        private System.Windows.Forms.Button b_custom_HTML;
        private System.Windows.Forms.ListView element_list;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader HTML;
        private System.Windows.Forms.MenuStrip main_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFormDefinitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFormDefinitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel form_name;
        private System.Windows.Forms.ToolStripStatusLabel form_comment;
        private System.Windows.Forms.ContextMenuStrip ListViewMenu;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

