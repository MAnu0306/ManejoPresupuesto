using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManejoPresupuesto.Models;
using ManejoPresupuesto.Servicios;

namespace ManejoPresupuesto.Interfaces
{
    public interface IRepositorioTiposCuentas
    {
        void Crear(TiposCuentas tiposCuentas);
    }
}