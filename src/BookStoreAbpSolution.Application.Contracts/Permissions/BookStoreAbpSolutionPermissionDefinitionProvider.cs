using BookStoreAbpSolution.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace BookStoreAbpSolution.Permissions;

public class BookStoreAbpSolutionPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var bookStoreGroup = context.AddGroup(BookStoreAbpSolutionPermissions.GroupName, L("Permission:BookStore"));

        var booksPermission = bookStoreGroup.AddPermission(BookStoreAbpSolutionPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(BookStoreAbpSolutionPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(BookStoreAbpSolutionPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(BookStoreAbpSolutionPermissions.Books.Delete, L("Permission:Books.Delete"));

        var authorsPermission = bookStoreGroup.AddPermission(BookStoreAbpSolutionPermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(BookStoreAbpSolutionPermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(BookStoreAbpSolutionPermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(BookStoreAbpSolutionPermissions.Authors.Delete, L("Permission:Authors.Delete"));


        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookStoreAbpSolutionPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreAbpSolutionResource>(name);
    }
}
