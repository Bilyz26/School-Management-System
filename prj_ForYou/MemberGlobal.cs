using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace prj_ForYou
{
   public   class MemberGlobal
    {
        public static string cnxstring= @"data source =LAPTOP-APHV9V69\SQLEXPRESS01;initial catalog=DB_Support_School;integrated security=true";      
        public static DataTable rechercher(string query)
        {          
            DataTable b = new DataTable();
            SqlConnection cnx = new SqlConnection(cnxstring);
            SqlCommand cmd = new SqlCommand(query, cnx);
            SqlDataReader dtr;
            cnx.Open();
            dtr = cmd.ExecuteReader();
            if(dtr.HasRows)
            { b.Load(dtr);}
            dtr.Close();
            cnx.Close();
            return b;
        }
        public static bool Insert_Edit_Delete(string query)
        {
            bool b=true;
            SqlConnection cnx = new SqlConnection(cnxstring);
            SqlCommand cmd = new SqlCommand(query, cnx);
            cnx.Open();
            int n = cmd.ExecuteNonQuery();
            cnx.Close();
            if(n==1)
            { b = true; }
            else
            { b = false; }
                return b;
        }
        public static void vider(Form f)
        {
            foreach (Control c in f.Controls)
            {
                if (c is DataGridView)
                { ((DataGridView)c).Columns.Clear(); }
                if (c is TextBox)
                { ((TextBox)c).Clear();}
                if (c is ComboBox)
                { ((ComboBox)c).Text = string.Empty;}
                if (c is DateTimePicker)
                { ((DateTimePicker)c).Text = string.Empty; }
                if (c is MaskedTextBox)
                { ((MaskedTextBox)c).Text = string.Empty;}
               
            }
        }
        public static void messageBox(Form f,string m)
        {
           
            foreach(Control c in f.Controls)
            {
                if(c is Label)
                {
                    ((Label)c).Text = m;
                }
            }
            f.Show();
        }
       public static DataTable dt=new DataTable();


    }
}
