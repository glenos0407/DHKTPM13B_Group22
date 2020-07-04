var maGhe = ["A","B","C","D","E","F","G","H","I","J","K","L","M"];
var gheDaChon = [];
function getQueries(){
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
$(document).ready(function() {
    for(var i = 0;i<=12;i++){
        var them="<tr>";
        for(var j=0;j<=19;j++){
            if(j==0 && i==0 || i==0 && j == 19){
                them = them + "<td>" + "<input type='button' style = \"width: 50px; height: 50px;\" ;class='btn btn-light' value='"+maGhe[i]+"' disabled='disabled'>" + "</td>";
                }
            else if(i==1 && j==0 || i==1 && j == 19){
                them = them + "<td>" + "<input type='button' style = \"width: 50px; height: 50px;\" class='btn btn-light' value='"+maGhe[i]+"' disabled='disabled'>" + "</td>";						
            }
            else if(i==2 && j==0 || i==2 && j == 19){
                them = them + "<td>" + "<input type='button' style = \"width: 50px; height: 50px;\" class='btn btn-light' value='"+maGhe[i]+"' disabled='disabled'>" + "</td>";						
            }
            else if(i==3 && j==0 || i==3 && j == 19){
                them = them + "<td>" + "<input type='button' style = \"width: 50px; height: 50px;\" class='btn btn-light' value='"+maGhe[i]+"' disabled='disabled'>" + "</td>";						
            }
            else if(i==4 && j==0 || i==4 && j == 19){
                them = them + "<td>" + "<input type='button' style = \"width: 50px; height: 50px;\" class='btn btn-light' value='"+maGhe[i]+"' disabled='disabled'>" + "</td>";						
            }
            else if(i==5 && j==0 || i==5 && j == 19){
                them = them + "<td>" + "<input type='button' style = \"width: 50px; height: 50px;\" class='btn btn-light' value='"+maGhe[i]+"' disabled='disabled'>" + "</td>";						
            }
            else if(i==6 && j==0 || i==6 && j == 19){
                them = them + "<td>" + "<input type='button' style = \"width: 50px; height: 50px;\" class='btn btn-light' value='"+maGhe[i]+"' disabled='disabled'>" + "</td>";						
            }
            else if(i==7 && j==0 || i==7 && j == 19){
                them = them + "<td>" + "<input type='button' style = \"width: 50px; height: 50px;\" class='btn btn-light' value='"+maGhe[i]+"' disabled='disabled'>" + "</td>";						
            }
            else if(i==8 && j==0 || i==8 && j == 19){
                them = them + "<td>" + "<input type='button' style = \"width: 50px; height: 50px;\" class='btn btn-light' value='"+maGhe[i]+"' disabled='disabled'>" + "</td>";						
            }
            else if(i==9 && j==0 || i==9 && j == 19){
                them = them + "<td>" + "<input type='button' style = \"width: 50px; height: 50px;\" class='btn btn-light' value='"+maGhe[i]+"' disabled='disabled'>" + "</td>";						
            }
            else if(i==10 && j==0 || i==10 && j == 19){
                them = them + "<td>" + "<input type='button' style = \"width: 50px; height: 50px;\" class='btn btn-light' value='"+maGhe[i]+"' disabled='disabled'>" + "</td>";						
            }
            else if(i==11 && j==0 || i==11 && j == 19){
                them = them + "<td>" + "<input type='button' style = \"width: 50px; height: 50px;\" class='btn btn-light' value='"+maGhe[i]+"' disabled='disabled'>" + "</td>";						
            }
            else if(i==12 && j==0 || i==12 && j == 19){
                them = them + "<td>" + "<input type='button' style = \"width: 50px; height: 50px;\" class='btn btn-light' value='"+maGhe[i]+"' disabled='disabled'>" + "</td>";						
            }
            if(j>0 && j<5){
                if(i<=2){
                  them = them + "<td>" + "<input type='button' class='btn btn-outline-light gray' value='" + maGhe[i] + j + "'>" + "</td>";						
                }
                else{
                  them = them + "<td>" + "<input type='button' class='btn btn-outline-warning' value='" + maGhe[i] +j + "'>" + "</td>";	
                }
            }
            if(j==5 || j==13){
                them = them + "<td>" + "<input type='button' class='btn' value=' ' disabled='disabled'>" + "</td>";						
            }
            if(j>5 && j<13 && i!=11 && i!=12){
                if(i<=2){
                  them = them + "<td>" + "<input type='button' class='btn btn-outline-light gray' value='" + maGhe[i] + (j-1) + "'>" + "</td>";						
                }
                else {
                  them = them + "<td>" + "<input type='button' class='btn btn-outline-warning' value='" + maGhe[i] +(j-1) + "'>" + "</td>";						
                }
            }
            if(j>13 && j<19 && i!=11 && i!=12){
                if(i<=2){
                  them = them + "<td>" + "<input type='button' class='btn btn-outline-light gray' value='" + maGhe[i] +(j-2) + "'>" + "</td>";						
                }
                else {
                    them = them + "<td>" + "<input type='button' class='btn btn-outline-warning' value='" + maGhe[i] +(j-2) + "'>" + "</td>";							
                }
            }
            if((j>5 && j<13) && (i==11||i==12)){
                if(j<11){
                     them = them + "<td>" + "<input type='button' class='btn btn-outline-warning' value='" +maGhe[i]+ (j-1) + "'>" + "</td>";						
                }
                else {
                     them = them + "<td>" + "<input type='button' class='btn' value=' ' disabled='disabled'>" + "</td>";						
                }
            }
            if(j>13 && j<19 && i==12){
                them = them + "<td>" + "<input type='button' class='btn' value=' ' disabled='disabled'>" + "</td>";							
            }
            if(j>13 && j<19 && i==11){
                    them = them + "<td>" + "<input type='button' class='btn btn-outline-warning' value='" + (j-2) + "'>" + "</td>";							
            }
            
        }
        them=them+"</tr>";
        $("table tbody").append(them);
    }
    $(".btn-outline-light").click(function(e) {
        $(this).removeClass("gray");
        $(this).addClass("doimau");
        var index = gheDaChon.indexOf(this.value);
        if(index == -1){
            gheDaChon.push(this.value);
            Cookies.set("ghe-da=chon",gheDaChon);
        }
        console.log(gheDaChon);
    });
    $(".btn-outline-warning").click(function(e) {
        $(this).addClass("doimau");
        var index = gheDaChon.indexOf(this.value);
        if(index == -1){
            gheDaChon.push(this.value);
            Cookies.set("ghe-da-chon",gheDaChon);
        }
        console.log(gheDaChon);
    });
    $(".btn-outline-light").dblclick(function(e) {
        $(this).removeClass("doimau");
        $(this).addClass("gray");
        var index = gheDaChon.indexOf(this.value);
        if(index != -1){
            gheDaChon.splice(index,1);
            Cookies.set("ghe-da-chon",gheDaChon);
        }
        console.log(gheDaChon);
    });
    $(".btn-outline-warning").dblclick(function(e) {
        $(this).removeClass("doimau");
        var index = gheDaChon.indexOf(this.value);
        if(index != -1){
            gheDaChon.splice(index,1);
            Cookies.set("ghe-da-chon",gheDaChon);
        }
        console.log(gheDaChon);
    });
    var queries = getQueries();
    var item = getItemById(queries.id);
    var cinema = getCinemaById(queries.rap);
    var s = "<h2 style=\"color: #28a745\">" + item.name + "</h2>";
    s += "<h3 style=\"color: #28a745\"> Suất chiếu: " + queries.sc + "</h3>";
    s += "<h3 style=\"color: #28a745\"> Rạp: " + cinema.name + "</h3>";
    $("#infor-movie").append(s);
    
    var btna = "<a href=\"thanhtoan.html?id="+ queries.id +"&sc="+ queries.sc + "&rap="+ queries.rap + "\" class=\"col-lg-3 col-md-3 col-sm-3 col-xs-3 float-right btn btn-danger btn-lg\" style=\"color: white\">XÁC NHẬN</a>"
    $("#btn-xac-nhan").append(btna);
});