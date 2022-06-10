// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FrontOrion.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\_Imports.razor"
using FrontOrion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\_Imports.razor"
using FrontOrion.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\_Imports.razor"
using FrontOrion.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
using FrontOrion.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/list")]
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 124 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
       
    public Guid EditingAddressId = Guid.Empty;
    
    public Collection<ClientModel> clients = new Collection<ClientModel>(){
        new ClientModel{
            Id = Guid.NewGuid(),
            Name = "Some Name",
            Addresses = new Collection<AddressModel>(){
                new AddressModel{
                    Id = Guid.NewGuid(),
                    Street = "Some Street",
                    PostCode = "Some Number",
                    Province = "Some City",
                    Reference = "Some Country"
                },
                      new AddressModel{
                    Id = Guid.NewGuid(),
                    Street = "Some Street",
                    PostCode = "Some Number",
                    Province = "Some City",
                    Reference = "Some Country"
                },
                      new AddressModel{
                    Id = Guid.NewGuid(),
                    Street = "Some Street",
                    PostCode = "Some Number",
                    Province = "Some City",
                    Reference = "Some Country"
                }
            }
        }    
    };

    public ClientModel modalClient = new ClientModel(){
        Id = Guid.NewGuid(),
        Name = "",
    };

    public AddressModel addressToAdd = new AddressModel(){
        ClientId = Guid.NewGuid(),
        Street = "",
        PostCode = "",
        Province ="",
        Reference = ""
    };

    public AddressModel addressToEdit = new AddressModel(){
        ClientId = Guid.NewGuid(),
        Street = "",
        PostCode = "",
        Province ="",
        Reference = ""
    };

    protected override async Task OnInitializedAsync()
    {
        var request = await http.GetAsync("/Client").ConfigureAwait(true);
    }

    public async Task handleDelete(Guid id)
    {
        var indexToDelete = clients.ToList().FindIndex(client => client.Id == id);

        clients.RemoveAt(indexToDelete);

        var request = await http.DeleteAsync($"/Client?clientId={id}").ConfigureAwait(true);
    }

    public void HandleShowModal(Guid id)
    {
        var clientToFind = clients.ToList().FindIndex(client => client.Id == id);

        modalClient = clients.ElementAt(clientToFind);
    }

    public void handleDeleteClientAddress(Guid addressId)
    {
        var addressToDelete = modalClient.Addresses.ToList().FindIndex(address => address.Id == addressId);

        modalClient.Addresses.RemoveAt(addressToDelete);

        var request = http.DeleteAsync($"/Address?addressId={addressId}").ConfigureAwait(true);
    }

    public async Task addAddressToContact()
    {
        modalClient.Addresses.Add(addressToAdd);

        var response = await http.PostAsync("/Address", new StringContent(JsonSerializer.Serialize(addressToAdd), Encoding.UTF8, "application/json")).ConfigureAwait(true); 

        addressToAdd = new AddressModel(){
            ClientId = Guid.NewGuid(),
            Street = "",
            PostCode = "",
            Province ="",
            Reference = ""
        };
    }

    public void updateAddress (Guid id)
    {
        EditingAddressId = id;

        var indexToEdit = modalClient.Addresses.ToList().FindIndex(address => address.Id == id);

        addressToEdit = modalClient.Addresses.ElementAt(indexToEdit);
    }

    public async Task updateSelectedAddress() 
    {
        if(EditingAddressId == Guid.Empty) return;

        var indexToEdit = modalClient.Addresses.ToList().FindIndex(address => address.Id == EditingAddressId);

        modalClient.Addresses.RemoveAt(indexToEdit);
        modalClient.Addresses.Insert(indexToEdit, addressToEdit);
       
        var response = await http.PutAsync("/Address", new StringContent(JsonSerializer.Serialize(addressToEdit), Encoding.UTF8, "application/json")).ConfigureAwait(true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
