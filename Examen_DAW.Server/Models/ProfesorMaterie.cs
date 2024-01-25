namespace Examen_DAW.Server.Models
{
    public class ProfesorMaterie
    {
        public Guid ProfesorId { get; set; }
        public Profesor Profesor { get; set; }

        public Guid MaterieId { get; set; }
        public Materie Materie { get; set;}
    }
}
