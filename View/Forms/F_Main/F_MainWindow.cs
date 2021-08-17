using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.F_Main
{
    public partial class F_MainWindow : Form
    {
        public F_MainWindow()
        {
            InitializeComponent();
        }

        //Referência das Janelas
        protected View.F_HomeWindow Home_Window;
        protected View.F_ArmorsWindow Armors_Window;
        protected View.F_ArtifactWindow Artifact_Window;
        protected View.F_WeaponsWindow Weapons_Window;
        protected View.F_StatisticsWindow Statistics_Window;
        private int index_WindowSelected;

        //Inicialização do programa
        private void F_MainWindow_Load(object sender, EventArgs e)
        {
            /*
            */
            //Lockando abas para aguardar a importação do json
            btn_MenuArmors.Enabled = false;
            btn_MenuArtifact.Enabled = false;
            btn_MenuWeapons.Enabled = false;
            btn_MenuStatistics.Enabled = false;

            //Define index inicial
            index_WindowSelected = 0;

            //Iniciando janela principal
            Home_Window = new F_HomeWindow(this);
            Home_Window.TopLevel = false;
            Home_Window.Dock = DockStyle.Fill;
            this.Panel_SelectedWindow.Controls.Add(Home_Window);
            this.Panel_SelectedWindow.Tag = Home_Window;
            Home_Window.Show();

            InitializeWindows();
        }

        //Métodos dos menus principais do programa
        private void btn_MenuHome_CheckedChanged(object sender, EventArgs e)
        {
            //Esconde janela anterior
            HidePreviousWindow(index_WindowSelected);

            //Define index atual
            index_WindowSelected = 0;

            //Iniciando janela
            Home_Window.Show();
        }
        private void btn_MenuArmors_CheckedChanged(object sender, EventArgs e)
        {
            //Esconde janela anterior
            HidePreviousWindow(index_WindowSelected);

            //Define index atual
            index_WindowSelected = 1;

            //Iniciando janela
            Armors_Window.Show();
            
        }
        private void btn_MenuArtifact_CheckedChanged(object sender, EventArgs e)
        {
            //Esconde janela anterior
            HidePreviousWindow(index_WindowSelected);

            //Define index atual
            index_WindowSelected = 2;

            //Iniciando janela
            Artifact_Window.Show();
        }
        private void btn_MenuWeapons_CheckedChanged(object sender, EventArgs e)
        {
            //Esconde janela anterior
            HidePreviousWindow(index_WindowSelected);

            //Define index atual
            index_WindowSelected = 3;

            //Iniciando janela
            Weapons_Window.Show();
        }
        private void btn_MenuStatistics_CheckedChanged(object sender, EventArgs e)
        {
            //Esconde janela anterior
            HidePreviousWindow(index_WindowSelected);

            //Define index atual
            index_WindowSelected = 4;

            //Iniciando janela
            Statistics_Window.Show();
        }
    }
}
