// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace ConsoleApp.Conexion
{
    public class Equipos
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Ciudad { get; set; }

        public List<Jugadores>? Jugadores { get; set; }
    }

    public class Jugadores
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Equipo { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }
        public decimal Estatura { get; set; }

        public Equipos? _Equipo { get; set; }
    }
}