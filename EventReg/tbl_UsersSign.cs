using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReg
{
    class tbl_UsersSign
    {
        public string Name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string Phone { get; set; }
        public string DateOfBirth { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString; 

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select * from tbl_UsersSign where email=@email";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

     

        public bool Insert (tbl_UsersSign u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "Insert into  tbl_UsersSign (Name, email, password, Phone, DateOfBirth) values(@Name, @email, @password, @Phone, @DateOfBirth)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", u.Name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@Phone", u.Phone);
                cmd.Parameters.AddWithValue("@DateOfBirth", u.DateOfBirth);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

      

    }

    class tbl_Events
    {
        public string EventName { get; set; }
        public string DateandTime { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
       

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        public bool Insert(tbl_Events a)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "Insert into  tbl_Events (EventName, DateandTime, Location , Description) values(@EventName, @DateandTime, @Location , @Description)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EventName", a.EventName);
                cmd.Parameters.AddWithValue("@DateandTime", a.DateandTime);
                cmd.Parameters.AddWithValue("@Location", a.Location);
                cmd.Parameters.AddWithValue("@Description", a.Description);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
     }

    class tbl_Halls
    {
        public string HallName { get; set; }
        public string Capacity { get; set; }
        public string Location { get; set; }
        public string DateOfEvent { get; set; }
        public object EventID { get;  set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        public bool Insert(tbl_Halls h)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "Insert into  tbl_Halls (EventID, HallName, Capacity, Location , DateOfEvent) values(@EventID, @HallName, @Capacity, @Location , @DateOfEvent)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EventID", h.EventID);
                cmd.Parameters.AddWithValue("@HallName", h.HallName);
                cmd.Parameters.AddWithValue("@Capacity", h.Capacity);
                cmd.Parameters.AddWithValue("@Location", h.Location);
                cmd.Parameters.AddWithValue("@DateOfEvent", h.DateOfEvent);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }

    class tbl_FAQS
    {
        public string ThingsToBring { get; set; }
        public string Prerequisites { get; set; }
        public string FacilitiesAvailable { get; set; }
        public string DressCode { get; set; }
        public string EventID { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public bool Insert(tbl_FAQS f)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "Insert into  tbl_FAQS (EventID, ThingsToBring, Prerequisites, FacilitiesAvailable , DressCode) values(@EventID, @ThingsToBring, @Prerequisites, @FacilitiesAvailable , @DressCode)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EventID", f.EventID);
                cmd.Parameters.AddWithValue("@ThingsToBring", f.ThingsToBring);
                cmd.Parameters.AddWithValue("@Prerequisites", f.Prerequisites);
                cmd.Parameters.AddWithValue("@FacilitiesAvailable", f.FacilitiesAvailable);
                cmd.Parameters.AddWithValue("@DressCode", f.DressCode);
                
          
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                isSuccess = true;
            }
            else
            {
                isSuccess = false;
            }

        }
        catch (Exception ex)
        {

        }
        finally
        {
            conn.Close();
        }
        return isSuccess;
    }
}

    class tbl_Volunteers
    {
        public string ThingsToBring { get; set; }
        public string ReportAt { get; set; }
        public string ReportTo { get; set; }
        public string DressCode { get; set; }
        public string EventID { get; set; }
        public string ReportingDateAndTime { get; set; }
        
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public bool Insert(tbl_Volunteers v)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "Insert into  tbl_Volunteers (EventID, ThingsToBring, ReportAt, ReportTo , DressCode, ReportingDateAndTime) values(@EventID, @ThingsToBring, @ReportAt, @ReportTo , @DressCode, @ReportingDateAndTime)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EventID", v.EventID);
                cmd.Parameters.AddWithValue("@ReportAt", v.ReportAt);
                cmd.Parameters.AddWithValue("@ReportTo", v.ReportTo);
                cmd.Parameters.AddWithValue("@ReportingDateAndTime", v.ReportingDateAndTime);
                cmd.Parameters.AddWithValue("@ThingsToBring", v.ThingsToBring);
                cmd.Parameters.AddWithValue("@DressCode", v.DressCode);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }


    class tbl_Reg
    {
       
        public string EventID { get; set; }
        public string Food { get; set; }
        public string Shuttle { get; set; }
        public string Accomidation { get; set; }
        public string TypeOfReg { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public bool Insert(tbl_Reg r)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "Insert into  tbl_Reg (EventID, Food, Shuttle , Accomidation,TypeOfReg) values( @EventID, @Food, @Shuttle , @Accomidation, @TypeOfReg)";
                SqlCommand cmd = new SqlCommand(sql, conn);
               
                cmd.Parameters.AddWithValue("@EventID", r.EventID);
                cmd.Parameters.AddWithValue("@Food", r.Food);
                cmd.Parameters.AddWithValue("@Shuttle", r.Shuttle);
                cmd.Parameters.AddWithValue("@Accomidation", r.Accomidation);
                cmd.Parameters.AddWithValue("@TypeOfReg", r.TypeOfReg);


                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }


    class tbl_Accomidation
    {

        public string Name { get; set; }
        public string RoomNo { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public bool Insert(tbl_Accomidation r)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "Insert into  tbl_Accomidation (Name, RoomNo, Date , Location) values( @Name, @RoomNo, @Date , @Location)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Name", r.Name);
                cmd.Parameters.AddWithValue("@RoomNo", r.RoomNo);
                cmd.Parameters.AddWithValue("@Date", r.Date);
                cmd.Parameters.AddWithValue("@Location", r.Location);
               


                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }



    class tbl_Messenger
    {

        public string SenderName { get; set; }
        public string EventID { get; set; }
        public string Message { get; set; }
      
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public bool Insert(tbl_Messenger r)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "Insert into  tbl_Messenger (SenderName, EventID, Message) values( @SenderName, @EventID, @Message)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@SenderName", r.SenderName);
                cmd.Parameters.AddWithValue("@EventID", r.EventID);
                cmd.Parameters.AddWithValue("@Message", r.Message);
               
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
