﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBox
{
    public partial class userControlClient2b : UserControl
    {
        OrderManager om;

        public userControlClient2b(OrderManager om)
        {
            this.om = om;
            InitializeComponent();
        }

        private void userControlClient2_Load(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (txtTel.Text.Equals("") || txtPassword.Text.Equals("") || txtName.Text.Equals("")
                || txtPasswordConf.Text.Equals("") || txtMail.Text.Equals(""))
            {
                MessageBox.Show("Veuillez remplir toutes les cases.", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtPasswordConf.Text)
            {
                MessageBox.Show("Les mots de passe ne corrspondent pas.", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (true /*can't login*/)
            {
                MessageBox.Show("֍ ERROR ֎",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*END*/
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new userControlClient(om));
        }

        private void txtIdentifier_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
