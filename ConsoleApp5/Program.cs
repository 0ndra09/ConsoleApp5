Console.Write("Zadejte délku cesty (v km): ");
double delkacesty = Convert.ToDouble(Console.ReadLine());

Console.Write("Zadejte spotřebu auta na 100 km (v l/100 km): ");
double spotřeba = Convert.ToDouble(Console.ReadLine());

Console.Write("Zadejte kapacitu nádrže (v litrech): ");
double kapacitanadrže = Convert.ToDouble(Console.ReadLine());

double celkempaliva = (delkacesty / 100) * spotřeba;

int stop = (int)(celkempaliva / kapacitanadrže);
if (celkempaliva % kapacitanadrže > 0) stop++;

double zastavka = celkempaliva % kapacitanadrže;
if (zastavka == 0) zastavka = kapacitanadrže;

Console.WriteLine("Celkem paliva potřebné na cestu: " + celkempaliva + " litrů");
Console.WriteLine("Počet zastávek na tankování: " + stop);