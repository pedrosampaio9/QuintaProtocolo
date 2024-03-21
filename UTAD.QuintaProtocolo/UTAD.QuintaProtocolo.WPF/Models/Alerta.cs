
using UTAD.QuintaProtocolo.WPF.Models.Shared;

namespace UTAD.QuintaProtocolo.WPF.Models
{
    public class Alerta: BaseModel
    {

       public string Mensagem { get; set; }

       public DateTime DataHora { get; set; }

       public IList<string> Tipos { get; set; }

        public bool desligado { get; set; } = false; 
    }
}
