using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SocketMSG<T>
    {
        public string Metodo { get; set; }

        public T Entidad { get; set; }

    }
}
