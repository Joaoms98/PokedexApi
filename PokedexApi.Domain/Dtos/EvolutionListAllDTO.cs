﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexApi.Domain.Dtos
{
    public class EvolutionListAllDTO
    {
        public Guid? PreEvolution { get; set; }
        public int PokemonStage { get; set; }
    }
}
