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

namespace Pomodoro
{
    public partial class FormReport : Form
    {
        public FormReport(string connstr)
        {
            InitializeComponent();
            ConnStr = connstr;
            listViewUserTime.Columns.Add("User", listViewUserTime.Width/2-2, HorizontalAlignment.Left);
            listViewUserTime.Columns.Add("WorkTime", listViewUserTime.Width/2-2, HorizontalAlignment.Left);
            listViewUserTime.View = View.Details;

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
    }
}
