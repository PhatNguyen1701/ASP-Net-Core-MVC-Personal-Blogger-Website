﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger_Project_Practise.Models.Commments
{
    public class MainComment : Comment
    {
        public List<SubComment> SubComments { get; set; }
    }
}
