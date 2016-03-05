
namespace SeeSharper.ContentManagement
{
    using jQueryApi;
    using Serenity;
    using System.Collections.Generic;

    [IdProperty(QuestionRow.IdProperty), NameProperty(QuestionRow.NameProperty)]
    [FormKey("ContentManagement.Question"), LocalTextPrefix(QuestionRow.LocalTextPrefix), Service(QuestionService.BaseUrl)]
    public class QuestionDialog : EntityDialog<QuestionRow>
    {
        protected QuestionForm form;

        public QuestionDialog()
        {
            form = new QuestionForm(this.IdPrefix);
        }
    }
}