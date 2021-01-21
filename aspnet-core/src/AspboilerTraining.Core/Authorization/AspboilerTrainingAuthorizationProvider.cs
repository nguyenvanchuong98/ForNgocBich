﻿using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace AspboilerTraining.Authorization
{
    public class AspboilerTrainingAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Quanhuyen, L("Quanhuyen"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_TinhThanh, L("Tinhthanh"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AspboilerTrainingConsts.LocalizationSourceName);
        }
    }
}
