using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempControlApp {
    public partial class TempView : Form {
        public TempView() {
            InitializeComponent();
            timer1.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void TempView_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblIstTemp.Text = Serverraum.getInstance().IstTemperatur.ToString();
            lblSollTemp.Text = Serverraum.getInstance().SollTemperatur.ToString();
        }
    }
}
