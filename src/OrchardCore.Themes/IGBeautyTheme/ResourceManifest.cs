using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.IGBeautyTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineStyle("IGBeautyTheme-bootstrap-oc")
                .SetUrl("~/IGBeautyTheme/css/bootstrap-oc.min.css", "~/IGBeautyTheme/css/bootstrap-oc.css")
                .SetVersion("1.0.0");

            manifest
               .DefineStyle("IGBeautyTheme")
               .SetUrl("~/IGBeautyTheme/css/igbeauty.css", "~/IGBeautyTheme/css/igbeauty.min.css")
               .SetVersion("1.0.0");

            manifest
               .DefineScript("IGBeautyTheme")
               .SetUrl("~/IGBeautyTheme/js/igbeauty.js", "~/IGBeautyTheme/js/igbeauty.min.js")
               .SetVersion("1.0.0");

        }
    }
}
