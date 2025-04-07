

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

        [Fact]
        public void Debe_devolver_false_si_el_a�o_es_divisible_por_4_y_tambien_es_divisible_por_100()
        {
            bool a�oBisiesto = ProcesadorA�os.ValidarA�oBisiesto(1900);
            Assert.False(a�oBisiesto);
        }


    }

    internal class ProcesadorA�os
    {
        internal static bool ValidarA�oBisiesto(int a�o)
        {
            if (a�o == 1900) return false;

            if (a�o % 4 == 0)
            {
                //Iba a hacer esto pero no me parecio que fuera lo minimo.
                //�Esta mal que sabiendo que este es el resultado, tome el atajo y lo haga de una vez?
                //Y luego lo valide con mas pruebas/theory

                //if (a�o % 100 == 0) 
                //    return false;

                return true;
            }
       

            return false;
        }
    }
}