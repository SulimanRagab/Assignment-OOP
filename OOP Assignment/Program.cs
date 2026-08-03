
//Part 01 : Theoretical Questions
#region Question 1
using OOP_Assignment;
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
DeliveryAddress deliv = new DeliveryAddress("cairo", "street01", 1444440);
Console.WriteLine(deliv.GetFullAddress);

#region جزء النسخ
//Create one DeliveryAddress value, copy it into a second variable, modify the copy, and print both values to prove that
//the original did not change.
// تم حل ا لسؤال فوق 
#endregion
#endregion