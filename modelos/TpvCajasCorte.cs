﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TpvEmpresasUV.modelos;

public partial class TpvCajasCorte
{
    public int Id { get; set; }

    public int IdCaja { get; set; }

    public string FechaInicio { get; set; }

    public string FechaCierre { get; set; }

    public double DineroInicio { get; set; }

    public double DineroCierre { get; set; }

    public double UtilidadNeta { get; set; }

    public int? NumeroOperaciones { get; set; }

    public int? NumeroProductos { get; set; }

    /// <summary>
    /// A=Abierto C=Cerrado
    /// </summary>
    public string Estado { get; set; }
}