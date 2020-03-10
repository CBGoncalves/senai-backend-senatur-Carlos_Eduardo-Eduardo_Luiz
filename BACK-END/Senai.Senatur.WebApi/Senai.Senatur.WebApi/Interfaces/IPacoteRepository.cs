using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface IPacoteRepository
    {
        /// <summary>
        /// Lista todos os usuarios
        /// </summary>
        /// <returns>Uma lista de pacotes</returns>
        List<Pacotes> Listar();

        /// <summary>
        /// Cadastra um novo pacote
        /// </summary>
        /// <param name="novoPacote">Objeto novoPacote que será cadastrado</param>
        void Cadastrar(Pacotes novoPacote);

        /// <summary>
        /// Atualiza um pacote existente
        /// </summary>
        /// <param name="pacoteAtualizado">Objeto com as novas informações</param>
        void Atualizar(int id, Pacotes pacoteAtualizado);
    }
}
