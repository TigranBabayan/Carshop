#pragma checksum "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa5acb2b467277ee0e3769d1f73e70d9379b6987"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetCar), @"mvc.1.0.view", @"/Views/Home/GetCar.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\_ViewImports.cshtml"
using CarShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\_ViewImports.cshtml"
using CarShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\_ViewImports.cshtml"
using CarShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa5acb2b467277ee0e3769d1f73e70d9379b6987", @"/Views/Home/GetCar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e6d11823b65e4894a984f85769438e856f7ea83", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetCar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarShop.Models.CarModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-type", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("lightbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-gallery", new global::Microsoft.AspNetCore.Html.HtmlString("example-gallery"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
  
    List<string> SplitImageName(string ProfilePicture)
    {
        List<string> imageName = new List<string>();


        string[] splitedImageName = ProfilePicture.Split('<');
        foreach (var imgName in splitedImageName)
        {
            imageName.Add(imgName);
        }

        return imageName;

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"



    <div class=""container"">
        <div class=""carousel-container col-lg-6 position-relative row float-left"">

            <!-- Sorry! Lightbox doesn't work - yet. -->

            <div id=""myCarousel"" class=""carousel slide "" data-ride=""carousel"">
                <div class=""carousel-inner"">

");
#nullable restore
#line 79 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                      var iterator = 0;

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                         for (int i = 0; i < SplitImageName(Model.CarModelImage).Count - 1; i++)
                        {
                            iterator = i;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                       var isFirst = true;

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                         foreach (var carImg in SplitImageName(Model.CarModelImage))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 2942, "\"", 2991, 2);
            WriteAttributeValue("", 2950, "carousel-item", 2950, 13, true);
#nullable restore
#line 91 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
WriteAttributeValue("  ", 2963, isFirst ? "active" : "", 2965, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\" data-slide-number=\"");
#nullable restore
#line 91 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                                                                                                                    Write(iterator);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 92 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                                  isFirst = false;

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                                 if (carImg.Length > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fa5acb2b467277ee0e3769d1f73e70d9379b69878462", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3235, "~/images/", 3235, 9, true);
#nullable restore
#line 95 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
AddHtmlAttributeValue("", 3244, carImg, 3244, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 96 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 99 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <a class=""carousel-control-prev"" href=""#carousel-thumbs"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carousel-thumbs"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </div>

            <!-- Carousel Navigation -->
            <div id=""carousel-thumbs my-carousel-thumbs"" class=""carousel slide myCarousel"" data-ride=""carousel"">
                <div class=""carousel-inner"">
                    <div class=""carousel-item active"">
                        <div class=""row mx-0"">

");
#nullable restore
#line 119 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                              
                                var active = ""; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                             for (int i = 0; i < SplitImageName(Model.CarModelImage).Count - 1; i++)
                            {
                                iterator = i;

                                if (i == 0)
                                {
                                    active = "active";
                                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("id", " id=\"", 4885, "\"", 4917, 2);
            WriteAttributeValue("", 4890, "carousel-selector-", 4890, 18, true);
#nullable restore
#line 130 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
WriteAttributeValue("", 4908, iterator, 4908, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"thumb col-4 col-sm-2 px-1 py-2 \" data-target=\"#myCarousel\" data-slide-to=\"");
#nullable restore
#line 130 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                                                                                                                                                  Write(iterator);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fa5acb2b467277ee0e3769d1f73e70d9379b698713466", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5061, "~/images/", 5061, 9, true);
#nullable restore
#line 132 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
AddHtmlAttributeValue("", 5070, SplitImageName(Model.CarModelImage)[@i], 5070, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 134 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>

                </div>

            </div>

        </div> <!-- /row -->


        <div class=""col-lg-6 float-right"">
            <div>
                <h4>CarModel</h4>
                <hr />
                <dl class=""row"">
                    <dt class=""col-sm-4"">
");
            WriteLiteral("                        Մակնիշ\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 156 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.CarMaker.CarName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 159 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.ModelName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 162 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.ModelName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 165 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Modefication));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 168 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.Modefication));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 171 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 174 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 177 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Bodystyle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 180 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.Bodystyle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 183 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 186 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 189 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.CarModelColor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 192 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.CarModelColor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 195 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Gearbox));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 198 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.Gearbox));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 201 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Fueltype));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 204 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.Fueltype));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 207 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Handdrive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 210 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.Handdrive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 213 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Customcleared));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 216 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.Customcleared));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 219 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 222 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
            WriteLiteral("                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 231 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.TopAnnouncements));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n");
#nullable restore
#line 234 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                           if (Model.TopAnnouncements == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Այո</span>\r\n");
#nullable restore
#line 237 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Ոչ</span>\r\n");
#nullable restore
#line 241 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 245 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.EngineValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 248 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.EngineValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 251 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 254 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 257 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.HoursePower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 260 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.HoursePower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 263 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.CarModelExteriorColor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 266 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.CarModelExteriorColor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 269 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.DoorCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 272 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.DoorCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 275 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Drivetrain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 278 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.Drivetrain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 281 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Condition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 284 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.Condition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 287 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Vin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 290 "C:\Users\ACER\Desktop\ASP.NET CORE\CarShop\CarShop\Views\Home\GetCar.cshtml"
                   Write(Html.DisplayFor(model => model.Vin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarShop.Models.CarModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
