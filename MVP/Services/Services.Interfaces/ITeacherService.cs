﻿using Domain.DTO;
using Domain.Entities;
using MVP.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Services.Services.Interfaces
{
    public interface ITeacherService
    {
        Task<Teacher> GetTeacherDetails(string username);
    }
}
