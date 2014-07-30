using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoByMobilePortal.Web.Enums;

namespace GoByMobilePortal.Web.Models
{
    public class MasterTemplateModel
    {
        public string LayoutPath { get; set; }
        public TemplateType TemplateType { get; set; }
    }
}