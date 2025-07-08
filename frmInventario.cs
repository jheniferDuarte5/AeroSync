using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase7
{
    public partial class frmInventario : Form
    {
        //Binding de Areas Empresas
        public BindingList<AreasEmpresas> listaEmpresas1;
        public frmInventario(BindingList<AreasEmpresas> listaEmpresas)
        {
            InitializeComponent();
            this.listaEmpresas1 = listaEmpresas;

            // llenar combo de ubicacion stock
            cboUbicacionStock.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboUbicacionStock.SelectedIndex = 0;

            //Saco los id de la lista
            var listaDeIds = listaEmpresas.Select(e => e.idArea).ToList();

            // Mpstar id al combo box
            cboIdAreaEmpresa.DataSource = listaDeIds;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboIdAreaEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {   

            
            // mostrar id que selecciono 
            int idSeleccionado = (int)cboIdAreaEmpresa.SelectedValue;

            // mostrar mensaje con id seleccionado
            // se muestra en la pantalla un mensaje

            MessageBox.Show("El id seleccionado es:" + idSeleccionado);

            if (idSeleccionado != null)
            { 

                // buscar el area con ese id 
               
                AreasEmpresas areaEmpresaEncontrado = listaEmpresas1.FirstOrDefault(e => e.idArea ==idSeleccionado);

                // agrego el nombre y el responsable a los textBox

                txtNombreAreaI.Text = areaEmpresaEncontrado.nombreArea;
                txtNombreResponsableI.Text = areaEmpresaEncontrado.responsableArea;

            }


            }
        }
}
