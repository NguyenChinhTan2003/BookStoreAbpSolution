using AutoMapper;
using BookStoreAbpSolution.Authors;
using BookStoreAbpSolution.Books;

namespace BookStoreAbpSolution;

public class BookStoreAbpSolutionApplicationAutoMapperProfile : Profile
{
    public BookStoreAbpSolutionApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<Author, AuthorDto>();
        CreateMap<Author, AuthorLookupDto>();


        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
