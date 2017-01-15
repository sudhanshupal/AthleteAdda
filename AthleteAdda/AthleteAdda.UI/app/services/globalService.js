(function () {
    'use strict';

    var serviceId = 'globalService';
    angular.module('app').factory(serviceId, [globalService]);

    function globalService() {

        return {
            serviceUri: "http://localhost:42880"
        };
    }
})();