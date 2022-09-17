using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using CapaControlador;
using System.Data;
using System.Data.Odbc;

namespace CapaVista
{
    public partial class Consulta : Form
    {
        Controlador cn = new Controlador();
        string emp = "Usuarios";
        public Consulta()
        {
            InitializeComponent();
        }
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
