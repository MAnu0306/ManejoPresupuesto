using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManejoPresupuesto.Interfaces;
using ManejoPresupuesto.Models;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration; // Asegúrate de importar el espacio de nombres necesario

namespace ManejoPresupuesto.Servicios
{
    public class RepositorioTiposCuentas : IRepositorioTiposCuentas
    {
        private readonly string connectionString;

        public RepositorioTiposCuentas(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Crear(TiposCuentas tiposCuentas)
        {
            using var connection = new SqlConnection(connectionString);
            var Id = connection.QuerySingle<int>($@"INSERT INTO TiposCuentas (Nombre, UsuarioId, Orden)
                                                   VALUES (@Nombre, @UsuarioId, 0);
                                                   SELECT SCOPE_IDENTITY();", tiposCuentas);

            tiposCuentas.Id = Id;
        }
    }
}
