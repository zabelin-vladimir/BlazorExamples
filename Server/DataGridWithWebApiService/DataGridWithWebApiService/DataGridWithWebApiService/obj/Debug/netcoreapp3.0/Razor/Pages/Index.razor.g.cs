#pragma checksum "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b57a6246b368c40536ea5f36554f2303dd900214"
// <auto-generated/>
#pragma warning disable 1591
namespace DataGridWithWebApiService.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\_Imports.razor"
using DataGridWithWebApiService;

#line default
#line hidden
#line 7 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\_Imports.razor"
using DataGridWithWebApiService.Shared;

#line default
#line hidden
#line 8 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#line 5 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\Pages\Index.razor"
using DataGridWithWebApiService.Data;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Cascading DxDataGrids</h1>\r\n");
#line 8 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\Pages\Index.razor"
 if (categories == null)
{

#line default
#line hidden
            builder.AddContent(1, "    ");
            builder.AddMarkupContent(2, "<h1>Loading...</h1>\r\n");
#line 11 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\Pages\Index.razor"
}
else
{

#line default
#line hidden
            builder.AddContent(3, "    ");
            __Blazor.DataGridWithWebApiService.Pages.Index.TypeInference.CreateDxDataGrid_0(builder, 4, 5, 
#line 14 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\Pages\Index.razor"
                      categories

#line default
#line hidden
            , 6, 
#line 14 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\Pages\Index.razor"
                                                false

#line default
#line hidden
            , 7, 
#line 14 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\Pages\Index.razor"
                                                                  false

#line default
#line hidden
            , 8, 
#line 15 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\Pages\Index.razor"
                              (dataItem) => OnRowRemoving(dataItem)

#line default
#line hidden
            , 9, 
#line 16 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\Pages\Index.razor"
                              (updatingDataItem, newValues) => OnRowUpdating(updatingDataItem, newValues)

#line default
#line hidden
            , 10, 
#line 17 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\Pages\Index.razor"
                               (newValues) => OnRowInserting(newValues)

#line default
#line hidden
            , 11, (builder2) => {
                builder2.AddMarkupContent(12, "\r\n        ");
                builder2.OpenComponent<DevExpress.Blazor.DxDataGridCommandColumn>(13);
                builder2.AddAttribute(14, "Width", "150px");
                builder2.CloseComponent();
                builder2.AddMarkupContent(15, "\r\n        ");
                builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(16);
                builder2.AddAttribute(17, "Field", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(
#line 19 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\Pages\Index.razor"
                                 nameof(Categories.CategoryId)

#line default
#line hidden
                ));
                builder2.CloseComponent();
                builder2.AddMarkupContent(18, "\r\n        ");
                builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(19);
                builder2.AddAttribute(20, "Field", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\Pages\Index.razor"
                                 nameof(Categories.CategoryName)

#line default
#line hidden
                ));
                builder2.CloseComponent();
                builder2.AddMarkupContent(21, "\r\n        ");
                builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(22);
                builder2.AddAttribute(23, "Field", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(
#line 21 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\Pages\Index.razor"
                                 nameof(Categories.Description)

#line default
#line hidden
                ));
                builder2.CloseComponent();
                builder2.AddMarkupContent(24, "\r\n    ");
            }
            );
            builder.AddMarkupContent(25, "\r\n");
#line 23 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\Pages\Index.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 24 "C:\Work\BlazorSRCMy\Server\DataGridWithWebApiService\DataGridWithWebApiService\DataGridWithWebApiService\Pages\Index.razor"
            
    List<Categories> categories;

    protected override async Task OnInitAsync()
    {
        categories = await Http.GetJsonAsync<List<Categories>>(wsp.Path + "categories");
    }
    async void OnRowRemoving(Categories dataItem)
    {
        await Http.DeleteAsync(wsp.Path + "categories/" + dataItem.CategoryId);
        categories.Remove(dataItem);
        await Invoke(StateHasChanged);
    }
    async void OnRowUpdating(Categories dataItem, Dictionary<string, object> newValue)
    {
        foreach (var field in newValue.Keys)
        {
            switch (field)
            {
                case nameof(Categories.CategoryName):
                    dataItem.CategoryName = (string)newValue[field];
                    break;
                case nameof(Categories.Description):
                    dataItem.Description = (string)newValue[field];
                    break;
            }
        }
        await Http.PutJsonAsync(wsp.Path + "categories/" + dataItem.CategoryId, dataItem);
        await Invoke(StateHasChanged);
    }
    async void OnRowInserting(Dictionary<string, object> newValue)
    {
        Categories newCategory = new Categories();
        foreach (var field in newValue.Keys)
        {
            switch (field)
            {
                case nameof(Categories.CategoryName):
                    newCategory.CategoryName = (string)newValue[field];
                    break;
                case nameof(Categories.Description):
                    newCategory.Description = (string)newValue[field];
                    break;
            }
        }
        Categories insertedCategory = await Http.PostJsonAsync<Categories>(wsp.Path + "categories/", newCategory);
        newCategory.CategoryId = insertedCategory.CategoryId;
        categories.Add(newCategory);
        await Invoke(StateHasChanged);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WebServicePath wsp { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.DataGridWithWebApiService.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDxDataGrid_0<T>(global::Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Action<T> __arg3, int __seq4, global::System.Action<T, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object>> __arg4, int __seq5, global::System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        builder.OpenComponent<global::DevExpress.Blazor.DxDataGrid<T>>(seq);
        builder.AddAttribute(__seq0, "Data", __arg0);
        builder.AddAttribute(__seq1, "ShowFilterRow", __arg1);
        builder.AddAttribute(__seq2, "ShowPager", __arg2);
        builder.AddAttribute(__seq3, "RowRemoving", __arg3);
        builder.AddAttribute(__seq4, "RowUpdating", __arg4);
        builder.AddAttribute(__seq5, "RowInserting", __arg5);
        builder.AddAttribute(__seq6, "ChildContent", __arg6);
        builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
