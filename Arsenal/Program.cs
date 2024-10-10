using System.Text.Json;

Enemy Dummie=new(){
    Name="Dummie",
    Hp=100
};

string textWeapon=File.ReadAllText("weapons.json");
List<Weapon> weapons=JsonSerializer.Deserialize<List<Weapon>>(textWeapon);


Console.WriteLine("Welcome to the practise range");
Console.WriteLine("Choose your weapon");
for (int i = 0; i < weapons.Count; i++){
    Console.WriteLine(i+": "+weapons[i].Name);
}

string resp=Console.ReadLine();
int weapon=int.Parse(resp);
while (Dummie.Hp>0){
    Console.WriteLine("How many times would you like to shoot the practise dummy?");
    resp=Console.ReadLine();
    int attacks=int.Parse(resp);

    Console.WriteLine("Alright, let's begin!");
    Console.ReadLine();
    Console.Clear();
    int attackNmb=1;
    while(Dummie.Hp>0&&attackNmb<attacks){
        Console.WriteLine("Attack "+attackNmb);
        Console.WriteLine("Dummies Health: "+Dummie.Hp);
        Console.WriteLine("Press ENTER to shoot");
        Console.ReadLine();
        weapons[weapon].Attack(Dummie);
        attackNmb++;
    }
    if(Dummie.Hp>0){
        Console.WriteLine("The dummie isn't dead yet");
        Console.ReadLine();
        Console.Clear();
    }
}
Console.WriteLine("The dummie is dead, good job");
Console.ReadLine();