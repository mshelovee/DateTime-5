using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_5___96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMka_Click(object sender, EventArgs e)
        {
            DateTime tarih = new DateTime(2017, 11, 10, 9, 5, 0);
            lblMesaj.Text = tarih + " tarihinde M.Kemal Atatürk aramızdan ayrıldı.";
        }

        private void btnBaslangic_Click(object sender, EventArgs e)
        {
            DateTime tarih = new DateTime(2017, 1, 1);
            MessageBox.Show(tarih + " tarihi yeni yıl başlangıcıdır.");
            tarih = tarih.AddYears(1);
            MessageBox.Show(tarih + " tarihi de yeni yıl başlangıcıdır.");
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            lblMesaj.Text = "Bugün günlerden: " + bugun.DayOfWeek;
        }
    }
}
