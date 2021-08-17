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
        /// <summary>
        /// Método para inicializar as janelas referêntes ao menu principal
        /// </summary>
        private void InitializeWindows()
        {
            //Armor Window
            Armors_Window = new F_ArmorsWindow();
            Armors_Window.TopLevel = false;
            Armors_Window.Dock = DockStyle.Fill;
            this.Panel_SelectedWindow.Controls.Add(Armors_Window);
            this.Panel_SelectedWindow.Tag = Armors_Window;

            //Artifact Window
            Artifact_Window = new F_ArtifactWindow();
            Artifact_Window.TopLevel = false;
            Artifact_Window.Dock = DockStyle.Fill;
            this.Panel_SelectedWindow.Controls.Add(Artifact_Window);
            this.Panel_SelectedWindow.Tag = Artifact_Window;

            //Weapon Window
            Weapons_Window = new F_WeaponsWindow();
            Weapons_Window.TopLevel = false;
            Weapons_Window.Dock = DockStyle.Fill;
            this.Panel_SelectedWindow.Controls.Add(Weapons_Window);
            this.Panel_SelectedWindow.Tag = Weapons_Window;

            //Statistics Window
            Statistics_Window = new F_StatisticsWindow();
            Statistics_Window.TopLevel = false;
            Statistics_Window.Dock = DockStyle.Fill;
            this.Panel_SelectedWindow.Controls.Add(Statistics_Window);
            this.Panel_SelectedWindow.Tag = Statistics_Window;
        }

        /// <summary>
        /// Esconde a janela aberta anteriormente
        /// </summary>
        /// <param name="index_WindowSelected"></param>
        private void HidePreviousWindow(int index)
        {
            switch (index)
            {
                case 1:
                    Armors_Window.Hide();
                    break;
                case 2:
                    Artifact_Window.Hide();
                    break;
                case 3:
                    Weapons_Window.Hide();
                    break;
                case 4:
                    Statistics_Window.Hide();
                    break;
                default:
                    Home_Window.Hide();
                    break;
            }
        }
    }
}