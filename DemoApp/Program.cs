using Ksnm.Units.Japanese;
using Ksnm.Units;

{
    平成<int> h = 36;

    令和<int> r = (令和<int>)h;

    Console.WriteLine($"平成{h}=令和{r}");

}
{
    令和<int> r = 6;
    昭和<int> s = (昭和<int>)r;

    Console.WriteLine($"令和{r}って昭和{s}");
}
