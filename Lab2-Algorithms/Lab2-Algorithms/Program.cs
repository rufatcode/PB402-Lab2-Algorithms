#region 0.Bir metodunuz olur int array qebul edir ve geriye arrayin daxilinde en böyük 2 ye ve 3 e bölunen ededi qaytarir.
/*
Console.WriteLine(TheBiggestNumber(new int[] {1,24,42,3,24,6,12,18,36,}));
int TheBiggestNumber(int[] arr)
{
    int max = 0;

    foreach (var item in arr)
    {
        if (item%6==0&&item>max)
        {
            max = item;
        }
    }
    return max;
}
*/
#endregion


#region  2.Verilmiş arrayda sade ededlerin cemini return eden method yazin.
/*
//Console.WriteLine(IsPrime(5));
Console.WriteLine(SumOfPrimeNumbers(new int[] {1,2,3,5,11,14,16}));

int SumOfPrimeNumbers(int[] arr)
{
    int sum = 0;
    
    foreach (var item in arr)
    {
        if (IsPrime(item))
        {
            sum += item;
        }



    }

    return sum;
}
bool IsPrime(int num)
{
    if (num<2)
    {
        return false;
    }
    for (int i = 2; i < num; i++)
    {
        if (num%i==0)
        {
            return false;
        }
    }

    return true ;
}
*/

#endregion


#region 2.1
/*

// 2.1)Bir metodunuz olur string tipindən 1 parametr qebul edir həmin stringin tersi ve düzü özünə bərabərdirsə true eks halda false qaytarır.

//Məs:”Salam”->”malaS” —>false
//          “Ana”=>”anA”--->false
//“ana”=>”ana”-->true


Console.WriteLine(IsPolindrom("123"));

bool IsPolindrom(string text)
{
    string reverseText = "";
    for (int i = text.Length-1; i >=0; i--)
    {
        reverseText += text[i];
    }
    return reverseText == text;
}

*/
#endregion


#region 2.2)bir metodunuz var int return edir ve method stringden parametr qebul edir ve hemin texdin icindeki boşluqlarin sayini mene qaytarir
/*
Console.WriteLine(SpacesCount("Salam necesen hardasan"));

int SpacesCount(string text)
{
    int count = 0;
    foreach (char item in text)
    {
        if (item==' ')
        {
            count++;
        }
    }
    return count;
}
*/
#endregion





#region 2.4)Bir metonuz var stringden text ve char dan element adinda 2 paramtr qebul edir və həmin char tipinden olan elementden textde neçe dene varsa həmin sayı mənə qaytarır.
/*
Console.WriteLine(ElementCountInText("salam necesen",'s'));

int ElementCountInText(string text,char element)
{
    int count = 0;

    foreach (char item in text)
    {
        if (item==element)
        {
            count++;
        }
    }

    return count;

}
*/

#endregion



#region 2.3)Bir metodunuz var int array qebud edir ve geriye arrayin içindəki cüt və müeəkkəb ededlərin cəminin onlarin sayina olan nisbətini geri qaytarır.
/*
Console.WriteLine(SumDividedCountComplex(new int[] {4,9,6,4}));

decimal SumDividedCountComplex(int[] arr)
{
    int sum = 0;
    int count = 0;

    foreach (var item in arr)
    {
        if (IsComplex(item)&&IsEven(item))
        {
            sum += item;
            count++;
        }
    }
    return (decimal)sum / (decimal)count;
}


bool IsEven(int n)
{
    return n % 2 == 0;
}

bool IsComplex(int n)
{
    if (n<2)
    {
        return false;
    }
    for (int i = 2; i < n; i++)
    {
        if (n%i==0)
        {
             return true;
        }
    }

    return false;
}
*/
#endregion



#region 2.5)bir methodum var int array qebul edir və arrayin içindəki ən böyük ədədlə ən kiçik ədədin fərqini geri qaytarır.
/*
Console.WriteLine(SumOfBiggesAndSmallest(new int[] {6,11,1,2,3,14,12,9,7}));
int SumOfBiggesAndSmallest(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    foreach (var item in arr)
    {
        if (max<item)
        {
            max = item;
        }
        if (min>item)
        {
            min = item;
        }
    }
    return max - min;
}


*/
#endregion



#region 2.6)Bir method var array qəbul edir və həmin Arrayin içindəki 5 ə bölünən ədələrin ədədi ortasını tapın.

/*
Console.WriteLine(DividedSumByCount(new int[] {1,2,3,5,15,20}));

decimal DividedSumByCount(int[]arr)
{
    decimal count = 0;
    decimal sum = 0;

    foreach (var item in arr)
    {
        if (item%5==0)
        {
            count++;
            sum += item;
        }
    }
    return sum / count;
}
*/
#endregion




#region 2.7)method 2 eded qebul edir parametr olaraq onlarin əkob unu tapin yəni bular qaliqsız bölən ən kiçik ədədi.
/*
Console.WriteLine(EKOB(4,5));

int EKOB(int a,int b)
{
    int max = a > b ? a : b;

    for (int i = max; i <= a*b; i++)
    {
        if (i%a==0&i%b==0)
        {
            return i;
        }
    }
    return a * b;
}
*/
#endregion


#region 2.8)method 2 eded qebul edir parametr olaraq onlarin əbob unu tapin yəni buların qaliqsız böldüyü ən böyük ədədi.
/*
Console.WriteLine(EBOB(1,3));
int EBOB(int a,int b)
{
    int ebob = 1;

    int min = a < b ? a : b;
    for (int i = 1; i <= min; i++)
    {
        if (a%i==0&&b%i==0)
        {
            ebob = i;
        }
    }
    return ebob;

}
*/

#endregion
