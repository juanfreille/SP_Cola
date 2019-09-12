using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SP_Cola
{
    public class CCola
    {
        // campos privados de la clase CCola
        private CNodo primero;
        private CNodo ultimo;

        // propiedades públicas de la clase
        public CNodo Primero { get => primero; set => primero = value; }
        public CNodo Ultimo { get => ultimo; set => ultimo = value; }

        // constructor de la clase
        public CCola()
        {
            primero = null; // el valor nulo significa que no hay nodos en la cola
            ultimo = null;  // representa una estructura vacìa (sin nodos)
        }

        // métodos públicos de la clase
        // método Crear, se ejecuta cuando se agrega el primer nodo a la estructura de Cola
        public void Crear(CNodo nuevo)
        {
            if(primero == null && ultimo == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }else
            {
                Insertar(nuevo);
            }
        }

        // método Insertar, se ejecuta cuando la estructura de Cola ya tiene al menos un nodo
        // el nodo agregado se ubicará al final
        public void Insertar(CNodo nuevo)
        {
            if(primero != null && ultimo != null)
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
            else
            {
                Crear(nuevo);
            }
        }

        // método Eliominar, remueve de la estructura el primer nodo y lo devuelve para su proceso
        // el método devuelve una copia del nodo eliminado o nulo si ya no hay más nodos.
        public CNodo Eliminar()
        {
            CNodo nodo = primero;
            if(primero != null)
            {
                primero = primero.Siguiente;
                if(primero == null)
                {
                    ultimo = null;
                }
            }
            return nodo;
        }

        // método Listar, recorre todos los nodos de la estructura y los agrega a una colección de tipo CNodo
        // el método devuelve la colección generada
        public List<CNodo> Listar()
        {
            List<CNodo> nodos = new List<CNodo>();
            CNodo nodo = primero;
            while(nodo != null)
            {
                nodos.Add(nodo);
                nodo = nodo.Siguiente;
            }
            return nodos;
        }

        // método Buscar, recibe por parámetro un númmero de historia clínica, recorre los nodos de la estructura y
        // si encuentra ese número de HC detiene la búsqueda y devuelve el nodo encontrado, en caso contrario retorna nulo
        public CNodo Buscar(int nro)
        {
            return null;
        }
    }
}