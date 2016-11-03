angular.module("app")
    .controller("AlunoController",
        function ($scope, $http) {

            $http.get("http://localhost:49621/api/aluno")
                .success(function (data) {
                    $scope.retorno = data;
                });

            var aluno = {
                "id": 1,
                "nome": "Asdrubal123",
                "email": "teste1@teste.com",
                "dataNascimento": "1998-01-05T00:00:00Z",
                "ra": 123456,
                "cpf": "12345678901"
            }

            $scope.InsertAluno = function () {
                $http.post("http://localhost:49621/api/aluno", aluno)
                .success(function (data) {
                    $scope.retorno = data;
                    console.log(data);
                });
            }

            $scope.DELETAR = function () {
                $http({
                    method: 'DELETE',
                    url: "http://localhost:49621/api/aluno",
                    data: {
                        user: 1
                    },
                    headers: {
                        'Content-type': 'application/json;charset=utf-8'
                    }
                })
            .then(function (response) {
                console.log(response.data);
            }, function (rejection) {
                console.log(rejection.data);
            });
            }





        });