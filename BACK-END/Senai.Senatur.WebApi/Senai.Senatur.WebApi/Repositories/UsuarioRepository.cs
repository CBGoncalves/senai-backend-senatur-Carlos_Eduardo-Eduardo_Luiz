﻿using Microsoft.EntityFrameworkCore;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        SenaTurContext ctx = new SenaTurContext();

        public Usuarios BuscarPorEmailSenha(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public List<Usuarios> Listar()
        {
            return ctx.Usuarios.ToList();
        }

        public List<Usuarios> ListarComTiposUsuario()
        {
            return ctx.Usuarios.Include(u => u.IdTipoUsuarioNavigation).ToList();
        }
    }
}
