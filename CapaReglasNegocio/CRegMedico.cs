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
    public class CRegMedico
    {
        CDatMedico odatmedico = new CDatMedico();
        public bool guardar_Medico(CEndidadMedico oenmedico)
        {
            return odatmedico.guardar_Medico(oenmedico);
        }
       public DataSet consultar_Medico(CEndidadMedico oenmedico)
        {
            return odatmedico.consultar_Medico(oenmedico);
        }

    }
}
