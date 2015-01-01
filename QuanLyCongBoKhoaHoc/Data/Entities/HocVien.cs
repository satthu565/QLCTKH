//DevNETCoder  
//CopyRight By DevNET Group
 using System;
 using System.Text;

namespace QuanLyCongBoKhoaHoc.Entities 
{
   public class EHocVien
   {
	 public EHocVien()
	 {
	 }
	 private int _MaHocVien ;
	 private string _HoTen ;
	 private bool _GioiTinh ;
	 private DateTime _NgaySinh ;
	 private string _SoDienThoai ;
	 private string _ChuyenNganh ;
	 private string _Truong ;
	 private int _MaHocVi ;
	 private string _SoCMND ;
	 private string _Email ;
	 private string _QueQuan ;
 

	 public int MaHocVien
	 {
	    get { return _MaHocVien ; }
	    set { _MaHocVien = value ; }
	 }
	 public string HoTen
	 {
	    get { return _HoTen ; }
	    set { _HoTen = value ; }
	 }
	 public bool GioiTinh
	 {
	    get { return _GioiTinh ; }
	    set { _GioiTinh = value ; }
	 }
	 public DateTime NgaySinh
	 {
	    get { return _NgaySinh ; }
	    set { _NgaySinh = value ; }
	 }
	 public string SoDienThoai
	 {
	    get { return _SoDienThoai ; }
	    set { _SoDienThoai = value ; }
	 }
	 public string ChuyenNganh
	 {
	    get { return _ChuyenNganh ; }
	    set { _ChuyenNganh = value ; }
	 }
	 public string Truong
	 {
	    get { return _Truong ; }
	    set { _Truong = value ; }
	 }
	 public int MaHocVi
	 {
	    get { return _MaHocVi ; }
	    set { _MaHocVi = value ; }
	 }
	 public string SoCMND
	 {
	    get { return _SoCMND ; }
	    set { _SoCMND = value ; }
	 }
	 public string Email
	 {
	    get { return _Email ; }
	    set { _Email = value ; }
	 }
	 public string QueQuan
	 {
	    get { return _QueQuan ; }
	    set { _QueQuan = value ; }
	 }
   }
 }