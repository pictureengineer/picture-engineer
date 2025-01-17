﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PictureEngineer.Data.Common
{
    public static class StringExtensions
    {
        public static string ToSnakeCase(this string input, bool isUpper = false)
        {
            if (string.IsNullOrEmpty(input)) { return input; }

            var startUnderscores = Regex.Match(input, @"^_+");

            return isUpper ? startUnderscores + Regex.Replace(input, @"([a-z0-9])([A-Z])", "$1_$2").ToUpper().Replace("ASP_NET_", "")
                           : startUnderscores + Regex.Replace(input, @"([a-z0-9])([A-Z])", "$1_$2").ToLower();
        }
    }
}
