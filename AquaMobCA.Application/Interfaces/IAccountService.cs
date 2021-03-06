﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Account;
using Application.Wrappers;

namespace Application.Interfaces
{
    public interface IAccountService
    {
    Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress);
    Task<Response<string>> RegisterAsync(RegisterRequest request, string origin);
    Task ConfirmEmailAsync(string userId, string code);
    }
}
