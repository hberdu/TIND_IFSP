using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIND
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnCadastroP_Click(object sender, EventArgs e)
        {
            Forms.CadastroProfessor frm = new Forms.CadastroProfessor();           
            frm.ShowDialog();
  
        }

        private void btnCadastroM_Click(object sender, EventArgs e)
        {
            Forms.CadastroDeMatérias frm = new Forms.CadastroDeMatérias();
            frm.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
