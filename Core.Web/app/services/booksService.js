'use strict';
app.factory('booksService', ['$http', function ($http) {

    var serviceBase = 'http://localhost:3807/';
    var booksServiceFactory = {};

    var _getBooks = function () {

        return $http.get(serviceBase + 'api/books/books').then(function (results) {
            return results;
        });
    };

    ordersServiceFactory.getBooks = _getBooks;

    return ordersServiceFactory;

}]);