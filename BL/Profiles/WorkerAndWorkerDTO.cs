using AutoMapper;
using BL.DTO;
using DAL.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Profiles
{
    internal class WorkerAndWorkerDTO : Profile
    {
        /*public WorkerAndWorkerDTO()
        {
            CreateMap<Worker, WorkerDTO>()
                .ForMember(
                address => address.AddressBranch,
                options => options.MapFrom(b => b.AddressBranch == null ? "" : b.AddressBranch.FirstName + " " + b.Author.LastName))
               // .ReverseMap()
               // .ForMember(b => b.Category, opts => opts.Ignore())
               // .ForPath(b => b.Author.FirstName, opts => opts.MapFrom(b => b.Author.Split(" ", System.StringSplitOptions.None)[0]))
               // .ForPath(b => b.Author.LastName, opts => opts.MapFrom(b => b.Author.Split(" ", System.StringSplitOptions.None)[1]));
        }*/
    }
}
