namespace GuiTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = ForeColor = Color.Black;
            ForeColor = Color.White;
            lbl_Escolha_um_tema.ForeColor = Color.White;
            btn_Claro.BackColor = Color.Gray;
            btn_Escuro.BackColor = Color.Gray;
            
        }


        private void btn_Claro_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
            ForeColor = Color.Black;
            lbl_Escolha_um_tema.ForeColor = Color.Black;
            btn_Claro.BackColor = Color.LightBlue;
            btn_Escuro.BackColor = Color.LightBlue;
        }

        private void label1_Click(object sender, EventArgs e) { }

    }

}