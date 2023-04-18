﻿using Data.Entities.Models;

namespace Presentation.Contracts.Requests.User
{
    public class CreateUserRequest
    {
        public string Name;
        public string Email;
        public string Password;
        public bool IsAdmin;
        public int LocationId;

    }
}