var app = angular.module("myapp", ["ngRoute", "ngAnimate"]);

app.config(routeConfig);

//$routeProvider sayfalar arası iletişimden navigasyondan sorumludurç

routeConfig.$inject = ["$routeProvider", "$locationProvider"];

function routeConfig($routeProvider, $locationProvider) {
    $routeProvider
        .when("/anasayfa",
        {
            templateUrl: "anasayfa.html"
        })
        .when("/hakkimizda",
        {
            templateUrl: "hakkimizda.html"
        })
        .when("/iletisim",
        {
            templateUrl: "iletisim.html"
        })
        .when("/kategoriler",
        {
            templateUrl: "kategoriler.html",
            controller: "kategoriCtrl"
        })
        .when("/urunler/:id",
        {
            templateUrl: "urunler.html",
            controller: "urunCtrl"
        })
        .otherwise
        ({ redirectTo: "anasayfa" })


    $locationProvider.html5Mode(true);

}