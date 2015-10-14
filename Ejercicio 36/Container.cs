using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_36
{
    class Container
    {
        private int _capacidad;
        private string _empresa;
        private List<Producto> _listaProductos;

        public Container(int capacidad, string Empresa)
        {
            this._listaProductos = new List<Producto>();
            this._listaProductos.Capacity = capacidad;
            this._capacidad = capacidad;
            this._empresa = Empresa;

        }
        //-------------------------------------------------------------
        public static void Mostrar(Container Contenedor)
        {
            Console.WriteLine("-__-__Container__-__-\nEmpresa: " + Contenedor._empresa + "\nCapacidad: " + Contenedor._capacidad);
            foreach (Producto item in Contenedor._listaProductos)
            {
                item.mostrar();
            }
        }

        public bool Agregar(Producto proUno)
        {
            if(this._listaProductos.Count <= this._capacidad)
                if (this != proUno)
                {
                    this._listaProductos.Add(proUno);
                    return false;
                }
            return true;
        }
        //-------------------------------------------------------------
        public static bool operator ==(Container contenedor, Producto proUno)
        {
            foreach (Producto item in contenedor._listaProductos)
            {
                if (item == proUno)
                    return true;
            }
            return false;            
        }
        public static bool operator !=(Container contenedor, Producto proUno)
        {
            return !(contenedor == proUno);
        }

        public static List<Producto> operator -(Container contenedor, eTipoComestible tipo)
        {
            List<Producto> Lista = new List<Producto>();

            foreach (Producto item in contenedor._listaProductos)
            {
                if (item == tipo)
                    Lista.Add(item);
            }            
            return Lista;
        }


           
    }
}
