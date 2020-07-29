﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;

namespace WebMvc.Services
{
    public interface ICatalogService
    {
        Task<Catalog> GetCatalogItemsAsync(int page, int size, int? organizer, int? type);
        Task<IEnumerable<SelectListItem>> GetOragizersAsync();
        Task<IEnumerable<SelectListItem>> GetTypesAsync();
        
    }
}
