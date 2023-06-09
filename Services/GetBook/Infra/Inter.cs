using BookDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public interface InterBook
    {
        public BookDTOa GetAllBook(string email);
    }
}
