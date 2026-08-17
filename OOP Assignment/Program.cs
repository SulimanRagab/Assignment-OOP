
#region ASSIGNMENT 01
//Part 01 : Theoretical Questions

#region Question 1
using OOP_Assignment;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
#region First Requirement

//a)What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
//DeliveryAddress address01 = new DeliveryAddress();
//DeliveryAddress address02 = new DeliveryAddress();
//address01.City = "cairo";
//address01.Street = "street01";
//Console.WriteLine("addres01...");
//Console.WriteLine(address01.City);
//Console.WriteLine(address01.Street);
//address02= address01;
//Console.WriteLine("addres02...");
//Console.WriteLine(address02.City);
//Console.WriteLine(address02.Street);
//address02.City = "giza";
//address02.Street = "street02";
//Console.WriteLine("addres02...");
//Console.WriteLine(address02.City);
//Console.WriteLine(address02.Street);
//Console.WriteLine("addres01...");
//Console.WriteLine(address01.City);
//Console.WriteLine(address01.Street);
// ودا يثبت ان address01 الاصل م اتغيرش لأن struct Value type
#endregion

#region The second requirement
//b) What happens when a Customer variable is copied into another variable and one variable modifies the object
//Customer customer01 = new Customer();
//Customer customer02 = new Customer();
//customer01.Name = "Ahmed";
//customer02 = customer01;
//Console.WriteLine(customer01.Name);
//Console.WriteLine(customer02.Name);
//customer02.Name = "Suliman";
//Console.WriteLine(customer01.Name);
//Console.WriteLine(customer02.Name);
// ودا يثبت ان customer01 الاصل اتغيرت لأنها class من نوع Referencetype
#endregion
#endregion

#region Question 2
#region First Requirement
//a) a) Identify at least three problems with this design from an encapsulation perspective.
//The first problem : مفيش اي حمايه للبينات  اي حد يقدر يوصل للبينات ويعدل عليها علشان هيا public مش private
//The second problem : مفيش اي validation للبينات يعني ممكن حد يدخل بيانات غلط ومفيش اي حمايه من كده
//The third proble : ممكن اي حد غير قيم  DeliveryFee و Weight لقيم غير منطقيه ودا طبعا مش مقبول لأان  مفيش Validation للبيانات.
#endregion

#region The second requirement
//b) b) How can private fields and public properties improve this design?
//لو حوّلت public DeliveryFee ل  private DeliveryFee محدش يقدر يغير ف رسوم التوصيل  وتكون للقراء فقط للعرض ب استخدام Property Read Only
// وكذالك لو حوّلت public Weight ل  private Weight و بستخدام Property اقردر اعملله فاليديشن بحيث احدد  حدث بناءً على   الوزن 
#endregion
#endregion

//Part 02 : Practical
#region Question 1
//DeliveryAddress deliv = new DeliveryAddress("cairo", "street01", 1);
//Console.WriteLine(deliv.GetFullAddress());

#region جزء النسخ
//Create one DeliveryAddress value, copy it into a second variable, modify the copy, and print both values to prove that
//the original did not change.
// تم حل ا لسؤال فوق 
#endregion
#endregion

#region Question 2
#region 2.Ceate a Shipment struct
// قبل تحويل نوع properties ل read-only 
//Shipment shipment =new Shipment();
//shipment.TrackingCode = "A1001";
//shipment.Description = "Lap Top";
//shipment.TrackingCode = "   ";
//shipment.Description = "";
//shipment.Weight = 100;
//shipment.Weight = -3;
//shipment.Destination = new DeliveryAddress("Cairo", "Street 01", 1);
//shipment.DeliveryFee = 30;
//shipment.DeliveryFee = -2;
//Console.WriteLine($"TrackingCode: {shipment.TrackingCode}");
//Console.WriteLine($"Description: {shipment.Description}");
//Console.WriteLine($"Weight: {shipment.Weight}");
//Console.WriteLine($"DeliveryFee:{shipment.DeliveryFee}");
//Console.WriteLine($"Destination: {shipment.Destination.GetFullAddress()}");
//Console.WriteLine($"EstimatedCost:{shipment.EstimatedCost}");


// قبل انشاء ميثود ال DisplayShipmentInfo()
//Console.WriteLine(" The Firest constructor");
//Shipment shipment01 = new Shipment("aaa001");
//Console.WriteLine($"TrackingCode: {shipment01.TrackingCode}");
//Console.WriteLine($"Description: {shipment01.Description}");
//Console.WriteLine($"Weight: {shipment01.Weight}");
//Console.WriteLine($"DeliveryFee:{shipment01.DeliveryFee}");
//Console.WriteLine($"Destination: {shipment01.Destination.GetFullAddress()}");
//Console.WriteLine($"EstimatedCost:{shipment01.EstimatedCost}");
//Console.WriteLine("---------------------------------------------------");
//Console.WriteLine(" The second constructor");
//Shipment shipment02 = new Shipment("aaa002","Kepord", 55.5 , 30, new DeliveryAddress("cairo", "Street02", 20));
//Console.WriteLine($"TrackingCode: {shipment02.TrackingCode}");
//Console.WriteLine($"Description: {shipment02.Description}");
//Console.WriteLine($"Weight: {shipment02.Weight}");
//Console.WriteLine($"DeliveryFee:{shipment02.DeliveryFee}");
//Console.WriteLine($"Destination: {shipment02.Destination.GetFullAddress()}");
//Console.WriteLine($"EstimatedCost:{shipment02.EstimatedCost}");

//Console.WriteLine(" The Firest constructor");
//Shipment shipment01 = new Shipment("aaa001");
//shipment01.PrintShipment();
//Console.WriteLine("---------------------------------------------------");
//Console.WriteLine(" The second constructor");
//Shipment shipment02 = new Shipment("aaa002", "Kepord", 55.5, 30, new DeliveryAddress("cairo", "Street02", 20));
//shipment02.UpdateDeliveryFee(50);
//shipment02.UpdateDeliveryFee(-50);
//shipment02.PrintShipment();

#endregion
#endregion

#region Question 3
#region 5. Create a DeliveryCenter struct
// الكود اثناء انشاء 5. Create a DeliveryCenter struct
// اختبار الكود بعد انشاء 5. Create a DeliveryCenter struct
//Shipment shimp01 = new Shipment("aaa01", "Kepord", 21, 50, new DeliveryAddress("cairo", "Street03", 3540));
//Shipment shimp02 = new Shipment("aaa02", "LApTop", 55, 10, new DeliveryAddress("cairo", "Street03", 330));
//Shipment shimp03 = new Shipment("aaa03", "HedPhon", 105, 20, new DeliveryAddress("cairo", "Street03", 23405));
//Shipment shimp04 = new Shipment("aaa04", "Mause", 355, 40, new DeliveryAddress("Giza", "Street03", 3540));
//Shipment shimp05 = new Shipment("aaa05", "RUM", 455, 60, new DeliveryAddress("Naser city", "Street022", 450));
//Shipment shimp06 = new Shipment("aaa06", "MausPad", 855, 67, new DeliveryAddress("BNS", "Street06", 1030));
//Shipment shimp07 = new Shipment("aaa07", "Power", 655, 70, new DeliveryAddress("SUR", "Street05", 3220));
//Shipment shimp08 = new Shipment("aaa08", "شاشه", 655, 70, new DeliveryAddress("SUR", "Street05", 3220));
//Shipment shimp09 = new Shipment("aaa09", "اي حاجه", 655, 70, new DeliveryAddress("SUR", "Street05", 3220));
//Shipment shimp10 = new Shipment("aaa10", "Ay7aga", 655, 70, new DeliveryAddress("SUR", "Street05", 3220));
//DliveryCenter dliveryCenter = new DliveryCenter();
//dliveryCenter.AddShipment(shimp01);
//dliveryCenter.AddShipment(shimp02);
//dliveryCenter.AddShipment(shimp03);
//dliveryCenter.AddShipment(shimp04);
//dliveryCenter.AddShipment(shimp05);
//dliveryCenter.AddShipment(shimp06);
//dliveryCenter.AddShipment(shimp07);
//dliveryCenter.AddShipment(shimp08);
//dliveryCenter.AddShipment(shimp09);
//dliveryCenter.AddShipment(shimp10);
////dliveryCenter[0].PrintShipment();
////dliveryCenter[0] = new Shipment("aaa011", "111", 111, 11, new DeliveryAddress("cairo", "Street11", 1111));
////Console.WriteLine("__________________________");
////dliveryCenter[0].PrintShipment();
////dliveryCenter["aaa02"].PrintShipment();
////dliveryCenter["aaa02"] = new Shipment("aaa022", "222", 222, 22, new DeliveryAddress("cairo", "Street22", 2222));
////dliveryCenter.RemoveShipment("aaa03");
////dliveryCenter["aaa03"].PrintShipment();
////dliveryCenter.AddShipment(shimp03);
////dliveryCenter["aaa03"].PrintShipment();
//dliveryCenter.PrintAllShipments();

#endregion
#endregion

#region Question 4
#region 6. In Main, build a Console Application that does the following
//DliveryCenter Center = new DliveryCenter();
//for (int i = 1; i <= 3; i++)
//{
//    Console.Write("Enter TrackingCode: ");
//    string trackingCode = Console.ReadLine();
//    Console.Write("Enter Description: ");
//    string description = Console.ReadLine();
//    Console.Write("Enter Weight: ");
//    decimal.TryParse(Console.ReadLine(), out decimal weight);
//    Console.Write("Enter DeliveryFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);
//    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -  - - - ");
//    Console.WriteLine("Enter the shipment delivery address.");
//    Console.Write("Enter the City Name: ");
//    string City = Console.ReadLine();
//    Console.Write("Enter the Street Name: ");
//    string street = Console.ReadLine();
//    Console.Write("Enter the BuildingNumber Name: ");
//    int.TryParse(Console.ReadLine(), out int buildingNumber);
//    Console.WriteLine("____ All Shipments Data ____");
//    Shipment shipment = new Shipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(City, street, buildingNumber));
//    Center.AddShipment(shipment);
//}
//Center[0].PrintShipment();
//Center[1].PrintShipment();
//Center[2].PrintShipment();
//Console.WriteLine("Enter a trackingCode to search");
//string trac = Console.ReadLine();
//Shipment stringindex = Center[trac];
//if (!string.IsNullOrWhiteSpace(stringindex.TrackingCode))
//{
//    Center[trac].PrintShipment();
//}
//else
//{
//    Console.WriteLine("Shipment not found.");
//}
#endregion
#endregion
#endregion

#region ASSIGNMENT 02
// Part 01 : Theoretical Questions
#region Question 1
#region a)
// a) What is the difference between a class and a struct?
//Class reference type , بينما  Struct value type
// calss بيتخزن ف heap و struct بيتخزن ف stack
// class  مدعوم بالوراثه inheritance و انما  struct لا يدعم الوراثه
//class للبينات الكثيره و المعقدة  و انما struct للبينات البسيطه و القليله
// class معندوش constructor افتراضي و انما struct عندو constructor افتراضي
#endregion

#region b)
//b) Why are classes more suitable than structs for large applications?
//لأن ال Class  بتدعم الوراثة inheritance  ف دي ميزه انك بتقلل تكرار الكود بينما ال struct لا تدعم الوراثة inheritance  و بالتالي لو عندك كود متكرر هتضطر تكتبه اكتر من مره و ده هيخلي الكود كبير و معقد و صعب التعديل عليه
// وكمان ال class ما بتضرش تاخد نسخه من القيمه اللي بتساويها فالمقابل  وبالتالي ما فيش مشاكل في ال memory  و ال performance  زي ال struct اللي بتاخد نسخه من القيمه اللي بتساويها و ده بيخلي ال memory  و ال performance  يتاثروا سلبيا
#endregion
#endregion

#region Question 2
// a) Which class is the parent class?
//Shipment
//b) Which class is the child class?
// ExpressShipment
//c) What members are inherited by ExpressShipment?
// trackingCode
//d) Why is inheritance better than duplicating the same code in multiple classes?
//لأن الوراثة inheritance بتقلل تكرار الكود  وبالتالي بتخللي الكود اسهل ف القراءه والتعديل 
#endregion

// Part 02 : Practical
#region 5.In Main
#region The logical and best approach for the current code.

//Console.WriteLine("Enter the shipment type: \n 1. StandardShipment \n 2. ExpressShipment \n 3. InternationalShipment");
//int shipmentType = int.Parse(Console.ReadLine());
//if (shipmentType == 1)
//{
//    Console.Write("Enter TrackingCode: ");
//    string trackingCode = Console.ReadLine();

//    Console.Write("Enter Description: ");
//    string description = Console.ReadLine();

//    Console.Write("Enter Weight: ");
//    decimal.TryParse(Console.ReadLine(), out decimal weight);

//    Console.Write("Enter DeliveryFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);

//    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -  - - - ");
//    Console.WriteLine("Enter the shipment delivery address.");
//    Console.Write("Enter the City Name: ");
//    string City = Console.ReadLine();
//    Console.Write("Enter the Street Name: ");
//    string street = Console.ReadLine();
//    Console.Write("Enter the BuildingNumber Name: ");
//    int.TryParse(Console.ReadLine(), out int buildingNumber);
//    StandardShipment Standard = new StandardShipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(City, street, buildingNumber));
//}
//else if (shipmentType == 2)
//{
//    Console.Write("Enter TrackingCode: ");
//    string trackingCode = Console.ReadLine();

//    Console.Write("Enter Description: ");
//    string description = Console.ReadLine();

//    Console.Write("Enter Weight: ");
//    decimal.TryParse(Console.ReadLine(), out decimal weight);

//    Console.Write("Enter DeliveryFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);

//    Console.Write("Enter ExtraFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal extraFee);

//    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -  - - - ");
//    Console.WriteLine("Enter the shipment delivery address.");
//    Console.Write("Enter the City Name: ");
//    string City = Console.ReadLine();
//    Console.Write("Enter the Street Name: ");
//    string street = Console.ReadLine();
//    Console.Write("Enter the BuildingNumber Name: ");
//    int.TryParse(Console.ReadLine(), out int buildingNumber);

//    ExpressShipment Express = new ExpressShipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(City, street, buildingNumber), extraFee);
//}
//else if (shipmentType == 3)
//{
//    Console.Write("Enter TrackingCode: ");
//    string trackingCode = Console.ReadLine();

//    Console.Write("Enter Description: ");
//    string description = Console.ReadLine();

//    Console.Write("Enter Weight: ");
//    decimal.TryParse(Console.ReadLine(), out decimal weight);

//    Console.Write("Enter DeliveryFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);

//    Console.Write("Enter Destination country: ");
//    string destinationCountry = Console.ReadLine();

//    Console.Write("Enter CustomsFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal customsFee);

//    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -  - - - ");
//    Console.WriteLine("Enter the shipment delivery address.");
//    Console.Write("Enter the City Name: ");
//    string City = Console.ReadLine();
//    Console.Write("Enter the Street Name: ");
//    string street = Console.ReadLine();
//    Console.Write("Enter the BuildingNumber Name: ");
//    int.TryParse(Console.ReadLine(), out int buildingNumber);

//    InternationalShipment International = new InternationalShipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(City, street, buildingNumber), destinationCountry, customsFee);
//}
#endregion

//DliveryCenter Center = new DliveryCenter();
//Console.Write("Enter Center Name: ");
//Center.CenterName = Console.ReadLine();
#region Standard Shipment
//{
//    Console.WriteLine("Enter Standard Shipment Data\n");
//    Console.Write("Enter TrackingCode: ");
//    string trackingCode = Console.ReadLine();

//    Console.Write("Enter Description: ");
//    string description = Console.ReadLine();

//    Console.Write("Enter Weight: ");
//    decimal.TryParse(Console.ReadLine(), out decimal weight);

//    Console.Write("Enter DeliveryFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);

//    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -  - - - ");
//    Console.WriteLine("Enter the shipment delivery address.");
//    Console.Write("Enter the City Name: ");
//    string City = Console.ReadLine();
//    Console.Write("Enter the Street Name: ");
//    string street = Console.ReadLine();
//    Console.Write("Enter the BuildingNumber Name: ");
//    int.TryParse(Console.ReadLine(), out int buildingNumber);
//    StandardShipment Standard = new StandardShipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(City, street, buildingNumber));

//    Center.AddShipment(Standard);

//}

#endregion

#region Express Shipment
//{
//    Console.WriteLine("- - - - - - - - -  Express Shipment - - - - - - - - - - ");
//    Console.WriteLine("Enter Express Shipment Data");
//    Console.Write("Enter TrackingCode: ");
//    string trackingCode = Console.ReadLine();

//    Console.Write("Enter Description: ");
//    string description = Console.ReadLine();

//    Console.Write("Enter Weight: ");
//    decimal.TryParse(Console.ReadLine(), out decimal weight);

//    Console.Write("Enter DeliveryFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);

//    Console.Write("Enter ExtraFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal extraFee);

//    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -  - - - ");
//    Console.WriteLine("Enter the shipment delivery address.");
//    Console.Write("Enter the City Name: ");
//    string City = Console.ReadLine();
//    Console.Write("Enter the Street Name: ");
//    string street = Console.ReadLine();
//    Console.Write("Enter the BuildingNumber Name: ");
//    int.TryParse(Console.ReadLine(), out int buildingNumber);

//    ExpressShipment Express = new ExpressShipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(City, street, buildingNumber), extraFee);

//    Center.AddShipment(Express);
//}

#endregion

#region International Shipment
//{
//    Console.WriteLine("- - - - - - - - -  International Shipment - - - - - - - - - - ");
//    Console.WriteLine("Enter International Shipment Data");
//    Console.Write("Enter TrackingCode: ");
//    string trackingCode = Console.ReadLine();

//    Console.Write("Enter Description: ");
//    string description = Console.ReadLine();

//    Console.Write("Enter Weight: ");
//    decimal.TryParse(Console.ReadLine(), out decimal weight);

//    Console.Write("Enter DeliveryFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);

//    Console.Write("Enter Destination country: ");
//    string destinationCountry = Console.ReadLine();

//    Console.Write("Enter CustomsFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal customsFee);

//    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -  - - - ");
//    Console.WriteLine("Enter the shipment delivery address.");
//    Console.Write("Enter the City Name: ");
//    string City = Console.ReadLine();
//    Console.Write("Enter the Street Name: ");
//    string street = Console.ReadLine();
//    Console.Write("Enter the BuildingNumber Name: ");
//    int.TryParse(Console.ReadLine(), out int buildingNumber);

//    InternationalShipment International = new InternationalShipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(City, street, buildingNumber), destinationCountry, customsFee);

//    Center.AddShipment(International);
//}
#endregion

//Center.PrintAllShipments();
//Console.WriteLine("       ");
//Console.WriteLine("---------- Search ----------");
//Console.WriteLine("       ");
//Console.WriteLine("Enter a trackingCode to search");
//string trac = Console.ReadLine();
//Shipment stringindex = Center[trac];
//if (!string.IsNullOrWhiteSpace(stringindex.TrackingCode))
//{
//    Center[trac].PrintShipment();
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Shipment not found");
//    Console.ResetColor();
//}
//Console.WriteLine("       ");
//Console.WriteLine("---------- Delete shipment ----------");
//Console.WriteLine("       ");
//Console.WriteLine("Enter the tracking number for the shipment you want to delete");
//string trackingCodeToDelete = Console.ReadLine();
//bool remov = Center.RemoveShipment(trackingCodeToDelete);
//if (remov)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("The shipment has been successfully deleted");
//    Console.ForegroundColor = ConsoleColor.White;
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Shipment not found");
//    Console.ForegroundColor = ConsoleColor.White;
//}
//Center.PrintAllShipments();
#endregion
#endregion

#region ASSIGNMENT 03

// ASSIGNMENT 03
//Part 01 — Theoretical Questions
#region Q1 Overloading, Overriding, and Binding
//a) What is the difference between Method Overloading and Method Overriding?
// ال Method Overloading بتسمح بتكرار نفس الميثود اكثر من مره بنفس الاسم ولكن بمعاملات مختلفه Parameters مختلفه
// وال Method Overriding بتسمح للشيلد كلاس استخدام نفس الميثود اللي عند الأب بنفس ال Parameters والتغيير عليها حسب نوع الشيلد كلاس

//b) What is the difference between Static Binding and Dynamic Binding?
// ال Static Binding بيتم تحديد الميثود اللي هتتنفذ وقت الكومبايل Compile time و دا بيحصل مع ال Method Overloading اللي هيا مثلا new()
// وال Dynamic Binding بيتم تحديد الميثود اللي هتتنفذ وقت التشغيل Run time و دا بيحصل مع ال Method Overriding زي virtual() و override()
#endregion

#region Q2 Sealed Classes and Methods
//a) What is the purpose of the sealed keyword when applied to a class?
// انا لما ب استخدم sealed class  على اي كلاس ف انا بمنع اي كلاس تانيه انها تورث منها 
//b) What is the difference between a sealed class and a sealed method?
//sealed class تمنع توريث ال كلاس اللي مستخدماها لأي كلاس تانيه 
// اما ال sealed method بتمنع اي Child class انها تستخدم ال ميثود اللي مستخدماها عن طريق ال override() ولكن عادي جدا انها تعمل new() للكلاس  وعادي جدا  انها تنشئ اوبجيكت جديد هيا فقط بتمنع الميثود ان يتعملها override() ف اي Child class 
//c) Can a sealed method be overridden? Why?
// الاجابه : لأمينفعش اعمل override() ثل ميثود معمول لها sealed لأن ببساطه ال sealed method لما بستخدمها على ميثود ف انا بقولها اخرك هنا مفيش اي Child Class تعمللك override() تاني  
#endregion

//Part 02 — Practical
#region Q 10 Main() Checklist

//DliveryCenter Center = new DliveryCenter();
//Console.Write("Enter Center Name: ");
//Center.CenterName = Console.ReadLine();
//Console.WriteLine("Enter Name Driver");
//string fullName = Console.ReadLine();
//Driver driver = new Driver(1, fullName, "0123456789");
//Center.Driver = driver;
//StandardShipment Standard;
//ExpressShipment Express;
//InternationalShipment International;
#region Standard Shipment
//{
//    Console.WriteLine("Enter Standard Shipment Data\n");
//    Console.Write("Enter TrackingCode: ");
//    string trackingCode = Console.ReadLine();

//    Console.Write("Enter Description: ");
//    string description = Console.ReadLine();

//    Console.Write("Enter Weight: ");
//    decimal.TryParse(Console.ReadLine(), out decimal weight);

//    Console.Write("Enter DeliveryFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);

//    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -  - - - ");
//    Console.WriteLine("Enter the shipment delivery address.");
//    Console.Write("Enter the City Name: ");
//    string City = Console.ReadLine();
//    Console.Write("Enter the Street Name: ");
//    string street = Console.ReadLine();
//    Console.Write("Enter the BuildingNumber Name: ");
//    int.TryParse(Console.ReadLine(), out int buildingNumber);
//  Standard = new StandardShipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(City, street, buildingNumber));
//    Center.AddShipment(Standard);
//    DeliveryHelper.PrintShipmentDetails(Standard);
//    Console.WriteLine("Update shipment weight");
//    decimal.TryParse(Console.ReadLine(), out decimal Weight);
//    Standard.weightupdate(Weight);
//    Console.WriteLine("Update the shipment weight after packing");
//    Console.WriteLine("Enter Original Weight");
//    decimal.TryParse(Console.ReadLine(), out decimal OriginalWeight);
//    Console.WriteLine("Enter Weight  Packing");
//    decimal.TryParse(Console.ReadLine(), out decimal WeightPacking);
//    Standard.weightupdate(OriginalWeight, WeightPacking);
//    Console.WriteLine("Shipment details after weight update");
//    Console.ForegroundColor = ConsoleColor.Green;
//    DeliveryHelper.PrintShipmentDetails(Standard);
//    Console.ForegroundColor = ConsoleColor.White;
//}

#endregion

#region Express Shipment
//{
//    Console.WriteLine("- - - - - - - - -  Express Shipment - - - - - - - - - - ");
//    Console.WriteLine("Enter Express Shipment Data");
//    Console.Write("Enter TrackingCode: ");
//    string trackingCode = Console.ReadLine();

//    Console.Write("Enter Description: ");
//    string description = Console.ReadLine();

//    Console.Write("Enter Weight: ");
//    decimal.TryParse(Console.ReadLine(), out decimal weight);

//    Console.Write("Enter DeliveryFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);

//    Console.Write("Enter ExtraFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal extraFee);

//    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -  - - - ");
//    Console.WriteLine("Enter the shipment delivery address.");
//    Console.Write("Enter the City Name: ");
//    string City = Console.ReadLine();
//    Console.Write("Enter the Street Name: ");
//    string street = Console.ReadLine();
//    Console.Write("Enter the BuildingNumber Name: ");
//    int.TryParse(Console.ReadLine(), out int buildingNumber);
//    Express = new ExpressShipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(City, street, buildingNumber), extraFee);
//    Center.AddShipment(Express);
//    DeliveryHelper.PrintShipmentDetails(Express);

//}

#endregion

#region International Shipment

//{
//    Console.WriteLine("- - - - - - - - -  International Shipment - - - - - - - - - - ");
//    Console.WriteLine("Enter International Shipment Data");
//    Console.Write("Enter TrackingCode: ");
//    string trackingCode = Console.ReadLine();

//    Console.Write("Enter Description: ");
//    string description = Console.ReadLine();

//    Console.Write("Enter Weight: ");
//    decimal.TryParse(Console.ReadLine(), out decimal weight);

//    Console.Write("Enter DeliveryFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);

//    Console.Write("Enter Destination country: ");
//    string destinationCountry = Console.ReadLine();

//    Console.Write("Enter CustomsFee:");
//    decimal.TryParse(Console.ReadLine(), out decimal customsFee);

//    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -  - - - ");
//    Console.WriteLine("Enter the shipment delivery address.");
//    Console.Write("Enter the City Name: ");
//    string City = Console.ReadLine();
//    Console.Write("Enter the Street Name: ");
//    string street = Console.ReadLine();
//    Console.Write("Enter the BuildingNumber Name: ");
//    int.TryParse(Console.ReadLine(), out int buildingNumber);

//   International = new InternationalShipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(City, street, buildingNumber), destinationCountry, customsFee);
//    Center.AddShipment(International);
//    DeliveryHelper.PrintShipmentDetails(International);
//}
#endregion
//Console.ForegroundColor = ConsoleColor.DarkGreen;
//Console.WriteLine(" \n ");
//Console.WriteLine("Print all shipments using PrintAllShipments()");
//Console.WriteLine(" \n ");
//Console.WriteLine("===============================");
//Center.PrintAllShipments();
//Console.WriteLine("===============================");
//Console.WriteLine("print shipment a foreach Loop \n  ");
//Shipment[] shipments = { Standard, Express, International };
//foreach (Shipment shipment in shipments)
//{
//    shipment.PrintShipment();
//}

//l. Demonstrate the sealed class and sealed method (comments or code).

//   internal sealed class CompletedShipmen : Shipment
//{
// الكلاس دا مغلق يعني مفيش اي كلاس تانيه ترث منها 
//}
//internal  class testsealedClass : CompletedShipmen
//{
//    // error
//}
//public override void GenerateCustomsReport()
//{
//    // Error Not Ovveride
//}
#endregion
#endregion

#region ASSIGNMENT 04
// Part 01 — Theoretical Questions

#region Q01

//a) What is Abstraction in Object-Oriented Programming?a) What is Abstraction in Object-Oriented Programming?
//ال Abstraction هو ببساطه اخفاء التفاصيل الغير مهمه او المعقده للمستخدم و اظهار التفاصيل الل يحتاجها فقط 

//b) Why is abstraction considered one of the four pillars of OOP?
// لأن بيركز على اخفاء الكود المقعد والتفاصيل الكثيره ويوفر كود سهل القراءه و التعامل ودا بيسهل حل المشكلات فيما بعد وبيحمي اللبينات 

#endregion

#region Q02
//a) What is the difference between an Abstract Class and an Interface?
// => Abstract Class = Base Class \\ بيمثل كلاس اساسي مشترك لباقي الكلاسات الوارثه منه و يقدر يحتوي على Fields و Properties
// => Interface = Contract \\  بيحدد الكلاس هيعمل اي  يعني بيحدد سلوك الكلاس ممككن الكلاس ينفذ اكتر من Interface

//b) When would you choose an Interface instead of an Abstract Class?
// هختار Abstract Class لما يكون عندي  خاصيه و عايز اخلي اكتر من كلاس يستخدمها مثلا زي CRUD 
// و هختار Interface لما اكون عايز اخلي كلاس ينفذ سلوك معين ويلتزم بيه  و اكون عايز ينفذ اكتر من سلوك خلاف ال Abstract Class 

//c) Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
// مينفعش ال Class تطبق اكتر من Abstract Class لان c # مش بتسمح بكدا و انما ينفع تطبق اكتر من Interface بمعنى تنفذ اكتر من سلوك مختلف 

#endregion

// Part 02 — Practical
#region 8 Main() Checklist
#region Create Oject
//DliveryCenter Center = new DliveryCenter();
//StandardShipment Standard;
//ExpressShipment Express;
//InternationalShipment International;
#endregion

#region Standard Shipment
{
    Console.WriteLine("Enter Standard Shipment Data\n");
Console.Write("Enter TrackingCode: ");
string trackingCode = Console.ReadLine();

Console.Write("Enter Description: ");
string description = Console.ReadLine();

Console.Write("Enter Weight: ");
decimal.TryParse(Console.ReadLine(), out decimal weight);

Console.Write("Enter DeliveryFee:");
decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);

Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -  - - - ");
Console.WriteLine("Enter the shipment delivery address.");
Console.Write("Enter the City Name: ");
string City = Console.ReadLine();
Console.Write("Enter the Street Name: ");
string street = Console.ReadLine();
Console.Write("Enter the BuildingNumber Name: ");
int.TryParse(Console.ReadLine(), out int buildingNumber);
Standard = new StandardShipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(City, street, buildingNumber));
Center.AddShipment(Standard);}
#endregion

#region Express Shipment
{
    Console.WriteLine("- - - - - - - - -  Express Shipment - - - - - - - - - - ");
    Console.WriteLine("Enter Express Shipment Data");
    Console.Write("Enter TrackingCode: ");
    string trackingCode = Console.ReadLine();

    Console.Write("Enter Description: ");
    string description = Console.ReadLine();

    Console.Write("Enter Weight: ");
    decimal.TryParse(Console.ReadLine(), out decimal weight);

    Console.Write("Enter DeliveryFee:");
    decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);

    Console.Write("Enter ExtraFee:");
    decimal.TryParse(Console.ReadLine(), out decimal extraFee);

    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -  - - - ");
    Console.WriteLine("Enter the shipment delivery address.");
    Console.Write("Enter the City Name: ");
    string City = Console.ReadLine();
    Console.Write("Enter the Street Name: ");
    string street = Console.ReadLine();
    Console.Write("Enter the BuildingNumber Name: ");
    int.TryParse(Console.ReadLine(), out int buildingNumber);
   Express = new ExpressShipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(City, street, buildingNumber), extraFee);
    Center.AddShipment(Express);
}
#endregion

#region International Shipment
{
    Console.WriteLine("- - - - - - - - -  International Shipment - - - - - - - - - - ");
    Console.WriteLine("Enter International Shipment Data");
    Console.Write("Enter TrackingCode: ");
    string trackingCode = Console.ReadLine();

    Console.Write("Enter Description: ");
    string description = Console.ReadLine();

    Console.Write("Enter Weight: ");
    decimal.TryParse(Console.ReadLine(), out decimal weight);

    Console.Write("Enter DeliveryFee:");
    decimal.TryParse(Console.ReadLine(), out decimal deliveryFee);

    Console.Write("Enter Destination country: ");
    string destinationCountry = Console.ReadLine();

    Console.Write("Enter CustomsFee:");
    decimal.TryParse(Console.ReadLine(), out decimal customsFee);

    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -  - - - ");
    Console.WriteLine("Enter the shipment delivery address.");
    Console.Write("Enter the City Name: ");
    string City = Console.ReadLine();
    Console.Write("Enter the Street Name: ");
    string street = Console.ReadLine();
    Console.Write("Enter the BuildingNumber Name: ");
    int.TryParse(Console.ReadLine(), out int buildingNumber);

    International = new InternationalShipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(City, street, buildingNumber), destinationCountry, customsFee);
    Center.AddShipment(International);

}
#endregion

#region Output
//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine("====================\n Dlivery Center \n ====================");
//Center.PrintAllShipments();
//ITrackable[] iTrackable =
//{
//    Standard,
//    Express,
//    International
//};
//Console.WriteLine("==========================================");
//Console.WriteLine("Tracking Status");
//foreach (var trackable in iTrackable)
//{
//    Console.WriteLine($"{trackable.GetTrackingStatus()}");
//}
//IInsurable[] iInsurable =
//{
//    Standard,
//    Express,
//    International
//};
//Console.WriteLine("==========================================");
//Console.WriteLine("Insurance");

//foreach (var Insurable in iInsurable)
//{
//    Console.WriteLine($"{Insurable.GetType().Name} Insurance: {Insurable.CalculateInsurance()} EGP\n ");
//}
//Console.WriteLine("==========================================");
//Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
#endregion

#endregion
#endregion