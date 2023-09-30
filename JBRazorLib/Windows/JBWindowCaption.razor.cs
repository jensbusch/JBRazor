using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JBRazorLib.Windows
{
    public partial class JBWindowCaption : ComponentBase
    {
        [Parameter]
        public string Text { get; set; }
    }
}
