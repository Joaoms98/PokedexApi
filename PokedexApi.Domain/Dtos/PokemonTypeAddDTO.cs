﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexApi.Domain.Dtos
{
    public class PokemonTypeAddDTO
    {
        public Guid? PokemonId { get; set; }

        public Guid? SpecialStageId { get; set; }

        public int TypeName { get; set; }
    }
}
