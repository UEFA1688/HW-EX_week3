    public class cal
    {
        public static double[] monney(double amount) 
        {  
            double [] money = {1000, 500, 100, 50, 20, 10, 5, 2, 1, .50, .25};
            int  i;
            double count;
            double[] ans = new double[11]; 

    for (i = 0; i <money.Length; i++)
            {
              count = amount / money[i];
              ans[i] = Math.Floor(count);
              Console.WriteLine(money[i]+" :"+ans[i]);
              amount %= money[i];


            }
             return  ans;   


    }
}