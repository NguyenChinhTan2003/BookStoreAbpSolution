using BookStoreAbpSolution.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace BookStoreAbpSolution.Permissions;

public class BookStoreAbpSolutionPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookStoreAbpSolutionPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(BookStoreAbpSolutionPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(BookStoreAbpSolutionPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(BookStoreAbpSolutionPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(BookStoreAbpSolutionPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookStoreAbpSolutionPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreAbpSolutionResource>(name);
    }
}
