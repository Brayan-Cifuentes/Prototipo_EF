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
    public partial class TrasladoD : Form
    {
        public TrasladoD()
        {
            InitializeComponent();

            //Inicializacion
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            navegador1.funAsignarAliasVista(alias, "trasladoProductoD", "hotelSanCarlos");
            navegador1.funAsignarSalidadVista(this);

            //combobox
            navegador1.funLlenarComboControl(cbxTraslado, "trasladoProductoE", "idTrasladoE", "idTrasladoE", "estado");
            navegador1.funLlenarComboControl(cbxInventario, "inventarioTraslado", "idInventario", "idInventario", "estado");
            navegador1.funLlenarComboControl(cbxProducto, "productoTraslado", "idProducto", "nombre", "estado");

            //campo estado
            //navegador1.campoEstado = "estado";

            //ayuda 
            navegador1.idAplicacion = "4004";

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
            txtTraslado.Visible = false;
            txtInventario.Visible = false;
            txtProducto.Visible = false;
            

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dataGridView1);
        }

        private void cbxTraslado_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cbxTraslado, txtTraslado);
        }

        private void cbxInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cbxInventario, txtInventario);
        }

        private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cbxProducto, txtProducto);
        }

        private void txtTraslado_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cbxTraslado, txtTraslado);
        }

        private void txtInventario_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cbxInventario, txtInventario);
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cbxProducto, txtProducto);
        }

        private void TrasladoD_Load(object sender, EventArgs e)
        {

        }
    }
}
