using ApiEstado.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ApiEstado.Controller
{
    [Route("api/estado")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        [HttpGet]
        public List<EstadoDto> Get()
        {
            return ListarEstados();
        }

        [HttpGet("{id}")]
        public EstadoDto Get(int id)
        {
            var estados = ListarEstados();
            return estados.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public EstadoDto Post(EstadoDto dto)
        {
            return dto;
        }

        [HttpPut("{id}")]
        public EstadoDto Put(int id, EstadoDto dto)
        {
            return dto;
        }

        private List<EstadoDto> ListarEstados()
        {
            var estados = new List<EstadoDto>()
            {
                new EstadoDto{ Id = 1, Sigla = "SP", Nome = "São Paulo"},
                new EstadoDto{ Id = 2, Sigla = "MG", Nome = "Minas Gerais"},
                new EstadoDto{ Id = 3, Sigla = "RJ", Nome = "Rio de Janeiro"}
            };

            return estados;
        }
    }
}