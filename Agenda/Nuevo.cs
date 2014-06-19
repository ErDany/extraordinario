/*
 * Created by SharpDevelop.
 * User: erickdaniel
 * Date: 18/06/2014
 * Time: 05:57 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Agenda
{
	/// <summary>
	/// Description of Nuevo.
	/// </summary>
	public partial class Nuevo : Form
	{
		private MainForm main;
		public Nuevo(MainForm main)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.main=main;
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(this.txtCodigo.Text.Trim()!="" && this.txtNombre.Text.Trim()!=""&& this.textdomicilio.Text.Trim()!=""&& this.textcolonia.Text.Trim()!=""&& this.textciudad.Text.Trim()!=""&& this.textemail.Text.Trim()!=""&& this.texttelefono.Text.Trim()!=""&& this.textcelular.Text.Trim()!=""){
				contactos contactos = new contactos();
				contactos.insertarRegistroNuevo(this.txtCodigo.Text.Trim(), this.txtNombre.Text.Trim(), this.textdomicilio.Text.Trim(), this.textcolonia.Text.Trim(), this.textciudad.Text.Trim(), this.textemail.Text.Trim(), this.texttelefono.Text.Trim(), this.textcelular.Text.Trim());
				this.main.actualizarTabla();
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"El contacto se agregó con exito ¿Desea agregar otro ?", "Nuevo contacto",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);
				
				if(result != System.Windows.Forms.DialogResult.Yes){
					this.Close();
				}else{
					this.txtCodigo.Clear();
					this.txtNombre.Clear();
					this.textdomicilio.Clear();
					this.textcolonia.Clear();
					this.textciudad.Clear();
					this.textemail.Clear();
					this.texttelefono.Clear();
					this.textcelular.Clear();
					
				}
			}
		}
	}
}
