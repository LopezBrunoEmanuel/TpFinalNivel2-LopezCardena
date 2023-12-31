﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocios
{
    public class CategoriasNegocio
    {
        public List<Categorias> listar()
        {
			List<Categorias> lista = new List<Categorias>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("Select id, descripcion From CATEGORIAS");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Categorias aux = new Categorias();
					aux.Id = (int)datos.Lector["Id"];
					aux.Descripcion= (string)datos.Lector["Descripcion"];

					lista.Add(aux);
				}

				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
        }
    }
}
