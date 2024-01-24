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
Console.WriteLine($"'o' appears {countOfO} times.");


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

int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;  
    case "02":
        type = "T-shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Others";
        break;
}
switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Brown";
        break;
    default:
        color = "White";
        break;
}
switch (product[2])
{
    case "S":
        size = "Small";
        break;   
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One size fit all";
        break;
}

/*if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");

string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}


for (int i = 1; i <= 100; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");   
}

Random random = new Random();
int current = 7;

do
{
    //current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);*/

//Random random = new Random();
//int current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);


while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

Random random = new Random();
int current;

do
{
    current = random.Next(1, 20);

    if (current >= 8)
    {
        Console.WriteLine("Opa");
    }
    else if (current <= 6)
    {
        Console.WriteLine("AAAAAAiiii");
    }

    Console.WriteLine(current);

} while (current != 7);

Random random = new Random();
int current = 8;//random.Next(1, 10);
int freq = 0;
do
{
    current = random.Next(1, 10);

    if (current == 8 || current == 9 || current == 5)
    {
        freq++;
        //continue;
    } 

    Console.WriteLine(current);
   
} while (current != 7);
Console.WriteLine($"A frequencia do numero 5, 8 ou 9 foi: {freq}");




Random random = new Random();
int  playerLife = 20, monsterLife = 20;

do
{
    int currentvalorDamage = random.Next(1,11);
    monsterLife -= currentvalorDamage;

    Console.WriteLine($"O monstro sofreu um dano de {currentvalorDamage} de vida e ficou com {monsterLife} de vida");
    
    if (monsterLife > 0)
    {
        currentvalorDamage = random.Next(1,11);
        playerLife -= currentvalorDamage;
        Console.WriteLine($"O player sofreu um dano de {currentvalorDamage} de vida e ficou com {playerLife} de vida");
    }

} while (playerLife > 0 && monsterLife > 0);
Console.WriteLine(playerLife > monsterLife? "Player Win": "Monster Win");

string? readResult;
bool validInt = false;
Console.WriteLine("Digite um número entre 5 e 10:");
do
{
    readResult = Console.ReadLine();
    if (int.TryParse(readResult, out int numericResult))
    {
        if (numericResult >= 5 && numericResult <= 10)
        {
            validInt = true;
            
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
    else {
        Console.WriteLine("Sua entrada não é um número válido, por favor, tente novamente.");
    }
} while (validInt == false);
Console.WriteLine($"O valor foi aceito corretamente!");

string userInput;
string acceptedRoles = "administrator manager user";

Console.WriteLine("Digite o nome da sua função (Administrador, Gerente ou Usuário):");

do
{
    userInput = Console.ReadLine().Trim().ToLower();

    if (acceptedRoles.Contains(userInput))
    {
        Console.WriteLine($"O valor de entrada ({userInput}) foi aceito.");
        break; // Sai do loop quando a entrada é válida.
    }
    else
    {
        Console.WriteLine($"O valor da entrada ({userInput}) não é válido. \nDigite novamente sua função (Administrador, Gerente ou Usuário):");
    }

} while (true); // O loop continua até que a entrada seja válida.
Console.WriteLine("O valor de entrada foi aceito com sucesso!");

string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();




string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();








string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}


string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal somaNumerico = 0m;
string concatenacao = "";
decimal numero;

foreach (var collection in values)
{
    
    if (decimal.TryParse(collection, out numero))
    {
        somaNumerico += numero;
    }
    else
    {
        concatenacao += collection;
    }
    
}
Console.WriteLine($"Soma numérica: {somaNumerico}");
Console.WriteLine($"Concatenação: {concatenacao}");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('I');


int closingPosition = message.LastIndexOf('m');

closingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));*/

//Qual será a saída do seguinte trecho de código?

int y = 5;
void PrintValue()
{
    int y = 10;
    Console.WriteLine(y);
}
PrintValue();






