using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsFormsPubs.Models;

namespace WindowsFormsPubs.AdminDatos
{
    public class DacStore
    {
        PubsContext context = new PubsContext();
        public List<Store> Lista()
        {
            List<Store> lista = context.Stores.ToList();
            return lista;
        }
        public Store TraerUno(string id)
        {
            Store store = context.Stores.Find(id);
            return store;
        }
        public int Nuevo(Store store)
        {
            context.Stores.Add(store);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
        public int Modificar(Store store)
        {
            Store storeAModificar = new Store();
            storeAModificar = context.Stores.Find(store.Stor_id);
            if (storeAModificar != null)
            {
                storeAModificar.Stor_address = "Address 1";
                storeAModificar.Stor_name ="Nombre 1" ;
                storeAModificar.City = "ciudad 1";
                storeAModificar.State = "SS";
                storeAModificar.Zip = "4000";
            }
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
        public int Eliminar(Store store)
        {
            var storeEliminada = context.Stores.Find(store.Stor_id);

            if (store != null)
            {
                //context.Stores.Attach(store);
                 context.Stores.Remove(storeEliminada);
                //context.Entry(store).State = System.Data.Entity.EntityState.Deleted;
            }
            else
            {
                return 0;
            }

            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }

    }
}
