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


            string classificação = string.Empty;

            if (imc < 16.9)
                classificação = "Muito abaixo do peso";
            else if (imc >= 17 && imc <= 18.4)
                classificação = "Abaixo do peso";
            else if (imc >= 18.5 && imc <= 24.9)
                classificação = "Peso normal";
            else if (imc >= 25 && imc <= 29.9)
                classificação = "Acima do peso";
            else if (imc >= 30 && imc <= 34.9)
                classificação = "Obesidade grau I";
            else if (imc >= 35 && imc <= 40)
                classificação = "Obesidade grau II";
            else if (imc > 40)
                classificação = "Obesidade grau III" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "";


            labelCLASSIFICACAO.Text = classificação;
            labelCLASSIFICACAO.Visible = true;


        }
    }
}
