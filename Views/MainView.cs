﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

using Npgsql; // Libreria para conectar con PostgreSQL
using TurApp.db; // incluir libreria para poder acceder a los objetos de negocios.

namespace TurApp.Views
{    
    public partial class MainView : FormBase
    {
        private Usuario _usuarioActual = null;
        public Usuario UsuarioActual
        {
            get { return _usuarioActual; }
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        public void ShowUsuario()
        {
            _usuarioActual = Usuario.UsuarioSys;
            StatusInfoUser.Text = String.Format("Usuario: {0} - {1}", _usuarioActual.UsuarioName, _usuarioActual.FechaLogin); ;
            // mostrar los permisos del usuario en base a los roles, leer cada permiso.
            // Recorrer cada item de Menu, para verificar primero los grupos  y luego cada opcion.
            var list = this.menuStrip1.Items.Cast < ToolStripMenuItem>().ToList().Where(t=> t.Name.IndexOf("mnu_top") != -1);
            List<Funcion> listFuncUser = UsuarioActual.ListadoFunciones;
            bool prmOK=false;
            foreach (var item in list)
	        {
                // verificar el permiso puede incluir listado hacer split.
                prmOK = false;
                string perm = item.Tag.ToString();
                string[] listFunciones = perm.Split(',');
                for (int i = 0; i < listFunciones.Length; i++)
                {
                    prmOK = prmOK || listFuncUser.Find(ff => ff.Nombre == listFunciones[i])!=null;
                }
                item.Enabled = prmOK;
                //por cada ItemPrincipal, verificar los SubItems por debajo si tiene permiso.

                var list_subitm = item.DropDownItems.Cast<ToolStripMenuItem>().ToList();
                                
                foreach (var subitm in list_subitm)
                {
                    prmOK = false;
                    string permsub = subitm.Tag.ToString();
                    string[] listFuncionesSub = permsub.Split(',');
                    for (int i = 0; i < listFuncionesSub.Length; i++)
                    {
                        prmOK = prmOK || listFuncUser.Find(ff => ff.Nombre == listFuncionesSub[i]) != null;
                    }                    
                    subitm.Enabled = prmOK;
                }
            }
            // aplicar permiso a cada submenu.
            
            this.Visible = true;
        }
        private static readonly MainView instance = new MainView();
        static MainView()
        {
            
        }
        private MainView()
        {
            InitializeComponent();
        }
        // Implementacion de Patron Singleton
        public static MainView Instance
        {
            get
            {
                return instance;
            }
        }

        public void ShowMain(FrmLogin loginFrm, Usuario user)
        {
            loginFrm.Dispose();
            loginFrm= null;
            _usuarioActual = user;
            this.Show();
        }
        private void MainView_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin;
            if (_usuarioActual == null)
            {
                this.Visible = false;
                frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                if (_usuarioActual == null)
                {
                    Application.Exit();
                    return;
                }
                this.Visible = true;
            }
        }

        private void IngresoEspecialidadMnu_Click(object sender, EventArgs e)
        {
            
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                MessageBox.Show("Operacion realizada correctamente " , "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Verificar si hay Form de Listado para poder actualizar la lista de datos..
            }
            else
            {
                MessageBox.Show("Ocurrio un error: " + ev.Mensaje,"Error...",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }             

        private void IngresoTuristaMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmTuristaAM frm = new FrmTuristaAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoTurista(this);
        }

        private void IngresoPaqueteMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmPaqueteAM frm = new FrmPaqueteAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoPaquete(this);
        }

        private void BuscarTuristaMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmTuristaBusq frm = new FrmTuristaBusq();
            frm.ShowBuscar();
        }

        private void ListadoTuristaMnu_Click(object sender, EventArgs e)
        {
            FrmListadoTuristas frmListPac = new FrmListadoTuristas();
            frmListPac.Show();
        }

        private void ListadoAgencias_Click(object sender, EventArgs e)
        {
            FrmListadoAgencias frm = new FrmListadoAgencias();
            frm.Show();
        }

        private void IngresoAgencia_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmAgenciaAM frm = new FrmAgenciaAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoAgencia();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmAgenciaBusq frmba = new FrmAgenciaBusq();
            frmba.ShowBuscar();
        }

        
        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir del sistema?", "salida..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
                return;
            }
            e.Cancel = true;
        }

        private void ActividadAM_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmActividadAM frm = new FrmActividadAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoActividad();
        }

        private void Turistas_mnu_top_Click(object sender, EventArgs e)
        {

        }

        private void localidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListadoLocalidades frm = new FrmListadoLocalidades();
            frm.Show();
        }

        private void LocalidadAM_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmLocalidadAM frm = new FrmLocalidadAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoLocalidad();
        }

        private void BuscarLocalidad_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmLocalidadBusq frm = new FrmLocalidadBusq();
            frm.ShowBuscar();
        }

        private void FormaPagoAM_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmFormaPagoAM frm = new FrmFormaPagoAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoFormaPago();
        }

        private void BuscarFormaPago_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmFormaPagoBusq frm = new FrmFormaPagoBusq();
            frm.ShowBuscar();
        }

        private void ListadoFormaPago_Click(object sender, EventArgs e)
        {
            FrmListadoFormaPago frmListPac = new FrmListadoFormaPago();
            frmListPac.Show();
        }

         private void PaqueteAM_mnu_Click(object sender, EventArgs e)
         {
             MainView.Instance.Cursor = Cursors.WaitCursor;
             FrmPaqueteAM frm = new FrmPaqueteAM();
             frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
             frm.ShowIngresoPaquete();
         }

        private void BuscarPaquete_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmPaqueteBusq frm = new FrmPaqueteBusq();
            frm.ShowBuscar();
        }

       
        private void BuscarActividad_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmActividadBusq frm = new FrmActividadBusq();
            frm.ShowBuscar();
        }

        private void TipoPaqueteAM_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmTipoPaqueteAM frm = new FrmTipoPaqueteAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoTipoPaquete();
        }

        private void BuscarTipoPaquete_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmTipoPaqueteBusq frm = new FrmTipoPaqueteBusq();
            frm.ShowBuscar();
        }


        private void ListadoDestinoMnu_Click(object sender, EventArgs e)
        {
            FrmListadoDestinos frmListPac = new FrmListadoDestinos();
            frmListPac.Show();
        }

        
         private void FacturaAM_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmFacturaAM frm = new FrmFacturaAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoFactura();
        }

         private void BuscarTipoAct_mnu_Click(object sender, EventArgs e)
         {
             MainView.Instance.Cursor = Cursors.WaitCursor;
             FrmTipoActividadBusq frm = new FrmTipoActividadBusq();
             frm.ShowBuscar();
         }

         private void ListadoTipoPaqueteMnu_Click(object sender, EventArgs e)
         {
             FrmListadoTipoPaquete frmListPac = new FrmListadoTipoPaquete();
             frmListPac.Show();
         }

         private void TipoActivAM_mnu_Click(object sender, EventArgs e)
         {
             MainView.Instance.Cursor = Cursors.WaitCursor;
             FrmTipoActividadAM frm = new FrmTipoActividadAM();
             frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
             frm.ShowIngresoTipoActividad();
         }

         private void TipoActividadToolStripMenuItem1_Click(object sender, EventArgs e)
         {
             FrmListadoTipoActividad frmListPac = new FrmListadoTipoActividad();
             frmListPac.Show();
         }

         private void ListadoPaisesMnu_Click(object sender, EventArgs e)
         {
             FrmListadoPaises frmListPac = new FrmListadoPaises();
             frmListPac.Show();
         }

         private void ListadoPaqueteMnu_Click(object sender, EventArgs e)
         {
             FrmListadoPaquetes frmListPac = new FrmListadoPaquetes();
             frmListPac.Show();
         }

         private void ListadoAuditoriaMnu_Click(object sender, EventArgs e)
         {
            FrmListadoAuditoria frmListPac = new FrmListadoAuditoria();
            frmListPac.Show();
         }

         private void ActividadesToolStripMenuItem1_Click(object sender, EventArgs e)
         {
             FrmListadoActividad frmListPac = new FrmListadoActividad();
             frmListPac.Show();
         }

         private void ingresoTransporte_Click(object sender, EventArgs e)
         {
             MainView.Instance.Cursor = Cursors.WaitCursor;
             FrmTransporteAm frm = new FrmTransporteAm();
             frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
             frm.ShowIngresoTransporte();
         }

         private void buscarTransporte_Click(object sender, EventArgs e)
         {
             MainView.Instance.Cursor = Cursors.WaitCursor;
             FrmTransporteBusq frm = new FrmTransporteBusq();
             frm.ShowBuscar();
         }

         private void TransportesToolStripMenuItem1_Click(object sender, EventArgs e)
         {
             FrmListadoTransportes frm = new FrmListadoTransportes();
             frm.Show();
         }

         private void AcercaDeMnu_Click(object sender, EventArgs e)
         {
             FrmAcercaDe frm = new FrmAcercaDe();
             frm.Show();
         }

    }
}
