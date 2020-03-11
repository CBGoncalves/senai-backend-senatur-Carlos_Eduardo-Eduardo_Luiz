using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        SenaTurContext ctx = new SenaTurContext();

        public List<TiposUsuario> Listar()
        {
            return ctx.TiposUsuario.ToList();
        }
    }
}
