var module = angular.module('zonaApp', []);

module.controller('zonaCtrl', function ($scope, $http) {

    // Get customer list
    $http.get("/api/zonaapi")
    .success(function (response) {
        $scope.Zona = response
    });
    // Initial 
    $scope.edit = true;
    $scope.error = false;
    $scope.incomplete = false;
    // Edit
    $scope.editCustomer = function (id) {
        if (id == 'new') {
            $scope.edit = true;
            $scope.incomplete = true;
            $scope.Id = 0;
            $scope.Nombre = "";
            $scope.Codigo = "";
            $scope.CuidadId = "";
            $scope.estado = "";
        } else {

            $scope.edit = false;
            $scope.Id = $scope.Zona[id].Id;
            $scope.Nombre = $scope.Zona[id].Nombre;
            $scope.Codigo = $scope.Zona[id].Codigo;
            $scope.CuidadId = $scope.Zona[id].CuidadId;
            $scope.estado = $scope.Zona[id].estado;
            $scope.incomplete = false;
        }
    };
    // Update or add new one  
    $scope.PostCustomer = function () {
        $.post("api/zonaapi",
                     $("#zonaForm").serialize(),
                     function (value) {

                         // Refresh list
                         $http.get("/api/zonaapi")
                         .success(function (response) {
                             $scope.Zona = response
                         });

                         alert("Saved successfully.");
                     },
                     "json"
               );
    }
    // Delete one customer based on id.
    $scope.delCustomer = function (id) {
        if (confirm("Are you sure you want to delete this customer?")) {
            // todo code for deletion
            $http.delete("api/zonaapi/" + id).success(function () {
                alert("Deleted successfully.");
                // Refresh list
                $http.get("/api/zonaapi")
                .success(function (response) {
                    $scope.Zona = response
                });

            }).error(function () {
                alert("Error.");
            });
        }
    };
});
