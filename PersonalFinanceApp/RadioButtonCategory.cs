using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceApp
{
    public partial class RadioButtonCategory : UserControl
    {
        bool task;
        public bool Task
        {
            get { return task; }
            set { task = value; }
        }
        bool appointment;

        public bool Appointment
        {
            get { return appointment; }
            set { appointment = value; }
        }
        public RadioButtonCategory()
        {
            InitializeComponent();
        }

        private void taskChecked(object sender, EventArgs e)
        {
            if (radioBtnTask.Checked)
            {
                radioBtnAppointment.Checked = false;
            }
            this.Task = true;
        }

        private void appointmentChecked(object sender, EventArgs e)
        {
            if (radioBtnAppointment.Checked)
            {
                radioBtnTask.Checked = false;
            }
            this.Appointment = true;
        }
    }
}
