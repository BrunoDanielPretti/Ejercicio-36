using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_36
{
    class Producto
    {
        private int _codigoDeBarra;
        private string _nombre;
        private double _precio;
        public eTipoComestible _tipo;


        private Producto(int codigoDeBarra)
        {
            this._codigoDeBarra = codigoDeBarra;
        }
        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo)
            : this(codigoDeBarra)
        {
            this._nombre = nombre;
            this._tipo = tipo;
        }
        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo, double precio)
            : this(codigoDeBarra, nombre, tipo)
        {
            this._precio = precio;
        }
        
        
        //---------------------------------------------------------
        public void mostrar()
        {
            Console.WriteLine("Nombre: " + this._nombre + "\nTipo: " + this._tipo + "\nCodigo: " + this._codigoDeBarra + "\nPrecio: " + this._precio);
        }

        //---------------------------------------------------------
        public static bool operator ==(Producto proUno, Producto proDos)
        {
            if (proUno._nombre == proDos._nombre)
                if (proUno._codigoDeBarra == proDos._codigoDeBarra)
                    if (proUno._tipo == proDos._tipo)
                        if (proUno._precio == proDos._precio)
                            return true;
            return false;
        }
        public static bool operator !=(Producto proUno, Producto proDos)
        {
            return !(proUno == proDos);
        }

        public static bool operator ==(Producto proUno, eTipoComestible tipo)
        {
            if (proUno._tipo == tipo)
                return true;
            return false;
        }
        public static bool operator !=(Producto proUno, eTipoComestible tipo)
        {
            return !(proUno == tipo);
        }
        
    }
}
