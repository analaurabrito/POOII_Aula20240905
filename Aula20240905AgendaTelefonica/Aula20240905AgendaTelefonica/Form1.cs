using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula20240905AgendaTelefonica
{
    public partial class AgendaTelefonica : Form
    {
        public AgendaTelefonica()
        {
            InitializeComponent();
        }


        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (chbxTermos.Checked)
            {
                Contato contato = new Contato(txbNome.Text.ToString(), txbTelefone.Text.ToString(), cbxTipo.SelectedItem.ToString());
            }

            else
            {
                MessageBox.Show("Os termos devem ser aceitos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
