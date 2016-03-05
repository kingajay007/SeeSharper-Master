
namespace SeeSharper.ContentManagement
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("ContentManagement.Option"), IdProperty(OptionRow.IdProperty), NameProperty(OptionRow.NameProperty)]
    [DialogType(typeof(OptionDialog)), LocalTextPrefix(OptionRow.LocalTextPrefix), Service(OptionService.BaseUrl)]
    public class OptionGrid : EntityGrid<OptionRow>
    {
        public OptionGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}