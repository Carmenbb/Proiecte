namespace Notepadd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.New_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Open_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Save_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Copy_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Cut_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Paste_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Undo_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Redo_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.File_New_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.File_Open_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.File_Save_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.File_Close_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_Cut_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_Copy_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_Paste_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Edit_Undo_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_Redo_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.File_Select_All_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.File_Clear_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View_Font_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.myTabControlZ = new System.Windows.Forms.TabControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_ToolStripButton,
            this.Open_ToolStripButton,
            this.Save_ToolStripButton,
            this.Copy_ToolStripButton,
            this.Cut_ToolStripButton,
            this.Paste_ToolStripButton,
            this.Undo_ToolStripButton,
            this.Redo_ToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(638, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // New_ToolStripButton
            // 
            this.New_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.New_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("New_ToolStripButton.Image")));
            this.New_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New_ToolStripButton.Name = "New_ToolStripButton";
            this.New_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.New_ToolStripButton.Text = "toolStripButton8";
            this.New_ToolStripButton.Click += new System.EventHandler(this.New_ToolStripButton_Click);
            // 
            // Open_ToolStripButton
            // 
            this.Open_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Open_ToolStripButton.Image")));
            this.Open_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open_ToolStripButton.Name = "Open_ToolStripButton";
            this.Open_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Open_ToolStripButton.Text = "toolStripButton9";
            this.Open_ToolStripButton.Click += new System.EventHandler(this.Open_ToolStripButton_Click);
            // 
            // Save_ToolStripButton
            // 
            this.Save_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Save_ToolStripButton.Image")));
            this.Save_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_ToolStripButton.Name = "Save_ToolStripButton";
            this.Save_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Save_ToolStripButton.Text = "toolStripButton1";
            this.Save_ToolStripButton.Click += new System.EventHandler(this.Save_ToolStripButton_Click);
            // 
            // Copy_ToolStripButton
            // 
            this.Copy_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Copy_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Copy_ToolStripButton.Image")));
            this.Copy_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copy_ToolStripButton.Name = "Copy_ToolStripButton";
            this.Copy_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Copy_ToolStripButton.Text = "toolStripButton3";
            this.Copy_ToolStripButton.Click += new System.EventHandler(this.Copy_ToolStripButton_Click);
            // 
            // Cut_ToolStripButton
            // 
            this.Cut_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cut_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Cut_ToolStripButton.Image")));
            this.Cut_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cut_ToolStripButton.Name = "Cut_ToolStripButton";
            this.Cut_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Cut_ToolStripButton.Text = "toolStripButton4";
            this.Cut_ToolStripButton.Click += new System.EventHandler(this.Cut_ToolStripButton_Click);
            // 
            // Paste_ToolStripButton
            // 
            this.Paste_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Paste_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Paste_ToolStripButton.Image")));
            this.Paste_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Paste_ToolStripButton.Name = "Paste_ToolStripButton";
            this.Paste_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Paste_ToolStripButton.Text = "toolStripButton5";
            this.Paste_ToolStripButton.Click += new System.EventHandler(this.Paste_ToolStripButton_Click);
            // 
            // Undo_ToolStripButton
            // 
            this.Undo_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Undo_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Undo_ToolStripButton.Image")));
            this.Undo_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Undo_ToolStripButton.Name = "Undo_ToolStripButton";
            this.Undo_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Undo_ToolStripButton.Text = "toolStripButton7";
            this.Undo_ToolStripButton.Click += new System.EventHandler(this.Undo_ToolStripButton_Click);
            // 
            // Redo_ToolStripButton
            // 
            this.Redo_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Redo_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Redo_ToolStripButton.Image")));
            this.Redo_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Redo_ToolStripButton.Name = "Redo_ToolStripButton";
            this.Redo_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Redo_ToolStripButton.Text = "toolStripButton6";
            this.Redo_ToolStripButton.Click += new System.EventHandler(this.Redo_ToolStripButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_New_MenuItem,
            this.File_Open_MenuItem,
            this.toolStripSeparator1,
            this.File_Save_MenuItem,
            this.toolStripSeparator2,
            this.File_Close_MenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // File_New_MenuItem
            // 
            this.File_New_MenuItem.Name = "File_New_MenuItem";
            this.File_New_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.File_New_MenuItem.Text = "New";
            this.File_New_MenuItem.Click += new System.EventHandler(this.File_New_MenuItem_Click);
            // 
            // File_Open_MenuItem
            // 
            this.File_Open_MenuItem.Name = "File_Open_MenuItem";
            this.File_Open_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.File_Open_MenuItem.Text = "Open";
            this.File_Open_MenuItem.Click += new System.EventHandler(this.File_Open_MenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // File_Save_MenuItem
            // 
            this.File_Save_MenuItem.Name = "File_Save_MenuItem";
            this.File_Save_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.File_Save_MenuItem.Text = "Save";
            this.File_Save_MenuItem.Click += new System.EventHandler(this.File_Save_MenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // File_Close_MenuItem
            // 
            this.File_Close_MenuItem.Name = "File_Close_MenuItem";
            this.File_Close_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.File_Close_MenuItem.Text = "Close";
            this.File_Close_MenuItem.Click += new System.EventHandler(this.File_Close_MenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit_Cut_MenuItem,
            this.Edit_Copy_MenuItem,
            this.Edit_Paste_MenuItem,
            this.toolStripSeparator3,
            this.Edit_Undo_MenuItem,
            this.Edit_Redo_MenuItem,
            this.File_Select_All_MenuItem,
            this.File_Clear_MenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // Edit_Cut_MenuItem
            // 
            this.Edit_Cut_MenuItem.Name = "Edit_Cut_MenuItem";
            this.Edit_Cut_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.Edit_Cut_MenuItem.Text = "Cut";
            this.Edit_Cut_MenuItem.Click += new System.EventHandler(this.Edit_Cut_MenuItem_Click);
            // 
            // Edit_Copy_MenuItem
            // 
            this.Edit_Copy_MenuItem.Name = "Edit_Copy_MenuItem";
            this.Edit_Copy_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.Edit_Copy_MenuItem.Text = "Copy";
            this.Edit_Copy_MenuItem.Click += new System.EventHandler(this.Edit_Copy_MenuItem_Click);
            // 
            // Edit_Paste_MenuItem
            // 
            this.Edit_Paste_MenuItem.Name = "Edit_Paste_MenuItem";
            this.Edit_Paste_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.Edit_Paste_MenuItem.Text = "Paste";
            this.Edit_Paste_MenuItem.Click += new System.EventHandler(this.Edit_Paste_MenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // Edit_Undo_MenuItem
            // 
            this.Edit_Undo_MenuItem.Name = "Edit_Undo_MenuItem";
            this.Edit_Undo_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.Edit_Undo_MenuItem.Text = "Undo";
            this.Edit_Undo_MenuItem.Click += new System.EventHandler(this.Edit_Undo_MenuItem_Click);
            // 
            // Edit_Redo_MenuItem
            // 
            this.Edit_Redo_MenuItem.Name = "Edit_Redo_MenuItem";
            this.Edit_Redo_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.Edit_Redo_MenuItem.Text = "Redo";
            this.Edit_Redo_MenuItem.Click += new System.EventHandler(this.Edit_Redo_MenuItem_Click);
            // 
            // File_Select_All_MenuItem
            // 
            this.File_Select_All_MenuItem.Name = "File_Select_All_MenuItem";
            this.File_Select_All_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.File_Select_All_MenuItem.Text = "Select All";
            this.File_Select_All_MenuItem.Click += new System.EventHandler(this.File_Select_All_MenuItem_Click);
            // 
            // File_Clear_MenuItem
            // 
            this.File_Clear_MenuItem.Name = "File_Clear_MenuItem";
            this.File_Clear_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.File_Clear_MenuItem.Text = "Clear";
            this.File_Clear_MenuItem.Click += new System.EventHandler(this.File_Clear_MenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.View_Font_MenuItem,
            this.toolStripSeparator4});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.formatToolStripMenuItem.Text = "View";
            // 
            // View_Font_MenuItem
            // 
            this.View_Font_MenuItem.Name = "View_Font_MenuItem";
            this.View_Font_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.View_Font_MenuItem.Text = "Font";
            this.View_Font_MenuItem.Click += new System.EventHandler(this.View_Font_MenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // myTabControlZ
            // 
            this.myTabControlZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTabControlZ.Location = new System.Drawing.Point(0, 49);
            this.myTabControlZ.Name = "myTabControlZ";
            this.myTabControlZ.SelectedIndex = 0;
            this.myTabControlZ.Size = new System.Drawing.Size(638, 340);
            this.myTabControlZ.TabIndex = 7;
            this.myTabControlZ.Tag = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(638, 389);
            this.Controls.Add(this.myTabControlZ);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Save_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Copy_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Cut_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Paste_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Undo_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Redo_ToolStripButton;
        private System.Windows.Forms.ToolStripButton New_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Open_ToolStripButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem File_New_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem File_Open_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem File_Save_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem File_Close_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit_Cut_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit_Copy_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit_Paste_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Edit_Undo_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit_Redo_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem View_Font_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TabControl myTabControlZ;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem File_Select_All_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem File_Clear_MenuItem;
    }
}

