var ContactUs = function () {

    return {
        //main function to initiate the module
        init: function () {
			var map;
			$(document).ready(function(){
			  map = new GMaps({
				div: '#map',
				lat: 40.822521,
				lng: 29.922787,
			  });
			   var marker = map.addMarker({
			        lat: 40.822521,
			        lng: 29.922787,
		            title: 'Kocaeli Mühendislik Fakultesi.',
		            infoWindow: {
		                content: "<b>Kocaeli Muhendislik Fakultesi.</b> Kocaeli Universitesi Umut Tepe Yerleskesi 41380 Izmit/Kocaeli Turkiye"
		            }
		        });

			   marker.infoWindow.open(map, marker);
			});
        }
    };

}();