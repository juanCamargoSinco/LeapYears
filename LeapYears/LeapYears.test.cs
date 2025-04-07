

namespace LeapYears
{
    public class LeapYearsTest
    {
        [Fact]
        public void Debe_devolver_false_si_el_año_no_es_biciesto()
        {
            bool añoBiciesto = ProcesadorAños.ValidarAñoBiciesto(1993);
            Assert.False(añoBiciesto);
        }


    }

    internal class ProcesadorAños
    {
        internal static bool ValidarAñoBiciesto(int año)
        {
            throw new NotImplementedException();
        }
    }
}