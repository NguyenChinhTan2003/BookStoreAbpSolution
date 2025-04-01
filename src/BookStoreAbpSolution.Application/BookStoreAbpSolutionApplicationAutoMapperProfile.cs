using AutoMapper;
using BookStoreAbpSolution.Books;

namespace BookStoreAbpSolution;

public class BookStoreAbpSolutionApplicationAutoMapperProfile : Profile
{
    public BookStoreAbpSolutionApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
