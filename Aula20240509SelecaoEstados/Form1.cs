using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula20240509SelecaoEstados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txbAdicionar.Text.ToString() != "" &&
                txbAdicionar.Text.ToString() != " ")
            {
                cbxEstados.Items.Add(txbAdicionar.Text.ToString().ToUpper());
                txbAdicionar.Clear();
            }
            else {
                MessageBox.Show("Digite um estado");
            }
        }

        private void btnCopiarTodos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbxEstados.Items.Count; i++) { 
                lbxTodosEstados.Items.Add(cbxEstados.Items[i].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aux = lbxTodosEstados.SelectedItems.Count;
            if (aux > 0)
            {
                foreach (var v in lbxTodosEstados.SelectedItems) { 
                    lbxEstadosSelecionados.Items.Add(v.ToString()); 
                }
            }
            else {
                MessageBox.Show("Selecione pelo menos 1.");
            }


            

        }
    }
}
