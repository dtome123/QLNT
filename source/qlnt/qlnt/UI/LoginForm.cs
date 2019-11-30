using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlnt.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            lblUsernameError.Visible = false;
            lblPasswordError.Visible = false;
        }

        private void fbtnLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
