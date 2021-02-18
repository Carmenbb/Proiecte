using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepadd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int i = 1;
        private RichTextBox GetRichTextBox()
        {
            RichTextBox r = null;
            TabPage p = myTabControlZ.SelectedTab;
            if(p!=null)
            {
                r = p.Controls[0] as RichTextBox;
            }
            return r;
        }
        

        private void File_New_MenuItem_Click(object sender, EventArgs e)
        {
            TabPage p = new TabPage("Untitled" + i);
            i++;
            myTabControlZ.Controls.Add(p);
            //adaugare RichTextBox
            RichTextBox r = new RichTextBox();
            r.Dock = DockStyle.Fill;//ca textbox-ul sa aiva aceleasi dimensiuni precum tab-ul
            r.Name = "tbx"+i; 

            p.Controls.Add(r);

        }
        private void New_ToolStripButton_Click(object sender, EventArgs e)
        {
            TabPage p = new TabPage("Untitled" + i);
            i++;
            myTabControlZ.Controls.Add(p);
            //adaugare RichTextBox
            RichTextBox r = new RichTextBox();
            r.Dock = DockStyle.Fill;//ca textbox-ul sa aiva aceleasi dimensiuni precum tab-ul
            r.Name = "tbx" + i;

            p.Controls.Add(r);
        }
        //CUT

        private void Edit_Cut_MenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Cut();

        }
        //BUTONUL CUT
        private void Cut_ToolStripButton_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Cut();
        }
        //COPY
        private void Edit_Copy_MenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Copy();
        }
        //BUTONUL COPY
        private void Copy_ToolStripButton_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Copy();
        }
        //PASTE
        private void Edit_Paste_MenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Paste();

        }
        //BUTONUL PASTE
        private void Paste_ToolStripButton_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Paste();
        }

        //OPEN
        private void File_Open_MenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            openFileDialog1 = new OpenFileDialog();
            if(openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                if((myStream=openFileDialog1.OpenFile())!=null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext= File.ReadAllText(strfilename);
                    GetRichTextBox().Text = filetext;
                    myTabControlZ.SelectedTab.Text = Path.GetFileName(openFileDialog1.FileName);
                }
            }
        }
        //BUTONUL OPEN
        private void Open_ToolStripButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    GetRichTextBox().Text = filetext;
                    myTabControlZ.SelectedTab.Text = Path.GetFileName(openFileDialog1.FileName);
                }
            }

        }
        //SAVE
        private void File_Save_MenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(GetRichTextBox().Text);
                    myTabControlZ.SelectedTab.Text = Path.GetFileName(saveFileDialog1.FileName);
                }
            }

        }
        //BUTONUL SAVE
        private void Save_ToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(GetRichTextBox().Text);
                    myTabControlZ.SelectedTab.Text = Path.GetFileName(saveFileDialog1.FileName);
                }
            }
        }


        //CLOSE
        private void File_Close_MenuItem_Click(object sender, EventArgs e)
        {
            TabPage current_tab = myTabControlZ.SelectedTab;
            myTabControlZ.TabPages.Remove(current_tab);
        }
        //UNDO
        private void Edit_Undo_MenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Undo();
        }
        //BUTONUL UNDO
        private void Undo_ToolStripButton_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Undo();
        }
       // REDO
        private void Edit_Redo_MenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Redo();
        }
        //BUTONUL REDO
        private void Redo_ToolStripButton_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Redo();
        }
        //SELECT ALL
        private void File_Select_All_MenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().SelectAll();
        }
        //CLEAR
        private void File_Clear_MenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Clear();

        }
        //FONT
        private void View_Font_MenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.ShowColor = true;
            if(fontDialog1.ShowDialog()==DialogResult.OK && !String.IsNullOrEmpty(GetRichTextBox().Text))
            {
                GetRichTextBox().SelectionFont = fontDialog1.Font;
                GetRichTextBox().SelectionColor = fontDialog1.Color;
            }
        }

        
    }
}
