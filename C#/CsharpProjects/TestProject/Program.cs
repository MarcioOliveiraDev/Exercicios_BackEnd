/***Random dice = new Random();

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

Random random = new();
int daysUntilExpiration = 2; //random.Next(12);
int discountPercentage = 0;

// Your code goes here
if(daysUntilExpiration==0)
{
    Console.WriteLine("Sua assinatura expirou!");
}
else if(daysUntilExpiration==1)
{
    discountPercentage = 20;
    Console.WriteLine($"Sua assinatura expira hoje! \n Renove agora com {discountPercentage}%!");
}
else if(daysUntilExpiration<=5)
{
    discountPercentage = 10;
    Console.WriteLine($"Sua assinatura expirará em {daysUntilExpiration} dias. \n Renove agora com {discountPercentage}% de desconto!");
}
else if(daysUntilExpiration<=10)
{
    Console.WriteLine("Sua assinatura esta expirando");
}



if(daysUntilExpiration<=10)
{
    Console.WriteLine("Sua assinatura esta expirando");  
}
else if(daysUntilExpiration<=5)
{
    discountPercentage = 10;
    Console.WriteLine($"Sua assinatura expirará em {daysUntilExpiration} dias. \n Renove agora com {discountPercentage}% de desconto!");
}
else if(daysUntilExpiration==1)
{
    discountPercentage = 20;
    Console.WriteLine($"Sua assinatura expira hoje! \n Renove agora com {discountPercentage}%!");
}

//string[] fraudulentOrderIDs = new string[3];

//fraudulentOrderIDs[0] = "A123";
//fraudulentOrderIDs[1] = "B456";
//fraudulentOrderIDs[2] = "C789";
string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

string[] names = { "Rowena", "Robin", "Bao" };
int soma = 0;
foreach (string name in names)
{
    soma += name.Length;
    //Console.WriteLine(name.Length);
}
Console.WriteLine($"We have {soma} items in inventory.");

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int cont = 0;
foreach (int items in inventory)
{
    sum += items;
    cont++;
    Console.WriteLine($"Bin {cont} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

string[] transacoes = {"B123","C234","A345","C15","B177","G3003","C235","B179"};
int cont = 0;
foreach (string fraudes in transacoes)
{
    if (fraudes.StartsWith("B"))
    {
        Console.WriteLine($"{fraudes}");
        cont++;
    }
}
Console.WriteLine($"Houve um total de {cont} tentativas!");
Console.WriteLine(transacoes[2]);

string originalMessage = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = originalMessage.ToCharArray();
Array.Reverse(charMessage);
int countOfO = 0;

foreach (char character in charMessage) 
{ 
    if (character == 'o') 
    { 
        countOfO++; 
    } 
}

string reversedMessage = new String(charMessage);

Console.WriteLine(reversedMessage);
Console.WriteLine($"'o' appears {countOfO} times.");**/


// initialize variables - graded assignments
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
        
    else
        continue;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    // initialize/reset a counter for the number of assignment 
    int gradedAssignments = 0;

    // loop through the scores array and complete calculations for currentStudent
    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            // add the exam score to the sum
            sumAssignmentScores += score;

        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();