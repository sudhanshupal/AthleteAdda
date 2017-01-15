(function () {
    'use strict';

    var serviceId = 'demoService';
    angular.module('app').factory(serviceId, ['$http', 'common', 'globalService',  demoService]);

    function demoService($http, common, globalService) {

        var service = {
            contextualizeDashboard: contextualizeDashboard
        };

        return service;

        function contextualizeDashboard() {

            return $http.get(globalService.serviceUri + '/api/Demo/ContextualizeDashboard');
        }
    }
})();