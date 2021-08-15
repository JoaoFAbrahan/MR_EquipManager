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
        public F_HomeWindow()
        {
            InitializeComponent();

            JSONImport_Status = false;
        }

        public bool JSONImport_Status;

        private void button1_Click(object sender, EventArgs e)
        {
            JSONImport_Status = true;
        }
    }
}
