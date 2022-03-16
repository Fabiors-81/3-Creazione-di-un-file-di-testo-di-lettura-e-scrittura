namespace FilediTesto
{
    public partial class Form1 : Form
    {
        GestioneFile gestioneFile = new GestioneFile();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gestioneFile.scrivi_fileditesto(textBox1.Text, @"c:\test\", "filediTesto", "csv");
            gestioneFile.scrivi_fileditesto(html(), Directory.GetCurrentDirectory(), "FileTesto", "html");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = gestioneFile.leggi_fileditesto(@"c:\test\", "filediTesto", "csv");//Directory.GetCurrentDirectory());
        }

        private string html()
        {
            HtmlGenera htmlGenera = new();
            string result = null;
            //Scrivo la testata, apertura html
            result = htmlGenera.testa("Benvenuto");
            result += htmlGenera.body();
            result += htmlGenera.close();
            return result;
            //Chiusura dell'html
        }
        

        private void btnCreaDirectory_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gestioneFile.creazioneCartella(@"C:\Users\Facep\source\repos\Fabio\giorgio\pippo\"));
            gestioneFile.creazioneCartella(@"C:\Users\Facep\source\repos\Fabio\giorgio\pippo\");
        }
    }
}