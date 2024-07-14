using jsonTaskHW;
using System.Text.Json;
using System.Text.Json.Serialization;

void JsonSerializeMethod()
{
    
    List<Car> cars = new List<Car> {
    new Car { Model = "Priora", Marka = "Lada", Year = 2013 },
    new Car { Model = "2107", Marka = "Lada", Year = 2011 },
    new Car { Model = "2106", Marka = "Lada", Year = 1999 }
};
    CarGallery carGallery = new CarGallery("carGallery1", cars);
    var jsonString = JsonSerializer.Serialize(carGallery);
    File.WriteAllText("carGallery.json", jsonString);
    Console.WriteLine("✓✓✓");
}

static void JsonDeserializeMethod()
{
    string jsonString = File.ReadAllText("carGallery.json");
    CarGallery carGallery = JsonSerializer.Deserialize<CarGallery>(jsonString);

    Console.WriteLine($"Gallery Name: {carGallery.GalleryName}");
    Console.WriteLine("Cars:");
    Console.WriteLine(string.Join("\n", carGallery.Cars));
    // Console.WriteLine(carGallery.Cars);
    /* foreach (var car in carGallery.Cars)
     {
         Console.WriteLine($"Model: {car.Model}, Marka: {car.Marka}, Year: {car.Year}");
     }*/  
}
JsonSerializeMethod();

JsonDeserializeMethod();