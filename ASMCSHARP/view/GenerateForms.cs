using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMCSHARP
{
    class GenerateForms
    {
        Controller controller = new Controller();
        // Tạo form Internet Banking.
        public void InternetBanking()
        {

        }

        // Tạo form Login.
        public void Login()
        {
            // cho người dùng nhập username.
            // cho người dùng nhập password.
            // gọi hàm HandleLogin(username, password); 

            if (controller.HandleLogin(username, password))
            {
                Console.WriteLine("Login Success.");
                Menu();
            }
            else
            {
                Console.WriteLine("Login error. Please check again username or password. !!!");
            }

            // nếu hàm trả về true .....(các xử lí tiếp theo, như gọi đến hàm Menu());
            // nếu hàm trả về false - thông báo đăng nhập khoog thành công ;
            Console.WriteLine("========= Login Form ========");

        }


        // Tạo form Signup .
        public void Signup()
        {
            Console.WriteLine("========= Sign Up Form ========");
            while (true)
            {
                Console.WriteLine("Please Enter Username: ");
                string username = Console.ReadLine();
                if (controller.ValidateUsername(username) == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(controller.ValidateUsername(username));
                }
            }

            while (true)
            {
                Console.WriteLine("Please Enter Password: ");
                string password = Console.ReadLine();
                if (controller.ValidatePassword(password) == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(controller.ValidatePassword(password));
                }
            }

            while (true)
            {
                Console.WriteLine("Please Enter Fullname: ");
                string fullName = Console.ReadLine();
                if (controller.ValidateFullname(fullName) == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(controller.ValidateFullname(fullName));
                }
            }

            while (true)
            {
                Console.WriteLine("Please Enter BirthDay(01-01-1990): ");
                string DoB = Console.ReadLine();
                if (controller.ValidateBirthday(DoB) == null)
                {
                    DateTime db = Convert.ToDateTime(DoB);
                    break;
                }
                else
                {
                    Console.WriteLine(controller.ValidateBirthday(DoB));
                }
            }

            while (true)
            {
                Console.WriteLine("Please Enter Phone Number: ");
                string phoneNumber = Console.ReadLine();
                if(controller.ValidatePhone(phoneNumber) == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(controller.ValidatePhone(phoneNumber));
                }
            }

            while (true)
            {
                Console.WriteLine("Please Enter Identity Card: ");
                string userId = Console.ReadLine();
                if (controller.ValidateUserId(userId) == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(controller.ValidateUserId(userId));
                }
            }

            controller.HandleSignup();
        }

        // Tạo form Menu chính.
        public void Menu()
        {
            Console.WriteLine("--------Generate Menu--------");
            //1. thông tin  người dùng
            Console.WriteLine("1. Info");
            //2. truy vấn số dư
            Console.WriteLine("2. Balance inquiry");
            //3. rút tiền
            Console.WriteLine("3. Withdrawal");
            //4. chuyển khoản
            Console.WriteLine("4. Transfer");
            //5. lịch sử giao dịch
            Console.WriteLine("5. Transaction history");
            int choiceMenu = int.Parse(Console.ReadLine());
            switch (choiceMenu)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Please enter to 1 from 5.");
                    break;
            }
        }

        // Tạo form thông tin người dùng.
        public void InfoUser()
        {

        }

        // Tạo form truy vấn số dư.
        public void QueryBalance()
        {

        }

        // Tạo form rút tiền.
        public void Withdrawal()
        {

        }

        // Tạo form chuyển khoản.
        public void Transfer()
        {

        }

        // Tạo form tra cứu lịch sử giao dịch
        public void TransactionHistory()
        {

        }

    }
}
