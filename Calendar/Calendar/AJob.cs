using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class AJob : UserControl
    {
        private PlanItem job;
        public AJob()
        {
            InitializeComponent();
            this.Job = job;
        }

        public PlanItem Job
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
    }
}
