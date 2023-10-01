using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JBRazorLib.Windows
{
    public partial class JBWindow : ComponentBase
    {
        int _top, _left, _width, _right;
        [Parameter]
        public RenderFragment ChildContent
        {
            get;
            set;
        }
        [Parameter]
        public string Top { get; set; } = "0px";
        [Parameter]
        public string Left { get; set; } = "0px";
        [Parameter]
        public string Width { get; set; } = "400px";
        [Parameter]
        public string Height { get; set; } = "250px";


        [Parameter]
        public string Caption { get; set; } = "Window";

        
    }
}
