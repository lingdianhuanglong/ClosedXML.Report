﻿using System;
using System.Collections.Generic;
using LinqToDB.Mapping;

namespace ClosedXML.Report.Tests.TestModels
{
    public partial class customer
    {
        [Association(ThisKey = "CustNo", OtherKey = "CustNo", IsBackReference = true)]
        public List<order> Orders { get; set; }
    }
}