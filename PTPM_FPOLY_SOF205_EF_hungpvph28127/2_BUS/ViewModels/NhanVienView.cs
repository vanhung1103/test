﻿using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
   public class NhanVienView
    {
        public CuaHang CuaHang { get; set; }
        public NhanVien NhanVien { get; set; }
        public ChucVu ChucVu { get; set; }
        
    }
}
