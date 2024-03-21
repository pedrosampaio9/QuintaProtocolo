
using UTAD.QuintaProtocolo.WPF.Models.Shared;

namespace UTAD.QuintaProtocolo.WPF.Models
{
    public class Periodicidade: BaseModel
    {
          public string Tipo { get; set; }

          public IList<string> DiasSemana { get; set; }
    }
}
