﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TpvEmpresasUV.modelos;

public partial class BecasProgramacion
{
    /// <summary>
    /// Matricula del alumno becado
    /// </summary>
    public string IdMatricula { get; set; }

    /// <summary>
    /// D Desayuno, C Comida
    /// </summary>
    public string TipoAlimento { get; set; }

    /// <summary>
    /// Fecha del alimento
    /// </summary>
    public DateTime? Fecha { get; set; }

    /// <summary>
    /// D Disponible, E Entregado
    /// </summary>
    public string Estado { get; set; }
}