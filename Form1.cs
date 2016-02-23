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

        private void itemSelect(object sender, EventArgs e)
        {

        }

        private void Submit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            logic.updateCourse(idText.Text, courseBox);
        }

    }
}
