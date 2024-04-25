using System.ComponentModel.DataAnnotations;

namespace fourfit_sistema_gestao.UI.Models.Account
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "E-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "Email é obrigatório")]

        public string? Email { get; set; }
    }
}
