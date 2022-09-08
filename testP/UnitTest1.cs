namespace testP;

public class UnitTest1
{
    [Fact]
    public static void Test1()

    {     
        Store storeinfo = new Store("ร่ำรวยการค้า", 8348573, "นายค้าดี ร่ำรวย", 10000000);
                
    }

    [Fact]
    public static void test2()
    {

        double[] ans = { 1, 1, 1, 1, 0, 1, 1, 0, 0, 1, 1 };
        double[] casl = new double[11]; 
        casl = cal.monney(1665.75);
        Assert.Equal(casl, ans);
    }
}