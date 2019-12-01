using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Fiestas
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var usuario1 = new Usuario();
            usuario1.Nombre = "Ana";
            usuario1.Password = "123";
            contexto.Usuarios.Add(usuario1);


            var usuario2 = new Usuario();
            usuario2.Nombre = " Reyna";
            usuario2.Password = "456";
            contexto.Usuarios.Add(usuario2);


            var usuario3 = new Usuario();
            usuario3.Nombre = "Carlos";
            usuario3.Password = "789";
            contexto.Usuarios.Add(usuario3);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Mesas";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Sillas";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Manteles";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Descripcion = "Salones";
            contexto.Categorias.Add(categoria4);


            base.Seed(contexto);
        }
    }
}
