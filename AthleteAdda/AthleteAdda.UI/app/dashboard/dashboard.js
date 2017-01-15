(function () {
    'use strict';
    var controllerId = 'dashboard';
    angular.module('app').controller(controllerId, ['common', 'demoService', dashboard]);

    function dashboard(common, demoService) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        vm.news = {
            title: 'Hot Towel Angular',
            description: 'Hot Towel Angular is a SPA template for Angular developers.'
        };
        vm.newFeedCount = 0;
        vm.newFeeds = [];
        vm.title = 'Dashboard';

        activate();

        function activate() {
            var promises = [getPeople()];
            common.activateController(promises, controllerId)
                .then(function () { log('Activated Dashboard View'); });
        }

        function getPeople() {
            return demoService.contextualizeDashboard().then(function (result) {
                vm.newFeeds = result.data.newFeeds;
                vm.newFeedCount = result.data.newFeedCount;
            });
        }
    }
})();