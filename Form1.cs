using System.Data;
using System.Data.SqlClient;

namespace kitaplikprojesi
{
    public partial class Form1 : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();
        public Form1()
        {
            InitializeComponent();
        }
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TblKitaplar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void Turler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TblTurler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbTur.ValueMember = "Turid";   // Arka planda tutulacak deðer
            CmbTur.DisplayMember = "TurAd"; // Kullanýcýnýn göreceði metin
            CmbTur.DataSource = dt;
        }
        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
            Turler();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            // Baðlantýyý deðiþkene atayalým ki iþimiz bitince kapatabilelim
            SqlConnection baglan = bgl.baglanti();

            SqlCommand komutekle = new SqlCommand("insert into TblKitaplar (KitapAd, Yazar, Sayfa, Fiyat, YayinEvi, Tur) values (@p1, @p2, @p3, @p4, @p5, @p6)", baglan);

            komutekle.Parameters.AddWithValue("@p1", TxtKitapAd.Text);
            komutekle.Parameters.AddWithValue("@p2", TxtYazar.Text);
            komutekle.Parameters.AddWithValue("@p3", TxtSayfa.Text);
            komutekle.Parameters.AddWithValue("@p4", TxtFiyat.Text);
            komutekle.Parameters.AddWithValue("@p5", TxtYayinEvi.Text);

            // Tür kýsmýný ComboBox'tan seçilen deðerin ID'si olarak alýyoruz
            komutekle.Parameters.AddWithValue("@p6", CmbTur.SelectedValue);
            komutekle.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kitap Veri Tabanýna Eklendi ve Stok Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }
        //datagridview de týklanýlan özellikleri ilgili araçlara taþýyan özellik
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKitapId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtKitapAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtYazar.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtSayfa.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtYayinEvi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = bgl.baglanti();
            SqlCommand komutsil = new SqlCommand("Delete From TblKitaplar where KitapId=@p1", baglan);
            komutsil.Parameters.AddWithValue("@p1", TxtKitapId.Text);
            komutsil.Parameters.AddWithValue("@p2", TxtKitapId.Text); // Görseldeki yapýya göre
            komutsil.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Kitap Veri Tabanýndan Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = bgl.baglanti();

            // SQL Update sorgusu ve parametrelerin tanýmlanmasý
            SqlCommand komutguncelle = new SqlCommand("Update TblKitaplar set KitapAd=@p1, Yazar=@p2, Sayfa=@p3, Fiyat=@p4, YayinEvi=@p5, Tur=@p6 where KitapId=@p7", baglan);

            komutguncelle.Parameters.AddWithValue("@p1", TxtKitapAd.Text);
            komutguncelle.Parameters.AddWithValue("@p2", TxtYazar.Text);
            komutguncelle.Parameters.AddWithValue("@p3", TxtSayfa.Text);
            komutguncelle.Parameters.AddWithValue("@p4", TxtFiyat.Text);
            komutguncelle.Parameters.AddWithValue("@p5", TxtYayinEvi.Text);

            // Tür ID'sini ComboBox üzerinden gönderiyoruz
            komutguncelle.Parameters.AddWithValue("@p6", CmbTur.SelectedIndex + 1);

            // Güncellenecek kitabýn ID'si
            komutguncelle.Parameters.AddWithValue("@p7", TxtKitapId.Text);

            komutguncelle.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Kitap Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Listele();
        }
    }
}
