using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //criar uma arrayList
            ArrayList formaPagto = new ArrayList();
            formaPagto.Add(new FormaDePagto(1, "Selecionar Opção"));
            formaPagto.Add(new FormaDePagto(2, "Cartão"));
            formaPagto.Add(new FormaDePagto(3, "Boleto"));
            formaPagto.Add(new FormaDePagto(4, "Pix"));
            formaPagto.Add(new FormaDePagto(5, "Dinheiro"));

            //vincular ao comboBox
            comboBox1.DataSource = formaPagto;
            comboBox1.DisplayMember = "Descricao";
            comboBox1.ValueMember = "ID";

            int op = comboBox1.SelectedIndex;
            lblEscolha.Text = op.ToString();

        }

        public class FormaDePagto
        {
            public int ID { get; set; }
            public string Descricao { get; set; }

            public FormaDePagto(int ID, string Descricao)
            {
                this.ID = ID;
                this.Descricao = Descricao;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int op = comboBox1.SelectedIndex;
            lblEscolha.Text = op.ToString();

            switch (op)
            {
                case 0:
                    lblEscolha.Text = "Selecionar Opção";
                    break;
                case 1:
                    lblEscolha.Text = "Cartão";
                    listBox1.Items.Clear();
                    listBox1.Items.Add($"1x {double.Parse(textBox1.Text):F2}");
                    listBox1.Items.Add($"2x {((double.Parse(textBox1.Text)) / 2):F2}");
                    listBox1.Items.Add($"3x {((double.Parse(textBox1.Text)) / 3):F2}");
                    listBox1.Items.Add($"4x {((double.Parse(textBox1.Text)) / 4):F2}");
                    listBox1.Items.Add($"5x {((double.Parse(textBox1.Text)) / 5):F2}");
                    listBox1.Items.Add($"6x {((double.Parse(textBox1.Text)) / 6):F2}");
                    listBox1.Items.Add($"7x {((double.Parse(textBox1.Text)) / 7):F2}");
                    listBox1.Items.Add($"8x {((double.Parse(textBox1.Text)) / 8):F2}");
                    listBox1.Items.Add($"9x {((double.Parse(textBox1.Text)) / 9):F2}");
                    listBox1.Items.Add($"10x {((double.Parse(textBox1.Text)) / 10):F2}");
                    listBox1.Items.Add($"11x {((double.Parse(textBox1.Text)) / 11):F2}");
                    listBox1.Items.Add($"12x {((double.Parse(textBox1.Text)) / 12):F2}");
                    break;
                case 2:
                    lblEscolha.Text = "Boleto";
                    break;
                case 3:
                    lblEscolha.Text = "Pix";
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Chave Pix");
                    break;
                case 4:
                    lblEscolha.Text = "Dinheiro";
                    break;
                default:
                    lblEscolha.Text = "";
                    break;
            }
        }
    }
}
