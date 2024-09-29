using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        PeacockForm peacockForm = new PeacockForm();
        CrowForm crowForm = new CrowForm();
        DuckForm duckForm = new DuckForm();
        private void mnuPeacock_Click(object sender, EventArgs e)
        {
            peacockForm.MdiParent = this;
            peacockForm.Show();
            peacockForm.Activate();
        }

        private void mnuDuck_Click(object sender, EventArgs e)
        {
            duckForm.MdiParent = this;    
            duckForm.Show();
            duckForm.Activate();
        }

        private void mnuCrow_Click(object sender, EventArgs e)
        {
            crowForm.MdiParent = this;
            crowForm.Show();
            crowForm.Activate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
