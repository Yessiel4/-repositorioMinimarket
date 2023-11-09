using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_MiniMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void miniMarketToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarMiniMarket objFrm = new FrmRegistrarMiniMarket();

            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;


        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
