// Bibliotecas necessárias para a aplicação funcionar
using Projeto_Claro_Escuro.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Claro_Escuro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes da interface gráfica
            getIni(); // Carrega a configuração do tema ao iniciar o formulário
        }

        // Método para carregar a configuração do arquivo INI
        private void getIni() 
        {
            Configuracoes get = new Configuracoes(); // Cria uma instância da classe Configuracoes
            get.readIni(); // Lê o arquivo INI para verificar o tema salvo

            // Se o tema no arquivo for "dark", aplica o tema escuro
            if (get.theme == "dark")
            {
                label1.Text = "ESCURO"; // Atualiza o texto do label para "ESCURO"
                ToggleSwitch1.Checked = true; // Define o ToggleSwitch como ativado
                this.BackColor = Color.FromArgb(32, 33, 36); // Cor de fundo escura
                this.ForeColor = Color.White; // Cor do texto branca
            }
            // Mesmo processo que o anterior
            else 
            {
                label1.Text = "CLARO";
                ToggleSwitch1.Checked = false;
                this.BackColor = Color.White;
                this.ForeColor = Color.FromArgb(32, 33, 36);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Evento que ocorre quando o ToggleSwitch (interruptor) é alterado
        private void ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            Configuracoes set = new Configuracoes(); // Cria uma instância da classe Configuracoes

            // Se o ToggleSwitch for marcado (Checked == true), aplica o tema escuro
            if (ToggleSwitch1.Checked == true)
            {
                set.writeIni("SECTION", "key", "dark"); // Salva "dark" no arquivo INI
                this.BackColor = Color.FromArgb(32, 33, 36);
                this.ForeColor = Color.White;
                label1.Text = "ESCURO";
            }
            else 
            {
                // Se o ToggleSwitch for desmarcado, aplica o tema claro
                set.writeIni("SECTION", "key", "light"); // Salva "light" no arquivo INI
                this.BackColor = Color.White;
                this.ForeColor = Color.FromArgb(32, 33, 36);
                label1.Text = "CLARO";
            }
        }
    }
}
