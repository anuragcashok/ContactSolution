using System;
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
    public partial class NewContact : Form
    {
        public NewContact()
        {
            InitializeComponent();
        }

        private void NewContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void NewContact_Load(object sender, EventArgs e)
        {

        }
    }
}
