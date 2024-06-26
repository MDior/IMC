namespace CalcularIMC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPeso = new Label();
            lblAltura = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btCalcular = new Button();
            lblResultado = new Label();
            labelCLASSIFICACAO = new Label();
            labelIMC = new Label();
            SuspendLayout();
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(76, 98);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(39, 20);
            lblPeso.TabIndex = 0;
            lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(76, 145);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(49, 20);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "Altura";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(144, 91);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(125, 27);
            txtPeso.TabIndex = 2;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(144, 138);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 3;
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(144, 186);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(125, 29);
            btCalcular.TabIndex = 4;
            btCalcular.Text = "Calcular IMC";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(76, 240);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado";
            // 
            // labelCLASSIFICACAO
            // 
            labelCLASSIFICACAO.AutoSize = true;
            labelCLASSIFICACAO.Location = new Point(76, 340);
            labelCLASSIFICACAO.Name = "labelCLASSIFICACAO";
            labelCLASSIFICACAO.Size = new Size(115, 20);
            labelCLASSIFICACAO.TabIndex = 7;
            labelCLASSIFICACAO.Text = "CLASSIFICAÇÃO";
            labelCLASSIFICACAO.Visible = false;
            // 
            // labelIMC
            // 
            labelIMC.AutoSize = true;
            labelIMC.Location = new Point(76, 289);
            labelIMC.Name = "labelIMC";
            labelIMC.Size = new Size(35, 20);
            labelIMC.TabIndex = 8;
            labelIMC.Text = "IMC";
            labelIMC.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 450);
            Controls.Add(labelIMC);
            Controls.Add(labelCLASSIFICACAO);
            Controls.Add(lblResultado);
            Controls.Add(btCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(lblAltura);
            Controls.Add(lblPeso);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPeso;
        private Label lblAltura;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btCalcular;
        private Label lblResultado;
        private Label labelCLASSIFICACAO;
        private Label labelIMC;
    }
}
