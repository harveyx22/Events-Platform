﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;

namespace WebMvc.ViewModels
{
    public class CatalogIndexViewModel
    {
        public IEnumerable<SelectListItem> Organizers { get; set; }
        public IEnumerable<SelectListItem> Types { get; set; }
        public IEnumerable<CatalogItem> CatalogItems { get; set; }
        public PaginationInfo PaginationInfo { get; set; }
        public int? OrganizersFilterApplied { get; set; }
        public int? TypesFilterApplied { get; set; }
    }
}
