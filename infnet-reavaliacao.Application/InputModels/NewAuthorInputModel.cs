﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infnet_reavaliacao.Application.InputModels
{
    public class NewAuthorInputModel
    {
        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Country { get; private set; }
    }
}
