using EjemploPooListas.Entidades;
using System.Runtime.CompilerServices;

namespace EjemploPooListas.Datos
{
    public class RepositorioDeCuadrados
    {
        #region
        private List<Cuadrado> cuadrados;
        #endregion
        #region Constructores
        public RepositorioDeCuadrados()
        {
            cuadrados= new List<Cuadrado>();    
        }
        #endregion
        #region Métodos (Comportamiento, habilidades)

        public void AgregarCuadrado(Cuadrado cuadrado)
        {
            cuadrados.Add(cuadrado);
        }
        public List<Cuadrado> GetLista() =>cuadrados;
        #endregion
    }
}
