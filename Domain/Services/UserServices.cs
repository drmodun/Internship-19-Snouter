using Domain.Contracts.Requests.User;
using Domain.Contracts.Response.User;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class UserServices
    {
        private readonly UserRepo _userRepository;
        private readonly EntityMaker _entityMaker;
        public async Task<CreateUserResponse> CreateUserService(CreateUserRequest request)
        {
            var newUser = _entityMaker.RequestToNewUser(request);
            var addition = await _userRepository.CreateUser(newUser);
            if (!addition)
            {
                return new CreateUserResponse
                {
                    Success = false,
                    Profile = null,
                    StatusCode = System.Net.HttpStatusCode.BadRequest
                };
            }
            return new CreateUserResponse
            {
                Success = true,
                Profile = UserMappers.MapUserToDTO(newUser),
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }
        public async Task<DeleteUserResponse> DeleteUserService(DeleteUserRequest request)
        {
            var removal = await _userRepository.DeleteUser(request.Id);
            if (!removal)
            {
                return new DeleteUserResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.NotFound

                };
            }
            return new DeleteUserResponse
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Success = true
            };
        }
        public async Task<GetAllUsersResponse> GetAllUsersService()
        {
            var users = await _userRepository.GetAllUsers();
            return new GetAllUsersResponse
            {
                Users = users.Select(UserMappers.MapUserToDTO).ToList(),
            };
        }
        public async Task<GetUserResponse> GetUserService(GetUserRequest request)
        {
            var user = await _userRepository.GetUserById(request.Id);
            if (user == null)
            {
                return new GetUserResponse
                {
                    Success = false,
                    Status = System.Net.HttpStatusCode.NotFound,
                    User = null

                };
            }
            return new GetUserResponse
            {
                Success = true,
                Status = System.Net.HttpStatusCode.OK,
                User = UserMappers.MapUserToDTO(user)
            };
        }
        public async Task<UpdateUserResponse> UpdateUserService(UpdateUserRequest request)
        {
            var userToUpdate = _entityMaker.RequestToUpdatedUser(request);
            var update = await _userRepository.UpdateUser(userToUpdate);
            if (!update)
            {
                return new UpdateUserResponse
                {
                    Success = false,
                    Status = System.Net.HttpStatusCode.BadRequest,
                    User = null
                };
            };
            return new UpdateUserResponse
            {
                Success = true,
                Status = System.Net.HttpStatusCode.OK,
                User = UserMappers.MapUserToDTO(userToUpdate)
            };
        }
    }
}
