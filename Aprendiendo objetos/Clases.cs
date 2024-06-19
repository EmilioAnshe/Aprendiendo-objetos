using System.Diagnostics.Contracts;

namespace libreriaClases{

    class Persona{

        public string Nombre;

        public string FechaNacimiento;

        public int dni;

        public Persona(string rNombre, string rFechaNacimiento, int rdni){
            Nombre = rNombre;
            FechaNacimiento = rFechaNacimiento;
            dni = rdni;



        }

        public string caminar(){
            return "Caminando";
        }

        public void mostrarPersona(){
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine(Nombre, "FechaNacimiento: {0}", FechaNacimiento);
            Console.WriteLine("dni: {0}", dni);
        }

    }
}
