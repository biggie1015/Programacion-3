angular.module('parcial', [])

    .directive('fileModel', function ($parse) {
        return {
            restrict: 'EA',
            link: function (scope, element, attrs) {
                var model = $parse(attrs.fileModel);
                var modelSetter = model.assign;

                element.bind('change', function () {
                    scope.$apply(function () {
                        modelSetter(scope, element[0].files[0]);
                    });
                });
            }
        };
    })
    .controller('Registrar', function ($scope, $http) {

        $scope.uploadFile = function () {
            // probando propiedades image
            var img = new Image();
            var  file = $scope.myfile;
            console.log(file);

            var form = new FormData();
            
            form.append('data', file);
            

            $scope.file = ({

                file: file
                
             });
            var request = {

                method: 'POST',
                url: '/home/create',
                data: $scope.file,

            };

            return $http(request).then(function (response) {
            })
          
        }

    })




