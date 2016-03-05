
namespace SeeSharper.ContentManagement
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(CategoryRow.IdProperty), NameProperty(CategoryRow.NameProperty)]
    [FormKey("ContentManagement.Category"), LocalTextPrefix(CategoryRow.LocalTextPrefix), Service(CategoryService.BaseUrl)]
    public class CategoryDialog : EntityDialog<CategoryRow>
    {
        protected CategoryForm form;

        public CategoryDialog()
        {
            form = new CategoryForm(this.IdPrefix);
        }
    }
}