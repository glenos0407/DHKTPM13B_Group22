function getID(){
    var vars = [], hash;
    var hashes = window.location.href.slice(window.location.href.indexOf('?')+ 1 ).split('&');
    for (let i = 0; i< hashes.length; i++) {
        const element = hashes[i];
        hash = hashes[i].split('=');
        vars.push(hash[0]);
        vars[hash[0]] = hash[1];
    }
    return vars;
}
function LoadDetails(){
    var queries = getID();
    var item = getItemById(queries.id);
    var s = "";
    document.getElementById("namePhim-h5").innerHTML = "<a href=\"index.html\">Trang chủ</a> | " + item.name;
    document.getElementById("namePhim-h4").innerHTML = item.name;
    document.getElementById("con").innerHTML = item.content;
    document.getElementById("img1").src = item.poster;
    document.getElementById("dir").innerHTML =  item.director;
    document.getElementById("act").innerHTML =  item.actor;
    document.getElementById("kind").innerHTML =  item.kind;
    document.getElementById("pre").innerHTML =  item.premiere;
    document.getElementById("time").innerHTML =  item.time;
    document.getElementById("lan").innerHTML =  item.language;
    for (let i = 0; i < cinema.length; i++) {
        s += "<div class=\"detail-suatchieu\">";
        s += "<div class=\"address\">";
        s += "<p><img src=\"../image/bhd-logo.png\" style=\"width: 22px; height: 22px; border-radius:100%;\"> "+cinema[i].name+"</p>" + cinema[i].address;
        s += "</div>";
        s += "<div style=\"width: 800px; height: 100px; float: left;\" name=\"show-time\">";  
        for (let x = 0; x < cinema[i].showtime.length; x++) {
            s += "<a href=\"DatGhe.html?id="+ item.id +"&sc="+ cinema[i].showtime[x] + "&rap="+ cinema[i].id +"\" style=\"width: 80px; height: 50px; font-size: 20px; margin-right: 10px; margin-bottom: 10px\" class=\"btn btn-success\">" +cinema[i].showtime[x]+ "</a>"
        }
        s += "</div>";
    }
    document.getElementById("suatchieu").innerHTML = s;
}
