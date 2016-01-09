// Where all the fun happens 
function Initialize() {

    var minZoomLevel = 13;

    // Google has tweaked their interface somewhat - this tells the api to use that new UI
    google.maps.visualRefresh = true;
    var CenterPoint = new google.maps.LatLng(50.8093206, 19.1227711);

    // These are options that set initial zoom level, where the map is centered globally to start, and the type of map to show
    var mapOptions = {
        zoom: minZoomLevel,
        center: CenterPoint,
        mapTypeId: google.maps.MapTypeId.G_NORMAL_MAP,
        styles: [{ "featureType": "landscape", "stylers": [{ "saturation": -100 }, { "lightness": 65 }, { "visibility": "on" }] }, { "featureType": "poi", "stylers": [{ "saturation": -100 }, { "lightness": 51 }, { "visibility": "simplified" }] }, { "featureType": "road.highway", "stylers": [{ "saturation": -100 }, { "visibility": "simplified" }] }, { "featureType": "road.arterial", "stylers": [{ "saturation": -100 }, { "lightness": 30 }, { "visibility": "on" }] }, { "featureType": "road.local", "stylers": [{ "saturation": -100 }, { "lightness": 40 }, { "visibility": "on" }] }, { "featureType": "transit", "stylers": [{ "saturation": -100 }, { "visibility": "simplified" }] }, { "featureType": "administrative.province", "stylers": [{ "visibility": "off" }] }, { "featureType": "water", "elementType": "labels", "stylers": [{ "visibility": "on" }, { "lightness": -25 }, { "saturation": -100 }] }, { "featureType": "water", "elementType": "geometry", "stylers": [{ "hue": "#ffff00" }, { "lightness": -25 }, { "saturation": -97 }] }]
    };

    // This makes the div with id "map_canvas" a google map
    var map = new google.maps.Map(document.getElementById("map_canvas"), mapOptions);

    // Using the JQuery "each" selector to iterate through the JSON list and drop marker pins
    if (allMarkers != null) {
        $.each(allMarkers, function (i, item) {
            var marker = new google.maps.Marker({
                'position': new google.maps.LatLng(item.lat, item.lon),
                'map': map
            });

            //marker.setIcon('http://maps.google.com/mapfiles/ms/icons/blue-dot.png')
            marker.setIcon('http://maps.google.com/mapfiles/ms/icons/green-dot.png')
            //marker.setIcon('http://maps.google.com/mapfiles/ms/icons/caution.png')
            marker.setAnimation(google.maps.Animation.BOUNCE);

            var infowindow = new google.maps.InfoWindow({
                content: item.Description
            });

            //// finally hook up an "OnClick" listener to the map so it pops up out info-window when the marker-pin is clicked!
            google.maps.event.addListener(marker, 'click', function () {
                infowindow.open(map, marker);
                //homeObj.addNewChartForSelectedBillboard(item);
            });

            // Limit the zoom level
            google.maps.event.addListener(map, 'zoom_changed', function () {
                if (map.getZoom() < minZoomLevel) map.setZoom(minZoomLevel);
            });

        });
    }

}
