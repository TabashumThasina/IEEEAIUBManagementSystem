using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace demoproject
{
    class Database
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Neo\Documents\IEEEAIUBMANAGE.mdf;Integrated Security=True;Connect Timeout=30");
        public void insertMember(string query)//inserting 
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void delete(string query,string tablename,string col) //deleting
        {
            try
            {
                con.Open();
                string s = "delete from "+tablename+" where "+col+" = '" + query + "';";
                SqlCommand com = new SqlCommand(s, con);
                com.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public bool DetectPass(string id, string currentpass)   // detecting password currect 
        {

            con.Open();

            string s = " select Password from Member where AIUB_ID = '" + id + "'";
            SqlCommand com = new SqlCommand(s, con);

            try
            {
                string s1 = com.ExecuteScalar().ToString();
                //MessageBox.Show(s1);

                if (s1.TrimEnd().Equals(currentpass))
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return false;

        }
        public bool DetectAdmin(string id) // detecting admin
        {
            con.Open();
            string s = " select UserType from Member where AIUB_ID ='" + id + "';";
            SqlCommand com = new SqlCommand(s, con);

            try
            {
                string s1 = com.ExecuteScalar().ToString();
                //MessageBox.Show(s1);

                if (s1.TrimEnd().Equals("Admin"))
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }


            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return false;
        }
        public bool loginsearch(string s) // login search for user
        {

            SqlDataAdapter sdf = new SqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            sdf.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;


        }
        public void Admin(string AIUB_ID)
        {

        }
        public User User_View(string AIUB_ID, User u)// userprofile collecting information from database
        {
            try
            {
                // string s = "select FistName ,LastName , IEEE_ID , Dept , Gender , DOB,Password, Contact , MembershipType,Email from Member where AIUB_ID ='" +AIUB_ID + "';";
                string s1 = "select * from Member where AIUB_ID='" + AIUB_ID + "';";
                SqlCommand newCmd = new SqlCommand(s1, con);
                newCmd.Parameters.Add("@AIUB_ID", SqlDbType.Char).Value = AIUB_ID;
                con.Open();
                SqlDataReader rdr = newCmd.ExecuteReader();
                rdr.Read();
                u.FName = rdr.GetString(1);
                u.LName = rdr.GetString(2);
                u.IID = rdr.GetString(4);
                u.Department = rdr.GetString(5);
                u.gender = rdr.GetString(6);
                u.AID = rdr.GetString(3);
                u.Password = rdr.GetString(7);
                u.Contact = rdr.GetString(8);
                u.MemberType = rdr.GetString(9);
                u.Email = rdr.GetString(10);
                u.type = rdr.GetString(11);
                return u;
                // return rdr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return u;
            }


        }
        public User MemberApproval( User u,string AIUB_ID)
        {
            
           
            string s1 = "select * from MemberApproval where AIUB_ID='" + AIUB_ID + "';";
            SqlCommand newCmd = new SqlCommand(s1, con);
            newCmd.Parameters.Add("@AIUB_ID", SqlDbType.Char).Value = AIUB_ID;
            con.Open();
            SqlDataReader rdr = newCmd.ExecuteReader();
            rdr.Read();
            u.FName = rdr.GetString(1);
            u.LName = rdr.GetString(2);
            u.IID = rdr.GetString(4);
            u.Department = rdr.GetString(5);
            u.gender = rdr.GetString(6);
            u.AID = rdr.GetString(3);
            u.Password = rdr.GetString(8);
            u.Contact = rdr.GetString(9);
            u.MemberType = rdr.GetString(10);
            u.Email = rdr.GetString(11);
            u.type = rdr.GetString(12);
            con.Close();
            return u;
            
        }
        public void update(string query) //updating
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public DataGridView Eventview(DataGridView dataGridView1,string q) // gridview 
        {
            SqlCommand com = new SqlCommand(q, con);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = com;
            DataTable db = new DataTable();
            sda.Fill(db);
            BindingSource b = new BindingSource();
            b.DataSource = db;
            dataGridView1.DataSource = b;
            sda.Update(db);
            return dataGridView1;

        }
       
        public void Sort(string table,string q)
        {
            try
            {
                con.Open();
                string s = " SELECT * FROM   " + table + " ORDER BY " + q;
                SqlCommand com = new SqlCommand(s, con);
                com.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void addtopreevent(string q)
        {
            string s= "select EventTitle from UpcomingEvent where id = "+q;
            SqlCommand newCmd = new SqlCommand(s, con);
            con.Open();
            string s2 = newCmd.ExecuteScalar().ToString();
            con.Close();
            string s1= "insert into PreEvent1 ([EventTitle] ) values('"+s2+"');";
            con.Open();
            SqlCommand com = new SqlCommand(s1, con);
            com.ExecuteNonQuery();
            con.Close();
            delete(q,"UpcomingEvent","id");

        }
    }
}
