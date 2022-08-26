using AutoMapper;
using FilmesAPI.Data.DTOs;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }

        private void Filme()
        {
            throw new NotImplementedException();
        }

        private void ReadFilmeDto()
        {
            throw new NotImplementedException();
        }
    }
}
