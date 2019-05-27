
var app = angular.module("MoviesProject", ["ngRoute"])
        .config(function ($routeProvider, $locationProvider) {
            $locationProvider.hashPrefix('');
            $locationProvider.html5Mode(true);
            $routeProvider
              .when("/AllMovies", {
                  templateUrl: "Templates/AllMovies.html",
                  controller: "AllMoviesController"
              })
              .when("/MovieDetails/:id", {
                  templateUrl: "Templates/MovieDetails.html",
                  controller: "MovieDetailsController"
                              })
              .otherwise({
                  redirectTo: "/AllMovies"
              })
        })
            .controller("AllMoviesController", function ($scope, $http) {
                $http.get("WebMovies.asmx/GetAllMovies")
                    .then(function(response){
                        $scope.movies = response.data;
                    })
                $scope.sortCol = "Title";
            })
            .controller("MovieDetailsController", function ($scope, $http, $routeParams) {
                $http({
                    url: "WebMovies.asmx/GetMovie",
                    params: { id: $routeParams.id },
                    method: "get"
                })
                .then(function (response) {
                    $scope.movie = response.data;
                })
            });