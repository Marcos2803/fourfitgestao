using System.ComponentModel.DataAnnotations;

namespace fourfit_sistema_gestao.UI.Models.Account
{
    public class EmailConfiguracoesViewModel
    {
        [Required(ErrorMessage = "Servidor de saída de e-mails (SMTP) é obrigatório")]
        public string? Smtp { get; set; }
        [Required]
        public int Port { get; set; }
        [Required]
        public string? EmailUser { get; set; }

    }
}
