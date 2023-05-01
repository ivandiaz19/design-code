using System;
using System.Collections.Generic;
using System.Text;


namespace Design_code
{
    public class USUARIOS
    {
        private string nombre;
        private string apellidos;
        private int teléfono;
        private string email;
        private string dni;
        private string dirección;
        private string contraseña;
    }

    public class CARRITO : USUARIOS
    {
        public enum TYPE {Productos}
    }
}
