using Infrastucture;
using LoginDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginService
{
    public class LoginServicea: Inter
    {
        public LoginDTOa Geta(string email,string Pass)
        {


            // burda database ile kontroller saglanabililr 
            //ben sadece ornek olsun diye boyle kullanicilar koydum

            if (Pass == "123456")
            {

                switch (email)
                {
                    case "oray_503@hotmail.com":
                        return new LoginDTOa()
                        {
                            Id = 1,
                            Email = email,
                            Pass = Pass
                        };
                        break;
                    case "yonetici@gmail.com":
                        return new LoginDTOa()
                        {
                            Id = 2,
                            Email = email,
                            Pass = Pass
                        };
                        break;
                    case "kutuphaneci@gmail.com":
                        return new LoginDTOa()
                        {
                            Id = 3,
                            Email = email,
                            Pass = Pass
                        };
                        break;
                    case "admin@gmail.com":
                        return new LoginDTOa()
                        {
                            Id = 4,
                            Email = email,
                            Pass = Pass
                        };
                        break;
                    default:
                        return new LoginDTOa()
                        {
                            Id = 0,
                            Email = email,
                            Pass = Pass
                        };
                        break;
                }

            }
            else
            {
                return new LoginDTOa()
                {
                    Id = 9,
                    Email = email,
                    Pass = Pass
                };
            }

                /*
            return new LoginDTOa()
            {
                


                Email= email,
                Pass= Pass
            };*/

        }
    }
}
