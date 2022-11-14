using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsPubs.Models;

namespace WindowsFormsPubs.AdminDatos
{
    public class DacAuthor
    {
        PubsContext context = new PubsContext();
        public List<Author> Lista()
        {
            List<Author> lista = context.Authors.ToList();
            return lista;
        }
        public Author TraerUno(string id)
        {
            Author author = context.Authors.Find(id);
            return author;
        }
        public int Nuevo(Author author)
        {
            context.Authors.Add(author);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
        public int Modificar(Author author)
        {
            Author authorAModificar = new Author();
            authorAModificar = context.Authors.Find(author.Au_id);
            if (authorAModificar != null)
            {
                authorAModificar.Address = "Address 1";
                authorAModificar.Au_lname = "Nombre 1";
                authorAModificar.City = "ciudad 1";
                authorAModificar.State = "SS";
                authorAModificar.Zip = "4000";
            }
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
        public int Eliminar(Author author)
        {
            var authorEliminado = context.Authors.Find(author.Au_id);

            if (author != null)
            {
                //context.Stores.Attach(store);
                context.Authors.Remove(authorEliminado);
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
