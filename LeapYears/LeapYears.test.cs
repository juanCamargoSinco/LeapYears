

namespace LeapYears
{
    public class LeapYearsTest
    {
        [Fact]
        public void Debe_devolver_false_si_el_año_no_es_bisiesto()
        {
            bool añoBisiesto = ProcesadorAños.ValidarAñoBisiesto(1993);
            Assert.False(añoBisiesto);
        }

        [Fact]
        public void Debe_devolver_true_si_el_año_es_bisiesto()
        {
            bool añoBisiesto = ProcesadorAños.ValidarAñoBisiesto(1996);
            Assert.True(añoBisiesto);
        }

        [Fact]
        public void Debe_devolver_año_es_bisiesto_si_el_año_es_divisible_por_4()
        {
            bool añoBisiesto = ProcesadorAños.ValidarAñoBisiesto(2004);
            Assert.True(añoBisiesto);
        }

        [Theory]
        [InlineData(1900)]
        [InlineData(2100)]
        [InlineData(1800)]
        [InlineData(1600)]
        public void Debe_devolver_false_si_el_año_es_divisible_por_4_y_tambien_es_divisible_por_100(int año)
        {
            bool añoBisiesto = ProcesadorAños.ValidarAñoBisiesto(año);
            Assert.False(añoBisiesto);
        }

        [Fact]
        public void Debe_devolver_true_si_el_año_es_divisible_por_4_por_100_y_por_400()
        {
            bool añoBisiesto = ProcesadorAños.ValidarAñoBisiesto(1600);
            Assert.True(añoBisiesto);
        }

    }

    internal class ProcesadorAños
    {
        internal static bool ValidarAñoBisiesto(int año)
        {


            if (año % 4 == 0)
            {
                if (año % 100 == 0)
                    return false;

                return true;
            }
       

            return false;
        }
    }
}