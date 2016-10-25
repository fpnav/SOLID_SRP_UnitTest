using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel
{
    public interface IRepository
    {
        Aluno GetById(int id);
        IQueryable<Aluno> GetAll();
        void Save(Aluno aluno);
        void Delete(Aluno aluno);

    }
}
