using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using Pomodoro.DataBase.Models;
using Microsoft.Data.SqlClient;
using Dapper;
using Pomodoro.DataBase.ViewClasses;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Windows.Media.Animation;

namespace Pomodoro
{
    public partial class FormReport : Form
    {
        private MyUser currentUser;
        public FormReport(string connstr,MyUser currentUser)
        {
            InitializeComponent();
            ConnStr = connstr;
            listViewUserTime.Columns.Add("User", listViewUserTime.Width/2-2, HorizontalAlignment.Left);
            listViewUserTime.Columns.Add("WorkTime", listViewUserTime.Width/2-2, HorizontalAlignment.Left);
            listViewUserTime.View = View.Details;
           this.currentUser= currentUser;

        }
        string ConnStr;
        private void btnDay_Click(object sender, EventArgs e)
        {

        }
       
        private void FormReport_Load(object sender, EventArgs e)
        {
            ChartValues<double> chartValues = new ChartValues<double> { 5, 3, 2, 4, 5 };
            string[] arr = new string[] { "1", "2", "3", "4", "5" };
            Diagramm(chartValues, arr);
            Details();
        }

        private void Diagramm(ChartValues<double> chartValues, string[] arr)
        {
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = chartValues
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Days",
                Labels = arr
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;
            cartesianChart1.DataClick += CartesianChart1_DataClick;
        }

        private void CartesianChart1_DataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");
        }

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex==2)
            {
                listViewUserTime.Items.Clear();
               

                string query = "Select top 10 U.Login as 'User' ,Sum(T.WorkTime) as WorkTime from Users U join Tasks T on T.UserId = U.Id group by U.Login order by Sum(T.WorkTime) desc";
                using (var connection = new SqlConnection(ConnStr))
                {
                    var buf = await connection.QueryAsync<RankClass>(query);
                    foreach (var item in buf)
                    {
                        ListViewItem it = listViewUserTime.Items.Add(item.User);
                        it.SubItems.Add($"{item.WorkTime}");  
                    }
                }
            }
        }
        private async void Details()
        {
            listViewDateTaskMinuts.View = View.Details;
            listViewDateTaskMinuts.Columns.Add("Date", listViewDateTaskMinuts.Width / 3 - 3, HorizontalAlignment.Left);
            listViewDateTaskMinuts.Columns.Add("Task", listViewDateTaskMinuts.Width / 3 - 3, HorizontalAlignment.Left);
            listViewDateTaskMinuts.Columns.Add("Minutes", listViewDateTaskMinuts.Width / 3 - 3, HorizontalAlignment.Left);
            listViewDateTaskMinuts.Items.Clear();
            string query = $"Select T.DateOfFinish, T.Name as 'NameTask',T.WorkTime from Tasks T where T.UserId = {currentUser.Id} and T.TaskState = 'TaskState.Finished' ";//and T.TaskState = 'TaskState.Finished'
            MessageBox.Show($"{currentUser.Id}");
            using (var connection = new SqlConnection(ConnStr))
            {
                var b = await connection.QueryAsync<DetailsClass>(query);
                foreach(var i in b)
                {
                    ListViewItem item = listViewDateTaskMinuts.Items.Add(i.DateOfFinish.ToString());
                    item.SubItems.Add(i.NameTask);
                    item.SubItems.Add($"{i.WorkTime}");
                }
            }
            
            //Select* from Tasks where UserId = 'Id current user' and IsFinished = 1

        }

        private void listViewUserTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
