using AutoMapper;
using Core.API.Models;
using Core.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.API.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        //public override string ProfileName
        //{
        //    get { return "DomainToViewModelMappings"; }
        //}

        protected override void Configure()
        {
            Mapper.CreateMap<Book, BookModel>()
                .ForMember(vm => vm.Title, map => map.MapFrom(b => b.Title))
                .ForMember(vm => vm.Author, map => map.MapFrom(b => b.Author))
                .ForMember(vm => vm.Description, map => map.MapFrom(b => b.Description));
        }
    }
}