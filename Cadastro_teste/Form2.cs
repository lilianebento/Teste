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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Positivo\\Documents\\BD_cadastros.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public Form2()
        {
        }

        public Form2(string nome)
        {
            InitializeComponent();
            label1.Text = nome;
        }
        public void carregarLista()
        {
            listBox1.Items.Clear();
            listBox1.Items.Clear();
            listBox1.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();

            conn.Open();
            comando.CommandText = "SELECT *FROM Clientes";
            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0].ToString());
                    listBox2.Items.Add(dr[1].ToString());
                    listBox3.Items.Add(dr[2].ToString());
                    listBox4.Items.Add(dr[3].ToString());
                    listBox5.Items.Add(dr[4].ToString());
                }

            }
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
