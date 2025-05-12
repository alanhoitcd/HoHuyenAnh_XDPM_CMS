using CMS.BLL;
using CMS.GUI;
using CMS.UTIL;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CMS.VIEW
{
    public partial class frmLogin : Form
    {
        private static int countSaiPass = 0;
        private void btnLogin_Click_() //CODE CHO NÚT ĐĂNG NHẬP
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))//kiểm tra null
            {
                UTIL.UTIL.ShowMessage("notif_frmLogin_EnterUserAndPass", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                UsersBLL _usersBLL = new UsersBLL();
                if (_usersBLL.checkUser(txtUserName.Text))//kiểm tra id có trong database chưa
                {
                    try
                    {
                        if (_usersBLL.LoginUser(txtUserName.Text, txtPassword.Text))
                        {
                            UTIL.UTIL.ShowMessage("notif_frmLogin_LoginSuccessful", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            if (countSaiPass <= 2)
                            {
                                string frmLoginCap_WrongPassword = LanguageManager.GetString("notif_frmLogin_WrongPassword");
                                string frmLoginCap_CountTime = LanguageManager.GetString("notif_frmLogin_CountTime");
                                string notification = LanguageManager.GetString("notif_");
                                MessageBox.Show(frmLoginCap_WrongPassword + (countSaiPass + 1) + frmLoginCap_CountTime, notification, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                countSaiPass++;
                                txtPassword.ResetText();
                                if (countSaiPass == 3)
                                {
                                    txtPassword.Enabled = false;
                                    UTIL.UTIL.ShowMessage("notif_frmLogin_Closed", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.DialogResult = DialogResult.Cancel;
                                    Application.Exit();
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        UTIL.UTIL.ShowMessage("notif_frmLogin_Error" + ex.Message, "notif_", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtUserName.ResetText();
                    txtPassword.ResetText();
                    string notif_frmLogin_UserName = LanguageManager.GetString("notif_frmLogin_UserName");
                    string notif_frmLogin_NotFound = LanguageManager.GetString("notif_frmLogin_NotFound");
                    string notif_ = LanguageManager.GetString("notif_");
                    if (MessageBox.Show($"{notif_frmLogin_UserName} {txtUserName.Text.Trim()}{notif_frmLogin_NotFound}", notif_, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Hide();
                        frmCreateAccount frm = new frmCreateAccount();
                        frm.ShowDialog();
                    }
                }
            }
        }
        private void UpdateLanguage()// CẬP NHẬT NGÔN NGỮ CHO CÁC CONTROL
        {
            lblLogin.Text = LanguageManager.GetString("lblLogin");
            txtUserName.PlaceholderText = LanguageManager.GetString("txtUserName");
            txtPassword.PlaceholderText = LanguageManager.GetString("txtPassword");
            btnLogin.Text = LanguageManager.GetString("btnLogin");
            llblForgotPassword.Text = LanguageManager.GetString("llblForgotPassword");
            llblDontHaveAnAccount.Text = LanguageManager.GetString("llblDontHaveAnAccount");

        }
        void frmLogin_Load_()//HÀM CHO SỰ HIỆN FORM LOAD
        {
            UTIL.UTIL.fillImgToControl(btnClose, Properties.Resources.iconClose);//Thiết lập ảnh cho nút thoát
            UTIL.UTIL.fillImgToControl(ptbLogin, Properties.Resources.imgfrmLoginForm);//Thiết lập ảnh cho picturebox
            UTIL.UTIL.SetFormLanguage();
            UpdateLanguage();
            txtUserName.Text = "admin";
            txtPassword.Text = "admin";
        }
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            frmLogin_Load_();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void thongBao()
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin_Click_();
        }

        private void llblDontHaveAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateAccount f = new frmCreateAccount();
            f.ShowDialog();
        }
    }
}
