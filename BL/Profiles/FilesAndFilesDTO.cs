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
    internal class FilesAndFilesDTO : Profile
    {
        public FilesAndFilesDTO() {

            CreateMap<Files, FilesDTO>()
                .ReverseMap();
        }
    }
}
