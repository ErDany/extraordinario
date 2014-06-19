/*
 * Created by SharpDevelop.
 * User: erickdaniel
 * Date: 18/06/2014
 * Time: 05:35 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Agenda
{
	/// <summary>
	/// Description of Editar.
	/// </summary>
	public partial class Editar : Form
	{
		private MainForm main;
		private string id;
		
		public Editar(MainForm main, string id)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.main = main;
			this.id = id;
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(this.txtCodigo.Text.Trim()!="" && this.txtNombre.Text.Trim()!=""&& this.textdomicilio.Text.Trim()!=""&& this.textcolonia.Text.Trim()!=""&& this.textciudad.Text.Trim()!=""&& this.textemail.Text.Trim()!=""&& this.texttelefono.Text.Trim()!=""&& this.textcelular.Text.Trim()!=""){
				contactos contactos = new contactos();
				contactos.editar(this.id, this.txtCodigo.Text.Trim(), this.txtNombre.Text.Trim(), this.textdomicilio.Text.Trim(), this.textcolonia.Text.Trim(), this.textciudad.Text.Trim(), this.textemail.Text.Trim(), this.texttelefono.Text.Trim(), this.textcelular.Text.Trim());
				this.main.actualizarTabla();
				MessageBox.Show("Se editó con exito");
				this.Close();
			}
		}
		
		
		void EditarLoad(object sender, EventArgs e)
		{
			System.Collections.Hashtable registro = new System.Collections.Hashtable();
			contactos contactos = new contactos();
			registro= contactos.obtenerPorId(this.id);
			this.txtCodigo.Text =registro["alias"].ToString();
			this.txtNombre.Text =registro["nombre"].ToString();
			this.textdomicilio.Text =registro["domicilio"].ToString();
			this.textcolonia.Text =registro["colonia"].ToString();
			this.textciudad.Text =registro["ciudad"].ToString();
			this.textemail.Text =registro["email"].ToString();
			this.texttelefono.Text =registro["telefono"].ToString();
			this.textcelular.Text =registro["celular"].ToString();
			
			
		}
	}
}
