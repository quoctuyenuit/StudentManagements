using DevExpress.DXCore.Controls.LookAndFeel;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public Form1()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "DevExpress Style";
            btn_Done.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // navigationPage_Home.Show();
        }

        private void showFrame(Control navigationPage)
        {
            foreach (Control ctrl in navigationFrame_Main.Controls)
            {
                ctrl.Hide();
            }
            navigationPage.Show();
        }

        private void btn_Home_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showFrame(navigationPage_Home);
        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            showFrame(navigationPage_StudentList);
        }

        private void btn_Class_Click(object sender, EventArgs e)
        {
            showFrame(navigationPage_ClassList);
        }

        private void btn_ScoreBoard_Click(object sender, EventArgs e)
        {
            showFrame(navigationPage_ScoreBoardDetail);
        }

        private void btn_AddStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showFrame(navigationPage_AddStudent);
        }

        private void btn_AddClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showFrame(navigationPage_AddClass);
        }

        private void btn_CreateReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showFrame(navigationPage_CreateReport);
        }

        private void btn_ChangeRules_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showFrame(navigationPage_ChangeRules);
        }

        private void btn_FindStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showFrame(navigationPage_FindStudent);
        }

        private void btn_Edit_StudentDetail_Click(object sender, EventArgs e)
        {
            navigationPage_DetailStudent.Hide();
            navigationPage_DetailStudent_Edit.Show();
        }

        private void btn_DetailStudent_Click(object sender, EventArgs e)
        {
            showFrame(navigationPage_StudentDetail);
        }

        private void btn_Edit_DetailClass_Click(object sender, EventArgs e)
        {
            btn_Edit_DetailClass.Hide();
            btn_Apply_DetailClass.Show();
        }

        private void btn_Apply_DetailClass_Click(object sender, EventArgs e)
        {
            btn_Apply_DetailClass.Hide();
            btn_Edit_DetailClass.Show();
        }



    }
}
