//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIIFv2Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class Banco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Banco()
        {
            this.Cuenta = new HashSet<Cuenta>();
        }
    
        [Key]
        public short Banco_Id { get; set; }
        public string Banco_Dsc { get; set; }
        public string Banco_Dsc_Corta { get; set; }
        public string Banco_Clave_CNBV { get; set; }
        public bool Banco_Opera_Digito { get; set; }
        public string Banco_Clave_Financiera { get; set; }
        public string Banco_Cuenta_Contable { get; set; }
        public bool Banco_Habilitado { get; set; }
        public bool Banco_Permite_ModCtaCientes { get; set; }
        public bool Banco_Certifica_CuentaClientes { get; set; }
        public bool Banco_GeneraLayout_CertificacionCta { get; set; }
        public bool Banco_ConfirmaLayout_CertificacionCta { get; set; }
        public short Banco_Longitud_Cuenta { get; set; }
        public bool Banco_Maneja_Domiciliacion { get; set; }
        public bool Banco_RequiereAltaBaja_Domiciliacion { get; set; }
        public int Banco_Clave_Banxico { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuenta> Cuenta { get; set; }

        public List<Banco> Listar()
        {
            List<Banco> bancos;

            try
            {
                using (var ctx = new SIIFMF05Entities ())
                {
                    string sqlQry = "";
                        /*" SELECT  DISTINCT  CampoId =Banco_Id, NombreCampo=Banco_Dsc_Corta " +
                        " FROM SIIFMF05.dbo.Banco WHERE Banco_Id <> 999 AND Banco_Id IN (" + 
                        " SELECT  DISTINCT Cuenta.Banco_Id FROM SIIFMF05.dbo.Cuenta" +
                        " WHERE Cuenta.Tipo_Cuenta_Banco_Id IN ( 5, 20) ) ORDER BY Banco_Dsc_Corta";
                        */
                    sqlQry = "SELECT DISTINCT Banco_Id AS CampoId, Banco_Dsc_Corta AS NombreCampo FROM Banco AS B WHERE (Banco_Id <> 999) AND (Banco_Id IN (SELECT DISTINCT Banco_Id FROM Cuenta WHERE (Tipo_Cuenta_Banco_Id IN (5, 20)))) ORDER BY NombreCampo";
                    bancos = ctx.Banco.SqlQuery(sqlQry).ToList();

                }
            }
            catch (Exception)
            {
                bancos = null;
                throw;
                
            }

            return bancos;
        }








    }
}
