using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlnt.UI
{
    public partial class APIWeather : Form
    {
        public APIWeather()
        {
            InitializeComponent();
        }
        private const string API_KEY = "96d1895c2c68b23d0f37dd7ad5bb5bff";


        private const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" +
            "@QUERY@=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;
        private const string ForecastUrl =
            "http://api.openweathermap.org/data/2.5/forecast?" +
            "@QUERY@=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;

        private string[] QueryCodes = { "q", "zip", "id", };
        private void APIWeather_Load(object sender, EventArgs e)
        {

        }
    }
}
