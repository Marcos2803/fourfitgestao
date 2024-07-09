using System.ComponentModel.DataAnnotations;

namespace fourfit_sistema_gestao.UI.Models.Account
{
    public class CadastroViewModel
    {
        [Display(Name ="Primeiro Nome")]
        [Required(ErrorMessage ="Este campo é obrigatório")]
        public string PrimeiroNome { get; set; }

        [Display(Name = "SobreNome")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string SobreNome { get; set; }
        [EmailAddress(ErrorMessage = "E-mail invalido")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Email { get; set; }
      
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="As Senhas não conferem")]
        public string PasswordConfirmn { get; set; }
      
        
    }
}
