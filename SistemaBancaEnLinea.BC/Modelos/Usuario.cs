namespace SistemaBancaEnLinea.BC.Modelos
{
    public class Usuario
    {
        int Id { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        enum RolDeUsuario { }
        int IntentosFallidos { get; set; }
        DateTime FechaDeBloqueo { get; set; }
        int ClienteId { get; set; }

    }
}
