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
            locationLabel.Text = "";
            logic = new Logic("dbZero", courseBox, recitationBox,groupBox, problemBox);
        }

        private void Submit(object sender, EventArgs e)
        {
            logic.updateCourse(idText.Text);
        }

        private void courseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            logic.updateRecitation();
        }

        private void recitationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            logic.updateGroup();
            logic.updateProblembox();
        }

        private void groupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            logic.updateLocation(locationLabel);
        }
    }
}
