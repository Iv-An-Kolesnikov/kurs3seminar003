Console.Clear();
// string[] names;
// string[] names = new string[x];

// int[] num;
// int[] num = new int[5];
// int[] num = new int[5] {1, 2, 3, 4, 5};
// int[] num = new int[] {1, 2, 3, 4, 5};
// int[] num = new[] {1, 2, 3, 4, 5};

// int[] num = {1, 2, 3, 4, 5};//Задание массива с числами

string[] names = {"Ann", "John", "Bob", "Liz"};//Задание массива со словами

// Console.WriteLine(num[2]);//Вывод элемента массива
// num[2] = num[2] * 7; //Присваивание элементу новое значение
// Console.WriteLine(num[2]); //Вывод элемента с новым значением

Console.WriteLine(names[names.Length - 1]);//Вывод элемента массива
names[names.Length - 1] = "Mark";//Присваивание элементу новое значение
Console.WriteLine(names[names.Length - 1]);//Вывод элемента с новым значением

//names.Length - длина массива

// for (int i = 0; i < names.Length; i++) //Органицация цикла вывода элементов массива
//     Console.WriteLine(names[i]); //Вывод всех элемантов массива