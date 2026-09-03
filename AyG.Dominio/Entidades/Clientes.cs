namespace AyG.Dominio.Entidades;

public class Clientes
{
    public Guid Id { get; set; }
    public Guid BancoId { get; set; }
    public string Nombre { get; set; } = null!;
    public string  Cedula { get; set; } = null!;
    public string Contacto { get; set; } = null!;
    public string? Email { get; set; }
    public string? Direccion { get; set; }
    public string? Nota { get; set; }
    public int NoCuentaBanco { get; set; }

    // navegacion
    public Bancos? Banco { get; set; }
}
