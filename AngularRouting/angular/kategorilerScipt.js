

app.controller("kategoriCtrl", kategoriCtrl);

kategoriCtrl.$inject = ["$scope","$http"];

function kategoriCtrl($scope,$http) {
    $scope.Test = "Deneme";
    $scope.kategoriler = [];

    $scope.KategorileriGetir = function () {

        $http.get("http://localhost:19308/api/kategoriler").then(function (response) {
            console.log(response);
            $scope.kategoriler = response.data;

        }).catch(function (err) {
            console.log(err);
        })

    }

    $scope.KategorileriGetir();

}

