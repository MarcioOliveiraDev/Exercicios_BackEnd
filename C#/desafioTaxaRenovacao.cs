Random random = new Random();
int daysUntilExpiration = 5; //random.Next(12);
int discountPercentage = 0;

// Your code goes here
if(daysUntilExpiration<=10)
{
    Console.WriteLine("Sua assinatura esta expirando");  
}
else if(daysUntilExpiration<=5)
{
    Console.WriteLine($"Sua assinatura expirará em {daysUntilExpiration} dias. \n Renove agora com {discountPercentage=10}% de desconto!");
}
else if(daysUntilExpiration)
{

}