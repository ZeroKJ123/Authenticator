namespace Application.Dtos;

/// <summary>
/// Dto ответа регистрации.
/// </summary>
public class RegistrationResponseDto
{
    /// <summary>
    /// Регистрация успешна.
    /// </summary>
    public required bool Success { get; init; }

    /// <summary>
    /// Ошибки.
    /// </summary>
    public required List<string> Errors { get; init; }
}
