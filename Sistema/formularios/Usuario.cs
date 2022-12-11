using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            cargarroles();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void cargarroles()
        {
            DataSet ds = new DataSet();
            clases.ClRoles s = new clases.ClRoles();
            clases.Conexion c = new clases.Conexion(s.consultageneral());
            ds = c.consultar();
            cdroles.DataSource = ds.Tables[0];
            cdroles.DisplayMember = ds.Tables[0].Columns["Nombre"].ToString();
            cdroles.ValueMember = ds.Tables[0].Columns["Clave"].ToString();

        }

        private void Guardar_Click(object sender, EventArgs e)
        {

        }
        /*byte puesto = 0;
               puesto = byte.parse
                (xmbpuesto.selectedvalue.tostring)
        
         byte */
        public string consultafeneral()
        {
            return ("select * ");
        }
    }
}
