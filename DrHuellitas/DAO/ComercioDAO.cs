﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Encriptacion;
using DrHuellitas.BO;
using System.Data.SqlClient;
using System.Data;

namespace DrHuellitas.DAO
{
    public class ComercioDAO
    {
        ConexionSQL conex;
        EncriptarMD5 MD5 = new EncriptarMD5();
        FotoBO Foto = new FotoBO();
        

        public ComercioDAO()
        {
            conex = new ConexionSQL();
        }

        public int ContinuarRegistroComercio(RegistrosBO objBo, int usuario)
        {
            if (objBo.horario.inicioLunes != null && objBo.horario.finalLunes != null)
            {

                SqlCommand comando = new SqlCommand("exec horariosUsu @horaini,@horfin,@dia,@idusuario");
                comando.Parameters.Add("@horaini", SqlDbType.Time).Value = objBo.horario.inicioLunes;
                comando.Parameters.Add("@horfin", SqlDbType.Time).Value = objBo.horario.finalLunes;
                comando.Parameters.Add("@dia", SqlDbType.VarChar).Value = objBo.horario.dia = "Lunes";
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = usuario;
                comando.CommandType = CommandType.Text;
                 conex.EjecutarComando(comando);
            }
            if (objBo.horario.inicioMarte != null && objBo.horario.finalMartes != null)
            {

                SqlCommand comando = new SqlCommand("exec horariosUsu @horaini,@horfin,@dia,@idusuario");
                comando.Parameters.Add("@horaini", SqlDbType.Time).Value = objBo.horario.inicioMarte;
                comando.Parameters.Add("@horfin", SqlDbType.Time).Value = objBo.horario.finalMartes;
                comando.Parameters.Add("@dia", SqlDbType.VarChar).Value = objBo.horario.dia = "Martes";
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = usuario;
                comando.CommandType = CommandType.Text;
                conex.EjecutarComando(comando);
            }
            if (objBo.horario.inicioMiercoles != null && objBo.horario.finalMiercoles != null)
            {

                SqlCommand comando = new SqlCommand("exec horariosUsu @horaini,@horfin,@dia,@idusuario");
                comando.Parameters.Add("@horaini", SqlDbType.Time).Value = objBo.horario.inicioMiercoles;
                comando.Parameters.Add("@horfin", SqlDbType.Time).Value = objBo.horario.finalMiercoles;
                comando.Parameters.Add("@dia", SqlDbType.VarChar).Value = objBo.horario.dia = "Miercoles";
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = usuario;
                comando.CommandType = CommandType.Text;
                conex.EjecutarComando(comando);
            }
            if (objBo.horario.inicioJueves != null && objBo.horario.finalJueves != null)
            {

                SqlCommand comando = new SqlCommand("exec horariosUsu @horaini,@horfin,@dia,@idusuario");
                comando.Parameters.Add("@horaini", SqlDbType.Time).Value = objBo.horario.inicioJueves;
                comando.Parameters.Add("@horfin", SqlDbType.Time).Value = objBo.horario.finalJueves;
                comando.Parameters.Add("@dia", SqlDbType.VarChar).Value = objBo.horario.dia = "Jueves";
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = usuario;
                comando.CommandType = CommandType.Text;
                 conex.EjecutarComando(comando);
            }
            if (objBo.horario.inicioViernes != null && objBo.horario.finalViernes != null)
            {

                SqlCommand comando = new SqlCommand("exec horariosUsu @horaini,@horfin,@dia,@idusuario");
                comando.Parameters.Add("@horaini", SqlDbType.Time).Value = objBo.horario.inicioViernes;
                comando.Parameters.Add("@horfin", SqlDbType.Time).Value = objBo.horario.finalViernes;
                comando.Parameters.Add("@dia", SqlDbType.VarChar).Value = objBo.horario.dia = "Viernes";
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = usuario;
                comando.CommandType = CommandType.Text;
                 conex.EjecutarComando(comando);
            }
            if (objBo.horario.inicioSabado != null && objBo.horario.finalSabado != null)
            {

                SqlCommand comando = new SqlCommand("exec horariosUsu @horaini,@horfin,@dia,@idusuario");
                comando.Parameters.Add("@horaini", SqlDbType.Time).Value = objBo.horario.inicioSabado;
                comando.Parameters.Add("@horfin", SqlDbType.Time).Value = objBo.horario.finalSabado;
                comando.Parameters.Add("@dia", SqlDbType.VarChar).Value = objBo.horario.dia = "Sabado";
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = usuario;
                comando.CommandType = CommandType.Text;
                 conex.EjecutarComando(comando);
            }
            if (objBo.horario.inicioDomingo != null && objBo.horario.finalDomingo != null)
            {

                SqlCommand comando = new SqlCommand("exec horariosUsu @horaini,@horfin,@dia,@idusuario");
                comando.Parameters.Add("@horaini", SqlDbType.Time).Value = objBo.horario.inicioDomingo;
                comando.Parameters.Add("@horfin", SqlDbType.Time).Value = objBo.horario.finalDomingo;
                comando.Parameters.Add("@dia", SqlDbType.VarChar).Value = objBo.horario.dia = "Domingo";
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = usuario;
                comando.CommandType = CommandType.Text;
                 conex.EjecutarComando(comando);
            }
            return 1;
        }

        public int ComercioDatos(RegistrosBO objbo, int id)
        {
            SqlCommand comando = new SqlCommand("EXEC datocomercio @nombre,@apellidos,@telefono,@fechanaci,@status,@foto,@nomco,@veterinaria,@estetica,@vendeproduc,@nomfis,@rfc,@telefono1,@telefono2,@email,@idusuario,@calle,@numero,@cruzamiento,@longitud,@latitud,@colonia,@cp,@idcidad");
            //aqui empieza datos generales del usuario
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = objbo.usuario.nombre;
            comando.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = objbo.usuario.apellidos;
            comando.Parameters.Add("@telefono", SqlDbType.Char).Value = objbo.usuario.telefono;
            comando.Parameters.Add("@fechanaci", SqlDbType.Date).Value = objbo.usuario.fechanacimiento.ToString("yyyy-MM-dd");
            comando.Parameters.Add("@status", SqlDbType.Int).Value = objbo.usuario.status = 1;
            comando.Parameters.Add("@foto", SqlDbType.Image).Value = Foto.ConvertirAFoto(objbo.usuario.img);
            //comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
            //aqui empieza comercio
            comando.Parameters.Add("@nomco", SqlDbType.VarChar).Value = objbo.comercio.nombreComercial;
            comando.Parameters.Add("@veterinaria", SqlDbType.Bit).Value = objbo.comercio.veterinaria;
            comando.Parameters.Add("@estetica", SqlDbType.Bit).Value = objbo.comercio.estetica;
            comando.Parameters.Add("@vendeproduc", SqlDbType.Bit).Value = objbo.comercio.venderproducto;
            comando.Parameters.Add("@nomfis", SqlDbType.VarChar).Value = objbo.comercio.nombreFiscal;
            comando.Parameters.Add("@rfc", SqlDbType.VarChar).Value = objbo.comercio.rfc;
            comando.Parameters.Add("@telefono1", SqlDbType.VarChar).Value = objbo.comercio.telefono1;
            comando.Parameters.Add("@telefono2", SqlDbType.VarChar).Value = objbo.comercio.telefono2;
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = objbo.comercio.emal;
            //aqui empieza insertar comerciousuario
            //aqui empieza direccion
            comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
            comando.Parameters.Add("@numero", SqlDbType.VarChar).Value = objbo.direccion.numero;
            comando.Parameters.Add("@calle", SqlDbType.VarChar).Value = objbo.direccion.calle;
            comando.Parameters.Add("@cruzamiento", SqlDbType.VarChar).Value = objbo.direccion.cruzamiento;
            comando.Parameters.Add("@longitud", SqlDbType.VarChar).Value = objbo.direccion.longitud;
            comando.Parameters.Add("@latitud", SqlDbType.VarChar).Value = objbo.direccion.latitud;
            comando.Parameters.Add("@colonia", SqlDbType.VarChar).Value = objbo.direccion.colonia;
            comando.Parameters.Add("@cp", SqlDbType.VarChar).Value = objbo.direccion.CP="55555";
            comando.Parameters.Add("@idcidad", SqlDbType.Int).Value = objbo.direccion.idCiudad = 1;
            return conex.EjecutarComando(comando);
        }

        public List<PropagandaBO> obtenerpropaganda()
        {
            var propaganda = new List<PropagandaBO>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Propaganda");

            cmd.Connection = conex.establecerConexion();
            conex.AbrirConexion();
            var query = cmd;
            using (var dr = query.ExecuteReader())
            {
                while (dr.Read())
                {
                    String fotos = Convert.ToBase64String((byte[])dr["foto"]);
                    if (fotos == "0")
                    {
                        var p = new BO.PropagandaBO
                        {
                                id = Convert.ToInt32(dr["id"].ToString()),
                                idusuario =Convert.ToInt32( dr["iduUsuario"].ToString()),
                                descripcion = dr["descripcion"].ToString(),
                                foto = " "
                            
                        };
                        propaganda.Add(p);
                    }
                    else
                    {
                        var p = new BO.PropagandaBO
                        {

                          
                                id = Convert.ToInt32(dr["id"].ToString()),
                                idusuario =Convert.ToInt32( dr["idUsuario"].ToString()),
                                descripcion = dr["usuario"].ToString(),
                                foto = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])dr["foto"])
                        };
                        propaganda.Add(p);
                    }

                }
            }
            return propaganda;
        }
    }
}