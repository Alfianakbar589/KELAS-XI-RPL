namespace BiodataSiswa
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblJudul;
        private Label lblNama;
        private Label lblUmur;
        private Label lblAlamat;
        private Label lblAsalSekolah;
        private Label lblHobi;
        private TextBox txtNama;
        private TextBox txtUmur;
        private TextBox txtAlamat;
        private TextBox txtAsalSekolah;
        private TextBox txtHobi;
        private Button btnTampilkan;
        private Button btnHapus;
        private GroupBox grpHasil;
        private TextBox txtHasil;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblJudul = new Label();
            lblNama = new Label();
            lblUmur = new Label();
            lblAlamat = new Label();
            lblAsalSekolah = new Label();
            lblHobi = new Label();
            txtNama = new TextBox();
            txtUmur = new TextBox();
            txtAlamat = new TextBox();
            txtAsalSekolah = new TextBox();
            txtHobi = new TextBox();
            btnTampilkan = new Button();
            btnHapus = new Button();
            grpHasil = new GroupBox();
            txtHasil = new TextBox();
            grpHasil.SuspendLayout();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJudul.Location = new Point(270, 25);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(250, 41);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "BIODATA SISWA";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 10F);
            lblNama.Location = new Point(55, 100);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(56, 23);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama";
            // 
            // lblUmur
            // 
            lblUmur.AutoSize = true;
            lblUmur.Font = new Font("Segoe UI", 10F);
            lblUmur.Location = new Point(55, 150);
            lblUmur.Name = "lblUmur";
            lblUmur.Size = new Size(53, 23);
            lblUmur.TabIndex = 2;
            lblUmur.Text = "Umur";
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Font = new Font("Segoe UI", 10F);
            lblAlamat.Location = new Point(55, 200);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(64, 23);
            lblAlamat.TabIndex = 3;
            lblAlamat.Text = "Alamat";
            // 
            // lblAsalSekolah
            // 
            lblAsalSekolah.AutoSize = true;
            lblAsalSekolah.Font = new Font("Segoe UI", 10F);
            lblAsalSekolah.Location = new Point(55, 250);
            lblAsalSekolah.Name = "lblAsalSekolah";
            lblAsalSekolah.Size = new Size(105, 23);
            lblAsalSekolah.TabIndex = 4;
            lblAsalSekolah.Text = "Asal Sekolah";
            // 
            // lblHobi
            // 
            lblHobi.AutoSize = true;
            lblHobi.Font = new Font("Segoe UI", 10F);
            lblHobi.Location = new Point(55, 300);
            lblHobi.Name = "lblHobi";
            lblHobi.Size = new Size(46, 23);
            lblHobi.TabIndex = 5;
            lblHobi.Text = "Hobi";
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Segoe UI", 10F);
            txtNama.Location = new Point(190, 96);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(657, 30);
            txtNama.TabIndex = 6;
            // 
            // txtUmur
            // 
            txtUmur.Font = new Font("Segoe UI", 10F);
            txtUmur.Location = new Point(190, 150);
            txtUmur.Name = "txtUmur";
            txtUmur.Size = new Size(657, 30);
            txtUmur.TabIndex = 7;
            txtUmur.KeyPress += txtUmur_KeyPress;
            // 
            // txtAlamat
            // 
            txtAlamat.Font = new Font("Segoe UI", 10F);
            txtAlamat.Location = new Point(190, 196);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(657, 30);
            txtAlamat.TabIndex = 8;
            // 
            // txtAsalSekolah
            // 
            txtAsalSekolah.Font = new Font("Segoe UI", 10F);
            txtAsalSekolah.Location = new Point(190, 246);
            txtAsalSekolah.Name = "txtAsalSekolah";
            txtAsalSekolah.Size = new Size(657, 30);
            txtAsalSekolah.TabIndex = 9;
            // 
            // txtHobi
            // 
            txtHobi.Font = new Font("Segoe UI", 10F);
            txtHobi.Location = new Point(190, 296);
            txtHobi.Name = "txtHobi";
            txtHobi.Size = new Size(657, 30);
            txtHobi.TabIndex = 10;
            // 
            // btnTampilkan
            // 
            btnTampilkan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTampilkan.Location = new Point(190, 345);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(160, 42);
            btnTampilkan.TabIndex = 11;
            btnTampilkan.Text = "Tampilkan";
            btnTampilkan.UseVisualStyleBackColor = true;
            btnTampilkan.Click += btnTampilkan_Click;
            // 
            // btnHapus
            // 
            btnHapus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHapus.Location = new Point(370, 345);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(160, 42);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // grpHasil
            // 
            grpHasil.Controls.Add(txtHasil);
            grpHasil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpHasil.Location = new Point(72, 438);
            grpHasil.Name = "grpHasil";
            grpHasil.Size = new Size(775, 190);
            grpHasil.TabIndex = 13;
            grpHasil.TabStop = false;
            grpHasil.Text = "Hasil Biodata";
            grpHasil.Enter += grpHasil_Enter_1;
            // 
            // txtHasil
            // 
            txtHasil.Font = new Font("Consolas", 10F);
            txtHasil.Location = new Point(19, 39);
            txtHasil.Multiline = true;
            txtHasil.Name = "txtHasil";
            txtHasil.ReadOnly = true;
            txtHasil.ScrollBars = ScrollBars.Vertical;
            txtHasil.Size = new Size(742, 145);
            txtHasil.TabIndex = 0;
            txtHasil.TextChanged += txtHasil_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(947, 650);
            Controls.Add(lblJudul);
            Controls.Add(lblNama);
            Controls.Add(lblUmur);
            Controls.Add(lblAlamat);
            Controls.Add(lblAsalSekolah);
            Controls.Add(lblHobi);
            Controls.Add(txtNama);
            Controls.Add(txtUmur);
            Controls.Add(txtAlamat);
            Controls.Add(txtAsalSekolah);
            Controls.Add(txtHobi);
            Controls.Add(btnTampilkan);
            Controls.Add(btnHapus);
            Controls.Add(grpHasil);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BIODATA SISWA";
            grpHasil.ResumeLayout(false);
            grpHasil.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
