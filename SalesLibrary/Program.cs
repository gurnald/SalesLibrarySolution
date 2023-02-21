
using SalesLib;

CustomersController custCtrl = new ("localhost" , "sqlexpress");

var customers = custCtrl.GetBySalesRange(20000 , 50000);
foreach(var cust in customers) {
    Console.WriteLine($" {cust.Id} | {cust.Name} | {cust.City}, | {cust.State} | {cust.Sales} | {cust.Active} ");
}

//var gurn = custCtrl.GetById(36);
//
//if(gurn is null) {
//    Console.WriteLine("Not Found!");
//    return;
//}
//
//gurn.Name = "DBS Certified Legend";
//
//var success = custCtrl.Update(gurn);
//
//if(!success) {
//    Console.WriteLine("Update Failed!");
//    return;
//}

//var newCustomer = new Customer {
//    Id = 0 ,
//    Name = "Gurn" ,
//    City = "Mason" ,
//    State = "OH" ,
//    Sales = 1000 ,
//    Active = true
//
//};
//
//var success = custCtrl.Add(newCustomer);
//if(!success) {
//    Console.WriteLine("Add Failed!");
//}

//var customers = custCtrl.GetAll();
//
//foreach(var customer in customers) {
//    Console.WriteLine(customer.Name);
//}

//var success = custCtrl.Delete(36);
//
//var cust = custCtrl.GetById(36);
//
//if (cust is null) {
//    Console.WriteLine("Not Found!");
//} else {
//    Console.WriteLine($" {cust.Id} | {cust.Name} | {cust.City}, | {cust.State} | {cust.Sales} | {cust.Active} ");
//}

custCtrl.CloseConnection();