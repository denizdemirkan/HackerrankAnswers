kaprekarNumbers(1,99999);

static void kaprekarNumbers(int p, int q)
{
    bool isAny = false;
    for(long number = p; number<=q; number++)
    {
        int right;
        int left;

        string numString = (number*number).ToString();
        
        int howManyDigits = numString.Length;
        if(howManyDigits%2 == 1)
        {
            right = howManyDigits/2+1;
            left = howManyDigits/2;
        }
        else
        {
            right = howManyDigits/2;
            left = howManyDigits/2;
        }
        
        string leftPart = numString.Substring(0,left);
        string rightPart = numString.Substring(left);


        if(leftPart==""){
            leftPart="0";
        }
        if(rightPart==""){
            rightPart="0";
        }
        if(Convert.ToInt64(rightPart)+Convert.ToInt64(leftPart) == number)
        {
            isAny = true;
            Console.Write(number+ " ");
        }
    }
    if(!isAny)
    {
        Console.WriteLine("INVALID RANGE");
    }
}