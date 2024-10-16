

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioClase
{
    public class SuperHeroe
    {
        public string Nombre { get; set; }
        public string identidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public bool puedeVolar { get; set; }
        
        
        public Superpoder superpoder;
        public SuperHeroe()    {
            superpoder = new Superpoder();
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {identidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede volar?: {puedeVolar}");
            Console.WriteLine($"Superpoder: {superpoder.nombre}");
            Console.WriteLine($"Descripción: {superpoder.descripcion}");
            Console.WriteLine($"Nivel: {superpoder.nivel}");
            Console.WriteLine();
        }
    }
}
