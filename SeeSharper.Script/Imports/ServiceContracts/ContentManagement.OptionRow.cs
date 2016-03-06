
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
    public partial class OptionRow
    {
        [InlineConstant] public const string IdProperty = "Id";
        [InlineConstant] public const string NameProperty = "Value";
        [InlineConstant] public const string LocalTextPrefix = "ContentManagement.Option";
    
        public Int32? Id { get; set; }
        public String Value { get; set; }
        public Boolean? IsCorrect { get; set; }
        public Int32? QuestionId { get; set; }
        public String QuestionQuery { get; set; }
        public Int32? QuestionCategoryId { get; set; }
    
        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string Id = "Id";
            [InlineConstant] public const string Value = "Value";
            [InlineConstant] public const string IsCorrect = "IsCorrect";
            [InlineConstant] public const string QuestionId = "QuestionId";
            [InlineConstant] public const string QuestionQuery = "QuestionQuery";
            [InlineConstant] public const string QuestionCategoryId = "QuestionCategoryId";
        }
    }
    
}

