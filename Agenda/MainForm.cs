/*
 * Created by SharpDevelop.
 * User: erickdaniel
 * Date: 18/06/2014
 * Time: 04:35 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Agenda
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private MySqlCommand myCmdQuery;
		private MySqlDataAdapter myDataAdapter;
		private BindingSource myBindingSource;
		private MySqlCommandBuilder myCommandBuilder;
		private DataSet myDataSet;
		private MySqlConnection myConnection;
		private string myStringCon;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.myCmdQuery= new MySqlCommand();
			this.myDataAdapter=new MySqlDataAdapter();
			this.myBindingSource=new BindingSource();
			this.myCommandBuilder =new MySqlCommandBuilder();
			this.myDataSet=new DataSet();
			this.myStringCon=
				"Server=localhost;" +
				"Database=agenda;" +
				"User ID=root;" +
				"Password=erdacaro21.;" +
				"Pooling=false;";
			

		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//create an instance of MySqlConnection class
			this.myConnection = new MySqlConnection(this.myStringCon);
			try{
				this.myConnection.Open();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
				System.Environment.Exit(1);
			}
			
			this.myCmdQuery.CommandText="SELECT * FROM contactos";
			this.myCmdQuery.CommandType=CommandType.Text;
			this.myCmdQuery.Connection=this.myConnection;
			
			this.myDataAdapter.SelectCommand=this.myCmdQuery;
			this.myCommandBuilder.DataAdapter=this.myDataAdapter;

			//Llenar el dataset
			this.myDataAdapter.Fill(this.myDataSet,"contactos");
			this.myBindingSource.DataSource=this.myDataSet;
			this.myBindingSource.DataMember="contactos";
			this.myDataGrid.DataSource=this.myBindingSource;

		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			Nuevo nuevo = new Nuevo(this);
			nuevo.Show();
		}
		
		void BtnEditarClick(object sender, EventArgs e)
		{
			if(this.myDataGrid.SelectedRows.Count>0){
				DataGridViewRow row = this.myDataGrid.SelectedRows[0];
				DataGridViewCell cell = row.Cells[0];
				string id = cell.Value.ToString();
				Editar editar = new Editar(this, id);
				editar.Show();
			}
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if(this.myDataGrid.SelectedRows.Count>0){
				DataGridViewRow row = this.myDataGrid.SelectedRows[0];
				DataGridViewCell cell0 = row.Cells[0];
				DataGridViewCell cell1 = row.Cells[1];
				DataGridViewCell cell2 = row.Cells[2];
				DataGridViewCell cell3 = row.Cells[3];
				DataGridViewCell cell4 = row.Cells[4];
				DataGridViewCell cell5 = row.Cells[5];
				DataGridViewCell cell6 = row.Cells[6];
				DataGridViewCell cell7 = row.Cells[7];
				DataGridViewCell cell8 = row.Cells[8];
				string id = cell0.Value.ToString();
				string alias = cell1.Value.ToString();
				string nombre = cell2.Value.ToString();
                string domicilio = cell3.Value.ToString();
                string colonia = cell4.Value.ToString();
                string ciudad = cell5.Value.ToString();
                string email = cell6.Value.ToString();
                string telefono = cell7.Value.ToString();
                string celular = cell8.Value.ToString();
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"¿Está seguro que desea eliminar al contacto con alias " + alias + "?", "Confirmar eliminación",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);
				
				if(result == System.Windows.Forms.DialogResult.Yes){
					this.eliminarcontactos(id);
					this.actualizarTabla();
					MessageBox.Show("El contacto con el alias " + alias + " fue eliminado con exito.");
				}
			}
		}
		
		private void eliminarcontactos(string id){
			string sql = "DELETE FROM `contactos` WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
		}
		
		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
		
		public void actualizarTabla(){
			try{
				this.myDataSet.Clear();
				this.myDataAdapter.Fill(this.myDataSet,"contactos");
				this.myBindingSource.DataSource=this.myDataSet;
				this.myBindingSource.DataMember="contactos";
				this.myDataGrid.DataSource=this.myBindingSource;
				this.myDataGrid.Update();
				this.myDataGrid.Refresh();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
			}
		}
		
		
		void MyDataGridCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
