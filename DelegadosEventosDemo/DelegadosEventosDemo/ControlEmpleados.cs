using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventosDemo
{
    class ControlEmpleados
    {
        
        public event Action EmpleadosCero;

        int numeroEmpleados = 5;
        public void ChecarSalida()
        {
            numeroEmpleados--;
            if (numeroEmpleados == 0)
            {
                if (EmpleadosCero != null)
                {
                    EmpleadosCero();
                }
            }
            else
            {
                Console.WriteLine($"Quedan {numeroEmpleados} empleados");
            }
        }
    }
}
