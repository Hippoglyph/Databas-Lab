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
                "AttachDbFilename = " + Application.StartupPath + "\\dbZero.mdf;" +
                "Integrated Security = True; Connect Timeout = 30");/*
            connect = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename = C:\\Users\\Fredrik\\Documents\\FreddansÅJontesDåtabasFöKidzen.mdf;" +
                "Integrated Security = True; Connect Timeout = 30");*/
        }

        private struct Data
        {
            public String Value { get; set; }
            public String Text { get; set; }
        }
        public void updateCourse(String searchText, ListBox courseBox)
        {
            List<List<String>> s = commitCommand("SELECT Course.cid, Course.name FROM takes JOIN Course ON takes.cid = Course.cid WHERE studentid = '" + searchText + "';");
            courseBox.DataSource = null;
            List<Data> data = new List<Data>();
            if (s.Count == 2)
            {
                for (int i = 0; i < s[0].Count; i++)
                {
                    data.Add(new Data() { Value = s[0][i], Text = s[0][i] + ": " + s[1][i] });
                }
                courseBox.DisplayMember = "Text";
                courseBox.DataSource = data;
            }
            else
                Console.WriteLine("updateCourse Wrong amount of colums");
        }

        public void updateRecitation(ListBox coureBox, ListBox recitationBox)
        {
            Data courseValue = new Data() { Value = "", Text = "" };
            if (coureBox.SelectedValue != null)
                courseValue = (Data)coureBox.SelectedValue;
            List<List<String>> s = commitCommand("SELECT Recitation.name FROM Recitation WHERE Recitation.cid = '" + courseValue.Value + "';");
            recitationBox.DataSource = null;
            List<Data> data = new List<Data>();
            if (s.Count == 1)
            {
                for (int i = 0; i < s[0].Count; i++)
                {
                    data.Add(new Data() { Value = s[0][i], Text = s[0][i] });
                }
                recitationBox.DisplayMember = "Text";
                recitationBox.DataSource = data;
            }
            else
                Console.WriteLine("updateRecitation Wrong amount of colums");
        }

        public void updateGroup(ListBox recitationBox, ListBox courseBox, ListBox groupBox)
        {
            Data recitationValue = new Data() { Value = "", Text = "" };
            Data courseValue = new Data() { Value = "", Text = "" };
            if (recitationBox.SelectedValue != null)
                recitationValue = (Data)recitationBox.SelectedValue;
            if (recitationBox.SelectedValue != null)
                courseValue = (Data)courseBox.SelectedValue;
            Console.WriteLine("//////////");
            Console.WriteLine(courseValue.Value);
            Console.WriteLine(recitationValue.Value);
            Console.WriteLine("//////////");
            List<List<String>> s = commitCommand("SELECT group_.name FROM group_ WHERE group_.cid = '" + courseValue.Value + "' AND group_.rname = '" + recitationValue.Value + "';");
            groupBox.DataSource = null;
            List<Data> data = new List<Data>();
            if (s.Count == 1)
            {
                for (int i = 0; i < s[0].Count; i++)
                {
                    data.Add(new Data() { Value = s[0][i], Text = s[0][i] });
                }
                groupBox.DisplayMember = "Text";
                groupBox.DataSource = data;
            }
            else
                Console.WriteLine("updateGroup Wrong amount of colums");
        }

        private List<List<String>> commitCommand(String code)
        {
            command = connect.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = code;
            connect.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<List<String>> sl = new List<List<string>>();
            for (int i = 0; i < reader.FieldCount; i++)
                sl.Add(new List<string>());
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    sl[i].Add(reader.GetString(i));
                    Console.WriteLine("---Added " + reader.GetString(i) + " to list " + i);
                }
            }
            connect.Close();
            return sl;
        }
    }
}
