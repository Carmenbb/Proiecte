namespace Agenda
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
            this.lv1 = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Numar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Addbtn = new System.Windows.Forms.Button();
            this.Stergerebtn = new System.Windows.Forms.Button();
            this.modificarebtn = new System.Windows.Forms.Button();
            this.numetbx = new System.Windows.Forms.TextBox();
            this.numartbx = new System.Windows.Forms.TextBox();
            this.mailtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Numar,
            this.Mail});
            this.lv1.FullRowSelect = true;
            this.lv1.GridLines = true;
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(23, 12);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(337, 343);
            this.lv1.TabIndex = 0;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            this.lv1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv1_MouseClick);
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 106;
            // 
            // Numar
            // 
            this.Numar.Text = "Numar";
            this.Numar.Width = 119;
            // 
            // Mail
            // 
            this.Mail.Text = "Mail";
            this.Mail.Width = 131;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(521, 166);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(70, 25);
            this.Addbtn.TabIndex = 1;
            this.Addbtn.Text = "Adaugare";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Stergerebtn
            // 
            this.Stergerebtn.Location = new System.Drawing.Point(41, 387);
            this.Stergerebtn.Name = "Stergerebtn";
            this.Stergerebtn.Size = new System.Drawing.Size(75, 23);
            this.Stergerebtn.TabIndex = 2;
            this.Stergerebtn.Text = "Stergere";
            this.Stergerebtn.UseVisualStyleBackColor = true;
            this.Stergerebtn.Click += new System.EventHandler(this.Stergerebtn_Click);
            // 
            // modificarebtn
            // 
            this.modificarebtn.Location = new System.Drawing.Point(211, 387);
            this.modificarebtn.Name = "modificarebtn";
            this.modificarebtn.Size = new System.Drawing.Size(75, 23);
            this.modificarebtn.TabIndex = 3;
            this.modificarebtn.Text = "Modificare";
            this.modificarebtn.UseVisualStyleBackColor = true;
            this.modificarebtn.Click += new System.EventHandler(this.modificarebtn_Click);
            // 
            // numetbx
            // 
            this.numetbx.Location = new System.Drawing.Point(463, 57);
            this.numetbx.Name = "numetbx";
            this.numetbx.Size = new System.Drawing.Size(218, 20);
            this.numetbx.TabIndex = 4;
            // 
            // numartbx
            // 
            this.numartbx.Location = new System.Drawing.Point(463, 90);
            this.numartbx.Name = "numartbx";
            this.numartbx.Size = new System.Drawing.Size(218, 20);
            this.numartbx.TabIndex = 5;
            // 
            // mailtbx
            // 
            this.mailtbx.Location = new System.Drawing.Point(463, 123);
            this.mailtbx.Name = "mailtbx";
            this.mailtbx.Size = new System.Drawing.Size(218, 20);
            this.mailtbx.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adresa de mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Numar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mailtbx);
            this.Controls.Add(this.numartbx);
            this.Controls.Add(this.numetbx);
            this.Controls.Add(this.modificarebtn);
            this.Controls.Add(this.Stergerebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.lv1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Numar;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Stergerebtn;
        private System.Windows.Forms.Button modificarebtn;
        private System.Windows.Forms.TextBox numetbx;
        private System.Windows.Forms.TextBox numartbx;
        private System.Windows.Forms.TextBox mailtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

