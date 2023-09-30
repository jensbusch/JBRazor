using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JBRazorLib.Windows
{
    public partial class JBWindow : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent
        {
            get;
            set;
        }
        [Parameter]
        public int Top { get; set; } = 0;
        [Parameter]
        public int Left { get; set; } = 0;
        [Parameter]
        public int Width { get; set; } = 0;
        [Parameter]
        public int Height { get; set; } = 0;


        [Parameter]
        public string Caption { get; set; } = "Window";
    }
}
