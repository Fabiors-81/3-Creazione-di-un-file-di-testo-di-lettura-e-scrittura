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
            gestioneFile.scrivi_fileditesto(textBox1.Text,@"c:\test\","filediTesto","csv");
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
              textBox1.Text = gestioneFile.leggi_fileditesto(@"c:\test\","filediTesto","csv");//Directory.GetCurrentDirectory());
        }
    }
}