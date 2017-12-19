app.controller("urunCtrl", urunCtrl);

urunCtrl.$inject = ["$scope", "$http","$routeParams"];

function urunCtrl($scope, $http, $routeParams) {
    var kategoriId = $routeParams.id;
    $scope.urunler = [];

    $scope.KategorisineGoreUrunler = function () {
        $http.get("http://localhost:19308/api/kategorideki-urunler/" + kategoriId).then(function (response) {
            $scope.urunler = response.data;
        }).catch(function (err) {
            console.log(err);
        })
    }

    $scope.KategorisineGoreUrunler();



}