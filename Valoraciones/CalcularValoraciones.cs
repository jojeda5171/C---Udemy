namespace Valoraciones
{
    public class CalcularValoraciones
    {
        public float ValoracionMaxima;
        public float ValoracionMinima;
        public float ValoracionPromedio;
        internal string valoracionMinima;

        public CalcularValoraciones()
        {
            ValoracionMinima = float.MaxValue;
        }
    }
}
