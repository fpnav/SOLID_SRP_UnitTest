using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using Data;


namespace Api.Controllers
{
    public class AlunoController : ApiController
    {
        private readonly IRepository<Aluno> _repo;

        public AlunoController(IRepository<Aluno> repository )
        {
            _repo= repository;
        }

        static readonly List<Aluno> Alunos = new List<Aluno> {
            new Aluno {Id = 1, Cpf = "12345678901",
                DataNascimento = new DateTime(1998,01,05),
                Email = "teste1@teste.com", Nome = "Asdrubal",
                Ra = 123456},

            new Aluno {Id = 2, Cpf = "111222333444",
                DataNascimento = new DateTime(2005,10,04),
                Email = "teste2@teste.com", Nome = "Ascleidson",
                Ra = 111222},

            new Aluno {Id = 3, Cpf = "147258369",
                DataNascimento = new DateTime(1979,06,04),
                Email = "teste3@teste.com", Nome = "Joedson",
                Ra = 333555}
        };



        public IHttpActionResult Post([FromBody] Aluno aluno)
        {
            var uuid = Guid.NewGuid().ToString();

            var al = new Aluno
            {
                Id = Alunos.OrderByDescending(x => x.Id).Select(c => c.Id).First() + 1,
                Ra = aluno.Ra,
                DataNascimento = aluno.DataNascimento,
                Email = aluno.Email,
                Nome = aluno.Nome,
                Cpf = aluno.Cpf,
            };
            //VERSÃO ANTERIOR, SEM PERSISTENCIA
            //_alunos.Add(al);


            return Ok(al);
        }
        public IHttpActionResult Get()
        {
            //return Ok(_alunos);
            return Ok(_repo.GetAll());
        }

        public IHttpActionResult Get(int id)
        {
            //return Ok(_alunos);
            return Ok(_repo.GetById(id));
        }
        public IHttpActionResult Put(int id, [FromBody] Aluno aluno)
        {
            var alunoUpdated = Alunos.Find(x => x.Id == id);
            alunoUpdated.Cpf = aluno.Cpf;
            alunoUpdated.DataNascimento = aluno.DataNascimento;
            alunoUpdated.Nome = aluno.Nome;
            alunoUpdated.Email = aluno.Email;
            alunoUpdated.Ra = aluno.Ra;

            return Ok(alunoUpdated);
        }
        public IHttpActionResult Delete([FromBody] Aluno aluno, int id)
        {
            Aluno alunoFinded = null;
            if (aluno != null)
            {
                alunoFinded = Alunos.Find(x => x.Nome.Equals(aluno.Nome) && x.Ra == aluno.Ra);
            }
            else
            {
                alunoFinded = Alunos.Find(x => x.Id == id);
            }
            Alunos.Remove(alunoFinded);
            return Ok(alunoFinded);
        }

    }
}
