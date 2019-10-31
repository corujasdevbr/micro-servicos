using System;
using System.Collections.Generic;

namespace CorujasDev.Identity.Servicos.ViewModels.Usuario
{
    public class UsuarioHomeViewModel
    {
          public int quantidade { get; set; }
          public IList<UsuarioViewModel> Usuarios { get; set; }
    }
}
