﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs.CorporationDtos
{
    public class CorporatePackageTypeUpdateDTO
    {
        public Int16 Id { get; set; }
        public string PackageName { get; set; }
        public Int16? CountOfBids { get; set; }
        public bool IsActive { get; set; }
    }
}
