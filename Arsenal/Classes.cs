using System.Text.Json.Serialization;

public class Weapon{
    [JsonInclude]
    public string Name;
    [JsonInclude]
    public int DmgMin;
    [JsonInclude]
    public int DmgMax;

    public void Attack(Enemy enemy){
        Random gen = new();
        int dmg=gen.Next(DmgMin,DmgMax);
        enemy.Hp-=dmg;
        Console.WriteLine("You dealt "+dmg+" damage");
        Console.ReadLine();
    }

}

public class Enemy{
    public string Name;
    public int Hp;
}
