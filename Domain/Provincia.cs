﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domain
{
    public class Provincia
    {
        public int Code { get; set; }
        [DisplayName("Provincia")]
        public string Descripcion { get; set; }
    }
}
