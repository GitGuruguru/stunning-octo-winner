using Biblioteka.models;

namespace Biblioteka
{
    public partial class FormMain : Form
    {
        private readonly Libary libary = new Libary();
        public FormMain()
        {
            InitializeComponent();
        }

        private void dodajKsiazke_Click(object sender, EventArgs e)
        {
            //Pobierz dane z formularza 
            string tytul = txttytul.Text.Trim();
            string autor = txtautor.Text.Trim();
            string kategoria = txtkategory.Text.Trim();
            int rokwydania = (int)rokwydaniaint.Value;

            if (string.IsNullOrEmpty(tytul) || string.IsNullOrEmpty(autor) || string.IsNullOrEmpty(kategoria)) {
                MessageBox.Show("Wypelnij wzystkie pola!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var book = new Book(tytul, autor,kategoria, rokwydania);
            libary.AddBook(book);
            txtautor.Clear();
            txtkategory.Clear();
            txttytul.Clear();
            rokwydaniaint.Value = 2025;
        }
        private void OdszwiezListe(object sender, EventArgs e)
        {
            string fraza = 
        }
    }
}
