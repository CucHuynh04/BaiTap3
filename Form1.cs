using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            if (txtLastName.Text != "")
            {
                item = new ListViewItem(txtLastName.Text);  
                item.SubItems.Add(txtFirstName.Text); 
                item.SubItems.Add(txtPhone.Text);
                lvDanhSach.Items.Add(item);
                txtLastName.Text = "";
                txtFirstName.Text = "";
                txtPhone.Text = "";
                txtLastName.Focus();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lvDanhSach.SelectedItems.Count>0)
            {
                lvDanhSach.Items.Remove(lvDanhSach.SelectedItems[0]);
                //xoa du lieu
                txtLastName.Clear();
                txtFirstName.Clear();
                txtPhone.Clear();
            }
            else
            {
                MessageBox.Show("Vui long chon mot dong de xoa.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvDanhSach.SelectedItems[0];
                //Cap nhat
                selectedItem.SubItems[0].Text = txtLastName.Text;
                selectedItem.SubItems[1].Text = txtFirstName.Text;
                selectedItem.SubItems[2].Text = txtPhone.Text;
            }
            else
            {
                MessageBox.Show("Vui long chon mot dong de sua.");
            }
        }
    }
}
