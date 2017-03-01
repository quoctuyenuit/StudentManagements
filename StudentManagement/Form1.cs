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



        private void btn_AddStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Done.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            foreach (Control ctrl in navigationFrameMain.Controls)
            {
                ctrl.Hide();
            }
            navigationPage_AddStudent.Show();
        }

        private void btn_AddClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Done.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            foreach (Control ctrl in navigationFrameMain.Controls)
            {
                ctrl.Hide();
            }
            navigationPage_Home.Show();
        }

        private void btn_Home_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Done.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            foreach (Control ctrl in navigationFrameMain.Controls)
            {
                ctrl.Hide();
            }
            navigationPage_Home.Show();
        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            btn_Done.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            foreach (Control ctrl in navigationFrameMain.Controls)
            {
                ctrl.Hide();
            }
            navigationPage_StudentList.Show();
        }

        private void btn_Class_Click(object sender, EventArgs e)
        {
            btn_Done.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            foreach (Control ctrl in navigationFrameMain.Controls)
            {
                ctrl.Hide();
            }
            navigationPage_ClassList.Show();
        }

       
        private void btn_LookStudentDetail_Click(object sender, EventArgs e)
        {
            btn_Done.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            foreach (Control ctrl in navigationFrameMain.Controls)
            {
                ctrl.Show();
            }
            navigationPage_DetailStudent.Show();
        }
        







    }
}
