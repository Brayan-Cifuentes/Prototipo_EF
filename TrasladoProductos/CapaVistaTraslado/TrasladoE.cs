using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaTraslado
{
    public partial class TrasladoE : Form
    {
        public TrasladoE()
        {
            InitializeComponent();

            //Inicializacion
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            navegador1.funAsignarAliasVista(alias, "trasladoProductoE", "hotelSanCarlos");
            navegador1.funAsignarSalidadVista(this);

            //combobox
            navegador1.funLlenarComboControl(cbxBodegaOrigen, "bodegaTraslado", "idBodega", "nombre", "estado");
            navegador1.funLlenarComboControl(cbxBodegaDestino, "bodegaTraslado", "idBodega", "nombre", "estado");

            //campo estado
            navegador1.campoEstado = "estado";

            //ayuda 
            navegador1.idAplicacion = "4003";

            //ejecucion de ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";

            //asociacion con reporte
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");

            //tabla datagridview
            navegador1.pideGrid(this.dataGridView1);
            navegador1.llenaTabla();
            navegador1.pedirRef(this);

            // Permisos
            navegador1.usuario = nombreUsuario.nombre;
            navegador1.aplicacion = "Mantenimiento Traslado";
            //navegador1.funActualizarPermisos();

            navegador1.idmodulo = "4001";

            //ocultar botones
            txtEstatus.Visible = false;
            txtBodegaO.Visible = false;
            txtBodegaDestino.Visible = false;
            txtFecha.Visible = false;

        }

        private void cbxBodegaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cbxBodegaOrigen, txtBodegaO);
        }

        private void cbxBodegaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cbxBodegaDestino, txtBodegaDestino);
        }

        private void txtBodegaO_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cbxBodegaOrigen, txtBodegaO);
        }

        private void txtBodegaDestino_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cbxBodegaDestino, txtBodegaDestino);
        }

        private void rbtActivo_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus, rbtActivo, "A");
        }

        private void rbtInactivo_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus, rbtInactivo, "I");
        }

        private void txtEstatus_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(rbtActivo, rbtInactivo, txtEstatus);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            navegador1.funDPTextBoxVista(dateTimePicker1,txtFecha);
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextBoxDPTVista(dateTimePicker1, txtFecha);
            navegador1.funDPTextBoxVista(dateTimePicker1, txtFecha);
        }

        private void TrasladoE_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dataGridView1);
        }
    }
}
