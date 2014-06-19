/*
 * Created by SharpDevelop.
 * User: erickdaniel
 * Date: 18/06/2014
 * Time: 05:57 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Agenda
{
	partial class Nuevo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo));
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.textdomicilio = new System.Windows.Forms.TextBox();
			this.textcolonia = new System.Windows.Forms.TextBox();
			this.textciudad = new System.Windows.Forms.TextBox();
			this.textemail = new System.Windows.Forms.TextBox();
			this.texttelefono = new System.Windows.Forms.TextBox();
			this.textcelular = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(25, 62);
			this.txtCodigo.MaxLength = 10;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 20);
			this.txtCodigo.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(25, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "alias";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(25, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(25, 116);
			this.txtNombre.MaxLength = 256;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(255, 20);
			this.txtNombre.TabIndex = 3;
			// 
			// btnGuardar
			// 
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(392, 263);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(96, 31);
			this.btnGuardar.TabIndex = 4;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// textdomicilio
			// 
			this.textdomicilio.Location = new System.Drawing.Point(25, 176);
			this.textdomicilio.MaxLength = 256;
			this.textdomicilio.Name = "textdomicilio";
			this.textdomicilio.Size = new System.Drawing.Size(255, 20);
			this.textdomicilio.TabIndex = 5;
			// 
			// textcolonia
			// 
			this.textcolonia.Location = new System.Drawing.Point(25, 231);
			this.textcolonia.MaxLength = 256;
			this.textcolonia.Name = "textcolonia";
			this.textcolonia.Size = new System.Drawing.Size(255, 20);
			this.textcolonia.TabIndex = 6;
			// 
			// textciudad
			// 
			this.textciudad.Location = new System.Drawing.Point(314, 62);
			this.textciudad.MaxLength = 256;
			this.textciudad.Name = "textciudad";
			this.textciudad.Size = new System.Drawing.Size(255, 20);
			this.textciudad.TabIndex = 7;
			// 
			// textemail
			// 
			this.textemail.Location = new System.Drawing.Point(314, 116);
			this.textemail.MaxLength = 256;
			this.textemail.Name = "textemail";
			this.textemail.Size = new System.Drawing.Size(255, 20);
			this.textemail.TabIndex = 8;
			// 
			// texttelefono
			// 
			this.texttelefono.Location = new System.Drawing.Point(314, 176);
			this.texttelefono.MaxLength = 256;
			this.texttelefono.Name = "texttelefono";
			this.texttelefono.Size = new System.Drawing.Size(255, 20);
			this.texttelefono.TabIndex = 9;
			// 
			// textcelular
			// 
			this.textcelular.Location = new System.Drawing.Point(314, 231);
			this.textcelular.MaxLength = 256;
			this.textcelular.Name = "textcelular";
			this.textcelular.Size = new System.Drawing.Size(255, 20);
			this.textcelular.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(25, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "domicilio";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(314, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "ciudad";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(314, 90);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "email";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(314, 150);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 14;
			this.label6.Text = "telefono";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(314, 205);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 15;
			this.label7.Text = "celular";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(25, 205);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 16;
			this.label8.Text = "colonia";
			// 
			// Nuevo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(587, 306);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textcelular);
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
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Nuevo";
			this.Text = "Nuevo";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textcelular;
		private System.Windows.Forms.TextBox texttelefono;
		private System.Windows.Forms.TextBox textemail;
		private System.Windows.Forms.TextBox textciudad;
		private System.Windows.Forms.TextBox textcolonia;
		private System.Windows.Forms.TextBox textdomicilio;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCodigo;
	}
}
