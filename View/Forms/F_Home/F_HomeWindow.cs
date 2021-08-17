using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class F_HomeWindow : Form
    {
        public F_HomeWindow(F_Main.F_MainWindow ref_MainForm)
        {
            InitializeComponent();

            ref_MainWindow = ref_MainForm;
            JSONImport_Status = false;
        }

        private F_Main.F_MainWindow ref_MainWindow;
        public bool JSONImport_Status;

        //Importar arquivo
        private void Btn_BrowseImport_Click(object sender, EventArgs e)
        {

        }
        private void btn_Import_Click(object sender, EventArgs e)
        {
            JSONImport_Status = true;

            if (JSONImport_Status)
            {
                ref_MainWindow.btn_MenuArmors.Enabled = true;
                ref_MainWindow.btn_MenuArtifact.Enabled = true;
                ref_MainWindow.btn_MenuWeapons.Enabled = true;
                ref_MainWindow.btn_MenuStatistics.Enabled = true;
            }
        }


        //Exportar arquivo
        private void Btn_BrowseExport_Click(object sender, EventArgs e)
        {

        }
        private void btn_Export_Click(object sender, EventArgs e)
        {

        }
    }
}
