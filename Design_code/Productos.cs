using System;
using System.Collections.Generic;
using System.Text;

namespace Design_code
{
    public class PRODUCTOS
    {
        public string idectificador;
        public string nombre;
        public string marca;
        public string visibilidad;
        public float precio_base;
        public float descuento;
    }

    public class COMÚN : PRODUCTOS
    {
        public string categoría;
        public string subcategoría;
    }

    public class ESPECIALIZADOS : PRODUCTOS
    {
        public string categoría;
        public string subcategoría;
        public string subcategoría2;
    }

    public class DIFERENTES : PRODUCTOS
    {
        public string categoría;
        public string subcategoría;
        public string subcategoría2;
    }
}
