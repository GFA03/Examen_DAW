using Examen_DAW.Server.Models.Base;

namespace Examen_DAW.Server.Models
{
    public class Profesor : BaseEntity
    {
        public string Name { get; set; }

        public string Type {  get; set; }

       public ICollection<ProfesorMaterie> ProfesoriMaterii { get; set; }
    }
}
