
namespace SeeSharper.ContentManagement.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("ContentManagement.Category")]
    [BasedOnRow(typeof(Entities.CategoryRow))]
    public class CategoryForm
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public Boolean IsActive { get; set; }
        public string ShortName { get; set; }
    }
}