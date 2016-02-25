using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecitationRapportering
{
    public partial class RecitationReport : Form
    {
        Logic logic;
        public RecitationReport()
        {
            InitializeComponent();
            logic = new Logic("RecitationDatabase");
        }

        private void Submit(object sender, EventArgs e)
        {
            logic.updateCourse(idText.Text, courseBox);
        }

        private void courseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            logic.updateRecitation(courseBox, recitationBox);
        }

        private void recitationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            logic.updateGroup(recitationBox, courseBox, groupBox);
        }
    }
}
