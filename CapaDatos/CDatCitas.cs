﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class CDatCitas
    {
        CConexion oConexion = new CConexion();
        SqlCommand ocmd = new SqlCommand();

        public bool guardar_Cita(CEntidadCitas ocitas) {
            try // Desactiva la recoleccion automtica de errores
            {

            ocmd.Connection = oConexion.conectar("bdHospital");
            ocmd.CommandType = CommandType.StoredProcedure;
            ocmd.CommandText = "sp_guardar_citas";

            //declarar variables del procedimiento almacenado
            ocmd.Parameters.Add("@pcod_cita", ocitas.Cod_cita);
            ocmd.Parameters.Add("@pfecha", ocitas.Fecha);
            ocmd.Parameters.Add("@phora", ocitas.Hora);
            ocmd.Parameters.Add("@pId_paciente ", ocitas.Id_paciente1);
            ocmd.Parameters.Add("@pid_medico", ocitas.Id_medico);
            ocmd.Parameters.Add("@pvalor", ocitas.Valor);
            ocmd.Parameters.Add("@pdiagnostico", ocitas.Diagnostico);
            ocmd.Parameters.Add("@pNom_acompanante", ocitas.Nom_acompanante1);

                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err){
                throw new Exception(err.Message);// solo se ejecuta si hay error
            }
        }
        public bool anular_Cita(CEntidadCitas ocitas) {
            try {
                ocmd.Connection = oConexion.conectar("bdHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_anular_citas";

                //declarar variables
                ocmd.Parameters.Add("@pcod_cita", ocitas.Cod_cita);
                ocmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception err) {
                throw new Exception(err.Message);
            }
        }
        public DataSet consultar_cita(CEntidadCitas ocitas)
        {
            try
            {
                ocmd.Connection = oConexion.conectar("bdHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_consultar_citas";

                //declarar variables
                ocmd.Parameters.Add("@pcod_cita", ocitas.Cod_cita);


                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            
            catch (Exception err) {
                throw new Exception(err.Message);
             }

        }
    }
}
