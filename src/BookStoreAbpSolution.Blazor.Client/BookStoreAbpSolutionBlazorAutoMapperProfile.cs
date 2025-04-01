using AutoMapper;
using BookStoreAbpSolution.Books;

namespace BookStoreAbpSolution.Blazor.Client;

public class BookStoreAbpSolutionBlazorAutoMapperProfile : Profile
{
    public BookStoreAbpSolutionBlazorAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your AutoMapper configuration here for the Blazor project.
    }
}