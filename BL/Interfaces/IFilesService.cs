using BL.DTO;
using BL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces;

public interface IFilesService : IService<FilesDTO>
{
    Task<List<FilesDTO>> GetByStatusAsync(Status.FileStatus fileStatus);
}
