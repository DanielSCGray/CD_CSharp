class Attack
{
    public string Name;
    // public int Damage { get{return Damage;} set{if(value >= 5 && value <= 25) Damage = value;}}
    public int Damage {get;set;}

    public Attack(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }
}