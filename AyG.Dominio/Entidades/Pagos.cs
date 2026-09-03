using AyG.Dominio.Enums;

namespace AyG.Dominio.Entidades;

public class Pagos
{
    public Guid Id { get; set; }
    public Guid ParticipanteId { get; set; }
    public int Orden { get; set; }
    public decimal Monto { get; set; }
    public DateTime Fecha_Vencimiento { get; set; }
    public DateTime Fecha_Pago { get; set; }
    public string UrlComprobanteBanco { get; set; } = null!;
    public EnumEstatusPago Estatus { get; set; }

    // navegacion
    public Participantes? Participante { get; set; }

}
