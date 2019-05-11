using System;
using System.Diagnostics;
using System.Windows.Forms;
using WebsiteManager.DataEdit;
using WebsiteManager.Varibute;
namespace WebsiteManager
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private Array_Website websites;
        private string ProgramPath = Application.StartupPath + "/Website.txt";
        private void lst_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Main.SelectedIndex != -1)
            {
                Website website = websites.GetArray()[lst_Main.SelectedIndex];
                lab_Name.Text = website.Name;
                lab_URL.Text = website.URL;
                but_Open.Enabled = true;
                but_Delete.Enabled = true;
                but_Edit.Enabled = true;
            }
            else
            {
                lab_Name.Text = "";
                lab_URL.Text = "";
                but_Open.Enabled = false;
                but_Delete.Enabled = false;
                but_Edit.Enabled = false;
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            websites = DataLoad.WebsiteLoad(ProgramPath);
            foreach (Website website in websites.GetArray())
            {
                lst_Main.Items.Add(website.Name);
            }
        }

        private void but_Edit_Click(object sender, EventArgs e)
        {
            Website tem = websites.GetArray()[lst_Main.SelectedIndex];
            EditVaribute.name = tem.Name;
            EditVaribute.URL = tem.URL;
            frm_Edit frm_Edit = new frm_Edit();
            frm_Edit.Text = "编辑网页";
            frm_Edit.ShowDialog();
            tem.Name = EditVaribute.name;
            tem.URL = EditVaribute.URL;
            ReFresh();
        }

        private void but_Delete_Click(object sender, EventArgs e)
        {
            websites.Delete(lst_Main.SelectedIndex);
            ReFresh();

        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            EditVaribute.name = "";
            EditVaribute.URL = "";
            frm_Edit frm_Edit = new frm_Edit();
            frm_Edit.Text = "添加网页";
            frm_Edit.ShowDialog();
            websites.Add(new Website(EditVaribute.name, EditVaribute.URL));
            ReFresh();
        }

        private void but_Open_Click(object sender, EventArgs e)
        {
            Process.Start(websites.GetArray()[lst_Main.SelectedIndex].URL);
        }
        private void ReFresh()
        {
            lst_Main.Items.Clear();
            foreach (Website website in websites.GetArray())
            {
                lst_Main.Items.Add(website.Name);
            }
            DataSave.WebsiteSave(websites, ProgramPath);
            lst_Main_SelectedIndexChanged(null, null);
        }
    }
}
