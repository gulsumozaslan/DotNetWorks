using Work2;

/* Restoranın menüsündeki yemekleri, fiyatlarını ve popülerlik derecelendirmelerini bir dizi ile tutan algoritma yazınız. */

Food food1 = new Food("köfte",150,4.5);
Food food2 = new Food("çorba", 100, 4.1);
Food food3 = new Food("salata", 120, 3.8);
Food food4 = new Food("tatlı", 200, 4.0);

RestoranMenu restoranMenu = new RestoranMenu();
restoranMenu.AddFood(food1);
restoranMenu.AddFood(food2);
restoranMenu.AddFood(food3);
restoranMenu.AddFood(food4);

restoranMenu.GetMenu();

