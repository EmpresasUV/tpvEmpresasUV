﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TpvEmpresasUV.modelos;

public partial class TpvVenta
{
    public int Id { get; set; }

    public int IdCorte { get; set; }

    public string Serie { get; set; }

    public string Folio { get; set; }

    public string Fecha { get; set; }

    public string Cliente { get; set; }

    public float? Descuentos { get; set; }

    public float Total { get; set; }

    public string Tipopago { get; set; }

    public string Tipoventa { get; set; }

    public string Estado { get; set; }

    public string Motivo { get; set; }
}