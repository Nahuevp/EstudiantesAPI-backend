namespace Estudiantes.Backend
{
    public class Estudiantes
    {
        //Entity - Tabla Db
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Edad { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Curso { get; set; }
    }
    public class CrearActualizar
    {
        //Actualizar - Update
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Edad { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Curso { get; set; }
    }
}
