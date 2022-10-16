﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs.NotificationDtos
{
    public class NotificationMessageUserAddDTO
    {
        public int NotificationMessageId { get; set; }
        public Guid SendToBaseUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
