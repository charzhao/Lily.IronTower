(function (global) {

    var map = L.map('map', {
        crs: L.CRS.Baidu,
        minZoom: 3,
        //maxZoom: 18,
        attributionControl: true,
        center: [31.834912, 117.220102],
        zoom: 15
    });
    global.Char = {
        Map: {}
    }

    var listColum=['站址编码','坐落单位名称',]
    global.Char.Map.Search=function(){
        var popupContent = "<div id=testDivTable>";
        popupContent += "<div>";
        for (var key in data.points[0]) {
            if(listColum.includes(key))
            {
                popupContent += "<div>" + key + "</div>"; 
            }
        }
        popupContent += "</div>";

        popupContent += "<div>";
        popupContent += "<div>" + "_" + "</div>"; 
        popupContent += "<div>" + "_" + "</div>"; 
        popupContent += "</div>";


        for (i in data.points) {
            popupContent += "<div>";
            for (var key in data.points[i]) {
                if (data.points[i].hasOwnProperty(key) && listColum.includes(key)) {
                    popupContent += "<div>" + data.points[i][key] + "</div>";
                   
                }
            }
            popupContent += "</div>";
        }
        popupContent += "</div>";
        $( "div.search_content" ).html( popupContent);
    }

    global.Char.Map.Search1=function(filter){
        var popupContent = "<table id='tabList' border='1'>";

         popupContent += "<colgroup>";
         popupContent += "<col width='55%'/>";
         popupContent += "<col width='45%'/>";
         popupContent += "</colgroup>";
         popupContent += "<thead>";

        popupContent += "<tr>";
        for (var key in data.points[0]) {
            if(listColum.includes(key))
            {
                popupContent += "<th>" + key + "</th>"; 
            }
        }
        popupContent += "</tr>";
        popupContent += "</thead>";

        popupContent += "<tbody>";


        for (i in data.points) {
            popupContent += "<tr>";
            if(filter.replace(/(^s*)|(s*$)/g, "").length !== 0 && !data.points[i].坐落单位名称.includes(filter))
            {
                continue;
            }
            for (var key in data.points[i]) {
                if (data.points[i].hasOwnProperty(key) && listColum.includes(key)) {
                    popupContent += "<td>" + data.points[i][key] + "</td>";
                   
                }
            }
            popupContent += "</tr>";
        }
        popupContent += "</tbody>";
        popupContent += "</table>";
        $( "div.search_content" ).html( popupContent);
    }

    global.Char.Map.SetMapLocation=function(id){
        for (i in data.points) {
            if(data.points[i]["站址编码"]==id)
            {
                var latlng=new L.LatLng(data.points[i].纬度, data.points[i].经度);
                map.setView(latlng, 18, { animation: true });
                //map.panTo(new L.LatLng(data.points[i].纬度, data.points[i].经度));
                //map.setZoom(18);
                break;
            }
        }
    }

    global.Char.Map.Init = function () {
       


        //控制地图底图
        L.control.layers({
            "百度地图": L.tileLayer.baidu({
                layer: 'vec'
            }).addTo(map),
            "百度卫星": L.tileLayer.baidu({
                layer: 'img'
            }),
            "百度地图-大字体": L.tileLayer.baidu({
                layer: 'vec',
                bigfont: true
            }),
            "百度卫星-大字体": L.tileLayer.baidu({
                layer: 'img',
                bigfont: true
            }),
            "自定义样式-黑色地图": L.tileLayer.baidu({
                layer: 'custom',
                customid: 'dark'
            }),
            "自定义样式-蓝色地图": L.tileLayer.baidu({
                layer: 'custom',
                customid: 'midnight'
            })
        }, {
            "实时交通信息": L.tileLayer.baidu({
                layer: 'time'
            })
        }, {
            position: "topright"
        }).addTo(map);


        LeafIcon = L.Icon.extend({
            options: {
                shadowUrl: 'pic/leaf-shadow.png',
                iconSize: [38, 95], // size of the icon
                shadowSize: [50, 64], // size of the shadow
                iconAnchor: [22, 94], // point of the icon which will correspond to marker's location
                shadowAnchor: [4, 62], // the same for the shadow
                popupAnchor: [-3, -76] // point from which the popup should open relative to the iconAnchor
            }
        });

        var greenIcon = new LeafIcon({
            iconUrl: 'pic/leaf-green.png'
        });

        var options = {
            maxHeight: 900
        };
        for (i in data.points) {
            var popupContent = "<div id=testDivTable>";

            for (var key in data.points[i]) {
                if (data.points[i].hasOwnProperty(key)) {
                    popupContent += "<div>";
                    popupContent += "<div>" + key + "</div>";
                    popupContent += "<div>" + data.points[i][key] + "</div>";
                    popupContent += "</div>";
                }
            }
            popupContent += "</div>";

            new L.marker([data.points[i].纬度, data.points[i].经度], {
                icon: greenIcon
            }).bindPopup(popupContent, options).addTo(map);
            map.panTo(new L.LatLng(data.points[i].纬度, data.points[i].经度));
        }
    }

})(window);