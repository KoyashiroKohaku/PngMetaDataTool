using System.Globalization;
using System.Reflection;
using System.Resources;

namespace KoyashiroKohaku.PngChunkUtil.Helpers
{
    public static class ResourceHelper
    {
        private const string BaseName = "KoyashiroKohaku.PngChunkUtil.Properties.Resources";
        private static readonly ResourceManager _resourceManager = new ResourceManager(BaseName, Assembly.GetExecutingAssembly());

        public static string GetString(string name)
        {
            return _resourceManager.GetString(name, CultureInfo.CurrentCulture);
        }
    }
}
