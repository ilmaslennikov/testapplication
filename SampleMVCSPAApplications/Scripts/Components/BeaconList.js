var beaconListModule = angular.module("BeaconList", []);


beaconListModule.controller("BeaconListController",
   ["$scope", function ($scope) {
   }
   ]);

beaconListModule.controller("AddItemController", [
		    "$scope", "$rootScope", "$http", function ($scope, $rootScope, $http) {
		        $scope.currentItem = {};
		        $scope.ActionName = "Создать";
		        $scope.Save = function () {
		            $scope.$broadcast("show-errors-check-validity");
		            $http.post("/Home/AddPLBRequest", {
		                transformRequest: angular.identity,
		                data: JSON.stringify(scope.Filter),
		                dataType: "json",
		                contentType: "application/json; charset=utf-8"
		            }).then(
                        function (res) {
                            scope.items = res.ActionItems;
                            scope.Filter.TotalItems = res.TotalItems;
                            scope.$apply();
                        },
                        function (message) {
                            alert(message.responseText);
                        });
		            $rootScope.$broadcast("item-list-changed");
		        };
		    }
]);

beaconListModule.directive("itemList", ["$http", function ($http) {
    function link(scope, element, attrs) {
        scope.Filter = {};
        scope.Filter.ItemsPerPage = 10;
        scope.Filter.CurrentPage = 1;
        scope.$on("item-list-changed", function () {
            scope.Filter = {};
            scope.Filter.ItemsPerPage = 10;
            scope.Filter.CurrentPage = 1;
            scope.pageChanged();
        });
        scope.OrderBy = function (columnName) {
            if (scope.Filter.OrderColumn == columnName) {
                scope.Filter.Ascending = !scope.Filter.Ascending;
            } else {
                scope.Filter.Ascending = true;
            }
            scope.Filter.OrderColumn = columnName;
            scope.pageChanged();
        };
        scope.pageChanged = function () {
            $http.post(attrs.getitems, {
                transformRequest: angular.identity,
                data: JSON.stringify(scope.Filter),
                dataType: "json",
                contentType: "application/json; charset=utf-8"
            }).then(
                function (res) {
                    scope.items = res.data.Beacons;
                    scope.Filter.TotalItems = res.data.TotalItems;
                //    scope.$apply();
                },
                function (message) {
                    alert(message.responseText);
                });
        };
        scope.pageChanged();
    }
    return {
        link: link
    };
}]);

beaconListModule.directive("requestEdit", function () {
    return {
        replace: true,
        templateUrl: "/Home/BeaconEdit"
    };
});
