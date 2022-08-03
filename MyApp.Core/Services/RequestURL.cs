using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;

using MyApp.Core.Data;
using MyApp.Core.Dtos;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Services
{
    public class RequestURL : IRequestURL
    {
        private readonly MyAppDataContext _context;
        private readonly NavigationManager _navigation;
        private readonly IConfiguration _config;

        public RequestURL(MyAppDataContext context, NavigationManager navigation, IConfiguration config)
        {
            _context = context;
            _navigation = navigation;
            _config = config;
        }
        public async Task<string> AddRequestUrl(RequestURLDto requestURLDto)
        {
            string uri = "https://claudia.sunlife.com/";
            var typeProduct = "";
            if (requestURLDto.ProductTypeId == 1)
            {
                typeProduct = "Convent";
            } else
            {
                typeProduct = "Syariah";
            }
            var preBase = typeProduct + requestURLDto.CustomerId + requestURLDto.ProductId + requestURLDto.ProductTypeId;
            var baseBytes = Encoding.UTF8.GetBytes(preBase);
            var encodeBase = Convert.ToBase64String(baseBytes);

            var urlRandom = uri + typeProduct + "?t=" + encodeBase;

            GenerateUrl data = new GenerateUrl()
            {
                ProductId = requestURLDto.ProductId,
                ProductTypeId = requestURLDto.ProductTypeId,
                CustomerId = requestURLDto.CustomerId,
                Url = urlRandom,
                CreatedBy = "system",
                CreatedOn = DateTime.Now
            };

            _context.GenerateUrls.Add(data);
            await _context.SaveChangesAsync();
            //_navigation.NavigateTo("/");
            return urlRandom;
        }
    }
}
