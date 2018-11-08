﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicio61
{
    public class PersonaDAO
    {
        SqlConnection conexion;
        SqlCommand comando;
        
        public PersonaDAO()
        {
            conexion = new SqlConnection("Data Source=LAB3PC07\\SQLEXPRESS;Initial Catalog=AdventureWorks2012;Integrated Security=True");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public List<Persona> Leer()
        {
            comando.CommandText = "SELECT ID, Nombre, Apellido FROM Persona";
            conexion.Open();
            SqlDataReader oDr = comando.ExecuteReader();
            List<Persona> lsPersonas = new List<Persona>();
            while(oDr.Read())
            {
                lsPersonas.Add(new Persona(oDr["ID"].ToString(), oDr["Nombre"].ToString(), oDr["Apellido"].ToString()));
            }
            conexion.Close();
            return lsPersonas;
        }

        public void Guardar(Persona p)
        {
            comando.CommandText = "INSERT INTO Persona (Nombre, Apellido) VALUES('" + p.Nombre + "', '" + p.Apellido + "')";
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Modificar(Persona p)
        {
            comando.CommandText = "UPDATE Persona SET Nombre = '" + p.Nombre + "', Apellido = '" + p.Apellido + "' WHERE ID = " + p.ID;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Borrar(Persona p)
        {
            comando.CommandText = "DELETE FROM Persona WHERE ID = " + p.ID;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }


    }
}
