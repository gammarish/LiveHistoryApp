

var allMarkers = null;
var chartsItems = [];

$(function () {
    $.extend(true, CC,
    {
        Route: function () {

            this.getDetailsForMarkers = function () {
                $.ajax({
                    type: "GET",
                    url: CC.Common.UrlHelper("GetDetailsForMarkers", "Route"),
                    contentType: "application/json;charset=utf-8",
                    cache: false,
                    dataType: "json",
                    success: function (data) {
                        try {
                            if (data.Result) {
                                allMarkers = data.Value;
                                Initialize();
                            }
                            else {
                            }
                        }
                        catch (err) {
                            console.log(err.message);
                        }
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                    }
                });

            },

           this.iniHome = function () {
               this.getDetailsForMarkers();

              
           },

           this.iniHome();
        }
    });
});


var homeObj = null

$(document).ready(function () {
    homeObj = new CC.Route();

});
