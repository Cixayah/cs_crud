namespace CRUD
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // Adiciona o evento Load para verificar a conex�o com o banco de dados quando o formul�rio � carregado
        }

        private void funcion�riosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees empWindow = new Employees();
            empWindow.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Evento Load do formul�rio principal
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Chama o m�todo que verifica a conex�o com o banco de dados quando o formul�rio � carregado
        }

        // M�todo para verificar a conex�o com o banco de dados

    }
}
