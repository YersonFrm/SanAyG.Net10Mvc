using AyG.Dominio.Enums;

namespace AyG.Dominio.Entidades;

public class San
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public EnumFrecuencias Frecuencia { get; set; }
    public DateTime Fecha_Inicio { get; set; }
    public DateTime Fecha_Final { get; set; }
    public int Cantidad { get; set; }
    public decimal Monto { get; set; }
    public DateTime CreadoEn { get; set; }
    public EnumEstatusSan Estatus { get; set; }
}
