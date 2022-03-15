#region Usos
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace InfraEstructura.Metodos
{
    internal class Acciones
    {
        string notas;

        public  string Notas { get => notas; set => notas = value; }

        public Acciones(global::System.String notas)
        {
            Notas = notas;
        }


        public Acciones()
        {
            Notas = string.Emply;
        }

    }
}