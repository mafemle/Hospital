using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEndidadMedico
    {
        private String id_medico;
        private String nom_medico;
        private String especialidad;
        private String tel_medico;
        private byte activo;

        public string Id_medico { get => id_medico; set => id_medico = value; }
        public string Nom_medico { get => nom_medico; set => nom_medico = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Tel_medico { get => tel_medico; set => tel_medico = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
