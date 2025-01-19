using System.ComponentModel.DataAnnotations;

namespace AnonymFinanceAPI.Config;

public class JwtSettingsOptions
{
    public const string JwtSettings = "JwtSettings";

    [Required(ErrorMessage = "JWT Secret is required")]
    [MinLength(50, ErrorMessage = "JWT Secret must be at least 50 characters long")]
    public string Secret { get; set; } = string.Empty;

    [Required(ErrorMessage = "JWT Issuer is required")]
    public string Issuer { get; set; } = string.Empty;

    [Required(ErrorMessage = "JWT Audience is required")]
    public string Audience { get; set; } = string.Empty;
}
