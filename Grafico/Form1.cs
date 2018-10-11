using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            Destinatario destino = new Destinatario();
            destino.destinatario = this.tbEmail.Text;
            destino.assunto = this.tbAssunto.Text;
            destino.mensagem = this.tbMensagem.Text;
            EnviarEmail.SentEmail(destino);
            MessageBox.Show("Mensagem enviada com sucesso!");
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
