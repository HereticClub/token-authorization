using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TokenAuthorization.JWT;

namespace JWTDemo
{
    public partial class frmMain : Form
    {
        JWTAuthentication jwt;


        public frmMain()
        {
            InitializeComponent();

            txtHeader.Dock = DockStyle.Fill;
            txtPayload.Dock = DockStyle.Fill;
            txtSecretKey.Dock = DockStyle.Fill;
            txtToken.Dock = DockStyle.Fill;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UserInfo user = new UserInfo();
            user.Id = Guid.Parse(txtId.Text);
            user.Email = txtEmail.Text;
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;

            jwt = new JWTAuthentication(txtSecretKey.Text);
            txtToken.Text = jwt.CreateToken(user, HSMODE.HS512);
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            UserInfo user;

            jwt = new JWTAuthentication(txtSecretKey.Text);
            user = jwt.ParseToken<UserInfo>(txtToken.Text);

            txtId.Text = user.Id.ToString();
            txtEmail.Text = user.Email;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;

            txtHeader.Text = jwt.HeaderJson;
            txtPayload.Text = jwt.PayloadJson;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            VALIDATIONSTATE state;

            jwt = new JWTAuthentication(txtSecretKey.Text);
            state = jwt.ValidationToken(txtToken.Text);

            txtHeader.Text = jwt.HeaderJson;
            txtPayload.Text = jwt.PayloadJson;

            lblValidateState.Text = string.Format("Validation State: {0}", state);
        }

        private void txtNewId_Click(object sender, EventArgs e)
        {
            txtId.Text = Guid.NewGuid().ToString();
        }
    }
}
