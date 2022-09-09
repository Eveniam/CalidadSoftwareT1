using CalidadT1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadTEST
{
    public class LibreriaTest
    {
        [Test]
        public void caso01libro()
        {
            var libros = new List<Book>
            {
                new Book {Name = "IT", Price = 255},
            };
            var libro = new BookStore(libros);
            var result = libro.GetTotal();

            Assert.That(result, Is.EqualTo(255));
        }
        [Test]
        public void caso02libro()
        {
            var libros = new List<Book>
            {
                new Book {Name = "IT", Price = 255},
                new Book {Name = "IT", Price = 300},
            };
            var libro = new BookStore(libros);
            var result = libro.GetTotal();
            for (int i = 0; i < libros.Count; i++)
            {
                for(int a = 0; a < libros.Count; a++)
                {
                    if (libros[i].Name.Equals(libros[a].Name) && i != a)
                    {
                        libros[i].Price *= (10/100);
                    }
                }
            }
            
            Assert.That(result, Is.EqualTo(555));

        }
        [Test]
        public void caso03libro()
        {
            var libros = new List<Book>
            {
                new Book {Name = "IT", Price = 255},
                new Book {Name = "Harry", Price = 300},
            };
            var libro = new BookStore(libros);
            var result = libro.GetTotal();
            for (int i = 0; i < libros.Count; i++)
            {
                for (int a = 0; a < libros.Count; a++)
                {
                    if (libros[i].Name.Equals(libros[a].Name) && i != a)
                    {
                        libros[i].Price *= (10/100);
                    }
                }
            }
            Assert.That(result, Is.EqualTo(555));
        }
        [Test]
        public void caso04libro()
        {
            var libros = new List<Book>
            {
                new Book {Name = "IT", Price = 255},
                new Book {Name = "Harry", Price = 300},
                new Book {Name = "IT", Price = 300},
            };
            var libro = new BookStore(libros);
            var result = libro.GetTotal();
            for (int i = 0; i < libros.Count; i++)
            {
                for (int a = 0; a < libros.Count; a++)
                {
                    if (libros[i].Name.Equals(libros[a].Name) && i != a)
                    {
                        libros[i].Price *= (10/100);
                    }
                }
            }
            Assert.That(result, Is.EqualTo(855));
        }
        [Test]
        public void caso05libro()
        {
            var libros = new List<Book>
            {
                new Book {Name = "IT", Price = 255},
                new Book {Name = "IT", Price = 300},
                new Book {Name = "IT", Price = 400},
            };
            var libro = new BookStore(libros);
            var result = libro.GetTotal();
            for (int i = 0; i < libros.Count; i++)
            {
                for (int a = 0; a < libros.Count; a++)
                {
                    if (libros[i].Name.Equals(libros[a].Name) && i != a)
                    {
                        libros[i].Price *= (10/100);
                    }
                }
            }
            Assert.That(result, Is.EqualTo(955));
        }
        [Test]
        public void caso06libro()
        {
            var libros = new List<Book>
            {
                new Book {Name = "IT", Price = 255},
                new Book {Name = "Harry", Price = 300},
                new Book {Name = "IT", Price = 300},
            };
            var libro = new BookStore(libros);
            var result = libro.GetTotal();
            for (int i = 0; i < libros.Count; i++)
            {
                for (int a = 0; a < libros.Count; a++)
                {
                    if (libros[i].Name.Equals(libros[a].Name) && i != a)
                    {
                        libros[i].Price *= (10/100);
                    }
                }
            }
            Assert.That(result, Is.EqualTo(855));
        }
        [Test]
        public void caso07libro()
        {
            var libros = new List<Book>
            {
                new Book {Name = "IT", Price = 255},
                new Book {Name = "Harry", Price = 300},
                new Book {Name = "IT", Price = 300},
                new Book {Name = "Harry", Price = 300},
            };
            var libro = new BookStore(libros);
            var result = libro.GetTotal();
            for (int i = 0; i < libros.Count; i++)
            {
                for (int a = 0; a < libros.Count; a++)
                {
                    if (libros[i].Name.Equals(libros[a].Name) && i != a)
                    {
                        libros[i].Price *= (10/100);
                    }
                }
            }
            Assert.That(result, Is.EqualTo(1155));
        }
        [Test]
        public void caso08libro()
        {
            var libros = new List<Book>
            {
                new Book {Name = "IT", Price = 255},
                new Book {Name = "Harry", Price = 300},
                new Book {Name = "IT", Price = 300},
                new Book {Name = "IT", Price = 300},
            };
            var libro = new BookStore(libros);
            var result = libro.GetTotal();
            for (int i = 0; i < libros.Count; i++)
            {
                for (int a = 0; a < libros.Count; a++)
                {
                    if (libros[i].Name.Equals(libros[a].Name) && i != a)
                    {
                        libros[i].Price *= (10/100);
                    }
                }
            }
            Assert.That(result, Is.EqualTo(1155));
        }
        [Test]
        public void caso09libro()
        {
            var libros = new List<Book>
            {
                new Book {Name = "IT", Price = 255},
                new Book {Name = "Harry", Price = 300},
                new Book {Name = "IT", Price = 300},
                new Book {Name = "Harry", Price = 300},
                new Book {Name = "Harry", Price = 300},
            };
            var libro = new BookStore(libros);
            var result = libro.GetTotal();
            for (int i = 0; i < libros.Count; i++)
            {
                for (int a = 0; a < libros.Count; a++)
                {
                    if (libros[i].Name.Equals(libros[a].Name) && i != a)
                    {
                        libros[i].Price *= (10/100);
                    }
                }
            }
            Assert.That(result, Is.EqualTo(1455));
        }
        [Test]
        public void caso010libro()
        {
            var libros = new List<Book>
            {
                new Book {Name = "IT", Price = 255},
                new Book {Name = "Harry", Price = 300},
                new Book {Name = "IT", Price = 300},
            };
            var libro = new BookStore(libros);
            var result = libro.GetTotal();
            for (int i = 0; i < libros.Count; i++)
            {
                for (int a = 0; a < libros.Count; a++)
                {
                    if (libros[i].Name.Equals(libros[a].Name) && i != a)
                    {
                        libros[i].Price *= (10/100);
                    }
                }
            }
            Assert.That(result, Is.EqualTo(855));
        }
    }
}
