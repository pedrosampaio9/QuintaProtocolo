using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTAD.QuintaProtocolo.WPF.Models
{
    public abstract class Tarefa
    {
        protected Tarefa()
        {

            if (string.IsNullOrEmpty(Periodicidade))
                Periodicidade = Guid.NewGuid().ToString();

        }
        public string Periodicidade { get; set; }

        public string Titulo { get; set; }
        public string Descrição { get; set; }
        public IList<string> DataInicio { get; set; }

        public IList<string> DataTérmino { get; set; }

        public string NivelImportância { get; set; }

        public string Estado { get; set; }

        public bool AlertaAntecipação { get; set; } = false;

        public bool AlertaExecução { get; set; } = false;






    }
}
