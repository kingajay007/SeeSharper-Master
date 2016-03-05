
namespace SeeSharper.ContentManagement
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("ContentManagement.Category"), IdProperty(CategoryRow.IdProperty), NameProperty(CategoryRow.NameProperty)]
    [DialogType(typeof(CategoryDialog)), LocalTextPrefix(CategoryRow.LocalTextPrefix), Service(CategoryService.BaseUrl)]
    public class CategoryGrid : EntityGrid<CategoryRow>
    {
        public CategoryGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}