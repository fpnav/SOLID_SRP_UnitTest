using System;
using Api.Controllers;
using Data;
using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestSolid
{
    [TestClass]
    public class UnitTestAlunoController
    {
        [TestMethod]
        public void TestSeAlunoControllerEstaOkParaGet()
        {
            var repo = new Repository<Aluno>();
            var alunoController = new AlunoController(repo);
            var aluno = alunoController.Get(1);
            Assert.IsNotNull(aluno);

        }
    }
}
