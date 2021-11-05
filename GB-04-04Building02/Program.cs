
using GB_04_04Building02;

Creator.CreateBuild(15, 10, 8);
Creator.CreateBuild(8, 9, 41);
Creator.CreateBuild(45, 1, 88);
Creator.CreateBuild(45, 1, 88);
Creator.CreateBuild(45, 1, 88);

Creator.CityPrint();

System.Console.WriteLine();
Creator.DeleteBuild(3);
Creator.CityPrint();
