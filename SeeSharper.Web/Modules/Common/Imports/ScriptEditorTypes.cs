
using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SeeSharper.Administration
{
    public partial class PermissionCheckEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SeeSharper.Administration.PermissionCheckEditor";
    
        public PermissionCheckEditorAttribute()
            : base(Key)
        {
        }
    
        public Boolean ShowRevoke
        {
            get { return GetOption<Boolean>("showRevoke"); }
            set { SetOption("showRevoke", value); }
        }
    }

    public partial class PermissionModuleEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SeeSharper.Administration.PermissionModuleEditor";
    
        public PermissionModuleEditorAttribute()
            : base(Key)
        {
        }
    }

    public partial class RoleCheckEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SeeSharper.Administration.RoleCheckEditor";
    
        public RoleCheckEditorAttribute()
            : base(Key)
        {
        }
    }
}

namespace SeeSharper.BasicSamples
{
    public partial class ProduceSeafoodCategoryEditorAttribute : LookupEditorBaseAttribute
    {
        public const string Key = "SeeSharper.BasicSamples.ProduceSeafoodCategoryEditor";
    
        public ProduceSeafoodCategoryEditorAttribute()
            : base(Key)
        {
        }
    }
}

namespace SeeSharper.Membership
{
    public partial class ChangePasswordPanelAttribute : CustomEditorAttribute
    {
        public const string Key = "SeeSharper.Membership.ChangePasswordPanel";
    
        public ChangePasswordPanelAttribute()
            : base(Key)
        {
        }
    }

    public partial class ForgotPasswordPanelAttribute : CustomEditorAttribute
    {
        public const string Key = "SeeSharper.Membership.ForgotPasswordPanel";
    
        public ForgotPasswordPanelAttribute()
            : base(Key)
        {
        }
    }

    public partial class LoginPanelAttribute : CustomEditorAttribute
    {
        public const string Key = "SeeSharper.Membership.LoginPanel";
    
        public LoginPanelAttribute()
            : base(Key)
        {
        }
    }

    public partial class ResetPasswordPanelAttribute : CustomEditorAttribute
    {
        public const string Key = "SeeSharper.Membership.ResetPasswordPanel";
    
        public ResetPasswordPanelAttribute()
            : base(Key)
        {
        }
    }

    public partial class SignUpPanelAttribute : CustomEditorAttribute
    {
        public const string Key = "SeeSharper.Membership.SignUpPanel";
    
        public SignUpPanelAttribute()
            : base(Key)
        {
        }
    }
}

namespace SeeSharper.Northwind
{
    public partial class CustomerEditorAttribute : LookupEditorBaseAttribute
    {
        public const string Key = "SeeSharper.Northwind.CustomerEditor";
    
        public CustomerEditorAttribute()
            : base(Key)
        {
        }
    }

    public partial class NotesEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SeeSharper.Northwind.NotesEditor";
    
        public NotesEditorAttribute()
            : base(Key)
        {
        }
    }

    public partial class OrderDetailsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SeeSharper.Northwind.OrderDetailsEditor";
    
        public OrderDetailsEditorAttribute()
            : base(Key)
        {
        }
    }

    public partial class PhoneEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SeeSharper.Northwind.PhoneEditor";
    
        public PhoneEditorAttribute()
            : base(Key)
        {
        }
    
        public Boolean Multiple
        {
            get { return GetOption<Boolean>("multiple"); }
            set { SetOption("multiple", value); }
        }
    }
}

namespace Serenity.ComponentModel
{
    public partial class HtmlBasicContentEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Serenity.HtmlBasicContentEditor";
    
        public HtmlBasicContentEditorAttribute()
            : base(Key)
        {
        }
    
        public Int32 Cols
        {
            get { return GetOption<Int32>("cols"); }
            set { SetOption("cols", value); }
        }
    
        public Int32 Rows
        {
            get { return GetOption<Int32>("rows"); }
            set { SetOption("rows", value); }
        }
    }
}

