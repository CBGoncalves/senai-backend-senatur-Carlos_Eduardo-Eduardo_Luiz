using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class PacoteRepository : IPacoteRepository
    {
        SenaTurContext ctx = new SenaTurContext();

        public void Atualizar(int id, Pacotes pacoteAtualizado)
        {
            Pacotes pacoteBuscado = ctx.Pacotes.Find(id);
            
            if (pacoteAtualizado.NomePacote != null)
            {
                pacoteBuscado.NomePacote = pacoteAtualizado.NomePacote;
            }

            ctx.Pacotes.Update(pacoteBuscado);

            ctx.SaveChanges();
        }

        public void Cadastrar(Pacotes novoPacote)
        {
            ctx.Pacotes.Add(novoPacote);

            ctx.SaveChanges();
        }

        public List<Pacotes> Listar()
        {
            return ctx.Pacotes.ToList();
        }
    }
}
