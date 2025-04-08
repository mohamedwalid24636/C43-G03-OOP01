using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_OOP
{
    internal enum Weekdays : int   
    {
        saturday , sunday , monday, tuesday,wednesday, thursday, friday
    }


    internal enum seas_on 
    {
        Spring,Summer,
        Autumn,Winter

    }

    [Flags]
    internal enum Permission
    {
        u_have_no_permissions , 
        Read = 1     ,  // 0001
        write = 2    ,  // 0010
        Delete = 4   ,  // 0100
        Execute = 8     // 1000
    }


    [Flags]
    internal enum Color
    {
        Red, Green, Blue
    }
}
