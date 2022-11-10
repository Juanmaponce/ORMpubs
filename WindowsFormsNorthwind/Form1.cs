using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsNorthwind.Models;

namespace WindowsFormsNorthwind
{
    public partial class Form1 : Form
    {
        //Creamos instancia EF
        NorthwindContext context = new NorthwindContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            //Creamos la instancia
            Shipper shipper = new Shipper() { CompanyName = "Express SRL", Phone = "(503) 555-9001" };

            //DBset
            context.Shippers.Add(shipper);
            //Guardar en la base
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("OK");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Buscar Shipper
            int id = 4;
            Shipper shipperDB = context.Shippers.Find(id);

            if (shipperDB != null)
            {
                shipperDB.CompanyName = "Express Latam SRL";
                shipperDB.Phone = "(503) 555-0001";

            }
            //Guardar en la base
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("OK");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            Shipper shipperDB = context.Shippers.Find(id);

            if (shipperDB != null)
            {
                //Remover 
                context.Shippers.Remove(shipperDB);
            }
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("OK");
            }
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            List<Shipper> list = context.Shippers.ToList();

            gridShippers.DataSource = list;
        }
    }
}
