$(document).ready(function(e) {
    jQuery.validator.addMethod("ten", function(value, element){
            return this.optional(element) || /^[A-Za-zÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚÝàáâãèéêìíòóôõùúýĂăĐđĨĩŨũƠơƯưẠ-ỹ\ ]+$/.test(value);
        }, "Phải nhập đúng tên!");
    jQuery.validator.addMethod("diachi", function(value, element){
            return this.optional(element) || /^[0-9A-Za-zÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚÝàáâãèéêìíòóôõùúýĂăĐđĨĩŨũƠơƯưẠ-ỹ\ ,-]+$/.test(value);
        }, "Phải nhập đúng địa chỉ!");
    $("#fr").validate({
        rules:{
            txtMS:{
                required:true,
                digits:true,
                rangelength:[9,9],
                },
            txtTen:{
                required:true,
                ten:true,
                },
            txtEmail:{
                required:false,
                email:true,
                },
            txtAddress:{
                required:true,
                diachi:true,
                },
            txtSDT:{
                required:true,
                digits:true,
                rangelength:[10,10],
                }
            },
        messages:{
            txtMS:{
                required:"Vui lòng nhập số chứng minh nhân dân",
                digits:"Số CMND chỉ chứa các ký tự là số!",
                rangelength:"Mã có 8 số!",
                },
            txtTen:{
                required:"Vui lòng nhập họ tên của bạn",
                ten:"Tên không được chứa ký tự đặc biệt",
                },
            txtEmail:{
                email:"Vui lòng nhập đúng định dạng email!",
                },
            txtAddress:{
                required: "Vui lòng nhập địa chỉ",
                diachi:"Địa chỉ không chứa kí tự đặc biệt, ngoại trừ dấu phẩy và gạch ngang",
                },
            txtSDT: {
                required: "Vui lòng nhập số điện thoại!",
                digits:"Số điện thoại chỉ chứa các ký tự là số!",
                rangelength:"Phải nhập đúng 10 số!",
                }
            }
        });
        /*$('.btn').on('click', function(){
            alert("Đặt vé thành công!");
        });*/
        $("#fr").submit(function(e){
        if($("#fr").valid())
        {
            alert("Đặt vé thành công!");
            return true;	
        }
        return false;
        });
});