namespace EjemploPooListas.Entidades
{
    public class Cuadrado
    {
        #region Atributos
        private int lado;
        #endregion
        #region Propiedades
        //public int Lado { get; set; }
        public int Lado
        {
            get { return lado; }
            set
            {
                if (value >= 1 && value <= 10)
                {

                    lado = value;
                }
                else
                {
                    throw new ArgumentException("Valor fuera del rango");
                }
            }
        }

        #endregion
        #region Constructores
        public Cuadrado()
        {

        }
        public Cuadrado(int medidaLado)
        {
            Lado = medidaLado;
        }
        #endregion
        #region Métodos (Comportamiento)
        public double GetPerimetro() => 4 * lado;
        public double GetSuperficie() => Math.Pow(lado, 2);
        #endregion
    }
}
