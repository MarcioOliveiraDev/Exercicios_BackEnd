Random dice = new Random();

int roll1 = 2; //dice.Next(1,7);
int roll2 =  3; //dice.Next(1,7);
int roll3 = 1; //dice.Next(1,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
{
    if ((roll1 == roll2) && (roll2 == roll3) )
    {
        Console.WriteLine("Dados Tripos! Você ganhou +6 de bônus!");
        total += 6;
    }
    else
    {
        Console.WriteLine("Dados Duplos! Você ganhou +2 de bônus!");
        total += 2;
    }
    
}


if(total>=15){
    Console.WriteLine("Você ganhou um carro!!!");
}
else if(total >= 10)
{
    Console.WriteLine("Você ganhou um Notebook!!!");
}
else if(total == 7)
{
    Console.WriteLine("Você ganhou um Jantar para dois!!!");
}
else
{
    Console.WriteLine("Você Perdeu!!!");
}