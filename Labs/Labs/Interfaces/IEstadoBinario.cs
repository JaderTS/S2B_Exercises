﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Interfaces
{
    public enum EstadoBinario { Ligado, Desligado };

    interface IEstadoBinario
    {
        void Ligar();
        void Desligar();
        EstadoBinario Estado { get; }
    }
}
