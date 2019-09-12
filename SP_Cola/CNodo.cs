using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SP_Cola
{
    public class CNodo
    {
        // campos privados de la clase
        private int nroHC;
        private string nombre;
        private CNodo siguiente;

        // propiedades publicas de la clase
        public int NroHC { get => nroHC; set => nroHC = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public CNodo Siguiente { get => siguiente; set => siguiente = value; }

        // constructor de la clase, inicializa todos los campos con valores determinados
        public CNodo()
        {
            nroHC = 0;
            nombre = "";
            siguiente = null; // el valor nulo indica que el nodo creado no está enlazado con ningún otro objeto
        }

    }
}