﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de conexion
/// </summary>
public class conexion
{
    public string busca;
    public string contra;
    public string nombre;
    public string apellido;

    /* CONEXION
     * CON
     * BASE DE DATOS */

    SqlConnection con = new SqlConnection("Data Source = guitarshop.mssql.somee.com; Persist Security Info=True;User ID = fernando9825_SQLLogin_2; Password=8nwapgzhqt");
    public SqlCommand comando;

    //METODO CONECTAR//

    public void conectar()
    {
        try
        {
            con.Open();
        }
        catch
        {

        }
        finally
        {
            con.Close();
        }

    }

    //FIN METODO CONECTAR//

    //METODO GUARDAR

    public void guardar(string sql)
    {
        con.Open();
        comando = new SqlCommand(sql, con);
        int i = comando.ExecuteNonQuery();
        if (i > 0)
        {

        }
        else
        {

        }


    }

    //FIN METODO GUARDAR//

    //METODO GUARDAR//
    public bool eliminar(string elimina)
    {
        con.Open();
        comando = new SqlCommand(elimina, con);
        int i = comando.ExecuteNonQuery();
        if (i > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //FIN METODO GUARDAR

    //METODO ACTUALIZAR

    public bool actualizar(string tabla, string campos, string condicion)
    {
        con.Open();
        string actualizar = "update " + tabla + " set " + campos + " where " + condicion;
        int i = comando.ExecuteNonQuery();
        if (i > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    //FIN METODO ACTUALIZAR  


    //BUSCAR
    public void buscar()
    {


        try
        {
            SqlConnection con1 = new SqlConnection("Data Source = guitarshop.mssql.somee.com; Persist Security Info=True;User ID = fernando9825_SQLLogin_2; Password=8nwapgzhqt");
            con1.Open();
            string cadsql = "SELECT *FROM Registro WHERE usuario ='" + busca + "'";
            SqlCommand comando = new SqlCommand(cadsql, con1);
            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read() == true)
            {
               
                nombre = leer["nombre"].ToString();
                apellido = leer["apellido"].ToString();
                contra = leer["contraseña"].ToString();
                

            }
        }
        catch (Exception)
        {


        }
    }

    

}




