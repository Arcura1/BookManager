using BookDTO;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book;

namespace BookService
{
    public class BookServicea : InterBook
    {
        //burada databaseden bilgi cekebilirsiniz
        public Booka[] denen()
        {
            


            return null;
        }
        public BookDTOa GetAllBook(string email)
        {
            BookDTOa boo = new BookDTOa();

            Booka[] booka = new Booka[10];
            for (int i = 0; i < 10; i++)
            {
                //booka[i].suitable=true;
                booka[i] = new Booka
                {
                    name = "omer tatilde",
                    title = "adventure",
                    description = "omerin tatil anlarini anlatan kitap"
                };
            }

            /*
            Booka booka = new Booka();
            booka.suitable=true;
            booka.name = "omer tatilde";
            booka.title= "adventure";
            booka.description = "omerin tatil anlarini anlatan kitap";
            
            boo.oray[0] = booka;
            */
            return new BookDTOa() {
                Email = email,
                oray = booka
             };
        }
    }
}
