#pragma checksum "D:\blazor fw\thuc tap\ShoppingCart\Client\Pages\Cart\Item.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "105f01e7a4eb0cf3cc9f0ab9c80fd02de19b0f05"
// <auto-generated/>
#pragma warning disable 1591
namespace ShoppingCartStarter.Client.Pages.Cart
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\blazor fw\thuc tap\ShoppingCart\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\blazor fw\thuc tap\ShoppingCart\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\blazor fw\thuc tap\ShoppingCart\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\blazor fw\thuc tap\ShoppingCart\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\blazor fw\thuc tap\ShoppingCart\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\blazor fw\thuc tap\ShoppingCart\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\blazor fw\thuc tap\ShoppingCart\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\blazor fw\thuc tap\ShoppingCart\Client\_Imports.razor"
using ShoppingCartStarter.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\blazor fw\thuc tap\ShoppingCart\Client\_Imports.razor"
using ShoppingCartStarter.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class Item : ItemBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row border py-4");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-sm");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "media");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", "/images/" + (
#nullable restore
#line 6 "D:\blazor fw\thuc tap\ShoppingCart\Client\Pages\Cart\Item.razor"
                               Details.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "class", "mr-3");
            __builder.AddAttribute(9, "alt", 
#nullable restore
#line 6 "D:\blazor fw\thuc tap\ShoppingCart\Client\Pages\Cart\Item.razor"
                                                                 Details.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "media-body");
            __builder.OpenElement(13, "h3");
            __builder.AddContent(14, 
#nullable restore
#line 8 "D:\blazor fw\thuc tap\ShoppingCart\Client\Pages\Cart\Item.razor"
                     Details.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-inline");
            __builder.AddMarkupContent(18, "<label for=\"qty\" class=\"mr-2\">Qty</label>\r\n                    ");
            __builder.OpenComponent<ShoppingCartStarter.Client.Pages.Cart.Quantity>(19);
            __builder.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "D:\blazor fw\thuc tap\ShoppingCart\Client\Pages\Cart\Item.razor"
                                     Details.Quantity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 11 "D:\blazor fw\thuc tap\ShoppingCart\Client\Pages\Cart\Item.razor"
                                                                     QuantityChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-sm btn-outline-danger");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\blazor fw\thuc tap\ShoppingCart\Client\Pages\Cart\Item.razor"
                                                                            HandleDelete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-sm-2");
            __builder.AddMarkupContent(30, "\r\n        $");
            __builder.AddContent(31, 
#nullable restore
#line 18 "D:\blazor fw\thuc tap\ShoppingCart\Client\Pages\Cart\Item.razor"
          Details.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
