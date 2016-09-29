var sitMessageModule = angular.module("MessageModule", []);
sitMessageModule.controller("MessageController", ["$scope", "$http", function ($scope, $http) {
    $scope.messages = [];
    $scope.divToMap = [];
    $scope.UploadFiles = function () {
        var fd = new FormData();
        var files = $("#fileUpload").get(0).files;

        if (files.length > 0) {
            fd.append("File", files[0]);
        }
        $scope.points = [];
        $http.post('/Home/ParseEventFile', fd, {
            transformRequest: angular.identity,
            headers: { 'Content-Type': undefined }
        }).then(
            function (res) {
                $scope.messages = [];
                $.each(res.data, function (i, item) {
                    $scope.messages.push(item);
                });
                $scope.$apply();
            },
            function (message) {
                alert(message.responseText);
            });
    };

    $scope.InitializeMap = function (element) {
        var map = new google.maps.Map(element, {
            zoom: 5,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        });
        var latlngbounds = new google.maps.LatLngBounds();
        for (var i = 0; i < $scope.points.length; i++) {
            var point = $scope.points[i];
            var marker = new google.maps.Marker({
                position: new google.maps.LatLng(point.Latitude, point.Longtitude),
                draggable: false,
                map: map
            });
            latlngbounds.extend(marker.position);
        };
        map.fitBounds(latlngbounds);
        return map;
    };

    $scope.ShowDetails = function (message) {
        $('#' + message.CurrentMessageNumber.toString()).toggle();
        var div = $('#' + message.CurrentMessageNumber.toString() + ' :first-child :first-child')[0];
        $scope.points = message.Points;
        $scope.InitializeMap(div);
    };
}]);
