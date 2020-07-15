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
    public partial class Medicos : System.Web.UI.Page
    {
        CRegMedico oregmedico = new CRegMedico();
        CEndidadMedico oentmedico = new CEndidadMedico();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btConsultarMedico_Click(object sender, EventArgs e)
        {
            if (Txtid_medico.Text == "")
            {
                lblConsultarMedico.Text = "No se ha digitado medico";
                Txtid_medico.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                oentmedico.Id_medico = Txtid_medico.Text;
                ds = oregmedico.consultar_Medico(oentmedico);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    lblConsultarMedico.Text = "El medico no esta registrado";
                    Txtnom_medico.Focus();
                }
                else
                {
                    Txtid_medico.Text = ds.Tables[0].Rows[0]["id_medico"].ToString();
                    Txtnom_medico.Text = ds.Tables[0].Rows[0]["nom_medico"].ToString();
                    Txtespecialidad.Text = ds.Tables[0].Rows[0]["especialidad"].ToString();
                    Txttel_medico.Text = ds.Tables[0].Rows[0]["tel_medico"].ToString();
                    lblConsultarMedico.Text = "Ya existe un registro del Medico";
                }

            }
        }

        protected void btguardarMedico_Click(object sender, EventArgs e)
        {
            oentmedico.Id_medico = Txtid_medico.Text;
            oentmedico.Nom_medico = Txtnom_medico.Text;
            oentmedico.Especialidad = Txtespecialidad.Text;
            oentmedico.Tel_medico = Txttel_medico.Text;

            if (oregmedico.guardar_Medico(oentmedico))
            {
                lblguardarMedico.Text = "Registro guardado Exitosamente";
            }
            else
            {
                lblguardarMedico.Text = "Registro no pudo ser guardado";
            }
        }
    }
}