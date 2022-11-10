using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsPubs.Models;

namespace WindowsFormsPubs
{
    public partial class Form1 : Form
    {
        PubsContext context = new PubsContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Creamos la instancia
            Publisher publisher = new Publisher() {Pub_id="5005", City="Mendoza", Country="Argentina", Pub_name="MDZOL", State="MZ" };

            //DBset
            context.Publishers.Add(publisher);
            //Guardar en la base
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("OK");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string id = "5005";
            Publisher publisherDB = context.Publishers.Find(id);

            if (publisherDB != null)
            {
                publisherDB.Country = "Uruguay";
                publisherDB.City = "Montevideo";

            }
            else
            {
                MessageBox.Show("No existe registro con esa id");
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
            string id = "5005";
            Publisher publisherDB = context.Publishers.Find(id);

            if (publisherDB != null)
            {
                context.Publishers.Remove(publisherDB);
            }
            else
            {
                MessageBox.Show("No existe registro con esa id");
            }
            //Guardar en la base
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("OK Eliminado");
            }
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            List<Publisher> list = context.Publishers.ToList();
            gridPublishers.DataSource = list;
        }
    }
}
