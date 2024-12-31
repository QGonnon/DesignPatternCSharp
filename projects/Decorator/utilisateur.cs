ICafe monCafe = new CafeSimple();
monCafe = new Lait(monCafe);
monCafe = new Sucre(monCafe);

System.Console.WriteLine(monCafe.GetCost());