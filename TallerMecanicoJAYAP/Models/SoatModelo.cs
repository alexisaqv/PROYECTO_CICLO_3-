﻿using System;
using System.ComponentModel.DataAnnotations;



public class SoatModelo
{
    public int IdSeguro { get; set; }
    [Required(ErrorMessage = "EL campo es obligatorio")]//obligatoria
    public string? TipoSeguro { get; set; }
    [Required(ErrorMessage = "EL campo es obligatorio")]//obligatoria
    public string? FechaCompra { get; set; }
    [Required(ErrorMessage = "EL campo es obligatorio")]//obligatoria
    public string? FechaVencimiento { get; set; }
    [Required(ErrorMessage = "EL campo es obligatorio")]//obligatoria



}



