using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbUser.Text.Trim() == null || tbPassword.Text.Trim() == null)
            {
                MetroMessageBox.Show(this,"No se pueden dejar espacios en blanco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
