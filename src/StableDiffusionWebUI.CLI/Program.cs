using StableDiffusionWebUI.Client;
using StableDiffusionWebUI.Client.Models;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;

namespace StableDiffusionWebUI
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            
            var rootCommand = new RootCommand();
            rootCommand.AddGlobalOption(new Option<Uri>(new[] { "-u", "--weburl" }, "WebUI URL"));
            {
                var img2img = new Command("img2img");
                img2img.Add(new Option<FileInfo>(new[] { "-i", "--image" }, "Input image"));
                img2img.Handler = CommandHandler.Create<Img2ImgOptions>(Img2Img);
                rootCommand.AddCommand(img2img);
            }
            {
                var text2img = new Command("text2img");
                text2img.Add(new Option<string>(new[] { "-p", "--prompt" }, "Prompt"));
                text2img.Handler = CommandHandler.Create<Text2ImgOptions>(Text2Img);
                rootCommand.AddCommand(text2img);
            }
            await rootCommand.InvokeAsync(args);
        }

        private static void Text2Img(Text2ImgOptions context)
        {
        }

        private static void Img2Img(Img2ImgOptions obj)
        {
            //var client = new Img2ImgapiClient(null, null, obj.WebURL);
        }
    }
}
