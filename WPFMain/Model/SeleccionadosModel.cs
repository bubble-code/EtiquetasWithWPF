using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFMain.Model
{
    public class SeleccionadosModel
    {
        public int IDLineaPedido { get; set; }
        public int IDPedido { get; set; }
        public string NPedido { get; set; }
        public string PedidoCliente { get; set; }
        public string RefCliente { get; set; }
        public string IDArticulo { get; set; }
        public string DescArticulo { get; set; }
        public decimal QPedida { get; set; }
        public decimal QServida { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        public int UdValoracion { get; set; }
        public decimal Factor { get; set; }
        public string DescCliente { get; set; }
        public string IDCliente { get; set; }
        public int IDDireccionEnvio { get; set; }

        public static explicit operator SeleccionadosModel(frmMntoExpedicione v)
        {
            return new SeleccionadosModel
            {
                IDLineaPedido = v.IDLineaPedido,
                IDPedido = v.IDPedido,
                NPedido = v.NPedido,
                PedidoCliente = v.PedidoCliente,
                RefCliente = v.RefCliente,
                IDArticulo = v.IDArticulo,
                DescArticulo = v.DescArticulo,
                QPedida = v.QPedida,
                QServida = v.QServida,
                Precio = v.Precio,
                Importe = v.Importe,
                UdValoracion = v.UdValoracion,
                Factor = v.Factor,
                DescCliente = v.DescCliente,
                IDCliente = v.IDCliente,
                IDDireccionEnvio = (int)v.IDDireccionEnvio,
            };
        }
    }
}
