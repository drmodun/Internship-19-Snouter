using Domain.Contracts.Requests.User;
using Domain.Contracts.Response.User;
using Domain.Repositories;
using Domain.Validators;
using FluentValidation;
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
        private readonly UserMappers _userMappers;
        private readonly UserValidator _userValidator;
        public UserServices(UserRepo userRepository, EntityMaker entityMaker, UserMappers userMappers, UserValidator validationRules)
        {
            _userRepository = userRepository;
            _entityMaker = entityMaker;
            _userMappers = userMappers;
            _userValidator = validationRules;
        }

        public async Task<CreateUserResponse> CreateUserService(CreateUserRequest request)
        {
            var newUser = _entityMaker.RequestToNewUser(request);
            var validationResult = _userValidator.ValidateAndThrowAsync(newUser);
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
                Profile = _userMappers.MapUserToDTO(newUser),
                StatusCode = System.Net.HttpStatusCode.OK
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
                Users = users.Select(_userMappers.MapUserToDTO).ToList(),
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
                User = _userMappers.MapUserToDTO(user)
            };
        }
        public async Task<UpdateUserResponse> UpdateUserService(UpdateUserRequest request)
        {
            var userToUpdate = _entityMaker.RequestToUpdatedUser(request);
            var validationResult = _userValidator.ValidateAndThrowAsync(userToUpdate);
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
                User = _userMappers.MapUserToDTO(userToUpdate)
            };
        }
    }
}
