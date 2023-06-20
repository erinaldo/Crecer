﻿using Servidor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosIntegracion
{
    public static class CuentaContable
    {
        private static SqlConnection objConexion = null;
        private static SqlDataAdapter objDataAdapter = null;
        //private static SqlCommand objCommand = null;
        //private static SqlDataReader objDataReader = null;
        private static string strProc = string.Empty;
        static CuentaContable()
        {
            try
            {
                
                objConexion = new SqlConnection(BaseDatos.StringConexionIntegracion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ObtenerDelPeriodo(DateTime pDesde, DateTime pHasta, bool pPorFechaEmision)
        {
            DataTable dt = new DataTable();
            strProc = "SP_CUENTASCONTABLESDEPERIODO_SELECT";
            objDataAdapter = new SqlDataAdapter(strProc, objConexion);
            objDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            objDataAdapter.SelectCommand.Parameters.AddWithValue("@FechaDesde", pDesde.Date);
            objDataAdapter.SelectCommand.Parameters.AddWithValue("@FechaHasta", pHasta.Date);
            objDataAdapter.SelectCommand.Parameters.AddWithValue("@PorFechaEmision", pPorFechaEmision);

            try
            {
                objDataAdapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }
        /*
        public static DataTable ObtenerTodos()
        {
            DataTable dt = new DataTable();
            strProc = "SP_CUENTASCONTABLES_SELECT";
            objDataAdapter = new SqlDataAdapter(strProc, objConexion);
            objDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                objDataAdapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }

        public static DataTable ObtenerImpuestosTodos(char tipo)
        {
            DataTable dt = new DataTable();
            strProc = "SP_CUENTASCONTABLESIMPUESTOS_SELECT";
            objDataAdapter = new SqlDataAdapter(strProc, objConexion);
            objDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            objDataAdapter.SelectCommand.Parameters.AddWithValue("@Tipo", tipo);
            try
            {
                objDataAdapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }
        public static DataTable ObtenerBienesDeUso()
        {
            DataTable dt = new DataTable();
            strProc = "SP_CUENTASCONTABLES_BIENESDEUSO_SELECT";
            objDataAdapter = new SqlDataAdapter(strProc, objConexion);
            objDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                objDataAdapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }

        public static DataTable ObtenerBienesDeCambio()
        {
            DataTable dt = new DataTable();
            strProc = "SP_CUENTASCONTABLES_BIENESDECAMBIO_SELECT";
            objDataAdapter = new SqlDataAdapter(strProc, objConexion);
            objDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                objDataAdapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }

        public static DataTable ObtenerGastos()
        {
            DataTable dt = new DataTable();
            strProc = "SP_CUENTASCONTABLES_GASTOS_SELECT";
            objDataAdapter = new SqlDataAdapter(strProc, objConexion);
            objDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                objDataAdapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }

        public static DataTable ObtenerBancos()
        {
            DataTable dt = new DataTable();
            strProc = "SP_CUENTASCONTABLES_BANCOS_SELECT";
            objDataAdapter = new SqlDataAdapter(strProc, objConexion);
            objDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            
            try
            {
                objDataAdapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }



        public static Entidades.CuentaContable ObtenerUno(int pCodigo)
        {
            Entidades.CuentaContable objCuenta = new Entidades.CuentaContable();
            strProc = "SP_CUENTASCONTABLES_SELECT_UNO";
            objCommand = new SqlCommand(strProc, objConexion);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.Parameters.AddWithValue("@Codigo", pCodigo);
            try
            {
                objConexion.Open();
                objDataReader = objCommand.ExecuteReader();
                objDataReader.Read();
                if (objDataReader.HasRows.Equals(false))
                {
                    objCuenta = null;
                }
                else
                {

                    objCuenta.Codigo = Convert.ToInt32(objDataReader["Codigo"]); ;
                    objCuenta.Nombre = objDataReader["Nombre"].ToString();
                    objCuenta.Saldo = objDataReader["Saldo"].ToString();
                    objCuenta.Genero = Convert.ToInt32(objDataReader["Genero"]);
                    objCuenta.Grupo = Convert.ToInt32(objDataReader["Grupo"]);
                    objCuenta.Rubro = Convert.ToInt32(objDataReader["Rubro"]);
                    objCuenta.Cuenta = Convert.ToInt32(objDataReader["Cuenta"]);
                    objCuenta.SubCuenta = Convert.ToInt32(objDataReader["SubCuenta"]);
                    
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (objConexion.State == ConnectionState.Open)
                    objConexion.Close();
            }
            return objCuenta;
        }
        */

    }
}
