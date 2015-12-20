'use strict';

app.directive('sideBar', function() {
    return {
        restrict: 'E',
        replace: true,
        templateUrl:'app/views/layout/sideBar.html'
    }
});

//(angular.module('common.ui'))