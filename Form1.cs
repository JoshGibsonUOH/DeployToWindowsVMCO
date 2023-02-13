namespace TestApplicationForClickOnce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddNumber_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int currentNumber = int.Parse(tbNumberBox.Text);
            int addNumber = rand.Next(0, 100);
            int finalNumber = currentNumber += addNumber;
            tbNumberBox.Text = finalNumber.ToString();
        }
    }
}