using ApiDeOrcamento.Models.Enums;

namespace ApiDeOrcamento.Models
{
    public class Usuario:ModeloGenerico
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AuthToken { get; set; }
        public UsuarioTipo UsuarioTipo { get; set; } 
    }
}
