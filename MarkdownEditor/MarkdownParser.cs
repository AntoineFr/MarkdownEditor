using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MarkdownEditor
{
    class MarkdownParser
    {
        public static string Parse(string text)
        {
            RegexOptions options = RegexOptions.Multiline;

            text = Regex.Replace(text, @"^(#{1,6}) (.*)$", parseHeader, options);
            text = Regex.Replace(text, @"^(-|\*|\+) (.+)$", "<ul><li>$2</li></ul>", options);
            text = Regex.Replace(text, @"(\*\*|__)(.+?)(?<!\s)\1", "<b>$2</b>", options);
            text = Regex.Replace(text, @"(\*|_)(.+?)(?<!\s)\1", "<i>$2</i>", options);
            text = Regex.Replace(text, @"`(.+?)`", "<code>$1</code>", options);
            text = Regex.Replace(text, @"^[0-9]+\. (.+)$", "<ol><li>$1</li></ol>", options);
            text = Regex.Replace(text, @"^>(.+)$", "<blockquote>$1</blockquote>", options);
            text = Regex.Replace(text, @"!\[(.+)\]\((.+)\)", "<img src=\"$2\" alt=\"$1\">", options);
            text = Regex.Replace(text, @"\[(.+)\]\((.+)\)", "<a href=\"$2\" target=\"_blank\">$1</a>", options);

            text = Regex.Replace(text, @"  ", "<br>", options);
            text = Regex.Replace(text, @"(\r|\n){2}", "</p><p>", options);

            text = Regex.Replace(text, @"</ul>\s*<ul>", "", options);
            text = Regex.Replace(text, @"</ol>\s*<ol>", "", options);
            text = Regex.Replace(text, @"</blockquote>\s*<blockquote>", "", options);

            return "<p>" + text + "</p>";
        }

        private static string parseHeader(Match match)
        {
            int level = match.Groups[1].ToString().Length;
            string content = match.Groups[2].ToString();

            return "<h" + level + ">" + content + "</h" + level + ">";
        }
    }
}
