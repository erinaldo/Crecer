﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TipoEstadoValor
    {
        public DataTable ObtenerTodos() {
            try
            {
                return Datos.TipoEstadoValor.ObtenerTodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
