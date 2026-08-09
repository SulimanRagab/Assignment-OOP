//Part 01 : Theoretical Questions

#region Question 1
using OOP_Assignment;
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
//Shipment shimp01 = new Shipment("aaa01", "Kepord", 65.5, 50, new DeliveryAddress("cairo", "Street03", 3540));
//Shipment shimp02 = new Shipment("aaa02", "LApTop", 5.5, 10, new DeliveryAddress("cairo", "Street03", 330));
//Shipment shimp03 = new Shipment("aaa03", "HedPhon", 10.5, 20, new DeliveryAddress("cairo", "Street03", 23405));
//Shipment shimp04 = new Shipment("aaa04", "Mause", 35.5, 40, new DeliveryAddress("Giza", "Street03", 3540));
//Shipment shimp05 = new Shipment("aaa05", "RUM", 45.5,60, new DeliveryAddress("Naser city", "Street022", 450));
//Shipment shimp06 = new Shipment("aaa06", "MausPad", 85.5, 67, new DeliveryAddress("BNS", "Street06", 1030));
//Shipment shimp07 = new Shipment("aaa07", "Power", 65.5, 70, new DeliveryAddress("SUR", "Street05", 3220));
//Shipment shimp08 = new Shipment("aaa08", "شاشه", 65.5, 70, new DeliveryAddress("SUR", "Street05", 3220));
//Shipment shimp09 = new Shipment("aaa09", "اي حاجه", 65.5, 70, new DeliveryAddress("SUR", "Street05", 3220));
//Shipment shimp10 = new Shipment("aaa10", "Ay7aga", 65.5, 70, new DeliveryAddress("SUR", "Street05", 3220));
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
//dliveryCenter[0].PrintShipment();
//dliveryCenter[0] = new Shipment("aaa011", "111", 11.1, 11, new DeliveryAddress("cairo", "Street11", 1111));
//Console.WriteLine("__________________________");
//dliveryCenter[0].PrintShipment();
//dliveryCenter["aaa02"].PrintShipment();
//dliveryCenter["aaa02"] = new Shipment("aaa022", "222", 22.2, 22, new DeliveryAddress("cairo", "Street22", 2222));
//Console.WriteLine(dliveryCenter[5].TrackingCode);

#endregion
#endregion

#region Question 4
#region 6. In Main, build a Console Application that does the following
//DliveryCenter Center = new DliveryCenter();
//for (int i = 1; i <= 3; i++)
//{
//Console.Write("Enter TrackingCode: ");
//string trackingCode = Console.ReadLine();
//Console.Write("Enter Description: ");
//string description = Console.ReadLine();
//Console.Write("Enter Weight: ");
//double.TryParse(Console.ReadLine(), out double weight);
//Console.Write("Enter DeliveryFee:");
//double.TryParse(Console.ReadLine(), out double deliveryFee);
//Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -  - - - ");
//Console.WriteLine("Enter the shipment delivery address.");
//Console.Write("Enter the City Name: ");
//string City = Console.ReadLine();
//Console.Write("Enter the Street Name: ");
//string street = Console.ReadLine();
//Console.Write("Enter the BuildingNumber Name: ");
//int.TryParse(Console.ReadLine(), out int buildingNumber);
//Console.WriteLine("____ All Shipments Data ____");
//Shipment shipment = new Shipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(City, street, buildingNumber));
//Center.AddShipment(shipment);
//}
//Center[0].PrintShipment();
//Center[1].PrintShipment();
//Center[2].PrintShipment();
//Console.WriteLine("Enter a trackingCode to search");
//string trac = Console.ReadLine();
//Shipment stringindex = Center[trac];
//if (!string.IsNullOrWhiteSpace(stringindex.TrackingCode))
//{
//  Center[trac].PrintShipment();  
//}
//else
//{
//   Console.WriteLine("Shipment not found."); 
//}
#endregion
#endregion

// Continuing from the second session


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
#region Questions 1

#endregion