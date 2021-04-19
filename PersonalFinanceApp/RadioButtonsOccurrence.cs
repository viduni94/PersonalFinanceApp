using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalFinanceApp
{
    public partial class RadioButtonsOccurrence : UserControl
    {
        bool oneOff;

        public bool OneOff
        {
            get { return oneOff; }
            set { oneOff = value; }
        }
        bool recurring;

        public bool Recurring
        {
            get { return recurring; }
            set { recurring = value; }
        }

        public RadioButtonsOccurrence()
        {
            InitializeComponent();
        }

        private void oneOffChecked(object sender, EventArgs e)
        {
            if (radioBtnOne.Checked)
            {
                radioBtnRec.Checked = false;
            }
            this.OneOff = true;
        }

        private void recurringChecked(object sender, EventArgs e)
        {
            if (radioBtnRec.Checked)
            {
                radioBtnOne.Checked = false;
            }
            this.Recurring = true;
        }
    }
}
