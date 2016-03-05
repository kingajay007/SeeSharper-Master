﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Serenity.Web
{
    internal static partial class Texts
    {
        public static partial class Controls
        {
            public static class Pager
            {
                public static LocalText Page = "Page";
                public static LocalText PageStatus = "Showing {from} to {to} of {total} total records";
                public static LocalText NoRowStatus = "No records";
                public static LocalText LoadingStatus = "Please wait, loading data...";
                public static LocalText DefaultLoadError = "An error occured while loading data!";
            }
        }
    }
}