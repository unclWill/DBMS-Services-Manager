using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DBMS_Services_Manager.View.AboutFormView
{
    internal class AboutBox
    {
        private string programName;
        private string description;
        private string developerName;
        private string developerRepositories;
        private string developerEmail;
        private string version;
        private string copyright;

        public AboutBox(string programName, string description, string developerName, string developerRepositories, string developerEmail, string version, string copyright)
        {
            this.programName = programName;
            this.description = description;
            this.developerName = developerName;
            this.developerRepositories = developerRepositories;
            this.developerEmail = developerEmail;
            this.version = version;
            this.copyright = copyright;
        }

        public string ProgramName { get => programName; set => programName = value; }
        public string Description { get => description; set => description = value; }
        public string DeveloperName { get => developerName; set => developerName = value; }
        public string DeveloperRepositories { get => developerRepositories; set => developerRepositories = value; }
        public string DeveloperEmail { get => developerEmail; set => developerEmail = value; }
        public string Version { get => version; set => version = value; }
        public string Copyright { get => copyright; set => copyright = value; }

        public static void About()
        {
            MessageBox.Show(
            "DBMS Services Manager - Versão: 1.0.14.02.24-alpha\n" +
            "Gerenciador de Serviços de Bancos de Dados para Windows.\n\n" +
            "Desenvolvido por: William Silva\n" +
            "Repositórios: github.com/unclWill\n" +
            "Contato: william.silva@viannasempre.com.br \n\n" +
            "© 2022-2024 VESO Software. Direitos reservados.", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
