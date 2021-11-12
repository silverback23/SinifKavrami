
class Ogrenci
{
    private string name; 

    public string Name 
    {
        get { return name; }
        set { name = value; }
    }
    
}
class Person
{
    private int age=0;
    public int Age
    {
        get { return age; }
        set {
            if (value > 0)
            age = value;
        }
    }
}
