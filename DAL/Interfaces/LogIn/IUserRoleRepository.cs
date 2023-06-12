﻿using DAL.DataObjects.LogIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces.Login;

public interface IUserRoleRepository : IRepository<UserRole> 
{ 
    Task<List<Role>> GetRoleByName(string name);
}
