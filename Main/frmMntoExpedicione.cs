//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Main
{
    using System;
    using System.Collections.Generic;
    
    public partial class frmMntoExpedicione
    {
        public int IDLineaPedido { get; set; }
        public int IDPedido { get; set; }
        public string NPedido { get; set; }
        public string PedidoCliente { get; set; }
        public System.DateTime FechaEntrega { get; set; }
        public Nullable<System.DateTime> FechaPreparacion { get; set; }
        public Nullable<int> Año { get; set; }
        public Nullable<int> Mes { get; set; }
        public Nullable<System.DateTime> FechaAviso { get; set; }
        public Nullable<int> Semana { get; set; }
        public string IDCliente { get; set; }
        public Nullable<int> IDDireccionEnvio { get; set; }
        public string RefCliente { get; set; }
        public string IDArticulo { get; set; }
        public string DescArticulo { get; set; }
        public Nullable<decimal> StockFisico { get; set; }
        public decimal QPedida { get; set; }
        public decimal QServida { get; set; }
        public decimal Precio { get; set; }
        public decimal Dto1 { get; set; }
        public decimal Dto3 { get; set; }
        public decimal Dto2 { get; set; }
        public decimal Importe { get; set; }
        public int UdValoracion { get; set; }
        public decimal Factor { get; set; }
        public Nullable<decimal> Rotacion { get; set; }
        public bool Bloqueado { get; set; }
        public Nullable<decimal> Pendiente { get; set; }
        public int Estado { get; set; }
        public string IDAlmacen { get; set; }
        public int AgrupAlbaran { get; set; }
        public bool EnvioCompleto { get; set; }
        public decimal CantidadConfirmada { get; set; }
        public string DescCliente { get; set; }
        public bool Confirmado { get; set; }
        public decimal QAlbaran { get; set; }
        public Nullable<System.DateTime> FechaEntregaModificadoPedido { get; set; }
        public Nullable<bool> Deposito { get; set; }
        public string IDAlmacenEnvio { get; set; }
        public Nullable<int> AlmacenEnvioEsDeposito { get; set; }
        public bool GestionStockPorLotes { get; set; }
        public string IDTipo { get; set; }
        public bool NSerieObligatorio { get; set; }
        public Nullable<int> Expedible { get; set; }
        public string IDCentroGestion { get; set; }
        public Nullable<int> TienePedidoCompra2 { get; set; }
        public Nullable<int> EsPedidoVenta3 { get; set; }
        public bool EmpresaGrupo { get; set; }
        public bool EntregaProveedor { get; set; }
        public string IDUdInterna { get; set; }
        public string IDUdInterna2 { get; set; }
        public bool GestionStock { get; set; }
        public Nullable<decimal> QInterna2 { get; set; }
        public Nullable<decimal> QServida2 { get; set; }
        public Nullable<decimal> QPendiente2 { get; set; }
        public Nullable<decimal> PendientexFactor { get; set; }
        public Nullable<decimal> FactorConversion { get; set; }
        public bool Activo { get; set; }
        public Nullable<int> BloqueadoAlmacen { get; set; }
        public bool KitVenta { get; set; }
        public string CodPostal { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string IDTPV { get; set; }
        public string IDUDExpedicion { get; set; }
        public string IDClienteDistribuidor { get; set; }
        public string DescClienteDistribuidor { get; set; }
        public bool FirmeEDI { get; set; }
        public Nullable<decimal> QEmbalaje { get; set; }
    }
}
