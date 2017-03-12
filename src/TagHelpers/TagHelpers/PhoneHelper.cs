using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.TagHelpers
{
    [HtmlTargetElement("phone")]
    public class PhoneHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string formatedPhone = String.Format("{0:(##) #####-####}", double.Parse(output.GetChildContentAsync().Result.GetContent()));
            output.TagName = "a";
            output.Attributes.Add("href", $"tel:{output.GetChildContentAsync().Result.GetContent()}");
            output.Content.SetContent(formatedPhone);
        }
    }
}
