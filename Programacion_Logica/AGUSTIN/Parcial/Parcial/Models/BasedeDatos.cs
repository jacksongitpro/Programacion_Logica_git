﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public static class BasedeDatos
    {
        public static List<Empleado> ListaEmpleados = new List<Empleado>();

        public static void Cargar()
        {


            Empleado emp1 = new Empleado();
            emp1.Nombre = "Fernando Galvez";
            emp1.Dni = 38401865;
            emp1.Matricula = 123321;
            Empleado emp2 = new Empleado();
            emp2.Nombre = "Gaston Robles";
            emp2.Dni = 33561867;
            emp2.Matricula = 876321;
            Empleado emp3 = new Empleado();
            emp3.Nombre = "Martin Peralta";
            emp3.Dni = 35401266;
            emp3.Matricula = 423351;
            Empleado emp4 = new Empleado();
            emp4.Nombre = "Ruben caré";
            emp4.Dni = 37653865;
            emp4.Matricula = 999342;
            Empleado emp5 = new Empleado();
            emp5.Nombre = "Nicolas Tabares";
            emp5.Dni = 38543781;
            emp5.Matricula = 234876;
            Empleado emp6 = new Empleado();
            emp6.Nombre = "Morena Leyes";
            emp6.Dni = 35987321;
            emp6.Matricula = 643897;
           
            
            ListaEmpleados.Add(emp1);
            ListaEmpleados.Add(emp2);
            ListaEmpleados.Add(emp3);
            ListaEmpleados.Add(emp4);
            ListaEmpleados.Add(emp5);
            ListaEmpleados.Add(emp6);
          


        }
    }
}
