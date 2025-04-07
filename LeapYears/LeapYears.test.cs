

namespace LeapYears
{
    public class LeapYearsTest
    {
        [Fact]
        public void Debe_devolver_false_si_el_a�o_no_es_bisiesto()
        {
            bool a�oBisiesto = ProcesadorA�os.ValidarA�oBisiesto(1993);
            Assert.False(a�oBisiesto);
        }

        [Fact]
        public void Debe_devolver_true_si_el_a�o_es_bisiesto()
        {
            bool a�oBisiesto = ProcesadorA�os.ValidarA�oBisiesto(1996);
            Assert.True(a�oBisiesto);
        }

        [Fact]
        public void Debe_devolver_a�o_es_bisiesto_si_el_a�o_es_divisible_por_4()
        {
            bool a�oBisiesto = ProcesadorA�os.ValidarA�oBisiesto(2004);
            Assert.True(a�oBisiesto);
        }



    }

    internal class ProcesadorA�os
    {
        internal static bool ValidarA�oBisiesto(int a�o)
        {
            if (a�o % 4 == 0) 
                return true;

            return false;
        }
    }
}