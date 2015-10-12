using System;
class BankAccountData
{
    static void Main(string[] args)
    {
        string firstName = "George";
        string lastName = "Washington";
        double availableBalanceOfMoney = 2965.23;
        string bankName = "Societe General";
        string IBAN = "BG4256525625321512";
        long creditCardNumber1 = 123456789012345;
        long creditCardNumber2 = 098765432198765;
        Console.WriteLine("Account holder name is:{0} {1}. \n Available balance is :{2}. \n Bank Name: {3}. \n IBAN : {4}. \n Credit Card Numbers :{5} , {6}", firstName, lastName, availableBalanceOfMoney, bankName, IBAN, creditCardNumber1, creditCardNumber2);

    }
}
