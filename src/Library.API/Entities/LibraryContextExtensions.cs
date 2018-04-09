using System;
using System.Collections.Generic;

namespace Library.API.Entities
{
    public static class LibraryContextExtensions
    {
        public static void EnsureSeedDataForContext(this LibraryContext context)
        {
            context.Authors.RemoveRange(context.Authors);
            context.SaveChanges();

            var authors = new List<Author>()
            {
                new Author()
                {
                     Id = 1,
                     FirstName = "Stephen",
                     LastName = "King",
                     Genre = "Horror",
                     DateOfBirth = new DateTimeOffset(new DateTime(1947, 9, 21)),
                     Books = new List<Book>()
                     {
                         new Book()
                         {
                             Id = 1,
                             Title = "The Shining",
                             Description = "The Shining is a horror novel by American author Stephen King. Published in 1977, it is King's third published novel and first hardback bestseller: the success of the book firmly established King as a preeminent author in the horror genre. "
                         },
                         new Book()
                         {
                             Id = 2,
                             Title = "Misery",
                             Description = "Misery is a 1987 psychological horror novel by Stephen King. This novel was nominated for the World Fantasy Award for Best Novel in 1988, and was later made into a Hollywood film and an off-Broadway play of the same name."
                         },
                         new Book()
                         {
                             Id = 3,
                             Title = "It",
                             Description = "It is a 1986 horror novel by American author Stephen King. The story follows the exploits of seven children as they are terrorized by the eponymous being, which exploits the fears and phobias of its victims in order to disguise itself while hunting its prey. 'It' primarily appears in the form of a clown in order to attract its preferred prey of young children."
                         },
                         new Book()
                         {
                             Id = 4,
                             Title = "The Stand",
                             Description = "The Stand is a post-apocalyptic horror/fantasy novel by American author Stephen King. It expands upon the scenario of his earlier short story 'Night Surf' and outlines the total breakdown of society after the accidental release of a strain of influenza that had been modified for biological warfare causes an apocalyptic pandemic which kills off the majority of the world's human population."
                         }
                     }
                },
                new Author()
                {
                     Id = 2,
                     FirstName = "George",
                     LastName = "RR Martin",
                     Genre = "Fantasy",
                     DateOfBirth = new DateTimeOffset(new DateTime(1948, 9, 20)),
                     Books = new List<Book>()
                     {
                         new Book()
                         {
                             Id = 5,
                             Title = "A Game of Thrones",
                             Description = "A Game of Thrones is the first novel in A Song of Ice and Fire, a series of fantasy novels by American author George R. R. Martin. It was first published on August 1, 1996."
                         },
                         new Book()
                         {
                             Id = 6,
                             Title = "The Winds of Winter",
                             Description = "Forthcoming 6th novel in A Song of Ice and Fire."
                         },
                         new Book()
                         {
                             Id = 7,
                             Title = "A Dance with Dragons",
                             Description = "A Dance with Dragons is the fifth of seven planned novels in the epic fantasy series A Song of Ice and Fire by American author George R. R. Martin."
                         }
                     }
                },
                new Author()
                {
                     Id = 3,
                     FirstName = "Neil",
                     LastName = "Gaiman",
                     Genre = "Fantasy",
                     DateOfBirth = new DateTimeOffset(new DateTime(1960, 11, 10)),
                     Books = new List<Book>()
                     {
                         new Book()
                         {
                             Id = 8,
                             Title = "American Gods",
                             Description = "American Gods is a Hugo and Nebula Award-winning novel by English author Neil Gaiman. The novel is a blend of Americana, fantasy, and various strands of ancient and modern mythology, all centering on the mysterious and taciturn Shadow."
                         }
                     }
                }
            };

            context.Authors.AddRange(authors);
            context.SaveChanges();
        }
    }
}
