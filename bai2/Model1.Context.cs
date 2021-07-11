﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bai2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class quanLyKiTucXaEntities3 : DbContext
    {
        public quanLyKiTucXaEntities3()
            : base("name=quanLyKiTucXaEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<hoaDonPhong> hoaDonPhongs { get; set; }
        public virtual DbSet<quanLiHoSoSinhVien> quanLiHoSoSinhViens { get; set; }
        public virtual DbSet<quanLiPhong> quanLiPhongs { get; set; }
        public virtual DbSet<hoaDonDienNuoc> hoaDonDienNuocs { get; set; }
    
        public virtual ObjectResult<getAllStudent_Result> getAllStudent()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllStudent_Result>("getAllStudent");
        }
    
        public virtual int sp_InsertSinhvien(Nullable<int> maSinhVien_p, byte[] hinhAnh_p, string hoTen_P, string diaChi_p, string gioiTinh_P, string khoa_P, Nullable<System.DateTime> ngaySinh_P, string soDienThoai_P)
        {
            var maSinhVien_pParameter = maSinhVien_p.HasValue ?
                new ObjectParameter("maSinhVien_p", maSinhVien_p) :
                new ObjectParameter("maSinhVien_p", typeof(int));
    
            var hinhAnh_pParameter = hinhAnh_p != null ?
                new ObjectParameter("hinhAnh_p", hinhAnh_p) :
                new ObjectParameter("hinhAnh_p", typeof(byte[]));
    
            var hoTen_PParameter = hoTen_P != null ?
                new ObjectParameter("hoTen_P", hoTen_P) :
                new ObjectParameter("hoTen_P", typeof(string));
    
            var diaChi_pParameter = diaChi_p != null ?
                new ObjectParameter("diaChi_p", diaChi_p) :
                new ObjectParameter("diaChi_p", typeof(string));
    
            var gioiTinh_PParameter = gioiTinh_P != null ?
                new ObjectParameter("gioiTinh_P", gioiTinh_P) :
                new ObjectParameter("gioiTinh_P", typeof(string));
    
            var khoa_PParameter = khoa_P != null ?
                new ObjectParameter("khoa_P", khoa_P) :
                new ObjectParameter("khoa_P", typeof(string));
    
            var ngaySinh_PParameter = ngaySinh_P.HasValue ?
                new ObjectParameter("ngaySinh_P", ngaySinh_P) :
                new ObjectParameter("ngaySinh_P", typeof(System.DateTime));
    
            var soDienThoai_PParameter = soDienThoai_P != null ?
                new ObjectParameter("soDienThoai_P", soDienThoai_P) :
                new ObjectParameter("soDienThoai_P", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertSinhvien", maSinhVien_pParameter, hinhAnh_pParameter, hoTen_PParameter, diaChi_pParameter, gioiTinh_PParameter, khoa_PParameter, ngaySinh_PParameter, soDienThoai_PParameter);
        }
    
        public virtual ObjectResult<sp_findStudent_Result> sp_findStudent(string maSVP)
        {
            var maSVPParameter = maSVP != null ?
                new ObjectParameter("MaSVP", maSVP) :
                new ObjectParameter("MaSVP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_findStudent_Result>("sp_findStudent", maSVPParameter);
        }
    
        public virtual ObjectResult<sp_findStudent1_Result> sp_findStudent1(string maSVP)
        {
            var maSVPParameter = maSVP != null ?
                new ObjectParameter("MaSVP", maSVP) :
                new ObjectParameter("MaSVP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_findStudent1_Result>("sp_findStudent1", maSVPParameter);
        }
    
        public virtual int sp_updateStudent(Nullable<int> maSinhVien_p, byte[] hinhAnh_p, string hoTen_P, string diaChi_p, string gioiTinh_P, string khoa_P, Nullable<System.DateTime> ngaySinh_P, string soDienThoai_P)
        {
            var maSinhVien_pParameter = maSinhVien_p.HasValue ?
                new ObjectParameter("maSinhVien_p", maSinhVien_p) :
                new ObjectParameter("maSinhVien_p", typeof(int));
    
            var hinhAnh_pParameter = hinhAnh_p != null ?
                new ObjectParameter("hinhAnh_p", hinhAnh_p) :
                new ObjectParameter("hinhAnh_p", typeof(byte[]));
    
            var hoTen_PParameter = hoTen_P != null ?
                new ObjectParameter("hoTen_P", hoTen_P) :
                new ObjectParameter("hoTen_P", typeof(string));
    
            var diaChi_pParameter = diaChi_p != null ?
                new ObjectParameter("diaChi_p", diaChi_p) :
                new ObjectParameter("diaChi_p", typeof(string));
    
            var gioiTinh_PParameter = gioiTinh_P != null ?
                new ObjectParameter("gioiTinh_P", gioiTinh_P) :
                new ObjectParameter("gioiTinh_P", typeof(string));
    
            var khoa_PParameter = khoa_P != null ?
                new ObjectParameter("khoa_P", khoa_P) :
                new ObjectParameter("khoa_P", typeof(string));
    
            var ngaySinh_PParameter = ngaySinh_P.HasValue ?
                new ObjectParameter("ngaySinh_P", ngaySinh_P) :
                new ObjectParameter("ngaySinh_P", typeof(System.DateTime));
    
            var soDienThoai_PParameter = soDienThoai_P != null ?
                new ObjectParameter("soDienThoai_P", soDienThoai_P) :
                new ObjectParameter("soDienThoai_P", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_updateStudent", maSinhVien_pParameter, hinhAnh_pParameter, hoTen_PParameter, diaChi_pParameter, gioiTinh_PParameter, khoa_PParameter, ngaySinh_PParameter, soDienThoai_PParameter);
        }
    
        public virtual ObjectResult<sp_getAllBoyStudent_Result> sp_getAllBoyStudent()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getAllBoyStudent_Result>("sp_getAllBoyStudent");
        }
    
        public virtual ObjectResult<sp_getAllGirlStudent_Result> sp_getAllGirlStudent()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getAllGirlStudent_Result>("sp_getAllGirlStudent");
        }
    
        public virtual ObjectResult<sp_getAllGirlStudent1_Result> sp_getAllGirlStudent1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getAllGirlStudent1_Result>("sp_getAllGirlStudent1");
        }
    
        public virtual ObjectResult<getAllBill1_Result> getAllBill1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllBill1_Result>("getAllBill1");
        }
    
        public virtual int pc_insertBill(Nullable<int> idHopDong_p, Nullable<int> idPhong_P, Nullable<int> maSinhVien_p, Nullable<int> kiHan_p, Nullable<System.DateTime> ngayBatDau_p, string thanhToan_p)
        {
            var idHopDong_pParameter = idHopDong_p.HasValue ?
                new ObjectParameter("IdHopDong_p", idHopDong_p) :
                new ObjectParameter("IdHopDong_p", typeof(int));
    
            var idPhong_PParameter = idPhong_P.HasValue ?
                new ObjectParameter("idPhong_P", idPhong_P) :
                new ObjectParameter("idPhong_P", typeof(int));
    
            var maSinhVien_pParameter = maSinhVien_p.HasValue ?
                new ObjectParameter("maSinhVien_p", maSinhVien_p) :
                new ObjectParameter("maSinhVien_p", typeof(int));
    
            var kiHan_pParameter = kiHan_p.HasValue ?
                new ObjectParameter("KiHan_p", kiHan_p) :
                new ObjectParameter("KiHan_p", typeof(int));
    
            var ngayBatDau_pParameter = ngayBatDau_p.HasValue ?
                new ObjectParameter("ngayBatDau_p", ngayBatDau_p) :
                new ObjectParameter("ngayBatDau_p", typeof(System.DateTime));
    
            var thanhToan_pParameter = thanhToan_p != null ?
                new ObjectParameter("thanhToan_p", thanhToan_p) :
                new ObjectParameter("thanhToan_p", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pc_insertBill", idHopDong_pParameter, idPhong_PParameter, maSinhVien_pParameter, kiHan_pParameter, ngayBatDau_pParameter, thanhToan_pParameter);
        }
    
        public virtual int deleteBill(Nullable<int> idHopDong_p)
        {
            var idHopDong_pParameter = idHopDong_p.HasValue ?
                new ObjectParameter("IdHopDong_p", idHopDong_p) :
                new ObjectParameter("IdHopDong_p", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteBill", idHopDong_pParameter);
        }
    
        public virtual ObjectResult<findContract_Result> findContract(Nullable<int> idHopDong_p)
        {
            var idHopDong_pParameter = idHopDong_p.HasValue ?
                new ObjectParameter("IdHopDong_p", idHopDong_p) :
                new ObjectParameter("IdHopDong_p", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<findContract_Result>("findContract", idHopDong_pParameter);
        }
    
        public virtual ObjectResult<findPaidContract_Result> findPaidContract(Nullable<int> idHopDong_p)
        {
            var idHopDong_pParameter = idHopDong_p.HasValue ?
                new ObjectParameter("IdHopDong_p", idHopDong_p) :
                new ObjectParameter("IdHopDong_p", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<findPaidContract_Result>("findPaidContract", idHopDong_pParameter);
        }
    
        public virtual ObjectResult<findUnaidContract_Result> findUnaidContract(Nullable<int> idHopDong_p)
        {
            var idHopDong_pParameter = idHopDong_p.HasValue ?
                new ObjectParameter("IdHopDong_p", idHopDong_p) :
                new ObjectParameter("IdHopDong_p", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<findUnaidContract_Result>("findUnaidContract", idHopDong_pParameter);
        }
    
        public virtual ObjectResult<findPaidContract1_Result> findPaidContract1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<findPaidContract1_Result>("findPaidContract1");
        }
    
        public virtual ObjectResult<findUnaidContract1_Result> findUnaidContract1(Nullable<int> idHopDong_p)
        {
            var idHopDong_pParameter = idHopDong_p.HasValue ?
                new ObjectParameter("IdHopDong_p", idHopDong_p) :
                new ObjectParameter("IdHopDong_p", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<findUnaidContract1_Result>("findUnaidContract1", idHopDong_pParameter);
        }
    
        public virtual ObjectResult<findUnaidContract2_Result> findUnaidContract2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<findUnaidContract2_Result>("findUnaidContract2");
        }
    
        public virtual ObjectResult<string> showListStudent(Nullable<int> tenPhong)
        {
            var tenPhongParameter = tenPhong.HasValue ?
                new ObjectParameter("tenPhong", tenPhong) :
                new ObjectParameter("tenPhong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("showListStudent", tenPhongParameter);
        }
    
        public virtual ObjectResult<string> showListStudent1(Nullable<int> tenPhong)
        {
            var tenPhongParameter = tenPhong.HasValue ?
                new ObjectParameter("tenPhong", tenPhong) :
                new ObjectParameter("tenPhong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("showListStudent1", tenPhongParameter);
        }
    
        public virtual int sp_DeleteStudent(string maSVP)
        {
            var maSVPParameter = maSVP != null ?
                new ObjectParameter("MaSVP", maSVP) :
                new ObjectParameter("MaSVP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteStudent", maSVPParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> getAllRoom()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getAllRoom");
        }
    }
}