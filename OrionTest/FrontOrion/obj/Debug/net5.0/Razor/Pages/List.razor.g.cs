#pragma checksum "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7109daa131b9816fbb5c59908d23a8c8106b2e5e"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex flex-column rounded-3 custom-form-box mt-2");
#nullable restore
#line 11 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
     if(!clients.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div class=\"d-flex justify-content-center\">\r\n            No hay clients que mostrar\r\n        </div>");
#nullable restore
#line 16 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
     foreach (var client in clients)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "my-2 py-3 border-3 card rounded-4 d-flex flex-row");
            __builder.OpenElement(5, "p");
            __builder.AddAttribute(6, "class", "m-0 ps-3 pb-0 text-center d-flex justify-content-center align-items-center");
#nullable restore
#line 21 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
__builder.AddContent(7, client.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, " \r\n            ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-danger ms-auto me-3");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
                                                                  (e => handleDelete(client.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Borrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-success me-3");
            __builder.AddAttribute(16, "data-bs-toggle", "modal");
            __builder.AddAttribute(17, "data-bs-target", "#modalContainer");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
                                                                                                                   (e => HandleShowModal(client.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Direcciones");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn btn-warning me-3");
            __builder.AddAttribute(23, "data-bs-toggle", "modal");
            __builder.AddAttribute(24, "data-bs-target", "#editContainer");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
                                                                                                                  (e => HandleShowModal(client.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "id", "modalContainer");
            __builder.AddAttribute(30, "class", "modal");
            __builder.AddAttribute(31, "tabindex", "-1");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "modal-dialog");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "modal-content");
            __builder.AddMarkupContent(36, "<div class=\"modal-header\"><h5 class=\"modal-title\">Direcciones</h5>\r\n        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"modal\" aria-label=\"Close\"></button></div>\r\n      ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal-body");
            __builder.OpenElement(39, "form");
            __builder.AddAttribute(40, "class", "d-flex flex-column");
            __builder.AddMarkupContent(41, "<label for>Calle</label>\r\n            ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "type", "text");
            __builder.AddAttribute(44, "class", "form-control mb-2");
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
                                addressToAdd.Street

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => addressToAdd.Street = __value, addressToAdd.Street));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            \r\n            ");
            __builder.AddMarkupContent(48, "<label for>Codigo Postal</label>\r\n            ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "text");
            __builder.AddAttribute(51, "class", "form-control mb-2");
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
                                addressToAdd.PostCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => addressToAdd.PostCode = __value, addressToAdd.PostCode));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            \r\n            ");
            __builder.AddMarkupContent(55, "<label for>Provincia</label>\r\n            ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "type", "text");
            __builder.AddAttribute(58, "class", "form-control mb-2");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
                                addressToAdd.Province

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => addressToAdd.Province = __value, addressToAdd.Province));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n            ");
            __builder.AddMarkupContent(62, "<label for>Referencia</label>\r\n            ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "text");
            __builder.AddAttribute(65, "class", "form-control mb-2");
            __builder.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
                                addressToAdd.Reference

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => addressToAdd.Reference = __value, addressToAdd.Reference));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "mt-4 d-flex flex-row justify-content-end");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "type", "button");
            __builder.AddAttribute(73, "class", "btn btn-success");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
                                                                        addAddressToContact

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(75, "\r\n                    Agregar\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n        <hr>");
#nullable restore
#line 58 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
         foreach (var address in modalClient.Addresses)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "my-2 py-2 px-3 d-flex card flex-row");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "d-flex flex-column");
            __builder.OpenElement(81, "p");
            __builder.AddAttribute(82, "class", "m-0 p-0");
#nullable restore
#line 62 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
__builder.AddContent(83, address.Street);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.OpenElement(85, "p");
            __builder.AddAttribute(86, "class", "m-0 p-0");
#nullable restore
#line 63 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
__builder.AddContent(87, address.PostCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                    ");
            __builder.OpenElement(89, "p");
            __builder.AddAttribute(90, "class", "m-0 p-0");
#nullable restore
#line 64 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
__builder.AddContent(91, address.Province);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.OpenElement(93, "p");
            __builder.AddAttribute(94, "class", "m-0 p-0");
#nullable restore
#line 65 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
__builder.AddContent(95, address.Reference);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "           \r\n\r\n                ");
            __builder.OpenElement(97, "button");
            __builder.AddAttribute(98, "class", "btn btn-danger ms-auto");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
                                                                 (e => handleDeleteClientAddress(address.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(100, "Borrar");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n\r\n");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "id", "editContainer");
            __builder.AddAttribute(104, "class", "modal");
            __builder.AddAttribute(105, "tabindex", "-1");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "modal-dialog");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "modal-content");
            __builder.AddMarkupContent(110, "<div class=\"modal-header\"><h5 class=\"modal-title\">Editar Direccion</h5>\r\n        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"modal\" aria-label=\"Close\"></button></div>\r\n      ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "modal-body");
            __builder.OpenElement(113, "form");
            __builder.AddAttribute(114, "class", "d-flex flex-column");
            __builder.AddMarkupContent(115, "<label for>Calle</label>\r\n            ");
            __builder.OpenElement(116, "input");
            __builder.AddAttribute(117, "type", "text");
            __builder.AddAttribute(118, "class", "form-control mb-2");
            __builder.AddAttribute(119, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 86 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
                                addressToEdit.Street

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(120, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => addressToEdit.Street = __value, addressToEdit.Street));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n            \r\n            ");
            __builder.AddMarkupContent(122, "<label for>Codigo Postal</label>\r\n            ");
            __builder.OpenElement(123, "input");
            __builder.AddAttribute(124, "type", "text");
            __builder.AddAttribute(125, "class", "form-control mb-2");
            __builder.AddAttribute(126, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
                                addressToEdit.PostCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(127, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => addressToEdit.PostCode = __value, addressToEdit.PostCode));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n            \r\n            ");
            __builder.AddMarkupContent(129, "<label for>Provincia</label>\r\n            ");
            __builder.OpenElement(130, "input");
            __builder.AddAttribute(131, "type", "text");
            __builder.AddAttribute(132, "class", "form-control mb-2");
            __builder.AddAttribute(133, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 92 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
                                addressToEdit.Province

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(134, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => addressToEdit.Province = __value, addressToEdit.Province));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n\r\n            ");
            __builder.AddMarkupContent(136, "<label for>Referencia</label>\r\n            ");
            __builder.OpenElement(137, "input");
            __builder.AddAttribute(138, "type", "text");
            __builder.AddAttribute(139, "class", "form-control mb-2");
            __builder.AddAttribute(140, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 95 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
                                addressToEdit.Reference

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(141, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => addressToEdit.Reference = __value, addressToEdit.Reference));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n\r\n            ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "mt-4 d-flex flex-row justify-content-end");
            __builder.OpenElement(145, "button");
            __builder.AddAttribute(146, "type", "button");
            __builder.AddAttribute(147, "class", "btn btn-success");
            __builder.AddAttribute(148, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
                                                                        updateSelectedAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(149, "\r\n                    Salvar\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n\r\n        <hr>");
#nullable restore
#line 105 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
         foreach (var address in modalClient.Addresses)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(151, "div");
            __builder.AddAttribute(152, "class", "my-2 py-2 px-3 d-flex card flex-row");
            __builder.OpenElement(153, "div");
            __builder.AddAttribute(154, "class", "d-flex flex-column");
            __builder.OpenElement(155, "p");
            __builder.AddAttribute(156, "class", "m-0 p-0");
#nullable restore
#line 109 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
__builder.AddContent(157, address.Street);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n                    ");
            __builder.OpenElement(159, "p");
            __builder.AddAttribute(160, "class", "m-0 p-0");
#nullable restore
#line 110 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
__builder.AddContent(161, address.PostCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n                    ");
            __builder.OpenElement(163, "p");
            __builder.AddAttribute(164, "class", "m-0 p-0");
#nullable restore
#line 111 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
__builder.AddContent(165, address.Province);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                    ");
            __builder.OpenElement(167, "p");
            __builder.AddAttribute(168, "class", "m-0 p-0");
#nullable restore
#line 112 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
__builder.AddContent(169, address.Reference);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "           \r\n\r\n                ");
            __builder.OpenElement(171, "button");
            __builder.AddAttribute(172, "class", "btn btn-warning ms-auto");
            __builder.AddAttribute(173, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 115 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
                                                                  (e => updateAddress(address.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(174, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 117 "C:\Users\cristian.gomez\Desktop\prueba\OrionTest\FrontOrion\Pages\List.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
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
