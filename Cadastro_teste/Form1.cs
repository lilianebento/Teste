using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cadastro_teste
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Positivo\\Documents\\BD_cadastros.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand comando = new SqlCommand ();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" & textBox2.Text != "" & maskedTextBox2.Text != "" & textBox4.Text != "" & maskedTextBox1.Text != "")

            conn.Open();
            comando.CommandText = "INSERT INTO Clientes (nome_cliente, sobrenome_cliente, data_de_nascimento, email_cliente, cpf_cliente) VALUES ('" + textBox3.Text + "','" + textBox2.Text + "','" + maskedTextBox2.Text + "', '" + textBox4.Text + "', '" + maskedTextBox1.Text + "')";
            conn.Close();

            textBox3.Text = "";
            textBox2.Text = "";
            maskedTextBox2.Text = "";
            textBox4.Text = "";
            maskedTextBox1.Text = "";

            Form2 fr = new Form2();
            fr.ShowDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;
        }
    }
}
