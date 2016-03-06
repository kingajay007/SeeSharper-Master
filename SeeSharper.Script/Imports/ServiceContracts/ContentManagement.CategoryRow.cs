
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
    public partial class CategoryRow
    {
        [InlineConstant] public const string IdProperty = "Id";
        [InlineConstant] public const string NameProperty = "Name";
        [InlineConstant] public const string LocalTextPrefix = "ContentManagement.Category";
    
        public Int32? Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Boolean? IsActive { get; set; }
        public String ShortName { get; set; }
    
        [Imported, PreserveMemberCase]
        public static class Fields
        {
            [InlineConstant] public const string Id = "Id";
            [InlineConstant] public const string Name = "Name";
            [InlineConstant] public const string Description = "Description";
            [InlineConstant] public const string IsActive = "IsActive";
            [InlineConstant] public const string ShortName = "ShortName";
        }
    }
    
}

