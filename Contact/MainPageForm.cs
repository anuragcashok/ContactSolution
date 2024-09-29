﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact
{
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
        }

        private SumCalcForm frmSumCalc = new SumCalcForm();
        private SquareCalcForm frmSquareCalc = new SquareCalcForm();
        private SalaryPage frmSalary = new SalaryPage();
        private ContactList frmContactList = new ContactList();
        private NewContact frmNewContact = new NewContact();

        private void mnuSumCalc_Click(object sender, EventArgs e)
        {
            frmSumCalc.MdiParent = this;
            frmSumCalc.Show();
            frmSumCalc.Activate();
        }

        private void mnuSquareCalc_Click(object sender, EventArgs e)
        {
            frmSquareCalc.MdiParent = this;
            frmSquareCalc.Show();
            frmSquareCalc.Activate();

        }

        private void mnuSalary_Click(object sender, EventArgs e)
        {
            frmSalary.MdiParent = this;
            frmSalary.Show();
            frmSalary.Activate();

        }

        private void mnuContactList_Click(object sender, EventArgs e)
        {
            frmContactList.MdiParent = this;
            frmContactList.Show();
            frmContactList.Activate();
        }

        private void mnuNewContact_Click(object sender, EventArgs e)
        {
            frmNewContact.MdiParent = this;
            frmNewContact.Show();
            frmNewContact.Activate();
            
        }
    }
}
