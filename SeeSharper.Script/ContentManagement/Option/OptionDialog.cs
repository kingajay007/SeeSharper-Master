
namespace SeeSharper.ContentManagement
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(OptionRow.IdProperty), NameProperty(OptionRow.NameProperty)]
    [FormKey("ContentManagement.Option"), LocalTextPrefix(OptionRow.LocalTextPrefix), Service(OptionService.BaseUrl)]
    public class OptionDialog : EntityDialog<OptionRow>
    {
        protected OptionForm form;

        public OptionDialog()
        {
            form = new OptionForm(this.IdPrefix);
        }
    }
}