using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalFinanceApp
{
    public partial class RadioButtonsType : UserControl
    {
        bool income;

        public bool Income
        {
            get { return income; }
            set { income = value; }
        }
        bool expense;

        public bool Expense
        {
            get { return expense; }
            set { expense = value; }
        }

        public RadioButtonsType()
        {
            InitializeComponent();
        }

        private void incomeChecked(object sender, EventArgs e)
        {
            if (radioBtnIncome.Checked)
            {
                radioBtnExpense.Checked = false;
            }
            this.Income = true;
        }

        private void expenseChecked(object sender, EventArgs e)
        {
            if (radioBtnExpense.Checked)
            {
                radioBtnIncome.Checked = false;
            }
            this.Expense = true;
        }
    }
}
