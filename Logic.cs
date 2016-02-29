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

        private TextBox idBox;
        private ListBox courseBox;
        private ListBox recitationBox;
        private ListBox groupBox;
        private FlowLayoutPanel problemBox;
        private List<CheckedListBox> checkLists;
        public Logic(String databaseName, ListBox courseBox, ListBox recitationBox, ListBox groupBox, FlowLayoutPanel problemBox, TextBox idBox)
        {
            connect = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename = " + Application.StartupPath + "\\"+ databaseName +".mdf;" +
                "Integrated Security = True; Connect Timeout = 30");
            this.idBox = idBox;
            this.courseBox = courseBox;
            this.recitationBox = recitationBox;
            this.groupBox = groupBox;
            this.problemBox = problemBox;
            checkLists = new List<CheckedListBox>();
        }

        private struct Data
        {
            public String Value { get; set; }
            public String Text { get; set; }
        }
        private struct ProblemValues
        {
            public String problemName { get; set; }
            public String setName { get; set; }
            public String Text { get; set; }
        }
        public void updateCourse(String searchText)
        {
            List<List<String>> s = commitCommand("SELECT Course.cid, Course.name FROM takes JOIN Course ON takes.cid = Course.cid WHERE studentid = '" + searchText + "';");
            courseBox.DataSource = null;
            List<Data> data = new List<Data>();
            for (int i = 0; i < s[0].Count; i++)
                data.Add(new Data() { Value = s[0][i], Text = s[1][i] });
            courseBox.DisplayMember = "Text";
            courseBox.DataSource = data;
        }

        public void updateRecitation()
        {
            recitationBox.DataSource = null;
            if (courseBox.SelectedValue == null)
                return;
            List<List<String>> s = commitCommand("SELECT Recitation.name FROM Recitation WHERE Recitation.cid = '" +
                ((Data)courseBox.SelectedValue).Value + "';");
            List<Data> data = new List<Data>();
            for (int i = 0; i < s[0].Count; i++)
                data.Add(new Data() { Value = s[0][i], Text = s[0][i] });
            recitationBox.DisplayMember = "Text";
            recitationBox.DataSource = data;
        }

        public void updateGroup()
        {
            groupBox.DataSource = null;
            if (recitationBox.SelectedValue == null || courseBox.SelectedValue == null)
                return;
            List<List<String>> s = commitCommand("SELECT group_.name FROM group_ WHERE group_.cid = '" + ((Data)courseBox.SelectedValue).Value +
                "' AND group_.rname = '" + ((Data)recitationBox.SelectedValue).Value + "';");
            List<Data> data = new List<Data>();
            for (int i = 0; i < s[0].Count; i++)
                data.Add(new Data() { Value = s[0][i], Text = s[0][i] });
            groupBox.DisplayMember = "Text";
            groupBox.DataSource = data;
        }

        public void updateLocation(Label locationLabel)
        {
            locationLabel.Text = "";
            if (recitationBox.SelectedValue == null || courseBox.SelectedValue == null || groupBox.SelectedValue == null)
                return;
            List<List<String>> s = commitCommand("SELECT group_.location, group_.date_ FROM group_ WHERE group_.cid = '" +
                ((Data)courseBox.SelectedValue).Value + "' AND group_.rname = '" + ((Data)recitationBox.SelectedValue).Value +
                "' AND group_.name = '" + ((Data)groupBox.SelectedValue).Value + "';");
            locationLabel.Text = s[0][0] + ": " + s[1][0];
        }

        public void updateProblembox()
        {
            problemBox.Controls.Clear();
            checkLists.Clear();
            if (recitationBox.SelectedValue == null || courseBox.SelectedValue == null)
                return;
            List<List<String>> s = commitCommand("SELECT setProblems.name, setProblems.description_ FROM setProblems WHERE setProblems.cid = '" +
                ((Data)courseBox.SelectedValue).Value + "' AND setProblems.rname = '" +
                ((Data)recitationBox.SelectedValue).Value + "';");
            for (int i = 0; i < s[0].Count; i++)
                insertSetProblem(s[0][i], s[1][i]);
        }

        private void insertSetProblem(String name, String description)
        {
            Label problemLabel = new Label();
            problemLabel.AutoSize = true;
            problemLabel.Text = name + ":  " + description;
            //problemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            problemBox.Controls.Add(problemLabel);
            CheckedListBox problemCheckBox = new CheckedListBox();
            problemCheckBox.Width = problemBox.Width-50;
            problemCheckBox.HorizontalScrollbar = true;
            problemBox.Controls.Add(problemCheckBox);
            problemCheckBox.DisplayMember = "Text";
            checkLists.Add(problemCheckBox);
            insertProblems(name, problemCheckBox);
        }

        private void insertProblems(String setName, CheckedListBox checkbox)
        {
            List<List<String>> s = commitCommand("SELECT problem.name, problem.description_ FROM problem WHERE problem.cid = '"+
                ((Data)courseBox.SelectedValue).Value + "' AND problem.rname = '" + ((Data)recitationBox.SelectedValue).Value +
                "' AND problem.setName = '"+ setName +"'; ");
            for (int i = 0; i < s[0].Count; i++)
                checkbox.Items.Add(new ProblemValues { problemName = s[0][i] , setName = setName, Text = s[0][i] + ". " + s[1][i] });
        }

        public void submitForm()
        {
            commitCommand("DELETE FROM hasSolved WHERE studentid = '" + idBox.Text + "' AND rName = '" + ((Data)recitationBox.SelectedValue).Value
                + "' AND gName = '" + ((Data)groupBox.SelectedValue).Value + "' AND cid = '" + ((Data)courseBox.SelectedValue).Value + "';");
            foreach(CheckedListBox clb in checkLists)
            {
                foreach(ProblemValues data in clb.CheckedItems)
                    commitCommand(buildUpdateQuery(data));
            }
        }

        private string buildUpdateQuery(ProblemValues data)
        {
            return "INSERT INTO hasSolved(cid, rName, setName, studentid, pName, gName, called, accepted) " + 
                   "VALUES('"+ ((Data)courseBox.SelectedValue).Value + "', '" + ((Data)recitationBox.SelectedValue).Value + "', '" + data.setName + "', '" +
                   idBox.Text + "', '" + data.problemName + "', '" + ((Data)groupBox.SelectedValue).Value + "', 0, 0);";
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
                    sl[i].Add(""+reader.GetValue(i));
                }
            }
            connect.Close();
            return sl;
        }
    }
}
