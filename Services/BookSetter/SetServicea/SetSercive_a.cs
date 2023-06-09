using Book;
using InfrastractureBook;
using SetBookDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetServicea
{
    public class SetSercive_a : Interface1
    {
        public Booka founder(string name)
        {

            //buraya sql sorgulari yazilabilir 
            if (name == "omer tatilde") {

                Booka omer= new Booka
                {
                    name = "omer tatilde",
                    title = "adventure",
                    description = "omerin tatil anlarini anlatan kitap"
                };
                return omer;
            }else
            {
                return null;
            }
            
        }
        
        public SetBookDTOa SetBooka(string name)
        {
            return new SetBookDTOa()
            {
                name= name,
                kitap=founder(name)

            };
        }
    }
}
