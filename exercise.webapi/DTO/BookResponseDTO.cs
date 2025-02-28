﻿using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public AuthorDTO Author { get; set; }

        public BookResponseDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Author = new AuthorDTO(book.Author);
        }

        public static List<BookResponseDTO> FromRepository(IEnumerable<Book> books)
        {
            var results = new List<BookResponseDTO>();
            foreach (var book in books)
            {
                results.Add(new BookResponseDTO(book));
            }
            return results;
        }
    }
}
