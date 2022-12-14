using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validate
{
    public class UserValidator
    {
        public List<string> Validate(User user)
        {
            List<string> errors = new List<string>();
            bool isNotCorrectLastName = string.IsNullOrWhiteSpace(user.LastName);
            if (isNotCorrectLastName)
            {
                errors.Add("Неккоректная фамилия");
            }
            bool isNotCorrectFirstName = string.IsNullOrWhiteSpace(user.FirstName);
            if (isNotCorrectFirstName)
            {
                errors.Add("Неккоректное имя");
            }
            bool isNotCorrectAge = string.IsNullOrWhiteSpace(user.Age);
            if (isNotCorrectAge)
            {
                errors.Add("Неккоректный возраст");
            }
            bool isNotCorrectLogin = string.IsNullOrWhiteSpace(user.Login);
            if (isNotCorrectLogin)
            {
                errors.Add("Неккоректный логин");
            }

            bool isNotCorrectPassword = string.IsNullOrWhiteSpace(user.Password);
            if (isNotCorrectPassword)
            {
                errors.Add("Неккоректный пароль");
            }
            return errors;
        }




    }
}
