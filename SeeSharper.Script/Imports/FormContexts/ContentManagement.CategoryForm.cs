
namespace SeeSharper.ContentManagement
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class CategoryForm : PrefixedContext
    {
        [InlineConstant] public const string FormKey = "ContentManagement.Category";

        public CategoryForm(string idPrefix) : base(idPrefix) {}


        public StringEditor Name { get { return ById<StringEditor>("Name"); } }
        public StringEditor Description { get { return ById<StringEditor>("Description"); } }
        public BooleanEditor IsActive { get { return ById<BooleanEditor>("IsActive"); } }
    }
}