using AutoMapper;
using BL.DTO;
using BL.Interfaces;
using BL.Utils;
using DAL.DataObjects;
using DAL.Implementation;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation;

internal class FileService : IFilesService
{
    IFilesRepository fileRepository;
    IMapper mapper;

    public FileService(IFilesRepository fileRepository, IMapper mapper)
    {
        this.fileRepository = fileRepository;
        this.mapper = mapper;
    }

    public async Task<int> CreateAsync(FilesDTO item)
    {
        Files file = mapper.Map<Files>(item);
        return await fileRepository.CreateAsync(file);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await fileRepository.DeleteAsync(id);
    }

    public async Task<List<FilesDTO>> GetAllAsync()
    {
        List<Files> files = await fileRepository.GetAllAsync();
        return mapper.Map<List<FilesDTO>>(files);
    }

    public async Task<List<FilesDTO>> GetByStatusAsync(Status.FileStatus status)
    {
        string statusString = status.ToString();
        var files = await fileRepository.GetByStatusAsync(statusString);
        return mapper.Map<List<FilesDTO>>(files);   
    }

    public bool Update(FilesDTO item)
    {
        throw new NotImplementedException();
    }
}
