using System.ComponentModel;

class Police : Person{
    private string[] _weapons;
    public Police(string firstName, string lastName, int age, string[] weapons) :base(firstName, lastName, age)
    {
        _weapons = weapons;
    }

    public override string GetPersonInfo(){
        string weapons = "";
        foreach (string weapon in _weapons){
            weapons = $"{weapons}{weapon}, ";
        }
        return $"{weapons}{base.GetPersonInfo()}";
    }
}