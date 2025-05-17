namespace atividade._15_05
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
            txtMarca = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPortas = new TextBox();
            txtPlaca = new TextBox();
            txtAno = new TextBox();
            txtModelo = new TextBox();
            txtAssento = new TextBox();
            txtCombustivel = new TextBox();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(91, 55);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 58);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 97);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Modelo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 145);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 3;
            label3.Text = "Ano:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 194);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "Placa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 55);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 5;
            label5.Text = "Quantidade de Portas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(247, 94);
            label6.Name = "label6";
            label6.Size = new Size(138, 15);
            label6.TabIndex = 6;
            label6.Text = "Quantidade de Assentos:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(261, 129);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 7;
            label7.Text = "Tipo de Combustível:";
            // 
            // txtPortas
            // 
            txtPortas.Location = new Point(391, 47);
            txtPortas.Name = "txtPortas";
            txtPortas.Size = new Size(100, 23);
            txtPortas.TabIndex = 8;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(91, 191);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(100, 23);
            txtPlaca.TabIndex = 9;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(91, 142);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(100, 23);
            txtAno.TabIndex = 10;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(91, 94);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 11;
            // 
            // txtAssento
            // 
            txtAssento.Location = new Point(391, 86);
            txtAssento.Name = "txtAssento";
            txtAssento.Size = new Size(100, 23);
            txtAssento.TabIndex = 12;
            // 
            // txtCombustivel
            // 
            txtCombustivel.Location = new Point(391, 126);
            txtCombustivel.Name = "txtCombustivel";
            txtCombustivel.Size = new Size(100, 23);
            txtCombustivel.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(330, 174);
            button1.Name = "button1";
            button1.Size = new Size(161, 23);
            button1.TabIndex = 14;
            button1.Text = "Visualizar dados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(152, 16);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(180, 9);
            label9.Name = "label9";
            label9.Size = new Size(205, 32);
            label9.TabIndex = 16;
            label9.Text = "Cadastro de Carro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(txtCombustivel);
            Controls.Add(txtAssento);
            Controls.Add(txtModelo);
            Controls.Add(txtAno);
            Controls.Add(txtPlaca);
            Controls.Add(txtPortas);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMarca);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarca;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPortas;
        private TextBox txtPlaca;
        private TextBox txtAno;
        private TextBox txtModelo;
        private TextBox txtAssento;
        private TextBox txtCombustivel;
        private Button button1;
        private Label label8;
        private Label label9;
    }
}
