using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace RecitationRapportering
{
    class Logic
    {
        static SqlConnection connect;
        static SqlCommand command;
        public Logic(String databaseName)
        {
            
              connect = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename = " + Application.StartupPath + "\\FreddansÅJontesDåtabasFöKidzen.mdf;" +
                "Integrated Security = True; Connect Timeout = 30");/*
            connect = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename = C:\\Users\\Fredrik\\Documents\\FreddansÅJontesDåtabasFöKidzen.mdf;" +
                "Integrated Security = True; Connect Timeout = 30");*/
        }

        public void updateCourse(String searchText, ListBox courseBox)
        {
            List<List<String>> s = commitCommand("SELECT cid FROM takes WHERE studentid = '" + searchText + "';");
            courseBox.Items.Clear();
            foreach (String st in s[0])
                courseBox.Items.Add(st);

        }

        private List<List<String>> commitCommand(String code)
        {
            command = connect.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = code;
            connect.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<List<String>> sl = new List<List<string>>();
            for (int i = 0; i < reader.FieldCount; i++) {
                sl.Add(new List<string>());
                while (reader.Read())
                    sl[i].Add(reader.GetString(i));
            }
            connect.Close();
            return sl;
        }
    }
}
