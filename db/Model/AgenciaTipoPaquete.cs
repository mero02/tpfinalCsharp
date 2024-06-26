﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    [Table(Name = "agencia_tipo_paquete")]
    public partial class AgenciaTipoPaquete

    {
        #region variables locales
        private int _cod_agencia;
        private int _cod_tipo_paquete;
        private Agencia codAgencia = null;
        private TipoPaquete codTipoPaquete = null;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "cod_agencia", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int CodAgencia
        {
            get { return _cod_agencia; }
            set { _cod_agencia = value; }
        }

        [Propiedad(Name = "cod_tipo_paquete", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int CodTipoPaquete
        {
            get { return _cod_tipo_paquete; }
            set { _cod_tipo_paquete = value; }
        }
        
        #endregion 
       

        // -- TODO --
        #region Relaciones con otras entidades


        public TipoPaquete TipoPaqueteObj
        {
            get {
                if (codTipoPaquete == null && this.CodTipoPaquete != 0)
                {
                    codTipoPaquete = TipoPaquete.FindByKeyStatic(this.CodTipoPaquete);
                }
                return codTipoPaquete;
            }
        }

        public Agencia AgenciaObj
        {
            get {
                if (codAgencia == null && this.CodAgencia != 0)
                {
                    codAgencia = Agencia.FindByKeyStatic(this.CodAgencia);
                }
                return codAgencia;
            }
        }
        #endregion

    }

}
