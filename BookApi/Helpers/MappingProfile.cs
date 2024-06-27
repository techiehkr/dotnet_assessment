using AutoMapper;
using BookApi.Dtos;
using BookApi.Models;


namespace BookApi.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>().ReverseMap();
        }
    }
}
