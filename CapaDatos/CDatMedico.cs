using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class CDatMedico
    {
        CConexion oConexion = new CConexion();
        SqlCommand ocmd = new SqlCommand();

        public bool guardar_Medico(CEndidadMedico omedico)
        {
            try
            {
                ocmd.Connection = oConexion.conectar("bdHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_guardar_medico";

                ocmd.Parameters.Add("@pid_medico", omedico.Id_medico);
                ocmd.Parameters.Add("@pnom_medico", omedico.Nom_medico);
                ocmd.Parameters.Add("@pespecialidad", omedico.Especialidad);
                ocmd.Parameters.Add("@ptel_medico", omedico.Tel_medico);

                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);// solo se ejecuta si hay error
            }

      }
        public DataSet consultar_Medico(CEndidadMedico omedico)
        {
            try
            {
                ocmd.Connection = oConexion.conectar("bdHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_consultar_medico";

                //declarar variables
                ocmd.Parameters.Add("@pid_medico", omedico.Id_medico);


                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
