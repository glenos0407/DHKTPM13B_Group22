function loadDuLieu(){
    var s = "";
    s += "<h2>PHIM ĐANG CHIẾU</h2>"
    for(var i=0; i < movies.length; i++){
        s += "<div class=\"informov\">";
        s += "<div class=\"hovereffect\">";
        s += "<a href=\"InforMovie.html?id="+ movies[i].id+"\">" + "<img class=\"img-responsive\" src=\"" +  movies[i].poster + "\">" + "</a>";
        s += "</div>";
        s += "<h5>"+ movies[i].name + "</h5>";
        s += "<a class=\"btn btn-success\" href=\"InforMovie.html?id=" + movies[i].id +"\"><i class=\"fa fa-ticket-alt\" aria-hidden=\"true\"></i> MUA VÉ</a>";
        s += "</div>";        
    }
    document.getElementById("phim").innerHTML += s;
}
function findMovie(id){
    for(var i=0; i< movies.length; i++){
        if(movies[i].id === id)
        return movies[i];
    }
    return null;
}
function getItemById(id){
    for (let i = 0; i < movies.length; i++) {
        if(id === movies[i].id)
            return movies[i];
    }
}
function getCinemaById(id){
    for (let i = 0; i < cinema.length; i++) {
        if(id === cinema[i].id)
            return cinema[i];
    }
}

