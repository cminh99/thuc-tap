#pragma checksum "D:\learn blazor fw\_test\SlackClone\Features\Messages\Reaction.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3987ef048376b08862df2c0ef66a9ffd80e34e8c"
// <auto-generated/>
#pragma warning disable 1591
namespace SlackClone.Features.Messages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using SlackClone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using SlackClone.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\learn blazor fw\_test\SlackClone\Features\Messages\Reaction.razor"
using SlackClone.Domain;

#line default
#line hidden
#nullable disable
    public partial class Reaction : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn btn-sm btn-primary mt-1 mb-3");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\learn blazor fw\_test\SlackClone\Features\Messages\Reaction.razor"
                                                           Like

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n    Like ");
            __builder.AddContent(4, 
#nullable restore
#line 4 "D:\learn blazor fw\_test\SlackClone\Features\Messages\Reaction.razor"
          MessageDetails.Like

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "D:\learn blazor fw\_test\SlackClone\Features\Messages\Reaction.razor"
       
    [Parameter]
    public SlackMessage MessageDetails { get; set; } = new SlackMessage();

    private void Like()
    {
        MessageDetails.Like++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
