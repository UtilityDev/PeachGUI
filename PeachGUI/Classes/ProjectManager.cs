using System;
using System.IO;

namespace PeachGUI.Classes
{
    public static class ProjectManager
    {
        public static void CreateFile(string name, string path, string content)
        {
            File.WriteAllText(Path.Join(path, name), content);
        }

        public static string PullExtension(string language)
        {
            language = language.ToLower();
            switch (language)
            {
                case "c#": return "cs";
                case "c++": return "cpp";
                case "c": return "c";
                case "python": return "py";
                case "kotlin": return "kt";
                case "java": return "java";
                case "rust": return "rs";
                case "javascript": return "js";
                case "css": return "css";
                case "html": return "html";
                case "f#": return "fs";
                case "haskell": return "hs";
                case "ruby": return "rb";
                case "lua": return "lua";
                default: return "";
            }
        }
    }
}
