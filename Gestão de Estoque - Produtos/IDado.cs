﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Estoque___Produtos
{
    interface IDado
    {
        string ToString();
        bool Equals(Object Obj);
        int CompareTo(Object Obj);
    }
}
