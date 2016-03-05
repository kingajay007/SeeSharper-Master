
namespace SeeSharper.ContentManagement
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    [Imported, Serializable, PreserveMemberCase]
    public partial class QuestionRow
    {
        [InlineConstant] public const string IdProperty = "Id";
        [InlineConstant] public const string NameProperty = "Query";
        [InlineConstant] public const string LocalTextPrefix = "ContentManagement.Question";

        public Int32? Id { get; set; }
        public String Query { get; set; }
        public Int32? CategoryId { get; set; }
        public String CategoryName { get; set; }
        public String CategoryDescription { get; set; }
        public Boolean? CategoryIsActive { get; set; }
        public String CategoryShortName { get; set; }

        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string Id = "Id";
            [InlineConstant] public const string Query = "Query";
            [InlineConstant] public const string CategoryId = "CategoryId";
            [InlineConstant] public const string CategoryName = "CategoryName";
            [InlineConstant] public const string CategoryDescription = "CategoryDescription";
            [InlineConstant] public const string CategoryIsActive = "CategoryIsActive";
            [InlineConstant] public const string CategoryShortName = "CategoryShortName";
        }
    }
}