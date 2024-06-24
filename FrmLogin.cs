using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Frmlogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            if (txtdn.Text == "Floppyduy" || (txtmk.Text == "duy"))
            {
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khấu Sai");
            }    
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
