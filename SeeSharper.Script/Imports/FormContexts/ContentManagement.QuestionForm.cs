
namespace SeeSharper.ContentManagement
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class QuestionForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "ContentManagement.Question";

        public QuestionForm(string idPrefix) : base(idPrefix) {}


        public StringEditor Query { get { return ById<StringEditor>("Query"); } }
        public IntegerEditor CategoryId { get { return ById<IntegerEditor>("CategoryId"); } }
    }
}