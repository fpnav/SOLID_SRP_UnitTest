using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace SharedKernel
{
    public class Repository : IRepository
    {
        public Context _Db { get; set; }

        public Repository()
        {
            _Db = new Context();
        }

        public void Delete(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Aluno> GetAll()
        {
            throw new NotImplementedException();
        }

        public Aluno GetById(int id)
        {
            return _Db.Alunos.Find(id);
        }

        public void Save(Aluno aluno)
        {
            throw new NotImplementedException();
        }
    }
}
