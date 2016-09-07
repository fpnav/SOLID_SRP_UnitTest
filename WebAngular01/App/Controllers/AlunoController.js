angular.module("app")
    .controller("AlunoController",
        function ($scope, $http) {
            $http.get("http://localhost:49621/api/aluno")
                .success(function (data) {
                    $scope.retorno = data;
                });
        });