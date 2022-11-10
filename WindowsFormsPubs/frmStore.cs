using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsPubs.AdminDatos;
using WindowsFormsPubs.Models;
using static System.Windows.Forms.AxHost;

namespace WindowsFormsPubs
{
    public partial class frmStore : Form
    {
        DacStore dacStore = new DacStore();
        public frmStore()
        {
            InitializeComponent();
        }
        PubsContext pubsContext = new PubsContext();    

        private void btnListar_Click(object sender, EventArgs e)
        {
            gridStore.DataSource = dacStore.Lista();
        }

        private void btnTraerUno_Click(object sender, EventArgs e)
        {
            var store = dacStore.TraerUno("6380");
            MessageBox.Show(store.Stor_name + "\n" + store.Stor_address + "\n" + store.City + "\n" + store.State + "\n" + store.Zip);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Store store = new Store() { Stor_id="4454", Stor_name="Nueva Tienda", Stor_address= "Viamonte 2899", City="Lujan de Cuyo", State="MZ",Zip= "5505"};
            int filasAfectadas = dacStore.Nuevo(store);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("OK");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = "4444";
            Store storeAEliminar = pubsContext.Stores.Find(id);

            int filasAfectadas = dacStore.Eliminar(storeAEliminar);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("OK eliminado");
            }
            else
            {
                MessageBox.Show("No existe el objeto");
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
