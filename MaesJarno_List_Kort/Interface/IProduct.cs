using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaesJarno_List_Kort.Interface
{
    interface IProduct
    {
        string Merk { get; set; }
        string Naam { get; set; }
        string Volume { get; set; }
        string GetCode();
    }
}
