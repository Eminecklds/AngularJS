//post get metodu nereye gidecek onu tutmus oluyorum burda.

app.service('myService', function ($http) {
    //get all employes
    this.getEmployees = function () { //this $scope aynı şeyi temsil ediyor.
        return $http.get("/Home/GetAll");

    }
});