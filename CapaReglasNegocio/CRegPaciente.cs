using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaReglasNegocio
{
    public class CRegPaciente
    {
        CDatoPacientecs odatpacientes = new CDatoPacientecs();

        public bool guardar_Paciente(ClEntidadPaciente oenpaciente)
        {
            return odatpacientes.guardar_Paciente(oenpaciente);
        }
        public DataSet consultar_Paciente(ClEntidadPaciente oenpaciente)
        {
            return odatpacientes.consultar_Paciente(oenpaciente);
        }
    }
}
