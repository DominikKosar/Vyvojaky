namespace Vyvojaky
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btNovySoubor_Click(object sender, EventArgs e)
        {
            Form novySoubor = new Form2();
            novySoubor.Show();
        }

        private void btExistujici_Click(object sender, EventArgs e)
        {

        }
    }
}