using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TodoApplication;

[Dependency(ReplaceServices = true)]
public class TodoApplicationBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TodoApplication";
}
