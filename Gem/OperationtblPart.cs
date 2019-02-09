using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Gem
{
    public class OperationtblPart
    {
        SqlConnection cn;
        public OperationtblPart()
        {
            cn = new SqlConnection(Classmain.x);
        }

        public DataTable namayesh3(string fs,string ts ,string ws)
        {
            // try
            {
                string ns = "";

                ns = "select " + fs + " from " + ts + " where " + ws;
                
                //combobox-serail
                SqlCommand cmd = new SqlCommand(ns, cn);

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                return dt;
            }
        }
        public DataTable namayesh2(string t,int group=0)
        {
         // try
            {
                string ns = "";
                if (group == 0)
                {
                    ns = "select * from " + t;
                }
                else
                {
                   ns= "select * from " + t + "  where code_group='" + group + "'";
                }
                   //combobox-serail
                SqlCommand cmd = new SqlCommand(ns, cn);

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                return dt;
            }
            {
                //   return null;
            }

        }
         public DataTable redt(string t)
         {
             // try
             {
                
                
                 //combobox-serail
                 SqlCommand cmd = new SqlCommand(t, cn);

                 SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cn);
                 DataTable dt = new DataTable();
                 da.Fill(dt);

                 cn.Open();
                 cmd.ExecuteNonQuery();
                 cn.Close();

                 return dt;
             }
             {
                 //   return null;
             }

         }
        public DataTable namayesh(string field,string table)
        {
         // try
            {
                string ns = "select "+field+" from "+table; 
              //combobox-serail
                SqlCommand cmd = new SqlCommand(ns, cn);

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                return dt;
            }
         //  catch
            {
           //   return null;
            }

        }
        public DataTable namayesh(string field, string table,int group)
        {
            // try
            {
                string ns = "select " + field + " from " + table + "  where code_group='" + group + "'"; 
                //combobox-serail
                SqlCommand cmd = new SqlCommand(ns, cn);

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                return dt;
            }
            //  catch
            {
                //   return null;
            }

        }


        public DataTable Searchuser(string name,string pass)
        {

            SqlCommand cmd = new SqlCommand("SELECT id,name,lname FROM users WHERE username='" + name + "' AND password='" + pass + "'", cn);

            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            return dt;

        }
        public DataTable Searchweek(string table, int code)
        {

            SqlCommand cmd = new SqlCommand("select c0,c1,c2,c3,c4,c5,c6 from " + table + " where id=" + code , cn);

            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            return dt;

        }
        public DataTable Search(string str,string table,string field)
        {

            SqlCommand cmd = new SqlCommand("select * from " + table + " where " + field + " like N'%" + str + "%' ORDER BY id DESC;", cn);

            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            return dt;

        }
        public DataTable sum(string str, string table, string field)
        {

            SqlCommand cmd = new SqlCommand("select count(id) as [all],max(date_first) as [maxdate] from " + table + " where " + field + " = " + str, cn);

            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            return dt;

        }
        public DataTable endentery(string str, string table, string field)
        {

            SqlCommand cmd = new SqlCommand("select max(date_first)  from " + table + " where " + field + " = " + str, cn);

            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            return dt;

        }
        public DataTable Search(string code)
        {

            SqlCommand cmd = new SqlCommand("select * from Customer where id='" + code + "'", cn);

            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            return dt;

        }
       

        public void ins(string ta, string[] na, string[] la, byte[] imge=null)
        {
       //   try
            {

                string s1 = "";
                string s2 = "";
                int j = 0, k = 0;
                string[] s3 = new string[50];
                foreach (string i in la) { s1 += i + ","; } s1 += "code_user,date_re";// s1 = s1.Remove(s1.Length - 1);
                foreach (string i in la) { s2 += "@" + i + ","; s3[j] = "@" + i; j++; }  s2 += "@user_id,@date_re";// s2 = s2.Remove(s2.Length - 1);
                string query = "insert into " + ta + "(" + s1 + ") values(" + s2 + ")"+" SELECT SCOPE_IDENTITY()";//@PersonName,@PersonImage)";
                SqlCommand cmd = new SqlCommand(query, cn);
                foreach (string i in na)
                {

                    cmd.Parameters.AddWithValue(s3[k], i); k++;
                }
              cmd.Parameters.AddWithValue("@user_id", Classmain.user_id); k++;
              cmd.Parameters.AddWithValue("@date_re", Classmain.date_re); k++;
                if (imge != null) { cmd.Parameters.AddWithValue("@image", imge); k++; }
                cn.Open();
               cmd.ExecuteNonQuery();
               
               
                cn.Close();
            }
   //      catch {
      //      MessageBox.Show("اطلاعات ثبت نشد");
        //  cn.Close();
     //  }
        }
        public int ins2(string ta, string[] na, string[] la, byte[] imge = null)
        {
            //   try
            {

                string s1 = "";
                string s2 = "";
                int j = 0, k = 0;
                string[] s3 = new string[50];
                foreach (string i in la) { s1 += i + ","; } s1 += "code_user,date_re";// s1 = s1.Remove(s1.Length - 1);
                foreach (string i in la) { s2 += "@" + i + ","; s3[j] = "@" + i; j++; } s2 += "@user_id,@date_re";// s2 = s2.Remove(s2.Length - 1);
                string query = "insert into " + ta + "(" + s1 + ") values(" + s2 + ")" + " SELECT SCOPE_IDENTITY()";//@PersonName,@PersonImage)";
                SqlCommand cmd = new SqlCommand(query, cn);
                foreach (string i in na)
                {

                    cmd.Parameters.AddWithValue(s3[k], i); k++;
                }
                cmd.Parameters.AddWithValue("@user_id", Classmain.user_id); k++;
                cmd.Parameters.AddWithValue("@date_re", Classmain.date_re); k++;
                if (imge != null) { cmd.Parameters.AddWithValue("@image", imge); k++; }
                cn.Open();
                // cmd.ExecuteNonQuery();
                int modified = Convert.ToInt32(cmd.ExecuteScalar());
                if (cn.State == System.Data.ConnectionState.Open) cn.Close();
                return modified;
                //cn.Close();
            }
            //      catch {
            //      MessageBox.Show("اطلاعات ثبت نشد");
            //  cn.Close();
            //  }
        }
        public void del(string ta,string a)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("Delete from " + ta + " where id='" + a + "'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch
            {
                MessageBox.Show("این داده را نمی توانید حذف کنید");
                cn.Close();

            }

        }

        public void up(string ta, string[] na, string[] la, byte[] imge = null)
        {
          //  try
            {
                string s1 = "";
                for (int i = 1; i < la.Length; i++) { s1 += la[i] + "=N'" + na[i] + "',"; } s1 = s1.Remove(s1.Length - 1);
              //  if (imge != null) s1 = s1 + "," + "@image ";
               string quary="update " + ta + " set " + s1 + " where id=@id";
               SqlCommand cmd = new SqlCommand(quary, cn);
              //  cmd.Parameters.AddWithValue("@image", imge);
                cmd.Parameters.AddWithValue("@id", na[0]);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
         //  catch {
          //    MessageBox.Show("داده های ویرایش نامعتبر می باشد");
          //    cn.Close();
          //  
         //  }
        }
        public void up2(string ta, string[] na, string[] la, byte[] imge = null)
        {
            //  try
            {
                string s1 = "";
                for (int i = 1; i < la.Length; i++) { s1 += la[i] + "=N'" + na[i] + "',"; } s1 = s1.Remove(s1.Length - 1);
                //  if (imge != null) s1 = s1 + "," + "@image ";
                string quary = "update " + ta + " set " + s1 + " where "+la[0]+"=@id";
                SqlCommand cmd = new SqlCommand(quary, cn);
                //  cmd.Parameters.AddWithValue("@image", imge);
                cmd.Parameters.AddWithValue("@id", na[0]);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            //  catch {
            //    MessageBox.Show("داده های ویرایش نامعتبر می باشد");
            //    cn.Close();
            //  
            //  }
        }
        public DataTable getif(string ta)
        {

            SqlCommand cmd = new SqlCommand("select max(id) from "+ta, cn);

            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            return dt;

        }
    }
}
