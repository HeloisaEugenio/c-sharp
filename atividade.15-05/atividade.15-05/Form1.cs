using System.Drawing.Text;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace atividade._15_05
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            this.BackColor = Color.LightBlue;
            InitializeComponent();
        }

        private string marca;

        private string modelo;

        private int ano;

        private string placa;

        private int quantidadedeportas;

        private int quantidadedeassentos;

        private string combustivel;


        public string Marca
        {
            get => marca;
            set => marca = value;
        }
        public string Modelo
        {
            get => modelo;
            set => modelo = value;
        }
        public int Ano
        {
            get => ano;
            set => ano = value;
        }
        public string Placa
        {
            get => placa;
            set => placa = value;
        }
        public int Quantidadedeportas
        {
            get => quantidadedeportas;
            set => quantidadedeportas = value;
        }
        public int QuantidadedeAssentos
        {
            get => quantidadedeassentos;
            set => quantidadedeassentos = value;
        }
        public string Combustivel
        {
            get => combustivel;
            set => combustivel = value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            int ano = int.Parse(txtAno.Text);
            string placa = txtPlaca.Text;
            int portas = int.Parse(txtPortas.Text);
            int assentos = int.Parse(txtAssento.Text);
            string combustivel = txtCombustivel.Text;

            string dados = $"Marca: {marca}\n" +
                           $"Modelo: {modelo}\n" +
                           $"Ano: {ano}\n" +
                           $"Placa: {placa}\n" +
                           $"Portas: {portas}\n" +
                           $"Assentos: {assentos}\n" +
                           $"Combustível: {combustivel}";


            MessageBox.Show(dados, "Carro Cadastrado");
        }
    }

    }


