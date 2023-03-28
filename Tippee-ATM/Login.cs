using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tippee_ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            PinCheck obj = new PinCheck();
            obj.Show();
            this.Hide();

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
