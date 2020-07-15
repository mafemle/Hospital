using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaEntidad;
using CapaReglasNegocio;
using System.Data;

namespace Hostipal
{
    public partial class Citas : System.Web.UI.Page
    {
        CRegCitas oregcitas = new CRegCitas();
        CEntidadCitas oentcitas = new CEntidadCitas();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncita_Click(object sender, EventArgs e)
        {
            if (Txtcod_cita.Text == "")
            {
                LblConfirmacionCita.Text = "No se ha digitado un codigo de cita";
                Txtcod_cita.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                oentcitas.Cod_cita = Txtcod_cita.Text;
                ds = oregcitas.consultar_Cita(oentcitas);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    LblConfirmacionCita.Text = "La cita no esta asignada";
                    TxtIfechaCita.Focus();
                }
                else
                {
                    TxtIfechaCita.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
                    TxtHoraCita.Text = ds.Tables[0].Rows[0]["hora"].ToString();
                    TxtId_paciente.Text = ds.Tables[0].Rows[0]["Id_paciente"].ToString();
                    LblNombrePaciente.Text = ds.Tables[1].Rows[0]["nom_paciente"].ToString();
                    LblTelPaciente.Text = ds.Tables[1].Rows[0]["tel_paciente"].ToString();
                    Txtid_medico.Text = ds.Tables[0].Rows[0]["id_medico"].ToString();
                    LblNombreMedico.Text = ds.Tables[2].Rows[0]["nom_medico"].ToString();
                    LblEspecialidad.Text = ds.Tables[2].Rows[0]["especialidad"].ToString();
                    Txtvalor.Text = ds.Tables[0].Rows[0]["valor"].ToString();
                    Txtdiagnostico.Text = ds.Tables[0].Rows[0]["diagnostico"].ToString();
                    TxtNom_acompanante.Text = ds.Tables[0].Rows[0]["Nom_acompanante"].ToString();
                }
    }
}

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            oentcitas.Cod_cita = Txtcod_cita.Text;
            oentcitas.Fecha = Convert.ToDateTime(TxtIfechaCita.Text);
            oentcitas.Hora = Convert.ToDateTime(TxtHoraCita.Text);
            oentcitas.Id_paciente1 = TxtId_paciente.Text;
            oentcitas.Id_medico = Txtid_medico.Text;
            oentcitas.Valor = Convert.ToInt32(Txtvalor.Text);
            oentcitas.Diagnostico = Txtdiagnostico.Text;
            oentcitas.Nom_acompanante1 = TxtNom_acompanante.Text;

            if (oregcitas.guardar_Cita(oentcitas)) {
                LblConfirmacionCita.Text = "Registro guardado Exitosamente";
            }
            else
            {
                LblConfirmacionCita.Text = "Error no se pudo guardar el registro";
            }
        }
    }
}