// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookstoreProject.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Pages/Admin/_Imports.razor"
using BookstoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Pages/Admin/_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class OrdersTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Pages/Admin/OrdersTable.razor"
       
    [Parameter]
    public string TableTitle { get; set; } = "Orders";
    [Parameter]
    public IEnumerable<Purchase> Orders { get; set; }
    [Parameter]
    public string ButtonLabel { get; set; } = "Ship";
    [Parameter]
    public EventCallback<int> OrderSelected { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
