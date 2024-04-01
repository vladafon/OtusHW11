using OtusHW11.Models;

var cat = new Mammal(
    name: "Кот", 
    organs: new List<Organ> { 
    new Organ { Name = "Мозг"}, 
    new Organ { Name = "Сердце"}, 
    new Organ { Name = "Почки" } },
    limbsCount: 4,
    eyesCount: 2,
    hasTail: true,
    averageChildrenCount: 4);

var tarantul = new Arachnid(
    name: "Тарантул",
    organs: new List<Organ> {
    new Organ { Name = "Мозг"},
    new Organ { Name = "Сосущий желудок" } },
    limbsCount: 4,
    eyesCount: 2,
    hasTail: true,
    isPoisonous: false);

var earthworm = new Worm(
    name: "Дождевой червь",
    organs: new List<Organ> {
    new Organ { Name = "Зоб"},
    new Organ { Name = "Мозговой ганглий" } },
    limbsCount: 4,
    eyesCount: 2,
    hasTail: true,
    hasRegeneration: true);

Console.WriteLine("Оригинальные объекты.");

Console.WriteLine(cat.ToString());
Console.WriteLine();
Console.WriteLine(tarantul.ToString());
Console.WriteLine();
Console.WriteLine(earthworm.ToString());
Console.WriteLine();

Console.WriteLine("Клонируем при помощи нашего метода.");

var cat2 = cat.MyClone();
var tarantul2 = tarantul.MyClone();
var earthworm2 = earthworm.MyClone();

Console.WriteLine(cat2.ToString());
Console.WriteLine();
Console.WriteLine(tarantul2.ToString());
Console.WriteLine();
Console.WriteLine(earthworm2.ToString());
Console.WriteLine();


Console.WriteLine("Клонируем при помощи встроенного метода.");

var cat3 = cat.Clone();
var tarantul3 = tarantul.Clone();
var earthworm3 = earthworm.Clone();

Console.WriteLine(cat3.ToString());
Console.WriteLine();
Console.WriteLine(tarantul3.ToString());
Console.WriteLine();
Console.WriteLine(earthworm3.ToString());
Console.WriteLine();

Console.WriteLine("Пробуем изменить ссылочный тип в клоне, а проверить в основном объекте.");

cat2.Organs.Add(new Organ { Name = "Кишечник" });

Console.WriteLine("Клонированный объект");
Console.WriteLine(cat2.ToString());
Console.WriteLine();

Console.WriteLine("Исходный объект");
Console.WriteLine(cat.ToString());
Console.WriteLine();

cat = new Mammal(
    name: "Кот",
    organs: new List<Organ> {
    new Organ { Name = "Мозг"},
    new Organ { Name = "Сердце"},
    new Organ { Name = "Почки" } },
    limbsCount: 4,
    eyesCount: 2,
    hasTail: true,
    averageChildrenCount: 4);

cat3 = cat.Clone();

((Mammal)cat3).Organs.Add(new Organ { Name = "Кишечник" });

Console.WriteLine("Клонированный объект");
Console.WriteLine(cat3.ToString());
Console.WriteLine();

Console.WriteLine("Исходный объект");
Console.WriteLine(cat.ToString());
Console.WriteLine();