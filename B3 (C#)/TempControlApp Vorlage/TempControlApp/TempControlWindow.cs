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
    public partial class TempControlWindow : Form {
        public TempControlWindow() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void OnAktualisieren(object sender, EventArgs e)
        {
            txtIstTemp.Text = Serverraum.getInstance().IstTemperatur.ToString();
            txtSollTemp.Text = Serverraum.getInstance().SollTemperatur.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Serverraum.getInstance().SollTemperatur = Convert.ToDouble(txtSollTemp.Text);
        }
    }
}
