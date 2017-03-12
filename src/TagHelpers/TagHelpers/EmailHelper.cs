using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.TagHelpers
{
    [HtmlTargetElement("phone")]
    public class EmailHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.Add("href", $"mailto:{output.GetChildContentAsync().Result.GetContent()}");
            output.Content.SetContent(output.GetChildContentAsync().Result.GetContent());
        }
    }
}
