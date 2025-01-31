﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs.NotificationDtos
{
    public class NotificationMessageUpdateDTO
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
