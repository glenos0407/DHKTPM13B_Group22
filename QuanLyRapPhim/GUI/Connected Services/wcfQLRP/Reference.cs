﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI.wcfQLRP {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="eNhanVien", Namespace="http://schemas.datacontract.org/2004/07/Entities")]
    [System.SerializableAttribute()]
    public partial class eNhanVien : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GUI.wcfQLRP.ChucVu chucVuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cmndField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string hoTenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idNhanVienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string soDienThoaiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GUI.wcfQLRP.ChucVu chucVu {
            get {
                return this.chucVuField;
            }
            set {
                if ((this.chucVuField.Equals(value) != true)) {
                    this.chucVuField = value;
                    this.RaisePropertyChanged("chucVu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cmnd {
            get {
                return this.cmndField;
            }
            set {
                if ((object.ReferenceEquals(this.cmndField, value) != true)) {
                    this.cmndField = value;
                    this.RaisePropertyChanged("cmnd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string hoTen {
            get {
                return this.hoTenField;
            }
            set {
                if ((object.ReferenceEquals(this.hoTenField, value) != true)) {
                    this.hoTenField = value;
                    this.RaisePropertyChanged("hoTen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idNhanVien {
            get {
                return this.idNhanVienField;
            }
            set {
                if ((this.idNhanVienField.Equals(value) != true)) {
                    this.idNhanVienField = value;
                    this.RaisePropertyChanged("idNhanVien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string soDienThoai {
            get {
                return this.soDienThoaiField;
            }
            set {
                if ((object.ReferenceEquals(this.soDienThoaiField, value) != true)) {
                    this.soDienThoaiField = value;
                    this.RaisePropertyChanged("soDienThoai");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ChucVu", Namespace="http://schemas.datacontract.org/2004/07/Entities.Enum")]
    public enum ChucVu : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NhanVienBanVe = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NhanVienQuanLyRap = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ePhim", Namespace="http://schemas.datacontract.org/2004/07/Entities")]
    [System.SerializableAttribute()]
    public partial class ePhim : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idPhimField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int luaTuoiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ngayCongChieuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ngonNguField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string noiDungPhimField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string posterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tenDaoDienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tenPhimField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string theLoaiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int thoiLuongField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idPhim {
            get {
                return this.idPhimField;
            }
            set {
                if ((this.idPhimField.Equals(value) != true)) {
                    this.idPhimField = value;
                    this.RaisePropertyChanged("idPhim");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int luaTuoi {
            get {
                return this.luaTuoiField;
            }
            set {
                if ((this.luaTuoiField.Equals(value) != true)) {
                    this.luaTuoiField = value;
                    this.RaisePropertyChanged("luaTuoi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ngayCongChieu {
            get {
                return this.ngayCongChieuField;
            }
            set {
                if ((this.ngayCongChieuField.Equals(value) != true)) {
                    this.ngayCongChieuField = value;
                    this.RaisePropertyChanged("ngayCongChieu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ngonNgu {
            get {
                return this.ngonNguField;
            }
            set {
                if ((object.ReferenceEquals(this.ngonNguField, value) != true)) {
                    this.ngonNguField = value;
                    this.RaisePropertyChanged("ngonNgu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string noiDungPhim {
            get {
                return this.noiDungPhimField;
            }
            set {
                if ((object.ReferenceEquals(this.noiDungPhimField, value) != true)) {
                    this.noiDungPhimField = value;
                    this.RaisePropertyChanged("noiDungPhim");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string poster {
            get {
                return this.posterField;
            }
            set {
                if ((object.ReferenceEquals(this.posterField, value) != true)) {
                    this.posterField = value;
                    this.RaisePropertyChanged("poster");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tenDaoDien {
            get {
                return this.tenDaoDienField;
            }
            set {
                if ((object.ReferenceEquals(this.tenDaoDienField, value) != true)) {
                    this.tenDaoDienField = value;
                    this.RaisePropertyChanged("tenDaoDien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tenPhim {
            get {
                return this.tenPhimField;
            }
            set {
                if ((object.ReferenceEquals(this.tenPhimField, value) != true)) {
                    this.tenPhimField = value;
                    this.RaisePropertyChanged("tenPhim");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string theLoai {
            get {
                return this.theLoaiField;
            }
            set {
                if ((object.ReferenceEquals(this.theLoaiField, value) != true)) {
                    this.theLoaiField = value;
                    this.RaisePropertyChanged("theLoai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int thoiLuong {
            get {
                return this.thoiLuongField;
            }
            set {
                if ((this.thoiLuongField.Equals(value) != true)) {
                    this.thoiLuongField = value;
                    this.RaisePropertyChanged("thoiLuong");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="eRapPhim", Namespace="http://schemas.datacontract.org/2004/07/Entities")]
    [System.SerializableAttribute()]
    public partial class eRapPhim : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string diaChiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string hotLineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idRapPhimField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int soLuongChoNgoiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tenRapField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string diaChi {
            get {
                return this.diaChiField;
            }
            set {
                if ((object.ReferenceEquals(this.diaChiField, value) != true)) {
                    this.diaChiField = value;
                    this.RaisePropertyChanged("diaChi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string hotLine {
            get {
                return this.hotLineField;
            }
            set {
                if ((object.ReferenceEquals(this.hotLineField, value) != true)) {
                    this.hotLineField = value;
                    this.RaisePropertyChanged("hotLine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idRapPhim {
            get {
                return this.idRapPhimField;
            }
            set {
                if ((this.idRapPhimField.Equals(value) != true)) {
                    this.idRapPhimField = value;
                    this.RaisePropertyChanged("idRapPhim");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int soLuongChoNgoi {
            get {
                return this.soLuongChoNgoiField;
            }
            set {
                if ((this.soLuongChoNgoiField.Equals(value) != true)) {
                    this.soLuongChoNgoiField = value;
                    this.RaisePropertyChanged("soLuongChoNgoi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tenRap {
            get {
                return this.tenRapField;
            }
            set {
                if ((object.ReferenceEquals(this.tenRapField, value) != true)) {
                    this.tenRapField = value;
                    this.RaisePropertyChanged("tenRap");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="eVe", Namespace="http://schemas.datacontract.org/2004/07/Entities")]
    [System.SerializableAttribute()]
    public partial class eVe : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string gheNgoiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double giaVeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idNhanVienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idRapPhimField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idSuatChieuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idVeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ngayXuatVeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string gheNgoi {
            get {
                return this.gheNgoiField;
            }
            set {
                if ((object.ReferenceEquals(this.gheNgoiField, value) != true)) {
                    this.gheNgoiField = value;
                    this.RaisePropertyChanged("gheNgoi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double giaVe {
            get {
                return this.giaVeField;
            }
            set {
                if ((this.giaVeField.Equals(value) != true)) {
                    this.giaVeField = value;
                    this.RaisePropertyChanged("giaVe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idNhanVien {
            get {
                return this.idNhanVienField;
            }
            set {
                if ((this.idNhanVienField.Equals(value) != true)) {
                    this.idNhanVienField = value;
                    this.RaisePropertyChanged("idNhanVien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idRapPhim {
            get {
                return this.idRapPhimField;
            }
            set {
                if ((this.idRapPhimField.Equals(value) != true)) {
                    this.idRapPhimField = value;
                    this.RaisePropertyChanged("idRapPhim");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idSuatChieu {
            get {
                return this.idSuatChieuField;
            }
            set {
                if ((this.idSuatChieuField.Equals(value) != true)) {
                    this.idSuatChieuField = value;
                    this.RaisePropertyChanged("idSuatChieu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idVe {
            get {
                return this.idVeField;
            }
            set {
                if ((this.idVeField.Equals(value) != true)) {
                    this.idVeField = value;
                    this.RaisePropertyChanged("idVe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ngayXuatVe {
            get {
                return this.ngayXuatVeField;
            }
            set {
                if ((this.ngayXuatVeField.Equals(value) != true)) {
                    this.ngayXuatVeField = value;
                    this.RaisePropertyChanged("ngayXuatVe");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wcfQLRP.IQLRP")]
    public interface IQLRP {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/CreateNhanVien", ReplyAction="http://tempuri.org/IQLRP/CreateNhanVienResponse")]
        GUI.wcfQLRP.eNhanVien CreateNhanVien(GUI.wcfQLRP.eNhanVien nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/CreateNhanVien", ReplyAction="http://tempuri.org/IQLRP/CreateNhanVienResponse")]
        System.Threading.Tasks.Task<GUI.wcfQLRP.eNhanVien> CreateNhanVienAsync(GUI.wcfQLRP.eNhanVien nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/GetPhimById", ReplyAction="http://tempuri.org/IQLRP/GetPhimByIdResponse")]
        GUI.wcfQLRP.ePhim GetPhimById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/GetPhimById", ReplyAction="http://tempuri.org/IQLRP/GetPhimByIdResponse")]
        System.Threading.Tasks.Task<GUI.wcfQLRP.ePhim> GetPhimByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/GetRapPhimById", ReplyAction="http://tempuri.org/IQLRP/GetRapPhimByIdResponse")]
        GUI.wcfQLRP.eRapPhim GetRapPhimById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/GetRapPhimById", ReplyAction="http://tempuri.org/IQLRP/GetRapPhimByIdResponse")]
        System.Threading.Tasks.Task<GUI.wcfQLRP.eRapPhim> GetRapPhimByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/CreateVe", ReplyAction="http://tempuri.org/IQLRP/CreateVeResponse")]
        GUI.wcfQLRP.eVe CreateVe(GUI.wcfQLRP.eVe ve);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/CreateVe", ReplyAction="http://tempuri.org/IQLRP/CreateVeResponse")]
        System.Threading.Tasks.Task<GUI.wcfQLRP.eVe> CreateVeAsync(GUI.wcfQLRP.eVe ve);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/GetVe", ReplyAction="http://tempuri.org/IQLRP/GetVeResponse")]
        GUI.wcfQLRP.eVe GetVe(int idVe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/GetVe", ReplyAction="http://tempuri.org/IQLRP/GetVeResponse")]
        System.Threading.Tasks.Task<GUI.wcfQLRP.eVe> GetVeAsync(int idVe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/CreatePhim", ReplyAction="http://tempuri.org/IQLRP/CreatePhimResponse")]
        GUI.wcfQLRP.ePhim CreatePhim(GUI.wcfQLRP.ePhim phim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/CreatePhim", ReplyAction="http://tempuri.org/IQLRP/CreatePhimResponse")]
        System.Threading.Tasks.Task<GUI.wcfQLRP.ePhim> CreatePhimAsync(GUI.wcfQLRP.ePhim phim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/DangNhap", ReplyAction="http://tempuri.org/IQLRP/DangNhapResponse")]
        GUI.wcfQLRP.eNhanVien DangNhap(int id, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/DangNhap", ReplyAction="http://tempuri.org/IQLRP/DangNhapResponse")]
        System.Threading.Tasks.Task<GUI.wcfQLRP.eNhanVien> DangNhapAsync(int id, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/ThongKeDoanhThu", ReplyAction="http://tempuri.org/IQLRP/ThongKeDoanhThuResponse")]
        double ThongKeDoanhThu(System.DateTime startDate, System.DateTime endDate, int idPhim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQLRP/ThongKeDoanhThu", ReplyAction="http://tempuri.org/IQLRP/ThongKeDoanhThuResponse")]
        System.Threading.Tasks.Task<double> ThongKeDoanhThuAsync(System.DateTime startDate, System.DateTime endDate, int idPhim);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQLRPChannel : GUI.wcfQLRP.IQLRP, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QLRPClient : System.ServiceModel.ClientBase<GUI.wcfQLRP.IQLRP>, GUI.wcfQLRP.IQLRP {
        
        public QLRPClient() {
        }
        
        public QLRPClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QLRPClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QLRPClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QLRPClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GUI.wcfQLRP.eNhanVien CreateNhanVien(GUI.wcfQLRP.eNhanVien nv) {
            return base.Channel.CreateNhanVien(nv);
        }
        
        public System.Threading.Tasks.Task<GUI.wcfQLRP.eNhanVien> CreateNhanVienAsync(GUI.wcfQLRP.eNhanVien nv) {
            return base.Channel.CreateNhanVienAsync(nv);
        }
        
        public GUI.wcfQLRP.ePhim GetPhimById(int id) {
            return base.Channel.GetPhimById(id);
        }
        
        public System.Threading.Tasks.Task<GUI.wcfQLRP.ePhim> GetPhimByIdAsync(int id) {
            return base.Channel.GetPhimByIdAsync(id);
        }
        
        public GUI.wcfQLRP.eRapPhim GetRapPhimById(int id) {
            return base.Channel.GetRapPhimById(id);
        }
        
        public System.Threading.Tasks.Task<GUI.wcfQLRP.eRapPhim> GetRapPhimByIdAsync(int id) {
            return base.Channel.GetRapPhimByIdAsync(id);
        }
        
        public GUI.wcfQLRP.eVe CreateVe(GUI.wcfQLRP.eVe ve) {
            return base.Channel.CreateVe(ve);
        }
        
        public System.Threading.Tasks.Task<GUI.wcfQLRP.eVe> CreateVeAsync(GUI.wcfQLRP.eVe ve) {
            return base.Channel.CreateVeAsync(ve);
        }
        
        public GUI.wcfQLRP.eVe GetVe(int idVe) {
            return base.Channel.GetVe(idVe);
        }
        
        public System.Threading.Tasks.Task<GUI.wcfQLRP.eVe> GetVeAsync(int idVe) {
            return base.Channel.GetVeAsync(idVe);
        }
        
        public GUI.wcfQLRP.ePhim CreatePhim(GUI.wcfQLRP.ePhim phim) {
            return base.Channel.CreatePhim(phim);
        }
        
        public System.Threading.Tasks.Task<GUI.wcfQLRP.ePhim> CreatePhimAsync(GUI.wcfQLRP.ePhim phim) {
            return base.Channel.CreatePhimAsync(phim);
        }
        
        public GUI.wcfQLRP.eNhanVien DangNhap(int id, string password) {
            return base.Channel.DangNhap(id, password);
        }
        
        public System.Threading.Tasks.Task<GUI.wcfQLRP.eNhanVien> DangNhapAsync(int id, string password) {
            return base.Channel.DangNhapAsync(id, password);
        }
        
        public double ThongKeDoanhThu(System.DateTime startDate, System.DateTime endDate, int idPhim) {
            return base.Channel.ThongKeDoanhThu(startDate, endDate, idPhim);
        }
        
        public System.Threading.Tasks.Task<double> ThongKeDoanhThuAsync(System.DateTime startDate, System.DateTime endDate, int idPhim) {
            return base.Channel.ThongKeDoanhThuAsync(startDate, endDate, idPhim);
        }
    }
}
