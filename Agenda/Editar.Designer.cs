/*
 * Created by SharpDevelop.
 * User: erickdaniel
 * Date: 18/06/2014
 * Time: 05:35 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Agenda
{
	partial class Editar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.textdomicilio = new System.Windows.Forms.TextBox();
			this.textcolonia = new System.Windows.Forms.TextBox();
			this.textciudad = new System.Windows.Forms.TextBox();
			this.textemail = new System.Windows.Forms.TextBox();
			this.texttelefono = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textcelular = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnGuardar
			// 
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(429, 241);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(96, 31);
			this.btnGuardar.TabIndex = 9;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(12, 109);
			this.txtNombre.MaxLength = 256;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(255, 20);
			this.txtNombre.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Nombre";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "alias";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(12, 55);
			this.txtCodigo.MaxLength = 10;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 20);
			this.txtCodigo.TabIndex = 5;
			// 
			// textdomicilio
			// 
			this.textdomicilio.Location = new System.Drawing.Point(12, 160);
			this.textdomicilio.MaxLength = 256;
			this.textdomicilio.Name = "textdomicilio";
			this.textdomicilio.Size = new System.Drawing.Size(255, 20);
			this.textdomicilio.TabIndex = 10;
			// 
			// textcolonia
			// 
			this.textcolonia.Location = new System.Drawing.Point(12, 215);
			this.textcolonia.MaxLength = 256;
			this.textcolonia.Name = "textcolonia";
			this.textcolonia.Size = new System.Drawing.Size(255, 20);
			this.textcolonia.TabIndex = 11;
			// 
			// textciudad
			// 
			this.textciudad.Location = new System.Drawing.Point(326, 55);
			this.textciudad.MaxLength = 256;
			this.textciudad.Name = "textciudad";
			this.textciudad.Size = new System.Drawing.Size(255, 20);
			this.textciudad.TabIndex = 12;
			// 
			// textemail
			// 
			this.textemail.Location = new System.Drawing.Point(326, 109);
			this.textemail.MaxLength = 256;
			this.textemail.Name = "textemail";
			this.textemail.Size = new System.Drawing.Size(255, 20);
			this.textemail.TabIndex = 13;
			// 
			// texttelefono
			// 
			this.texttelefono.Location = new System.Drawing.Point(326, 160);
			this.texttelefono.MaxLength = 256;
			this.texttelefono.Name = "texttelefono";
			this.texttelefono.Size = new System.Drawing.Size(255, 20);
			this.texttelefono.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "domicilio";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 189);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 16;
			this.label4.Text = "colonia";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(326, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "ciudad";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(326, 82);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 18;
			this.label6.Text = "email";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(326, 134);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 19;
			this.label7.Text = "telefono";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(326, 189);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 20;
			this.label8.Text = "celular";
			// 
			// textcelular
			// 
			this.textcelular.Location = new System.Drawing.Point(326, 215);
			this.textcelular.MaxLength = 256;
			this.textcelular.Name = "textcelular";
			this.textcelular.Size = new System.Drawing.Size(255, 20);
			this.textcelular.TabIndex = 21;
			// 
			// Editar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(593, 284);
			this.Controls.Add(this.textcelular);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.texttelefono);
			this.Controls.Add(this.textemail);
			this.Controls.Add(this.textciudad);
			this.Controls.Add(this.textcolonia);
			this.Controls.Add(this.textdomicilio);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCodigo);
			this.Name = "Editar";
			this.Text = "Editar";
			this.Load += new System.EventHandler(this.EditarLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textcelular;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox texttelefono;
		private System.Windows.Forms.TextBox textemail;
		private System.Windows.Forms.TextBox textciudad;
		private System.Windows.Forms.TextBox textcolonia;
		private System.Windows.Forms.TextBox textdomicilio;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnGuardar;
	}
}
