var CC = CC || {};

$.extend(true, CC, {
    Resources: {
    },

    Common: {
        UrlHelper: function (methodName, controllerName) {
            var url = controllerName + '/' + methodName;
            return url;
        },


        IniPage: function () {
        },

        PageLoaded: function () {
        },
    }
});

$(document).ready(function () {
    CC.Common.IniPage();
})

