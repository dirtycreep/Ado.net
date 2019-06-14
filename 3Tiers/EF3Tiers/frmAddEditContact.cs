using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BussinesLayer;
using DataLayer;

namespace EF3Tiers
{
    public partial class frmAddEditContact : Form
    {
        bool IsNew;
        public frmAddEditContact(Contact obj)
        {
            InitializeComponent();
            if(obj == null)
            {
                contactBindingSource.DataSource = new Contact();
                IsNew = true;
            }
            else
            {
                contactBindingSource.DataSource = obj;
                IsNew = false;
            }
        }

        private void frmAddEditContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                if(string.IsNullOrEmpty(txtContactName.Text))
                {
                    MessageBox.Show("{Please enter your contact name.", "Messeage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtContactName.Focus();
                    e.Cancel = true;
                    return;
                }
                if(IsNew)
                  ContactServices.Insert(contactBindingSource.Current as Contact);
                else
                  ContactServices.Update(contactBindingSource.Current as Contact);
            }
        }
    }
}
