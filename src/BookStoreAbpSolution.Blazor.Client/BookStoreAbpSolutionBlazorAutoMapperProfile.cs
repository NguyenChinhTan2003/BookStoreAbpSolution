using AutoMapper;
using BookStoreAbpSolution.Authors;
using BookStoreAbpSolution.Books;

namespace BookStoreAbpSolution.Blazor.Client;

public class BookStoreAbpSolutionBlazorAutoMapperProfile : Profile
{
    public BookStoreAbpSolutionBlazorAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        CreateMap<AuthorDto, UpdateAuthorDto>();

        //Define your AutoMapper configuration here for the Blazor project.
    }
}