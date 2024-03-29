﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppee.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreateDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        bool Status { set; get; }
    }
}
