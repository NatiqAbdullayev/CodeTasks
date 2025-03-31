namespace ZeroToHeroTasks_Part_1;

// Tapşırıq 19:
// Aşağıdaki funksionallıqlara sahib olan ATM proqramı yazılsın.
//     İstifadəçinin ilkin balansı müəyyən edilsin.
//     İstifadəçi balansı yoxlaya bilsin, vəsait əlavə edə bilsin, pul çıxara bilsin.
// (məbləğ mənfi olmamalı, çıxarılan məbləğ balansdan çox olmamalıdır və s. yoxlamalar aparın).
public class ATM
{
    private double balance;

    public ATM()
    {
        setBalance(0);
    }


    public void IncreaseBalance(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Artirilan balans 0 veya menfi ola bilmez !");
            return;
        }

        balance += amount;
        Console.WriteLine($"{amount} balansa yuklendi.Yeni balans {balance} AZN dir.");
    }

    public void DecreaseBalance(double amount)
    {
        if (balance < amount)
        {
            Console.WriteLine("Balansda kifayet qeder vesait yoxdur !");
            return;
        }

        balance -= amount;
        Console.WriteLine($"{amount} balansa yuklendi.Yeni balans {balance} AZN dir.");
    }

    public double getBalance()
    {
        return balance;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }
}