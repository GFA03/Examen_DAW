using Examen_DAW.Server.Models.Base;

namespace Examen_DAW.Server.Models
{
    public class Materie : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<ProfesorMaterie> ProfesorMaterii {  get; set; }
    }
}
