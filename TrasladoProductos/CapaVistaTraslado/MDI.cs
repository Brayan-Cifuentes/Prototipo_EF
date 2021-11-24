using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;
using CapaVistaReporte;
using CapaVista;

namespace CapaVistaTraslado
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDI_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                nombreUsuario.nombre = txtUsuario.Text;

            }
            else
            {
                this.Close();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            {
                this.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMIDSeguridad seguridad = new frmMIDSeguridad();
            seguridad.Show();
        }

        private void mantenimientoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoProducto form = new frmMantenimientoProducto();
            form.MdiParent = this;
            form.Show();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ReporteadorAdmin repo = new ReporteadorAdmin();
            repo.Show();
        }

        private void consultasInteligentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuconsultas consultas = new menuconsultas();
            consultas.Show();
        }

        private void mantenimientoBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoBodega form = new frmMantenimientoBodega();
            form.MdiParent = this;
            form.Show();
        }

        private void trasladoEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrasladoE form = new TrasladoE();
            form.MdiParent = this;
            form.Show();
        }

        private void trasladoDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrasladoD form = new TrasladoD();
            form.MdiParent = this;
            form.Show();
        }
    }
}
