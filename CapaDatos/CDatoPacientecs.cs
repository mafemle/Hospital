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
    public class CDatoPacientecs
    {
        CConexion oConexion = new CConexion();
        SqlCommand ocmd = new SqlCommand();

        public bool guardar_Paciente(ClEntidadPaciente opacientes)
        {
            try
            {
                ocmd.Connection = oConexion.conectar("bdHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_guardar_paciente";

                ocmd.Parameters.Add("@pId_paciente", opacientes.Id_paciente1);
                ocmd.Parameters.Add("@ptip_doc", opacientes.Tip_doc);
                ocmd.Parameters.Add("@pnom_paciente", opacientes.Nom_paciente);
                ocmd.Parameters.Add("@pdir_paciente", opacientes.Dir_paciente);
                ocmd.Parameters.Add("@ptel_paciente", opacientes.Tel_paciente);
                ocmd.Parameters.Add("@pcel_paciente", opacientes.Cel_paciente);

                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);// solo se ejecuta si hay error
            }
        }
        public DataSet consultar_Paciente(ClEntidadPaciente opacientes)
            {
                try
                {
                ocmd.Connection = oConexion.conectar("bdHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_consultar_paciente";

                //declarar variables
                ocmd.Parameters.Add("@pId_paciente", opacientes.Id_paciente1);


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
