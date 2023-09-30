using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JBRazorLib.Windows
{
    public partial class JBWindowBody : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent
        {
            get;
            set;
        }
    }
}
