﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Api.Models.Login;

namespace ToDoList.Api.Services
{
	public interface IUserLoginService
	{
		UserLoginResponseModel Login(UserLoginModel model);
		void Logout();
		void ChangePassword(UserChangePasswordModel model);
		void ResetPassword(UserResetPasswordModel model);
		void InitUserPasswordReset(InitPasswordResetModel model);
	}
}
