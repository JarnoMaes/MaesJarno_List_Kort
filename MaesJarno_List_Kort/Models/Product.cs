using MaesJarno_List_Kort.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaesJarno_List_Kort.Models
{
    class Product : IProduct
    {
        public string Merk { get; set; }
        public string Naam { get; set ; }
        public string Volume { get; set; }

        public Product(string merk,string naam,string volume)
        {
            this.Merk = merk;
            this.Naam = naam;
            this.Volume = volume;
        }

        public string GetCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Merk.ToUpper().Substring(0, 3));
            sb.Append(Naam.ToUpper().Substring(0,3));
            sb.Append(Volume.Replace(' ', '_'));
            return sb.ToString();
        }
        
    }
}
