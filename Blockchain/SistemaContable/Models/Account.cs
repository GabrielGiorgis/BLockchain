using System;

namespace Models
{
    [Serializable]
    public class Account
    {
        private String nombre;
        private float debe;
        private float haber;


        public string _Nombre { get => nombre; set => nombre = value; }
        public float _Debe { get => debe; set => debe = value; }
        public float _Haber { get => haber; set => haber = value; }

        public Account()
        {

        }
        public Account(string nombre, float monto, int debeOHaber)
        {
            this.nombre = nombre;

            if (debeOHaber == 0)
            {
                this.debe = monto;
            }
            else
            {
                this.haber = monto;
            }
        }

        public Account(string nombre, float debe, float haber)
        {
            this.nombre = nombre;
            this.haber = haber;
            this.debe = debe;
        }

    }
}