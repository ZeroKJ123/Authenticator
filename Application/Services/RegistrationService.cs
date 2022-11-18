using Application.Dtos;
using Application.Validate;
using Domain.Models;

namespace Application.Services;

/// <summary>
/// Сервис для регистрации.
/// </summary>
public class RegistrationService
{
    private readonly UserValidator _userValidator;

    public RegistrationService()
    {
        _userValidator = new UserValidator();
    }

    /// <summary>
    /// Зарегистрироваться.
    /// </summary>
    /// <param name="user">Пользователь.</param>
    /// <returns>Dto ответа регистрации.</returns>
    public RegistrationResponseDto Register(User user)
    {
        var errors = _userValidator.Validate(user);

        var registrationResponse = new RegistrationResponseDto()
        {
            Success = errors.Count == 0,
            Errors = errors
        };

        return registrationResponse;
    }
}
