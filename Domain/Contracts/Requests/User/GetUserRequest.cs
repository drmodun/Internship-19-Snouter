﻿namespace Domain.Contracts.Requests.User
{
    public class GetUserRequest
    {
        public Guid Id { get; set; }
        public string Slug { get; set; }
    }
}