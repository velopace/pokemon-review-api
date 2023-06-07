﻿using System;
using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<PokemonDto, Pokemon>();
            CreateMap<Category, CategoryDto>();
			CreateMap<Country, CountryDto>();
            CreateMap<Owner, OwnerDto>();
            CreateMap<Review, ReviewDto>();
            CreateMap<Reviewer, ReviewerDto>();
        }
	}
}

