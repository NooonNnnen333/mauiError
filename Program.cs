using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace lab3opt4;


static class Program
{
    static void OopProgramm(string[] args)
    {
        ManagementCompany company = new ManagementCompany();
        House h1 = new House("London", 10, 35);
        company.AddQuarters(h1);
        company.Print3one();
        
    }
}



public class Rations
{
    [XmlElement("type")]
    public string Type { get; set; }

    private int population; // Плотность
    public string adress { get; private set; }
    private int square;
    
    public Rations(string _adres, int _square)
    {
        adress = _adres;
        square = _square; // Для жилого - количество квартир, для нежилого - площадь 
    }

    public int Population
    {
        get => population;
        set { population = value; }
    }
}

public class House : Rations
{
    // Конструктор, который вызывает базовый конструктор rations
    public House(string _adres, int _squar, int kolichestvoKomnat) : base(_adres, _squar)
    {
        Population = Convert.ToInt32(_squar * kolichestvoKomnat * 1.3);
    }
}

public class OfficeBuilding : Rations
{
    
    public OfficeBuilding(string _adres, int _square) : base(_adres, _square)
    {
        Population = Convert.ToInt32(_square * 0.2);
    }
}

public class ManagementCompany
{
    private List<Rations> quarters;
    private int average; // Среднее значение



    public ManagementCompany()
    {
        quarters = new();
    }
    
    public void AddQuarters(Rations quarter)
    {
        quarters.Add(quarter);
        average = Averaging(quarters);
    }

    public void Sorted()
    {
        int quartersLength = quarters.Count;
        for (int i = 0; i < quartersLength - 1; i++)
        {
            for (int j = 0; j < quartersLength - i - 1; j++)
            {
                if (quarters[j].Population < quarters[j + 1].Population)
                    (quarters[j], quarters[j + 1]) = (quarters[j + 1], quarters[j]);
                
                else if (quarters[j].Population == quarters[j + 1].Population)
                {
                    if (quarters[j] is OfficeBuilding && quarters[j + 1] is House)
                    {
                        (quarters[j], quarters[j + 1]) = (quarters[j + 1], quarters[j]);
                    }
                }
            }
        }
    }

    public void Print3one()
    {
        int i = 0;
        while (i<3 && i == (quarters.Count - 1))
        {
            Console.WriteLine($"{quarters[i].adress} \t {quarters[i].Population}");
            i++;
        }
    }
    
    public void Print4last()
    {
        int i = 0;
        int n = quarters.Count;
        while (i < 4 && n - i != 0 )
        {
            Console.WriteLine($"{quarters[n-i].adress} \t {quarters[n-i].Population}");
            i++;
        }
    }

    private int Averaging(List<Rations> massive)
    {
        int result = 0;
        foreach (var i in massive)
        {
            result += i.Population;
        }
        return result/massive.Count;
    }



   
        
        
        

}
