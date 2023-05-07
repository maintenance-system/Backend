﻿using BL.DTO.LogIn;
using BL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI_API.Controllers
{
    public class UaerRolesController : BaseController
    {
        IUserRoleService userRoleService;
        public UaerRolesController(IUserRoleService userRoleService)
        {
            this.userRoleService = userRoleService;
        }

        [HttpGet]
        public async Task<List<UserRoleDTO>> GetAllAsync()
        {
            return await userRoleService.GetAllAsync();
        }
        [HttpPost]
        public async Task<int> Post(UserRoleDTO role)
        {
            return await userRoleService.CreateAsync(role);
        }
    }
}