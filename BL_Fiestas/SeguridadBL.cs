using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Fiestas
{
    public class SeguridadBL
    {
        Contexto _contexto;
        public SeguridadBL()
        {
            _contexto = new Contexto();
        }
        public bool Autorizar(string Usuario, string Contraseña)
        {
            var usuarios = _contexto.Usuarios.ToList();

            foreach (var usuarioBD in usuarios)
            {
                if (Usuario == usuarioBD.Nombre &&  Contraseña == usuarioBD.Password)
                {
                    return true;
                }

            }
                  

                        return false;
          }
                
            
        
    }
}
