'use strict';

app.directive('topBar', function () {
    return {
        restrict: 'E',
        replace: true,
        templateUrl: 'app/views/layout/topBar.html'
    }
});