#pragma checksum "C:\BUCKET\DOT_NET\Learn_9\Logging\BrainstormSessions\Views\Session\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "26ad7d4bc49b017a485f56ffd790a03fbb9f73368110fb9093c659436c25afbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Session_Index), @"mvc.1.0.view", @"/Views/Session/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"26ad7d4bc49b017a485f56ffd790a03fbb9f73368110fb9093c659436c25afbc", @"/Views/Session/Index.cshtml")]
    #nullable restore
    internal sealed class Views_Session_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\BUCKET\DOT_NET\Learn_9\Logging\BrainstormSessions\Views\Session\Index.cshtml"
       BrainstormSessions.ViewModels.StormSessionViewModel

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\BUCKET\DOT_NET\Learn_9\Logging\BrainstormSessions\Views\Session\Index.cshtml"
  
    ViewBag.Title = "Brainstormer Session : " + Model.Name;
    Layout = "_Layout";

#line default
#line hidden
#nullable disable

            WriteLiteral("<h2>Brainstorm Session: ");
            Write(
#nullable restore
#line 7 "C:\BUCKET\DOT_NET\Learn_9\Logging\BrainstormSessions\Views\Session\Index.cshtml"
                         Model.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h2>\r\n<div class=\"small\">");
            Write(
#nullable restore
#line 8 "C:\BUCKET\DOT_NET\Learn_9\Logging\BrainstormSessions\Views\Session\Index.cshtml"
                    Model.DateCreated

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</div>

<div class=""row"">
    <div class=""col-md-9"">
        <h3>Idea Count: <span data-bind=""text:ideas().length""></span></h3>
        <div data-bind='foreach: ideas'>
            <div class=""panel panel-default"">
                <div class=""panel-heading"" data-bind=""text:name"">
                </div>
                <div class=""panel-body"" data-bind=""text:description"">
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-3"">
        <div class=""panel panel-primary"">
            <div class=""panel-heading"">
                Add New Idea
            </div>
            <div class=""panel-body"">
                <div data-bind=""with: ideaForEditing"">
                    <fieldset class=""form-group"">
                        <label for=""ideaName"">Idea Name</label>
                        <input type=""text"" class=""form-control"" id=""ideaName"" name=""ideaName"" placeholder=""New Idea"" data-bind=""value:name"">
                    </fieldset>
                    <");
            WriteLiteral(@"fieldset class=""form-group"">
                        <label for=""ideaDescription"">Description</label>
                        <textarea class=""form-control"" id=""ideaDescription"" name=""ideaDescription"" data-bind=""value:description""></textarea>
                    </fieldset>
                    <input type=""submit"" value=""Save"" id=""SaveButton"" name=""SaveButton"" class=""btn btn-primary"" data-bind=""click: $root.addIdea"">
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-12"">
        <a href=""/"">Return home</a>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        var Idea = function(id, name, description) {
            this.id = ko.observable(id);
            this.name = ko.observable(name);
            this.description = ko.observable(description);
            this.sessionId = ");
                Write(
#nullable restore
#line 54 "C:\BUCKET\DOT_NET\Learn_9\Logging\BrainstormSessions\Views\Session\Index.cshtml"
                              Model.Id

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@";
        };
        var ViewModel = function() {
            var self = this;
            self.ideas = ko.observableArray([]);
            self.ideaForEditing = ko.observable(new Idea());
            self.addIdea = function(newIdea) {
                if(newIdea.name() != undefined && newIdea.description() != undefined)
                {
                    console.log(""add idea: "" + newIdea.name() + "" desc: "" + newIdea.description());
                    self.ideas.push(newIdea);
                    $.ajax({
                        url: '/api/ideas/create',
                        type: 'POST',
                        data: ko.toJSON(newIdea),
                        contentType: 'application/json'
                    });
                    self.ideaForEditing(new Idea());
                }
            }
        };
        viewModel = new ViewModel();
        ko.applyBindings(viewModel);
        $(function() {
            $.ajax({
                url: '/api/ideas/forsession/");
                Write(
#nullable restore
#line 79 "C:\BUCKET\DOT_NET\Learn_9\Logging\BrainstormSessions\Views\Session\Index.cshtml"
                                             Model.Id

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"',
                dataType: 'json',
                success: function(data) {
                    if (data instanceof Array) {
                        viewModel.ideas(data);
                    }
                }
            });
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BrainstormSessions.ViewModels.StormSessionViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
