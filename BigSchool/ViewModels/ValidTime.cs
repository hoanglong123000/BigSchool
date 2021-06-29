using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        DateTime dateTime;
        public override bool IsValid(object value)
        {
            var isvalid = DateTime.TryParseExact(Convert.ToString(value), "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None, out dateTime);
            return isvalid;
        }
        
    }
}