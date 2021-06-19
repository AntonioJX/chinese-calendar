using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();


        }

        private void Demo_Shown(object sender, EventArgs e)
        {
            myMonthCalendar1.DictionaryDayType = new Dictionary<DateTime, bool>()
            {
                {new DateTime(2021,6,17),false },
                {new DateTime(2021,6,18),false }
            };
            myMonthCalendar1.Refresh();
        }
    }
}
