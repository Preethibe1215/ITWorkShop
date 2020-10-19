using BOL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class WorkShopDb
    {
        string conStr = "Server=localhost\\SQLEXPRESS;Database=ITWorkShop;Trusted_Connection = True";

        public bool InsertWorkShop(tbl_WorkShop Wp)
        {
            try
            {
                string cmdStr = "insert into tbl_WorkShop values(@WorkShopTitle,@WorkShopDate,@WorkShopDuration,@WorkShopTopics)";

                SqlConnection con = new SqlConnection(conStr);


                using (SqlCommand cmd = new SqlCommand(cmdStr, con))
                {
                    cmd.Parameters.AddWithValue("@WorkShopTitle", Wp.WorkShopTitle);
                    cmd.Parameters.AddWithValue("@WorkShopDate", Wp.WorkShopDate);
                    cmd.Parameters.AddWithValue("@WorkShopDuration", Wp.WorkShopDuration);
                    cmd.Parameters.AddWithValue("@WorkShopTopics", Wp.WorkShopTopics);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                return true;
            }


            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<tbl_WorkShop> GetWorkShops()
        {
            List<tbl_WorkShop> Ls;
            Ls = new List<tbl_WorkShop>();
            string cmdStrDr = "select * from tbl_WorkShop";

            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmdDr = new SqlCommand(cmdStrDr, con);
            con.Open();
            SqlDataReader dr = cmdDr.ExecuteReader();
            while (dr.Read())
            {
                tbl_WorkShop Wp = new tbl_WorkShop();
                Wp.WorkShopId = int.Parse(dr["WorkShopid"].ToString());
                Wp.WorkShopTitle = dr["WorkShopTitle"].ToString();
                Wp.WorkShopDate = DateTime.Parse(dr["WorkShopDate"].ToString());
                Wp.WorkShopDuration = dr["WorkShopDuration"].ToString();
                Wp.WorkShopTopics = dr["WorkShopTopics"].ToString();

                Ls.Add(Wp);
            }
            dr.Close();
            con.Close();
            return Ls;
        }

        public tbl_WorkShop GetWorkShopById(int WorkShopId)
        {
            tbl_WorkShop Wp = null;
            string cmdStr = "select * from tbl_WorkShop where WorkShopid=@WorkShopid";

            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(cmdStr, con);

            cmd.Parameters.AddWithValue("@WorkShopid", WorkShopId);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Wp = new tbl_WorkShop();
                Wp.WorkShopId = int.Parse(dr["WorkShopid"].ToString());
                Wp.WorkShopTitle = dr["WorkShopTitle"].ToString();
                Wp.WorkShopDate = DateTime.Parse(dr["WorkShopDate"].ToString());
                Wp.WorkShopDuration = dr["WorkShopDuration"].ToString();
                Wp.WorkShopTopics = dr["WorkShopTopics"].ToString();


            }
            dr.Close();
            con.Close();
            return Wp;
        }
        public bool UpdateWorkShopById(tbl_WorkShop Wp,int WorkShopId)

        {
            try
            {
                string cmdStr = @"Update tbl_WorkShop
                             Set WorkShopTitle=@WorkShopTitle, WorkShopDuration=@WorkShopDuration,WorkShopDate=@WorkShopDate,
WorkShopTopics=@WorkShopTopics where WorkShopId=@WorkShopid";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(cmdStr, con);
                cmd.Parameters.AddWithValue("@WorkShopTitle", Wp.WorkShopTitle);
                cmd.Parameters.AddWithValue("@WorkShopDate", Wp.WorkShopDate);
                cmd.Parameters.AddWithValue("@WorkShopDuration", Wp.WorkShopDuration);
                cmd.Parameters.AddWithValue("@WorkShopTopics", Wp.WorkShopTopics);
                cmd.Parameters.AddWithValue("@WorkShopid", WorkShopId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool DeleteWorkShopById(int WorkShopId)

        {
            try
            {

                string cmdStr = @"Delete from tbl_WorkShop where WorkShopId=@WorkShopid";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(cmdStr, con);
                cmd.Parameters.AddWithValue("@WorkShopid", WorkShopId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
           catch
            {
                return false;
            }


        }
    }
}

