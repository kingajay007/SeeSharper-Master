
namespace SeeSharper.ContentManagement
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class OptionForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "ContentManagement.Option";

        public OptionForm(string idPrefix) : base(idPrefix) {}


        public StringEditor Value { get { return ById<StringEditor>("Value"); } }
        public BooleanEditor IsCorrect { get { return ById<BooleanEditor>("IsCorrect"); } }
        public IntegerEditor QuestionId { get { return ById<IntegerEditor>("QuestionId"); } }
    }
}