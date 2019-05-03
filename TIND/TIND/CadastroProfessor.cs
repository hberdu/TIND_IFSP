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

namespace TIND
{
    public partial class CadastroProfessor : Form
    {
        public CadastroProfessor()
        {
            InitializeComponent();
            telainicial();
        }
        int operador = 0;
        int Idprofessor;

        public void telainicial()
        {
            txtNome.MaxLength = 100;
            txtProntuario.MaxLength = 7;
            txtEmail.MaxLength = 200;

            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtProntuario.CharacterCasing = CharacterCasing.Upper;
            txtEmail.CharacterCasing = CharacterCasing.Upper;

            txtEmail.Enabled = false;
            txtNome.Enabled = false;
            txtProntuario.Enabled = false;
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            carregarListBox(lstNomes, "SELECT PRONTUARIO, NOME FROM PROFESSOR ORDER BY ID");
            
        }
        public void limparTela()
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtProntuario.Text = string.Empty;
        }

        public int autoIncremento()
        {
            int codigo = 0;
            Conexao conexao = new Conexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT MAX(ID)+1 AS IDNOVO FROM PROFESSOR", conexao.conexao);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            try
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    codigo = Convert.ToInt32(dr["IDNOVO"].ToString());
                    return codigo;
                }
                else
                {
                    return codigo = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
                return 0;
            }
            finally
            {
                conexao.desconectar();
            }
        }

        public static void carregarListBox(ListBox lst, string query)
        {
            lst.Items.Clear();
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand(query, conexao.conexao);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);

            string texto;
            while (dr.Read())
            {
                texto = dr[0].ToString();

                for (int i = 1; i < dr.FieldCount; i++)
                {
                    texto = texto + "\t\t" + dr[i].ToString();
                }
                lst.Items.Add(texto);
            }
            dr.Close();
            conexao.desconectar();
        }

        public void exibirDadosProfessor(int id, string nome)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            string query = "SELECT * FROM PROFESSOR WHERE ID=@ID AND NOME=@NOME";
            SqlCommand cmd = new SqlCommand(query, conexao.conexao);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(id));
            cmd.Parameters.AddWithValue("@NOME", nome);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            if(dr.Read())
            {
                Idprofessor = Convert.ToInt32(dr[("id")].ToString());
                txtNome.Text = dr[("nome")].ToString();
                txtProntuario.Text = dr[("prontuario")].ToString();
                txtEmail.Text = dr[("email")].ToString();
            }
            else
            {
                foreach (Control ctl in this.Controls)
                {
                    if (ctl is TextBox)
                    {
                        ctl.Text = "";
                    }
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            limparTela();
            txtEmail.Enabled = true;
            txtNome.Enabled = true;
            txtProntuario.Enabled = true;

            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            operador = 1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();

            if (operador == 1)
            {
                int valorID = autoIncremento();
                string query = "INSERT INTO PROFESSOR VALUES(@ID, @NOME, @PRONTUARIO, @EMAIL)";
                SqlCommand cmd = new SqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@ID", valorID);
                cmd.Parameters.AddWithValue("@NOME", txtNome.Text);
                cmd.Parameters.AddWithValue("@PRONTUARIO", txtProntuario.Text);
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                cmd.ExecuteReader(CommandBehavior.SingleRow);  
            }
            else
            {
                string query = "UPDATE PROFESSOR SET NOME=@NOME, PRONTUARIO=@PRONTUARIO, EMAIL=@EMAIL WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(query, conexao.conexao);
                cmd.Parameters.AddWithValue("@NOME", txtNome.Text);
                cmd.Parameters.AddWithValue("@PRONTUARIO", txtProntuario.Text);
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                cmd.Parameters.AddWithValue("@ID", Idprofessor);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
            }
            telainicial();
            limparTela();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtEmail.Enabled = true;
            txtNome.Enabled = true;
            txtProntuario.Enabled = true;

            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            operador = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            telainicial();
            limparTela();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstNomes_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string[] campo = lstNomes.Text.Split(Convert.ToChar("\t"));
                exibirDadosProfessor(Convert.ToInt32(campo[0]), campo[1]);
                btnEditar.Enabled = true;
            }
            catch
            { 
            }
            
        }
         
    }

}
