namespace SistemaBancaEnLinea.BC.Modelos
{
    public class Transferencia
    {
        int Id { get; set; }
        string NumeroReferencia { get; set; }
        DateTime FechaCreacion { get; set; }
        DateTime FechaDeEjecucion { get; set; }
        decimal Monto { get; set; }
        decimal Comision { get; set; }
        decimal MontoADebitar { get; set; }
        int CuentaDeOrigenId { get; set; }
        enum EstadoDeTransferencia { }
        bool Aprobacion { get; set; }
        string IdentificadorDeAprobacion { get; set; } // quien aprobó la transaccion 
        Guid IdempotencyKey { get; set; }

    }
}
