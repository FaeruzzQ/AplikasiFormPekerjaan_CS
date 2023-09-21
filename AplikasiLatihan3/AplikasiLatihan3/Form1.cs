using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLatihan3
{
    public partial class txtPesan2 : Form
    {
        public txtPesan2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var Pendidikan = cmbPendidikan.Text;
            var Pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = string.Format("Halo {0}",nama);
            textBox3.Text = string.Format("Pendidikan Anda{0} ya?", Pendidikan);
            txtPesan3.Text = string.Format("Anda Seorang {0}, hebat !!!", Pekerjaan);
        }
    }
}
