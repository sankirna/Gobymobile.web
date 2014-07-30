using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GoByMobilePortal.Web.Enums
{
    public enum TemplateType
    {
        [Description("~/Views/Templates/HomePage.cshtml")]
        HomePage = 1,
        [Description("~/Views/Templates/Restaurant.Details.cshtml")]
        RestaurantDetail = 2,
        [Description("~/Views/Templates/Restaurant.Details.TwoColumn.cshtml")]
        RestaurantDetailTwoColumn = 3,
        [Description("~/Views/Templates/Restaurant.Details.TwoRowColumn.cshtml")]
        RestaurantDetailTwoRowColumn = 4,
        [Description("~/Views/Templates/Restaurant.List.cshtml")]
        RestaurantList = 5,

    }
}