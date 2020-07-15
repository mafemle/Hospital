﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEntidadCitas
    {
        private String cod_cita;
        private DateTime fecha;
        private DateTime hora;
        private String Id_paciente;
        private String id_medico;
        private int valor;
        private String diagnostico;
        private String Nom_acompanante;
        private byte activo;

        //realizar encapculamiento

        public string Cod_cita { get => cod_cita; set => cod_cita = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public string Id_paciente1 { get => Id_paciente; set => Id_paciente = value; }
        public string Id_medico { get => id_medico; set => id_medico = value; }
        public int Valor { get => valor; set => valor = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Nom_acompanante1 { get => Nom_acompanante; set => Nom_acompanante = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
