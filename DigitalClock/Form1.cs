using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Zaman_Tick(object sender, EventArgs e)
        {
            DateTime zaman = DateTime.Now; //şimdiki zaman 
            labelzaman.Text = zaman.ToString();
            LabelYıl.Text= zaman.Year.ToString();
            LabelAy.Text= CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.MonthNames[zaman.Month-1]; //türkiye ay isimlerini aldı.
            LabelGun.Text = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)zaman.DayOfWeek ];
            
        }
    }
}
