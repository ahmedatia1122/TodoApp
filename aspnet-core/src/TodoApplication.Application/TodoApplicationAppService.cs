using System;
using System.Collections.Generic;
using System.Text;
using TodoApplication.Localization;
using Volo.Abp.Application.Services;

namespace TodoApplication;

/* Inherit your application services from this class.
 */
public abstract class TodoApplicationAppService : ApplicationService
{
    protected TodoApplicationAppService()
    {
        LocalizationResource = typeof(TodoApplicationResource);
    }
}
