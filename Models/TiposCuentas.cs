using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using ManejoPresupuesto.Interfaces;
using ManejoPresupuesto.Models;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    // TiposCuentas.cs
public class TiposCuentas
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
    [StringLength(50, ErrorMessage = "El campo Nombre no puede tener más de 50 caracteres.")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El campo UsuarioId es obligatorio.")]
    public int UsuarioId { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "El campo Orden debe ser un número mayor que 0.")]
    public int Orden { get; set; }
}


}