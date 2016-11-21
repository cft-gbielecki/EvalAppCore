﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvalAppCore.Models
{
    public class Contracts
    {
        [Key]
        public int ContractID { get; set; }
        public int ClientID { get; set; }
        public string Contract { get; set; }
    }
}
