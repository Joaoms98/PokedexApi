﻿using PokedexApi.Core.Enums;

namespace PokedexApi.Domain.Dtos
{
    public class SpecialStageAddDTO
    {
        public int DexNumber { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Region { get; set; }
        public GenderEnum Gender { get; set; }
        public RarityEnum Rarity { get; set; }
    }
}
