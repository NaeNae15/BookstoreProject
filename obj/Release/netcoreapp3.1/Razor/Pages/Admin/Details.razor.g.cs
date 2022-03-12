#pragma checksum "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a959c8fd86ffd85c60def60f5638f9bf69aed4ab"
// <auto-generated/>
#pragma warning disable 1591
namespace BookstoreProject.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/_Imports.razor"
using BookstoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/details/{id:long}")]
    public partial class Details : OwningComponentBase<IBookstoreProjectRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"bg-info text-white text-center p-1\">Details</h3>\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-sm table-bordered table-striped");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<th>ID</th>");
            __builder.OpenElement(8, "td");
#nullable restore
#line 6 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/Details.razor"
__builder.AddContent(9, Book.BookId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n        ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "<th>Name</th>");
            __builder.OpenElement(13, "td");
#nullable restore
#line 7 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/Details.razor"
__builder.AddContent(14, Book.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n        ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "<th>Category</th>");
            __builder.OpenElement(18, "td");
#nullable restore
#line 8 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/Details.razor"
__builder.AddContent(19, Book.Category);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n        ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "<th>Price</th>");
            __builder.OpenElement(23, "td");
#nullable restore
#line 9 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/Details.razor"
__builder.AddContent(24, Book.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(28);
            __builder.AddAttribute(29, "class", "btn btn-warning");
            __builder.AddAttribute(30, "href", 
#nullable restore
#line 12 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/Details.razor"
                                        EditUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(32, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
            __builder.AddAttribute(35, "class", "btn btn-secondary");
            __builder.AddAttribute(36, "href", "/admin/books");
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(38, "Back");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/Details.razor"
       
    [Inject]
    public IBookstoreProjectRepository Repository { get; set; }
    [Parameter]
    public long Id { get; set; }
    public Book Book { get; set; }
    protected override void OnParametersSet()
    {
        Book = Repository.Books.FirstOrDefault(p => p.BookId == Id);
    }
    public string EditUrl => $"/admin/products/edit/{Book.BookId}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
