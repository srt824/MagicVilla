namespace MagicVilla_API.Modelos.Dto
{
    public class LoginResponseDTO
    {
        public UsuarioDTO Usuario { get; set; }
        public string Token { get; set; }
        public string Rol { get; set; }
    }
}
