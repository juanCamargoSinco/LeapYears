

namespace LeapYears
{
    public class LeapYearsTest
    {
        [Fact]
        public void Debe_devolver_false_si_el_a�o_no_es_biciesto()
        {
            bool a�oBiciesto = ProcesadorA�os.ValidarA�oBiciesto(1993);
            Assert.False(a�oBiciesto);
        }


    }

    internal class ProcesadorA�os
    {
        internal static bool ValidarA�oBiciesto(int a�o)
        {
            throw new NotImplementedException();
        }
    }
}