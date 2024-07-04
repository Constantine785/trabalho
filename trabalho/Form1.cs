namespace trabalho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float gravidade = float.Parse(textGravidade.Text);
            float massa = float.Parse(textMassa.Text);
            float altura = float.Parse(textAltura.Text);


            float resultado = gravidade * massa * altura;

            textResultado.Text = resultado.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}