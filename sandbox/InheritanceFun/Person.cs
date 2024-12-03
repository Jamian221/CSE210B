abstract class Person 
{
    private string _firstName;
    private string _lastName;
    private int _age;

    public Person(string firstName, string lastName, int age){
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
    }
    protected string GetBaseInfo(){
        return $"{_firstName}, {_lastName}, {_age}";
    }

    public abstract string GetPersonInfo();
    public void SetPersonFirstName(string newFirstName){
        _firstName = newFirstName;
    }
}