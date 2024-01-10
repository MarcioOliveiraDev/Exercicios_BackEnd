Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;

if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
{
    Console.WriteLine("Dados Duplos! Você ganhou +2 de bônus!");
    total += 2;
}
if ((roll1 == roll2) && (roll2 == roll3) && (roll3 == roll1))
{
    Console.WriteLine("Dados Tripos! Você ganhou +6 de bônus!");
    total += 6;
}

Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {total}");
if(total>14){
    Console.WriteLine("Você ganhou!!!");
}
if(total<15){
    Console.WriteLine("Desculpe, Você Perdeu!!!");
}