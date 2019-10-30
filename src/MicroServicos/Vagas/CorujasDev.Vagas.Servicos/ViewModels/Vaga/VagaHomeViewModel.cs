using System;
using System.Collections.Generic;

namespace CorujasDev.Vagas.Servicos.ViewModels.Vaga
{
    public class VagaHomeViewModel
    {
        public int quantidade { get; set; }
        public IList<VagaViewModel> Vagas { get; set; }
    }
}
