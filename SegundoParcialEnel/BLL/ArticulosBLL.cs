﻿using SegundoParcialEnel.DAL;
using SegundoParcialEnel.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SegundoParcialEnel.BLL
{
   public class ArticulosBLL
    {
        public static bool Guardar(Articulos Articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Articulos.Add(Articulos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }

        public static bool Modificar(Articulos Articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(Articulos).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Articulos Articulos = contexto.Articulos.Find(id);

                if (Articulos != null)
                {
                    contexto.Entry(Articulos).State = EntityState.Deleted;
                }

                if (contexto.SaveChanges() > 0)
                {
                    contexto.Dispose();
                    paso = true;
                }


            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static Articulos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulos Articulos = new Articulos();
            try
            {
                Articulos = contexto.Articulos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Articulos;
        }

        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> expression)
        {
            List<Articulos> articulos = new List<Articulos>();
            Contexto contexto = new Contexto();
            try
            {
                articulos = contexto.Articulos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulos;
        }

        public static string RetornarDescripcion(string descripcio)
        {
            string descripcion = string.Empty;
            var lista = GetList(x => x.Descripcion.Equals(descripcio));
            foreach (var item in lista)
            {
                descripcion = item.Descripcion;
            }

            return descripcion;
        }
        
        public static decimal CalcularGanancia(decimal precio, decimal costo)
        {
            
            return ((Convert.ToDecimal(precio) - Convert.ToDecimal(costo))/costo) * 100;
            
        }
    }
}
