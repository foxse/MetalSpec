//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MetalSpec
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profiles
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<float> h { get; set; }
        public Nullable<float> b { get; set; }
        public Nullable<float> s { get; set; }
        public Nullable<float> t { get; set; }
        public Nullable<float> r1 { get; set; }
        public Nullable<float> r2 { get; set; }
        public Nullable<float> A { get; set; }
        public Nullable<float> ly { get; set; }
        public Nullable<float> lz { get; set; }
        public Nullable<float> lu { get; set; }
        public Nullable<float> Wy { get; set; }
        public Nullable<float> iy { get; set; }
        public Nullable<float> lv { get; set; }
        public Nullable<float> Wz { get; set; }
        public Nullable<float> Wv { get; set; }
        public Nullable<float> zo { get; set; }
        public Nullable<float> tgAlpha { get; set; }
        public Nullable<float> Sy { get; set; }
        public Nullable<float> gamma { get; set; }
        public Nullable<float> D { get; set; }
        public Nullable<float> n1 { get; set; }
        public Nullable<float> n2 { get; set; }
        public Nullable<float> z0 { get; set; }
        public Nullable<float> Sz { get; set; }
        public Nullable<float> h_2t { get; set; }
        public Nullable<float> Wply { get; set; }
        public Nullable<float> Wplz { get; set; }
        public Nullable<float> Wvo { get; set; }
        public Nullable<float> iz { get; set; }
        public Nullable<float> iu { get; set; }
        public Nullable<float> iv { get; set; }
        public Nullable<float> lyz { get; set; }
        public Nullable<float> yo { get; set; }
        public Nullable<float> P { get; set; }
        public int SortamentID { get; set; }
        public Nullable<float> PaintArea { get; set; }
    
        public virtual Sortament Sortament { get; set; }
    }
}