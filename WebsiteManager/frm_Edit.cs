using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebsiteManager.Varibute;
namespace WebsiteManager
{
    public partial class frm_Edit : Form
    {
        public frm_Edit()
        {
            InitializeComponent();
        }

        private void but_Confirm_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_URL.Text != "")
            {
                EditVaribute.name = txt_Name.Text;
                EditVaribute.URL = txt_URL.Text;
                Dispose();
            }
            else
            {
                MessageBox.Show("请输入正确的名称与网址");
            }
        }

        private void frm_Edit_Load(object sender, EventArgs e)
        {
            txt_Name.Text = EditVaribute.name;
            txt_URL.Text = EditVaribute.URL;
        }
    }
}
