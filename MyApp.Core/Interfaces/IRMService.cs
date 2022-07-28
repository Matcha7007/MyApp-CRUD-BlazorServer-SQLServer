﻿using MyApp.Core.Dtos;
using MyApp.Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Interfaces
{
    public interface IRMService
    {
        //List<RMServiceDTo> DataRM { get; set; }
        IEnumerable<RMServiceDTo> GetAll();

    }
}