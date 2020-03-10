using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacotesController : ControllerBase
    {
        /// <summary>
        /// Cria um objeto _pacoteRepository que irá receber todos os métodos definidos na interface
        /// </summary>
        private IPacoteRepository _pacoteRepository;

        /// <summary>
        /// Instancia este objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public PacotesController()
        {
            _pacoteRepository = new PacoteRepository();
        }

        /// <summary>
        /// Lista todos os pacotes
        /// </summary>
        /// <returns>Uma lista de pacotes e um status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            // Retorna a resposta da requisição fazendo a chamada para o método
            return Ok(_pacoteRepository.Listar());
        }

        /// <summary>
        /// Cadastra um novo pacote
        /// </summary>
        /// <param name="novoPacote">Objeto que sera cadastrado</param>
        /// <returns>Um Status Code 201</returns>
        [HttpPost]
        public IActionResult Post(Pacotes novoPacote)
        {
            //Chama o método
            _pacoteRepository.Cadastrar(novoPacote);

            //Retorna o Satus Code 201
            return StatusCode(201);

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Pacotes pacoteAtualizado)
        {
            _pacoteRepository.Atualizar(id, pacoteAtualizado);

            return StatusCode(204);
        }


    }
}