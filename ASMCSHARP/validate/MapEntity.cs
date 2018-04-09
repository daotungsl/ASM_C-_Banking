using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMCSHARP
{
    class MapEntity
    {
        public static Dictionary<string, ErrorEntity> mapError = new Dictionary<string, ErrorEntity>();
        static MapEntity(){
            ErrorEntity username = new ErrorEntity("Username can not empty", "Username not enough length (7 characters )", "Username incorrect character (a-z, A-Z, 0-9)");
            ErrorEntity password = new ErrorEntity("Password can not empty", "Password not enough length ( 7 characters )", "Password incorrect character (a-z, A-Z, 0-9)");
            ErrorEntity fullName = new ErrorEntity("Full Name can not empty", "Full Name not enough length ( 10 characters )", "Full Name incorrect character (a-z, A-Z)");
            ErrorEntity birthday = new ErrorEntity("Birthday can not empty", " ", "Birthday incorrect character (1-1-2018)");
            ErrorEntity phone = new ErrorEntity("Phone can not empty", "Phone not enough length ( 10 characters)", "Phone incorect character (0-9)");
            ErrorEntity userId = new ErrorEntity("Identity Card can not empty", "Identity Card ( 11 characters)", "Identity Card (0-9)");

            mapError.Add("username", username);
            mapError.Add("password", password);
            mapError.Add("fullName", fullName);
            mapError.Add("birthday", birthday);
            mapError.Add("phone", phone);
            mapError.Add("userId", userId);
        }
       
    }
}
