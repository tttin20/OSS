using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Vib.Oss;

[Dependency(ReplaceServices = true)]
public class OssBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Oss";
}
