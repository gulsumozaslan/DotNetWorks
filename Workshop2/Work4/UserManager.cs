using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work4
{
    public class UserManager
    {
        List<User> users;

        public UserManager(User person)
        {
            users = new List<User>()
            {
                new User(1, "Ümmü Gülsüm", "Özaslan", "abcd@gmail.com", "glsm","123456"),
                new User(1, "Elif", "Öztürk", "elf@gmail.com", "elifoz","123"),
                new User(1, "Can", "Kara", "can@gmail.com", "sdfdsj","1010"),
            };

         
        }
        public void AddUser(User user)
        {
            if(IsUsernameUnique(user.UserName))
            {
                users.Add(user);
                Console.WriteLine("Kullanıcı başarıyla eklendi : " +user.UserName);
            }
            else
            {
                Console.WriteLine("Bu kullanıcı adı zaten kullanımda.");
                
            }


        }
        private bool IsUsernameUnique(string username)
        {
            return !users.Exists(u => u.UserName == username);
        }

        public List<User> GetAllUser()
        {
            Console.WriteLine("----------Kullanıcı Listesi-----------");

            foreach (var user in users)
            {
                Console.WriteLine($" İsim: {user.FirstName}, Soyisim: {user.LastName}, E-posta: {user.Email}, Kullanıcı Adı: {user.UserName}");
            }
            return users;
        }

        public void Login()
        {
            Console.WriteLine("----------Giriş----------");
            Console.Write("Kullanıcı adı: ");
            string username = Console.ReadLine();

            Console.Write("Şifre: ");
            string password = Console.ReadLine();

            User user = null;
            foreach (User u in users)
            {
                if (u.UserName == username && u.Password == password)
                {
                    user = u;
                    break;
                }
            }

            if (user != null)
            {
                Console.WriteLine($"Giriş başarılı. Hoş geldiniz, {user.FirstName} {user.LastName}.");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre yanlış.");
            }
            
        }
    }
}
