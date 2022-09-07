
public class Program {

 public static Store Register(string n1,
  double number,
  string oname,
  double nValue) {
    return new Store(n1,
    number,
    oname,
    nValue);
 }

 public static void Main(string[] args) {

     string n1 = input.n1();
     double number = input.number();
     string oname  = input.oname();
     double nValue = input.nValue();
     Store storeinfo = Register(n1, number, oname, nValue);
     output.Info(storeinfo);
     Console.WriteLine("Press 1 to enter to Calculator Change Program ");
     double amount = double.Parse(Console.ReadLine()); 
    while (true) {
           Console.WriteLine("Please input money: ");

            if (!double .TryParse(Console.ReadLine(), out amount)) {
                Console.WriteLine("error input");
                Console.WriteLine("");
                continue;
                }
         break;
        }
     cal.monney(amount);

 }
 
}

