#pragma checksum "C:\Work\BlazorSRCMy\Server\DetailDataGridInformation\DetailDataGridInformation\DetailDataGridInformation\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c15f51952f49fa7c7583fec830c1370f59545167"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DetailDataGridInformation.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Work\BlazorSRCMy\Server\DetailDataGridInformation\DetailDataGridInformation\DetailDataGridInformation\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Work\BlazorSRCMy\Server\DetailDataGridInformation\DetailDataGridInformation\DetailDataGridInformation\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Work\BlazorSRCMy\Server\DetailDataGridInformation\DetailDataGridInformation\DetailDataGridInformation\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "C:\Work\BlazorSRCMy\Server\DetailDataGridInformation\DetailDataGridInformation\DetailDataGridInformation\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Work\BlazorSRCMy\Server\DetailDataGridInformation\DetailDataGridInformation\DetailDataGridInformation\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Work\BlazorSRCMy\Server\DetailDataGridInformation\DetailDataGridInformation\DetailDataGridInformation\_Imports.razor"
using DetailDataGridInformation;

#line default
#line hidden
#line 7 "C:\Work\BlazorSRCMy\Server\DetailDataGridInformation\DetailDataGridInformation\DetailDataGridInformation\_Imports.razor"
using DetailDataGridInformation.Shared;

#line default
#line hidden
#line 8 "C:\Work\BlazorSRCMy\Server\DetailDataGridInformation\DetailDataGridInformation\DetailDataGridInformation\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 18 "C:\Work\BlazorSRCMy\Server\DetailDataGridInformation\DetailDataGridInformation\DetailDataGridInformation\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
