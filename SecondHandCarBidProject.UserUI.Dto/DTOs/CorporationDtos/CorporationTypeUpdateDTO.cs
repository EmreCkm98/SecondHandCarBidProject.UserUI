﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs.CorporationDtos
{
    public class CorporationTypeUpdateDTO
    {
        public int Id { get; set; }
        public string CorporationTypeName { get; set; }
        public byte IsActive { get; set; }
    }
}
