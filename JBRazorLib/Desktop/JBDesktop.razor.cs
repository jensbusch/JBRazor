using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JBRazorLib.Desktop
{
    public partial class JBDesktop : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent
        {
            get;
            set;
        }
    }
}
