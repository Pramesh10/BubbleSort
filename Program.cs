// See https://aka.ms/new-console-template for more information
using System;

//Descending  
int[] numberForDescending = { 89, 76, 45, 92, 67, 12, 99 };
bool flag = true;
int temp;
int numLength = numberForDescending.Length;


//largest to smallest
for (int i = 1; (i <= (numLength - 1)) && flag; i++)
{
    flag = false;
    for (int j = 0; j < (numLength - i -  1); j++)
    {
        if (numberForDescending[j + 1] > numberForDescending[j])
        {
            temp = numberForDescending[j];
            numberForDescending[j] = numberForDescending[j + 1];
            numberForDescending[j + 1] = temp;
            flag = true;
        }
    }
}


foreach (int num in numberForDescending)
{
    Console.Write("\t {0}", num);
}
Console.Read();

//Ascending  

int[] numberForAscending = { 89, 76, 45, 92, 67, 12, 99 };
flag = true;

int numberForAscendingLength = numberForAscending.Length;



//smallest to largest

for (int i = 0; (i <= numberForAscendingLength) && flag; i++)
{
    flag = false;

    for (int j = 0;  j < (numberForAscendingLength - i - 1);  j++)
    {
        if (numberForAscending[j+1] < numberForAscending[j])
        {
            temp = numberForAscending[j];
            numberForAscending[j] = numberForAscending[j + 1];
            numberForAscending[j + 1] = temp;
            flag = true;
        }

       

    }
}

// 89 76 45 92 67 12 99
// 76 89 45 92 67 12 99
// 76 45 89 92 67 12 99
// 76 45 89 67 92 12 99
// 76 45 89 67 12 92 99
// 76 45 89 67 12 92 99


// 45 76 89 67 12 92 99
// 45 76 89 67 12 92 99
// 45 76 67 89 12 92 99
// 45 76 67 12 89 92 99
// 45 76 67 12 89 92 99

// 45 76 67 12 89 92 99
// 45 67 76 12 89 92 99
// 45 67 12 76 89 92 99
// 45 67 12 76 89 92 99

// .................

foreach (int num in numberForAscending)
{
    Console.Write("\t {0}", num);
}

