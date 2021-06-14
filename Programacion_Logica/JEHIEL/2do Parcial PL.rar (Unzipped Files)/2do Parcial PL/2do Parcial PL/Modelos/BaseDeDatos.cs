using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2do_Parcial_PL.Models
{
    public static class BaseDeDatos
    {
        public static List<Departamento> Departamentos = new List<Departamento>();
        public static List<Material> Materiales = new List<Material>();

        public static void Cargar()
        {
            Material mat = new Material()
            {
                Nombre = "Material 1",
                Cantidad = 0
            };

            Departamento dep = new Departamento()
            {
                Nombre = "Departamento Uno",
                Direccion = "Avenida Verdadera 789",
                Material = mat
            };

            Departamentos.Add(dep);
            Materiales.Add(mat);

            mat = new Material()
            {
                Nombre = "Material 2",
                Cantidad = 0
            };

            dep = new Departamento()
            {
                Nombre = "Departamento Dos",
                Direccion = "Calle Falsa 321",
                Material = mat
            };

            Departamentos.Add(dep);
            Materiales.Add(mat);
        }
    }
}
