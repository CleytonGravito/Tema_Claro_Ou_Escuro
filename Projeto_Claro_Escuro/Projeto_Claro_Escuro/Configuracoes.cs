// Bibliotecas necessárias para a aplicação funcionar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Projeto_Claro_Escuro
{
    // Classe responsável por ler e escrever o arquivo de configurações (INI)
    class Configuracoes
    {
        // Caminho do arquivo INI (salvo na mesma pasta do aplicativo)
        public string iniPath = Application.StartupPath + @"\config.ini";

        // Importa função da API do Windows para ler arquivos INI
        [DllImport("Kernel32", CharSet = CharSet.Auto)]
        private static extern int GetPrivateProfileString(string sectionName, string KeyName, string defaultValue, StringBuilder returnedString, int Size, string fileName);
        
        // Importa função da API do Windows para escrever arquivos INI
        [DllImport("Kernel32")]
        private static extern long WritePrivateProfileString(string section, string keyname, string value, string path);

        // StringBuilder para armazenar o valor do tema lido do arquivo INI
        public StringBuilder sbTheme;
        
        // Propriedade que armazena o valor do tema (claro ou escuro)
        public string theme {  get; set; }
        
        // Método para ler a configuração do arquivo INI
        public void readIni()
        {
            int resultSize;
            sbTheme = new StringBuilder(10); // Cria um StringBuilder com capacidade de 10 caracteres

            // Lê o arquivo INI, buscando o valor da chave "key" na seção "SECTION"
            resultSize = GetPrivateProfileString("SECTION", "key", "", sbTheme, sbTheme.Capacity, iniPath);
            
            // Converte o valor lido em string e define a propriedade "theme"
            this.theme = sbTheme.ToString();
        }
       
        // Método para escrever no arquivo INI
        public void writeIni(string section, string key, string value) 
        {
            // Grava o valor fornecido no arquivo INI, na seção e chave especificadas
            WritePrivateProfileString(section, key, value, iniPath);
        }
    }
}
