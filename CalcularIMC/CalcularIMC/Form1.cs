namespace CalcularIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);

            double imc = peso / (altura * altura);

            labelIMC.Text = imc.ToString("F2");
            labelIMC.Visible = true;


            string classifica��o = string.Empty;

            if (imc < 16.9)
                classifica��o = "Muito abaixo do peso";
            else if (imc >= 17 && imc <= 18.4)
                classifica��o = "Abaixo do peso";
            else if (imc >= 18.5 && imc <= 24.9)
                classifica��o = "Peso normal";
            else if (imc >= 25 && imc <= 29.9)
                classifica��o = "Acima do peso";
            else if (imc >= 30 && imc <= 34.9)
                classifica��o = "Obesidade grau I";
            else if (imc >= 35 && imc <= 40)
                classifica��o = "Obesidade grau II";
            else if (imc > 40)
                classifica��o = "Obesidade grau III" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "";


            labelCLASSIFICACAO.Text = classifica��o;
            labelCLASSIFICACAO.Visible = true;


        }
    }
}
