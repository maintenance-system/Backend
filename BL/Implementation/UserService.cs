using AutoMapper;
using BL.DTO.LogIn;
using BL.Interfaces;
using DAL.DataObjects.LogIn;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation;

internal class UserService : IUserService
{
    IUserRepository userRepository;
    IMapper mapper;
    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        this.userRepository = userRepository;
        this.mapper = mapper;
    }
    public async Task<int> CreateAsync(UserDTO item)
    {
        User city = mapper.Map<User>(item);
        return await userRepository.CreateAsync(city);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await userRepository.DeleteAsync(id);
    }

    public async Task<List<UserDTO>> GetAllAsync()
    {
        List<User> users = await userRepository.GetAllAsync();
        List<UserDTO> usersDtos = mapper.Map<List<UserDTO>>(users);

        return usersDtos;
    }

    public bool Update(UserDTO item)
    {
        throw new NotImplementedException();
    }
}
