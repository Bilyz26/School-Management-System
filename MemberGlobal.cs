using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace prj_ForYou
{
   public static  class MemberGlobal
    {

        public static string cnxstring=@"data source =.\sqlexpress;initial catalog=DB_Support_School;integrated security=true";
        
        public static DataTable rechercher(string query)
        {
            DataTable b = new DataTable();
            SqlConnection cnx = new SqlConnection(cnxstring);
            SqlCommand cmd = new SqlCommand(query, cnx);
            SqlDataReader dtr;
            cnx.Open();
            dtr = cmd.ExecuteReader();
            if(dtr.HasRows)
            {
                b.Load(dtr);
            }
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


        public static void vider (Form f)
        {
            foreach(Control c in f.Controls )
            {
                if(c is TextBox)
                { 
                    ((TextBox)c).Clear();
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = string.Empty;
                }
                if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Text = string.Empty;
                }
                if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = string.Empty;
                }

                //if (c is DataGridView)
                //{
                //    ((DataGridView)c;
                //}
            }
        }




    }
}
