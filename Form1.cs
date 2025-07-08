using System.ComponentModel;

namespace Clase7
{
    public partial class frmPrincipal : Form
    {


        // TRAER DATOS copio y pego de donde quiera y lo pongo en el archivo de esta clase

        public BindingList<AreasEmpresas> ListaEmpresas = new BindingList<AreasEmpresas>();

        public int contador = 0;

        public frmPrincipal()
        {
            InitializeComponent();

            // contador para el id 
            txtIdArea.Text = contador.ToString();


        }

        //Para mostrar las opciones en el Combo Box


        private void btnCreateAreasEmpresas_Click(object sender, EventArgs e)
        {
            contador++;
            // creamos el objeto a enlazar
            AreasEmpresas areasEmpresas = new AreasEmpresas();

            // llenar los atributos del objeto con los datos de los textBox

            areasEmpresas.idArea = contador;
            areasEmpresas.nombreArea = txtIdArea.Text;
            areasEmpresas.responsableArea = txtResponsabledelArea.Text;

            // Binding enlazar el objeto o datos a mi grid
            ListaEmpresas.Add(areasEmpresas);


            // Actualizar mi Grid  (Datasource)

            grdAreasEmpresas.DataSource = ListaEmpresas;

        }

        private void grdAreasEmpresas_SelectionChanged(object sender, EventArgs e)
        {
            if (grdAreasEmpresas.CurrentRow != null && grdAreasEmpresas.CurrentRow.DataBoundItem != null)
            {
                AreasEmpresas areaEmpresaSeleccionada = (AreasEmpresas)grdAreasEmpresas.CurrentRow.DataBoundItem; //Mostramos en TextBox
                txtIdArea.Text = areaEmpresaSeleccionada.idArea.ToString();
                txtResponsabledelArea.Text = areaEmpresaSeleccionada.nombreArea;
                txtResponsabledelArea.Text = areaEmpresaSeleccionada.responsableArea;
            }


        }

        private void btnGestionarInventario_Click(object sender, EventArgs e)
        {
            frmInventario frmInventariof = new frmInventario(ListaEmpresas);
            //frmInventariof.Show(); // no es modal 
            frmInventariof.ShowDialog(); // es modal



        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Sin atributos queda funcionando el textbox
            string[] areas = { "Inventario", "Producción", "Mercadeo", "Finanzas" };
            cboNombreArea.Items.AddRange(areas);
        }

        //private void lblNombredelArea_Click(object sender, EventArgs e)
        //{

        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
