app.controller('myController', function ($scope, myService) {
    //GetAll burada karsılamam lazım
    GetAllEmp();

    //get datanın icine getemployeesdeki bilgileri aldı getdataya attı. get employees benim
    //servicejs te tanımladıgım fonksiyon
    function GetAllEmp() { 
        var getData = myService.getEmployees();
    getData.then(function (response) {  //veriyi getiren kısım
        $scope.employee = response.data;
    }, function () {

        alert("veriler getirilemedi")
            });

    }
});