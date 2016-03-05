using jQueryApi.UI.Widgets;
using System;

namespace Serenity
{
    public class EntityTypeAttribute : Attribute
    {
        public EntityTypeAttribute(string value)
        {
            this.Value = value;
        }

        public string Value  { get; private set; }
    }
}