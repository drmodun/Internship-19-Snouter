﻿using Domain.Contracts.Requests.User;
using Domain.Contracts.Response.User;

namespace Domain.Services.Interfaces
{
    public interface IUserServices
    {
        public Task<GetAllUsersResponse> GetAllUsersService();
        public Task<GetUserResponse> GetUserService(GetUserRequest request, CancellationToken cancellationToken = default);
        public Task<CreateUserResponse> CreateUserService(CreateUserRequest request, CancellationToken cancellationToken = default);
        public Task<DeleteUserResponse> DeleteUserService(DeleteUserRequest request, CancellationToken cancellationToken = default);
        public Task<UpdateUserResponse> UpdateUserService(UpdateUserRequest request, CancellationToken cancellationToken = default);
    }
}
