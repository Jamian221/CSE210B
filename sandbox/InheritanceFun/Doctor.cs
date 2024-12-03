using System.ComponentModel;

class Doctor : Person{
    private string[] _tools;
    public Doctor(string firstName, string lastName, int age, string[] tools) :base(firstName, lastName, age)
    {
        _tools = tools;
    }

    public override string GetPersonInfo(){
        string tools = "";
        foreach (string tool in _tools){
            tools = $"{tools}{tool}, ";
        }
        return $"{tools}{base.GetPersonInfo()}";
    }
}