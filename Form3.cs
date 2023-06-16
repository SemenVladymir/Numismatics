using Numismatics.Connection;
using Numismatics.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numismatics
{
    public partial class Form3 : Form
    {
        public Users newUser;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<Users> users;
            using (MyContext context = new MyContext())
            {
                users = context.Users.ToList();
            }
            newUser = new Users(Name.Text, Email.Text, Login.Text, Password.Text);
            if (users.Any(ee => (ee.Login.Equals(Login.Text) && ee.Password.Equals(Password.Text))))
                MessageBox.Show("User with this login and password already exist!");
            else
            {
                using (MyContext context = new MyContext())
                {
                    context.Users.Add(newUser);
                    if (context.SaveChanges() > 0)
                        MessageBox.Show("You added to base! Input your data to registrationlines.");
                }
                Close();
            }
        }
    }
}
