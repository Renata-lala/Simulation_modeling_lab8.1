namespace ИМ_лаба8
{
    public partial class Form1 : Form
    {
        public double p;
        public string otvet;
        public Form1()
        {
            otvet = string.Empty;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            p = 0.5;
            Random rnd = new Random();
            int a = rnd.Next(0, 2);
            if (a < p) { otvet = "Да"; }
            else { otvet = "Нет"; }
            label1.Text = "" + otvet;
        }


    }
}
