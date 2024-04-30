using TodoApplication.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TodoApplication.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TodoApplicationController : AbpControllerBase
{
    protected TodoApplicationController()
    {
        LocalizationResource = typeof(TodoApplicationResource);
    }
}
