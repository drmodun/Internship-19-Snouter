using Domain.Contracts.Requests.User;
using Domain.Contracts.Response.User;
using Domain.Mapper.Implementaions;
using Domain.Mapper.Interfaces;
using Domain.Repositories;
using Domain.Repositories.Interfaces;
using Domain.Services.Interfaces;
using Domain.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Implmentations
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepo _userRepository;
        private readonly EntityMaker _entityMaker;
        private readonly IUserMappers _userMappers;
        private readonly UserValidator _userValidator;
        public UserServices(IUserRepo userRepository, EntityMaker entityMaker, IUserMappers userMappers, UserValidator validationRules)
        {
            _userRepository = userRepository;
            _entityMaker = entityMaker;
            _userMappers = userMappers;
            _userValidator = validationRules;
        }

        public async Task<CreateUserResponse> CreateUserService(CreateUserRequest request, CancellationToken cancellationToken = default)
        {
            var newUser = _entityMaker.RequestToNewUser(request);
            await _userValidator.ValidateAndThrowAsync(newUser);
            var addition = await _userRepository.CreateUser(newUser, cancellationToken);
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
        public async Task<DeleteUserResponse> DeleteUserService(DeleteUserRequest request, CancellationToken cancellationToken = default)
        {
            var removal = await _userRepository.DeleteUser(request.Id, cancellationToken);
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
        public async Task<GetUserResponse> GetUserService(GetUserRequest request, CancellationToken cancellationToken = default)
        {
            var user = await _userRepository.GetUserById(request.Id, cancellationToken);
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
        public async Task<UpdateUserResponse> UpdateUserService(UpdateUserRequest request, CancellationToken cancellationToken = default)
        {
            var userToUpdate = _entityMaker.RequestToUpdatedUser(request);
            await _userValidator.ValidateAndThrowAsync(userToUpdate);
            var update = await _userRepository.UpdateUser(userToUpdate, cancellationToken);
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
