using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL;
using BLL;


namespace WebApplication1.Admin
{
    public partial class WorkShop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetWorkShops();
        }

        private void GetWorkShops()
        {
            WorkShopBusiness WB = new WorkShopBusiness();
            List<tbl_WorkShop> Ls = WB.GetWorkShops();
            gridviewWorkShop.DataSource = Ls;
            gridviewWorkShop.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            tbl_WorkShop Wp = new tbl_WorkShop();
            Wp.WorkShopTitle = txtWorkShopTitle.Text;
            Wp.WorkShopDate =DateTime.Parse(txtWorkShopDate.Text);
            Wp.WorkShopDuration =txtWorkShopDuration.Text;
            Wp.WorkShopTopics = txtWorkShopTopics.Text;
            WorkShopBusiness Wb = new WorkShopBusiness();
            Wb.InsertWorkShop(Wp);
            GetWorkShops();



        }

        protected void gridviewWorkShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(gridviewWorkShop.SelectedValue.ToString());
            WorkShopBusiness WB = new WorkShopBusiness();
            tbl_WorkShop Wp = WB.GetWorkShopById(id);
            txtWorkShopTitle.Text = Wp.WorkShopTitle;
            txtWorkShopDuration.Text = Wp.WorkShopDuration;
            txtWorkShopDate.Text= Wp.WorkShopDate.ToString();
            txtWorkShopTopics.Text = Wp.WorkShopTopics;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            WorkShopBusiness Wb = new WorkShopBusiness();
            int id = int.Parse(gridviewWorkShop.SelectedValue.ToString());
            Wb.DeleteWorkShopById(id);
            GetWorkShops();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            tbl_WorkShop Wp = new tbl_WorkShop();
            Wp.WorkShopTitle = txtWorkShopTitle.Text;
            Wp.WorkShopDate = DateTime.Parse(txtWorkShopDate.Text);
            Wp.WorkShopDuration = txtWorkShopDuration.Text;
            Wp.WorkShopTopics = txtWorkShopTopics.Text;
            WorkShopBusiness Wb = new WorkShopBusiness();
            int id = int.Parse(gridviewWorkShop.SelectedValue.ToString());
            Wb.UpdateWorkShopById(Wp, id);
            GetWorkShops();


        }
    }
}