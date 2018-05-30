namespace WebApplication8.Controllers
{
    internal class Usuario
    {
        public Usuario(string nombre, int Id)
        {
            this.nombre = nombre;
            this.Id = Id;
        }

        public Usuario()
        {
        }

        public string nombre { get; set; }
        public int Id { get; set; }
    }
}