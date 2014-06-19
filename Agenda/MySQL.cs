/*
 * Created by SharpDevelop.
 * User: erickdaniel
 * Date: 18/06/2014
 * Time: 05:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace Agenda
{
	/// <summary>
	/// Description of MySQL.
	/// </summary>
	public class MySQL
	{
		protected MySqlConnection myConnection;
		public MySQL ()
		{
		}
		
		protected void abrirConexion(){
			string connectionString =
          		"Server=localhost;" +
	          	"Database=Agenda;" +
	          	"User ID=root;" +
	          	"Password=erdacaro21.;" +
	          	"Pooling=false;";
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
		}
		
		protected void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}
	}
}

