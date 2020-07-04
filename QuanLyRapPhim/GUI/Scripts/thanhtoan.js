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
function thongBao(){
    alert("Bạn đã mua vé thành công");
}
function loadXacNhan(){
    var queries = getQueries();
    var item = getItemById(queries.id);
    var cinema = getCinemaById(queries.rap);
    var ghes = Cookies.getJSON('ghe-da-chon');
    var s = "<h1 class=\"bg-success text-danger text-center\">XÁC NHẬN ĐẶT VÉ</h1>";
    s += "<br>";
    s += "<h2>Số ghế đã chọn :" + ghes.length + "</h2>"; 
    s += "<br>";
    s += "<h2>Hàng ghế: ";
    for (let i = 0; i <ghes.length; i++) {
        s+=Cookies.getJSON('ghe-da-chon')[i] + " ";
    }
    s += "</h2>";
    s += "<br>";
    s += "<h2>Thành tiền: " + ghes.length * 80 + ".000VNĐ" + "</h2>";
    s += "<a onclick=\"thongBao()\" href=\"index.html\" class=\"col-lg-3 col-md-3 col-sm-3 col-xs-3 float-right btn btn-danger btn-lg\" style=\"color: white\">XÁC NHẬN</a>"
    $("#thanh-toan").append(s);
}