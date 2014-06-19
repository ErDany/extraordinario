/*
 * Created by SharpDevelop.
 * User: erickdaniel
 * Date: 18/06/2014
 * Time: 05:26 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Agenda
{
	/// <summary>
	/// Description of contactos.
	/// </summary>
	public class contactos : MySQL
	{
		public contactos ()
		{
		}
		
		public void mostrarTodos(){
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(), 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
	            string id = myReader["id"].ToString();
	            string codigo = myReader["codigo"].ToString();
	            string nombre = myReader["nombre"].ToString();
                         string domicilio = myReader["domicilio"].ToString();
string colonia = myReader["colonia"].ToString();
string ciudad = myReader["ciudad"].ToString();
string email = myReader["email"].ToString();
string telefono = myReader["telefono"].ToString();
string celular = myReader["celular"].ToString();
	            Console.WriteLine("ID: " + id +
				                  " Código: " + codigo + 
				                  " Nombre: " + nombre+
" domicilio: " + domicilio +
" colonia: " + colonia +
" ciudad: " + ciudad +
" email: " + email +
" telefono: " + telefono +
" celular: " + celular);
	       }
			
            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
		}
		
		public Hashtable obtenerPorId(string id){
			Hashtable registro = new Hashtable();
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM contactos WHERE id = '"+id+"'", 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
            if(myReader.HasRows){
	        	myReader.Read();
	        	registro["id"] = myReader["id"].ToString();
	            registro["alias"] = myReader["alias"].ToString();
	            registro["nombre"] = myReader["nombre"].ToString();
                registro["domicilio"] = myReader["domicilio"].ToString();
                registro["colonia"] = myReader["colonia"].ToString();
                registro["ciudad"] = myReader["ciudad"].ToString();
                registro["email"] = myReader["email"].ToString();
                registro["telefono"] = myReader["telefono"].ToString();
                registro["celular"] = myReader["celular"].ToString();
	       }
          
            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
			return registro;
		}
		
		public void insertarRegistroNuevo(string alias, string nombre, string domicilio, string colonia, string ciudad, string email, string telefono, string celular){
			this.abrirConexion();
			string sql = "INSERT INTO `contactos` (`alias`, `nombre`, `domicilio`, `colonia`, `ciudad`, `email`, `telefono`, `celular` ) VALUES ('" + alias + "', '" + nombre + "', '" + domicilio + "', '" + colonia + "', '" + ciudad + "', '" + email + "', '" + telefono + "', '" + celular + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		public void editar(string id, string alias, string nombre, string domicilio, string colonia, string ciudad, string email, string telefono, string celular){
			this.abrirConexion();
			string sql = "UPDATE `contactos` SET `alias`='" + alias + "', `nombre`='" + nombre + "', `domicilio`='" + domicilio + "', `colonia`= '" + colonia + "', `ciudad`='" + ciudad + "', `email`= '" + email + "', `telefono`='" + telefono + "', `celular`='" + celular + "'WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		public void editarCodigoRegistro(string id, string alias){
			this.abrirConexion();
			string sql = "UPDATE `contactos` SET `codigo`='" + alias + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		public void editarNombreRegistro(string id, string nombre){
			this.abrirConexion();
			string sql = "UPDATE `contactos` SET `nombre`='" + nombre + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		public void editardomicilioRegistro(string id, string domicilio){
			this.abrirConexion();
			string sql = "UPDATE `contactos` SET `domicilio`='" + domicilio + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
public void editarcoloniaRegistro(string id, string colonia){
			this.abrirConexion();
			string sql = "UPDATE `contactos` SET `colonia`='" + colonia + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
public void editarciudadRegistro(string id, string ciudad){
			this.abrirConexion();
			string sql = "UPDATE `contactos` SET `ciudad`='" + ciudad + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
public void editaremailRegistro(string id, string email){
			this.abrirConexion();
			string sql = "UPDATE `contactos` SET `email`='" + email+ "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
public void editartelefonoRegistro(string id, string telefono){
			this.abrirConexion();
			string sql = "UPDATE `contactos` SET `telefono`='" + telefono + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
public void editarcelularRegistro(string id, string celular){
			this.abrirConexion();
			string sql = "UPDATE `contactos` SET `celular`='" + celular + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		public void eliminarRegistroPorId(string id){
			this.abrirConexion();
			string sql = "DELETE FROM `contactos` WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
		
		private string querySelect(){
			return "SELECT * " +
	           	"FROM contactos";
		}
	}
}
