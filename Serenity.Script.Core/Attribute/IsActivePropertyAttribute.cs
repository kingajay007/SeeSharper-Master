using jQueryApi.UI.Widgets;
using System;

namespace Serenity
{
    public class IsActivePropertyAttribute : Attribute
    {
        public IsActivePropertyAttribute(string value)
        {
            this.Value = value;
        }

        public string Value { get; private set; }
    }
}