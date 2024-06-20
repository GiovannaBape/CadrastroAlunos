using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadrastroAlunos
{
    public partial class Cadastro : Form
    {
        int matricula = 0;
        string sexoEsc = "";
        string turnoEsc = "";
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matricula += 1;
            txtMatricula.Text = matricula.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            // salvar-feito
            string codigo = mskTxtCodigo.Text;
            string curso = txtCurso.Text;
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text; 
            string rg = mskTxtRg.Text;
            string cpf = msktxtCpf.Text;
            string Email = txtEmail.Text;
            string telefone = msktxtTelefone.Text;
            string turno = turnoEsc;
            string sexo = sexoEsc;

            try
            {
                if (!msktxtCpf.MaskCompleted || !msktxtTelefone.MaskCompleted || !msktxtDataNasc.MaskCompleted || !mskTxtRg.MaskCompleted || !mskTxtCodigo.MaskCompleted)
                {
                    string titulo = "CUIDADO!";
                    string msn = "Máscara incompleta";
                    MessageBox.Show(msn, titulo, MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation); 
                }
                else
                {
                    if (!Email.Contains('@') || !Email.Contains(".com"))
                    {
                        string titulo2 = "INVÁLIDO!";
                        string msn2 = "Seu e-mail não está dentro dos padrões,digite novamente.";
                        MessageBox.Show(msn2, titulo2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtEmail.Text = "";
                    }
                    else
                    {
                        string data = msktxtDataNasc.Text;
                        DateTime datanasc = DateTime.Parse(data);
                        Console.WriteLine(datanasc.Day + datanasc.Month + datanasc.Year);

                        txtMatricula.Text = matricula.ToString();

                        dtGrid.Rows.Add(txtMatricula.Text, mskTxtCodigo.Text, txtCurso.Text, txtNome.Text, txtSobrenome.Text, mskTxtRg.Text, msktxtCpf.Text, msktxtDataNasc.Text, txtEmail.Text, msktxtTelefone.Text, turnoEsc, sexoEsc);

                        string titulo = "Sucesso!";
                        string msn = "O aluno " + txtNome.Text + " " + txtSobrenome.Text + " foi registrado com sucesso!";
                        MessageBox.Show(msn, titulo, MessageBoxButtons.OK);

                        matricula += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                string titulo = "ERRO!";
                MessageBox.Show(ex.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //
        }
        private void gpBoxTurno_Enter(object sender, EventArgs e)
        {
            //
        }
        private void rbMatutino_CheckedChanged(object sender, EventArgs e)
        {
            turnoEsc = "Matutino";
        }
        private void rdVespertino_CheckedChanged(object sender, EventArgs e)
        {
            turnoEsc = "Vespertino";
        }
        private void rbNoturno_CheckedChanged(object sender, EventArgs e)
        {
            turnoEsc = "Noturno";
        }
        private void rbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            sexoEsc = "Feminino";
        }
        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            sexoEsc = "Masculino";
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                mskTxtCodigo.Text = "";
                txtCurso.Text = "";
                txtNome.Text = "";
                txtSobrenome.Text = "";
                mskTxtRg.Text = "";
                msktxtCpf.Text = "";
                string data = msktxtDataNasc.Text = " ";
                txtEmail.Text = "";
                msktxtTelefone.Text = "";
                rbFeminino.Checked = false;
                rbMasculino.Checked = false;
                rbMatutino.Checked = false;
                rbVespertino.Checked = false;
                rbNoturno.Checked = false;
            }
            catch (Exception ex)
            {
                string titulo = "ERRO!";
                MessageBox.Show(ex.Message,titulo,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //MINIMIZAR
            this.WindowState = FormWindowState.Minimized;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //
        }
    }
}
