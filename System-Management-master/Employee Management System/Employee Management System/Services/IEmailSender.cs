﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_System.Services
{
    public interface IEmailSender
    {
        // Override the _emailSender:
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
