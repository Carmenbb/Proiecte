using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adaugare(string nume, string numar, string mail )
        {
            string[] randuri = { nume, numar, mail };
            ListViewItem item = new ListViewItem(randuri);
            lv1.Items.Add(item);

        }
        private void modifica()
        {
            lv1.SelectedItems[0].SubItems[0].Text = numetbx.Text;
            lv1.SelectedItems[0].SubItems[1].Text = numartbx.Text;
            lv1.SelectedItems[0].SubItems[2].Text = mailtbx.Text;

            numetbx.Text = "";
            numartbx.Text = "";
            mailtbx.Text = "";
        }
        private void modificarebtn_Click(object sender, EventArgs e)
        {
            modifica();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            adaugare(numetbx.Text, numartbx.Text, mailtbx.Text);
            numetbx.Text = "";
            numartbx.Text = "";
            mailtbx.Text = "";
        }

        private void Stergerebtn_Click(object sender, EventArgs e)
        {
            lv1.Items.RemoveAt(lv1.SelectedIndices[0]);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lv1_MouseClick(object sender, MouseEventArgs e)
        {
            numetbx.Text = lv1.SelectedItems[0].SubItems[0].Text;
            numartbx.Text = lv1.SelectedItems[0].SubItems[1].Text;
            mailtbx.Text = lv1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
