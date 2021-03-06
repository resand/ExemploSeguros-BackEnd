﻿using System;
using System.Collections.Generic;
using ExemploSeguros.Application.ViewModels;

namespace ExemploSeguros.Application.Interfaces
{
    public interface IPaisResidenciaAppService : IDisposable
    {
        IEnumerable<PaisResidenciaViewModel> ObterTodosPaises();
    }
}