using System;
using BookStoreAbpSolution.Permissions;
using BookStoreAbpSolution.Books;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = BookStoreAbpSolutionPermissions.Books.Default;
        GetListPolicyName = BookStoreAbpSolutionPermissions.Books.Default;
        CreatePolicyName = BookStoreAbpSolutionPermissions.Books.Create;
        UpdatePolicyName = BookStoreAbpSolutionPermissions.Books.Edit;
        DeletePolicyName = BookStoreAbpSolutionPermissions.Books.Delete;
    }
}
