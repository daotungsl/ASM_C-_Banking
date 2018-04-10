using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASMCSHARP
{
    class Controller
    {
        // viết các câu lệnh xử lí phần đăng nhập
        public bool HandleLogin(string username, string password)
        {
            // gọi hàm SelectByUsername(username).
            // nếu hàm trả về 1 user: 
            //  - so sánh password nhập vào và pass lưu trong database: == thì return true còn != return false (có muối);
            // nếu hàm trả về null thì return false(đăng nhập không thành công); 

            return true;
        }

        // viết các câu lệnh xử lí phần đăng kí
        public void HandleSignup()
        {

        }

        // viết các câu lệnh xử lí phần thông tin người dùng
        public void HandleInforUser()
        {

        }

        // viết các câu lệnh xử lí phần truy vấn số dư
        public void HandleQueryBalance()
        {

        }

        // viết các câu lệnh xử lí phần rút tiền
        public void HandleWithdrawal()
        {

        }

        // viết các câu lệnh xử lí phần chuyển khoản
        public void HandleTransfers()
        {

        }

        // viết các câu lệnh xử lí phần xem lịch sử giao dịch
        public void HandleTransactionHistory()
        {

        }


        // các hàm validate các trường người dùng nhập vào để signup.
        public string ValidateUsername(string txt)
        {
            Regex regex = new Regex("[a-zA-Z0-9]+");
            if (txt == null)
            {
                return MapEntity.mapError["username"].ErrorEmpty;
            }
            else if (regex.IsMatch(txt))
            {
                if (txt.Length < 7)
                {
                    return MapEntity.mapError["username"].ErrorLength;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return MapEntity.mapError["username"].ErrorCharacter;
            }
        }

        public string ValidatePassword(string txt)
        {
            Regex regex = new Regex("[a-zA-Z0-9]+");
            if (txt == null)
            {
                return MapEntity.mapError["password"].ErrorEmpty;
            }
            else if (regex.IsMatch(txt))
            {
                if (txt.Length < 7)
                {
                    return MapEntity.mapError["password"].ErrorLength;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return MapEntity.mapError["password"].ErrorCharacter;
            }
        }

        public string ValidateFullname(string txt)
        {
            Regex regex = new Regex("[a-zA-z\\s]+");
            Regex regex2 = new Regex("[\\s]+");
            if(txt == null || regex2.IsMatch(txt))
            {
                return MapEntity.mapError["fullName"].ErrorEmpty;
            }else if (regex.IsMatch(txt))
            {
                if (txt.Length < 10)
                {
                    return MapEntity.mapError["fullName"].ErrorLength;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return MapEntity.mapError["fullName"].ErrorCharacter;
            }
        }

        public string ValidateBirthday(string txt)
        {
            // Chỗ này chưa làm ngâm ra.
            return null;
            //Regex regex = new Regex("[0-9\\-]");
            //if (txt == null)
            //{
              //  return MapEntity.mapError["birthday"].ErrorEmpty;
            //}
            //else
            //{
              //  return MapEntity.mapError["birthday"].ErrorCharacter;
            //}
        }

        public string ValidatePhone(string txt)
        {
            Regex regex = new Regex("[0-9]");
            if(txt == null)
            {
                return MapEntity.mapError["phone"].ErrorEmpty;
            }else if (regex.IsMatch(txt))
            {
                if (txt.Length < 10)
                {
                    return MapEntity.mapError["phone"].ErrorLength;
                }
                else
                {
                    return null;
                }
            }
            else {
                return MapEntity.mapError["phone"].ErrorCharacter;
            }
        }

        public string ValidateUserId(string txt)
        {
            Regex regex = new Regex("[0-9]");
            if (txt == null)
            {
                return MapEntity.mapError["userId"].ErrorEmpty;
            }
            else if (regex.IsMatch(txt))
            {
                if (txt.Length < 10)
                {
                    return MapEntity.mapError["userId"].ErrorLength;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return MapEntity.mapError["userId"].ErrorCharacter;
            }
        }
    }
}
