using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class DayPlan : Form
    {
        private DateTime dateTime;
        private PlanData job;
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }

            set
            {
                dateTime = value;
            }
        }

        internal PlanData Job
        {
            get
            {
                return job;
            }

            set
            {
                job = value;
            }
        }
        public DayPlan(DateTime dateTime, PlanData job)
        {
            InitializeComponent();
            DateTime = dateTime;
            Job = job;
        }
        
        

        
    }
}
