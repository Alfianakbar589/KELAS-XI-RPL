using System;
using System.Windows.Forms;

namespace BiodataSiswa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtUmur.Text) ||
                string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                string.IsNullOrWhiteSpace(txtAsalSekolah.Text) ||
                string.IsNullOrWhiteSpace(txtHobi.Text))
            {
                MessageBox.Show(
                    "Semua data harus diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            txtHasil.Text =
                "BIODATA SISWA\r\n" +
                "Nama         : " + txtNama.Text + "\r\n" +
                "Umur         : " + txtUmur.Text + " tahun\r\n" +
                "Alamat       : " + txtAlamat.Text + "\r\n" +
                "Asal Sekolah : " + txtAsalSekolah.Text + "\r\n" +
                "Hobi         : " + txtHobi.Text;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            txtNama.Clear();
            txtUmur.Clear();
            txtAlamat.Clear();
            txtAsalSekolah.Clear();
            txtHobi.Clear();
            txtHasil.Clear();
            txtNama.Focus();
        }

        private void txtUmur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtHasil_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpHasil_Enter(object sender, EventArgs e)
        {

        }

        private void grpHasil_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
