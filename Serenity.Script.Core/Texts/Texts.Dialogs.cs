﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Serenity
{
    public static partial class Texts
    {
        [PreserveMemberCase]
        public static class Dialogs
        {
            public static LocalText OkButton = "OK";
            public static LocalText YesButton = "Yes";
            public static LocalText NoButton = "No";
            public static LocalText CancelButton = "Cancel";
            public static LocalText AlertTitle = "Alert";
            public static LocalText ConfirmationTitle = "Confirm";
            public static LocalText InformationTitle = "Information";
            public static LocalText WarningTitle = "Warning";

            static Dialogs()
            {
                LocalText.InitializeTextClass(typeof(Dialogs), "Dialogs.");
            }
        }
    }
}