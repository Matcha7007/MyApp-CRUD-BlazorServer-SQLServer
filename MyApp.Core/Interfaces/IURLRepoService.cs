using MyApp.Core.Dtos;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Interfaces
{
    public interface IURLRepoService
    {
        IEnumerable<URLRepoServiceDto> GetAll();
        Task<List<URLRepoServiceDto>> UrlList();
    }
}
