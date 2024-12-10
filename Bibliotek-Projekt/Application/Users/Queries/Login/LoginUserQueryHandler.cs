﻿//using Application.Users.Queries.Login.Helpers;
//using Infrastructure.Database;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Application.Users.Queries.Login
//{
//    public class LoginUserQueryHandler : IRequestHandler<LoginUserQuery, string>
//    {
//        private readonly FakeDatabase _fakeDatabase;
//        private readonly TokenHelper _tokenHelper;
//        public LoginUserQueryHandler(FakeDatabase fakeDatabase, TokenHelper tokenHelper)
//        {
//            _fakeDatabase = fakeDatabase;
//            _tokenHelper = tokenHelper;
//        }

//        public Task<string> Handle(LoginUserQuery request, CancellationToken cancellationToken)
//        {
//            var user = _fakeDatabase.UsersFromDB.FirstOrDefault(user => user.UserName == request.LoginUser.UserName && user.Password == request.LoginUser.Password);

//            if (user == null)
//            {
//                throw new UnauthorizedAccessException("Invalid username or password");
//            }

//            string token = _tokenHelper.GeneerateJwtToken(user);

//            return Task.FromResult(token);
//        }
//    }
//}
