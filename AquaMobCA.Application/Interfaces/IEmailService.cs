﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Email;

namespace Application.Interfaces
{
    public interface  IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}
