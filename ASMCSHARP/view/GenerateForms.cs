﻿using System;
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
            while (true)
            {
                Console.WriteLine("-------Wellcom to InternetBanking--------");
                Console.WriteLine("1. Login.");
                Console.WriteLine("2. Signup.");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Login();
                        break;
                    case 2:
                        Signup();
                        break;
                    default:
                        Console.WriteLine("Please enter 1 or 2 !!!");
                        break;
                }
            }
        }

        // Tạo form Login.
        public void Login()
        {
            // cho người dùng nhập username.

            Console.WriteLine("Please enter your username: ");
            String username = Console.ReadLine();

            // cho người dùng nhập password.

            Console.WriteLine("Please emter your password: ");
            String password = Console.ReadLine();

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

        }


        // Tạo form Signup .
        public void Signup()
        {

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
