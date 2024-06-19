using System;
using System.Runtime.Serialization;
using libreriaClases;

namespace libreria{

    class Principal{
        static void Main(){
            Persona p1 = new Persona("diego", "1/1/1", 56793958);

            Persona p2 = new Persona("Messi", "26/1/1", 3472943);
            Console.WriteLine(p1.caminar());

            p1.mostrarPersona();

            p2.mostrarPersona();
            
        }
    }
}