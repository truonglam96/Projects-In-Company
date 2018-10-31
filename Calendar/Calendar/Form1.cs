using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Calendar
{
    public partial class Form1 : Form
    {
        private string filePath = "data.xml";
        private List<string> dateofweek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        private List<List<Button>> matrix;
        public Form1()
        {
            InitializeComponent();
            loadMaTrix();
            try
            {
               Job = DeserializeFromXML(filePath) as PlanData;
            }
            catch
            {
                
            }
            
        }
       
        void loadMaTrix()
        {
            matrix = new List<List<Button>>();
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    btn.Click += Btn_Click;

                    pnlMaTrix.Controls.Add(btn);
                    matrix[i].Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight) };
            }
            SetDefaultDate();
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            DayPlan daily = new DayPlan(new DateTime(dpkDate.Value.Year, dpkDate.Value.Month, Convert.ToInt32((sender as Button).Text)), Job);            
            daily.ShowDialog();
        }

        private PlanData job;      
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
        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30; ;
            }
        }
        void AddNumber(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateofweek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = matrix[line][column];
                //btn.Tag = i;
                btn.Click += Btn_Click;
                btn.Text = i.ToString();
                if (column >= 6)
                    line++;

                //if(isEqualDate(useDate, DateTime.Now))
                //{
                //    btn.BackColor = Color.Cyan;
                //}

                useDate = useDate.AddDays(1);
            }

        }        
        void ClearMatrix()
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Button btn = matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
                }
            }
        }
        void SetDefaultDate()
        {
            dpkDate.Value = DateTime.Now;
        }
        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }
        private void dpkDate_ValueChanged(object sender, EventArgs e)
        {
            
            AddNumber((sender as DateTimePicker).Value);
        }
        private void btnThangtruoc_Click(object sender, EventArgs e)
        {
            dpkDate.Value = dpkDate.Value.AddMonths(-1);
        }
        private void btnThangsau_Click(object sender, EventArgs e)
        {
            dpkDate.Value = dpkDate.Value.AddMonths(1);
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }
        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));
            sr.Serialize(fs, data);
            fs.Close();
        }
        private object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));
                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch (Exception e)
            {
                fs.Close();
                throw new NotImplementedException();
            }           
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(Job, filePath);
        }
    }
    }

