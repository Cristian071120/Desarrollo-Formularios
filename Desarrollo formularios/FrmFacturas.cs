using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desarrollo_formularios
{
    public partial class FrmFacturas : Form
    {
        public FrmFacturas()
        {
            InitializeComponent();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
