
using System;
using Work4;

/*Kullanıcının username, email, firstname, lastname ve password bilgilerini tutan bir List kullanarak giriş yapma algoritması yazınız.*/


//User user1 = new User(4, "Ali", "Boz", "user4@example.com", "aliboz", "password4");
User user2 = new User(5, "Esra", "Tekin", "user5@example.com", "esratekin", "password5");


UserManager userManager = new UserManager(user2);
userManager.AddUser(user2);
userManager.Login();
userManager.GetAllUser();
