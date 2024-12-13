using LibraryManagement.BusinessLayer;
using LibraryManagement.DataAccessLayer;
using LibraryManagement.EntityLayer.Models;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.Desktop
{
    public partial class Form1 : Form
    {
        private BookManager _kitapManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _kitapManager = new BookManager(new BookRepository(new AppDbContext()));
            ListeyiYenile();

            GetClear();
        }
        Book? secilenItem;
        private void ListeyiYenile()
        {

            lstListe.ValueMember = "Id";
            lstListe.DisplayMember = "DisplayInfo";
            lstListe.DataSource = _kitapManager.GetAllBooks();
            lstListe.SelectedIndex = -1;
            secilenItem = null;
        }

        private void GetClear()
        {
            txtAd.Clear();
            txtSayfaSayisi.Clear();
            txtTür.Clear();
            txtYayinEvi.Clear();
            txtYazar.Clear();   
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            var kitap = new Book()
            {
                Ad = txtAd.Text,
                Yazar = txtYazar.Text,
                YayinEvi = txtYayinEvi.Text,
                SayfaSayisi = int.Parse(txtSayfaSayisi.Text),
                Tur = txtTür.Text
            };

            MessageBox.Show("Eklendi");
            _kitapManager.Add(kitap);
            ListeyiYenile();
            GetClear();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {

            try
            {
                _kitapManager.Delete(secilenItem.Id);

                MessageBox.Show("Seçilen öðe baþarýyla silindi.");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            ListeyiYenile();
            GetClear();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (secilenItem != null)
            {


                secilenItem.Ad = txtAd.Text;
                secilenItem.Yazar = txtYazar.Text;
                secilenItem.YayinEvi = txtYayinEvi.Text;
                secilenItem.SayfaSayisi = int.Parse(txtSayfaSayisi.Text);
                secilenItem.Tur = txtTür.Text;
                _kitapManager.Update(secilenItem);

                MessageBox.Show("Kitap güncellendi.");
                ListeyiYenile();
            }
            GetClear();
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex != -1)
            {
                secilenItem = lstListe.SelectedItem as Book;
                if (secilenItem != null)
                {
                    txtAd.Text = secilenItem.Ad;
                    txtYazar.Text = secilenItem.Yazar;
                    txtYayinEvi.Text = secilenItem.YayinEvi;
                    txtSayfaSayisi.Text = secilenItem.SayfaSayisi.ToString();
                    txtTür.Text = secilenItem.Tur;

                }

            }
        }



    }
}
