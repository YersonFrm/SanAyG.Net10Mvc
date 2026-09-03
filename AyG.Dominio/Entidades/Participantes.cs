using AyG.Dominio.Enums;

namespace AyG.Dominio.Entidades;

public class Participantes
{
    public Guid Id { get; set; }
    public Guid SanId { get; set; }
    public Guid ClienteId { get; set; }
    public int TurnoPago { get; set; }
    public EnusEstatusCliente Estatus { get; set; }
    public DateTime Fecha_Cobro { get; set; }


    // navegacion
    public San? San { get; set; }
    public Clientes? Cliente { get; set; }
}
