using static Polimorfizm.BaseGeometrikSekil;

class BaseGeometrikSekil
{
    static void Main(string[] args)
    {

        // simdi bir kare nesnesi  oluşturalım

        Square square = new Square
        {
            Height = 15,
            Width = 10,
        };

        Dikdortgen dikdortgen = new Dikdortgen
        {

            Height = 20,
            Width = 10,
        };
        Dikucgen dikucgen = new Dikucgen
        {
            Height = 25,
            Width = 40,
        };
        // şimdi de her nesne icin konsola  yazdralım
        Console.WriteLine($"kare alanı : {square.CalculateField()}");
        Console.WriteLine($"dıkdortgen alanı : {dikdortgen.CalculateField()}");
        Console.WriteLine($"dık ucgen alanı :{dikucgen.CalculateField()}");
    }
}