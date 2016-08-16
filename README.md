# SOLID_SRP_UnitTest
Projeto com demonstração de UnitTest, SOLID e DDD


Tarefa do dia

Cenário: Você é um consultor que atua no desenvolvimento de Software e seu cliente, uma universidade, pediu o desenvolvimento de uma aplicação Web Responsiva que tenha as seguintes características:

a) Como a universidade possui uma equipe de TI, eles ficarão com o código fonte para futuras implementações e querem garantia de um código que siga os principais padrões de projeto, com baixo acoplamento, fortemente orientado a Testes Unitários, que sigam os princípios SOLID e DDD e que tenha uma arquitetura que facilite manutenções futuras. 

b) Dentro das funcionalidades previstas estão o desenvolvimento de uma API que possibilite o consumo por qualquer dispositivo seja móvel ou não. (DEIXAR PARA SER FEITO DEPOIS)

Tarefa 1: 

a) Implementar/Desenvolver a arquitetura inicial do projeto seguindo o primeiro princípio SOLID: SRP - Single Responsibility Principle.

b) Deverá ser implementado uma classe de domínio chamada "Aluno", em um projeto separado chamado "DOMAIN", que deverá ter no mínimo as seguintes propriedades: Id, Nome, Email, DataNascimento, RA. 
b1) O sistema também deve possibilitar o envio de mensagens para um aluno, tendo como parâmetro de entrada seu RA e EMAIL.
b2) A classe "Aluno" deverá ter um método IsValid() que deverá retornar boolean para CPF (tamanho = 11), maior de 18 anos e RA (tamanho = 6);

c) Criar um projeto de Testes de Unidade e fazer os seguintes testes:
-> Para um aluno estar válido ele deverá:
 - ter mais de 18 anos 
 - um RA válido(a quantidade de caracteres maior ou igual a 6) 
 - CPF válido (a quantidade de caracteres iggual a 11)
 - email deverá conter '@'
