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
    public class CRegCitas
    {
        CDatCitas odatcitas = new CDatCitas();

        public bool guardar_Cita(CEntidadCitas oenticitas) {
            return odatcitas.guardar_Cita(oenticitas);
        }

        public bool anular_Cita(CEntidadCitas oenticitas) {
            return odatcitas.anular_Cita(oenticitas);
        }

        public DataSet consultar_Cita(CEntidadCitas oenticitas) {
            return odatcitas.consultar_cita(oenticitas);
        }
    }
}
