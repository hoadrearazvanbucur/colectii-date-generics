using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace colectii_date_generics
{
    class KmComparer : Comparer<Masina>
    {
        public override int Compare(Masina x,Masina y)
        {
            if (x.Km < y.Km){
                return -1;
            }else if (x.Km == y.Km){
                return 0;
            }else if (x.Km > y.Km){
                return 1;
            }
            return -2;
        }
    }
}
