namespace HelloWordDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                pbxCorFundo.BackColor = colorPicker.Color;
                panel1.BackColor = colorPicker.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbxDados.Items.Clear();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            lbxDados.Items.Add($"{textNome.Text} | {textEndereco.Text} | {textComplemento.Text} | {textNumero.Text}");
            textNome.ResetText();
            textEndereco.ResetText();
            textComplemento.ResetText();
            textNumero.ResetText();
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbxDados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textEndereco_TextChanged(object sender, EventArgs e)
        {
        }
    }
}