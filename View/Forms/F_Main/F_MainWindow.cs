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

        //Inicialização do programa
        private void F_MainWindow_Load(object sender, EventArgs e)
        {
            //Lockando abas para aguardar a importação do json
            btn_MenuArmors.Enabled = false;
            btn_MenuAcessories.Enabled = false;
            btn_MenuWeapons.Enabled = false;
            btn_MenuStatistics.Enabled = false;
            /*
            */

            //Iniciando janela principal
            Home_Window = new F_HomeWindow();
            Home_Window.TopLevel = false;
            Home_Window.Dock = DockStyle.Fill;
            this.Panel_SelectedWindow.Controls.Add(Home_Window);
            this.Panel_SelectedWindow.Tag = Home_Window;
            Home_Window.Show();
            
        }
    }
}
