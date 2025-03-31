namespace ZeroToHeroTasks_Part_1;

public class Tasks
{
    //Tapşırıq 1:
    // İki ədəd dəyişən yaradın və onların cəmini ekranda çap edən proqramı yazın.
    public void PrintVariable(int firstNum, int secondNum)
    {
        Console.WriteLine((firstNum + secondNum));
    }

    // Tapşırıq 2:
    // Bir dəyişəndə saxlanan ədədin kvadratını (özünə vurulmasını) ekranda çap edən proqramı yazın.
    public void PrintExponent(int a)
    {
        Console.WriteLine((a * a));
    }

    // Tapşırıq 3:
    // Adınızı və yaşınızı ayrı dəyişənlərdə saxlayın, sonra bunları aşağıdakı kimi çap edən proqramı yazın:
    // Salam, mənim adım Boss-dur və mənim 222 yaşım var.

    public void PrintNameAge(string name, byte age)
    {
        Console.WriteLine($"Hərkəsə salam.Mənim adım {name}-dir və mənim {age} yaşım var.");
    }

    // Tapşırıq 4:
    // İki dəyişəndə saxlanılan ədədlərin dəyərlərinin yerini dəyişin və ekrana aşağıdaki
    // kimi çap edən proqramı yazın (Üçüncü dəyişəndən əlavə etmək olar):
    //     a dəyişəninin əvvəlki dəyəri 10, yer dəyişmədən sonra 20-dir.
    //     b dəyişəninin əvvəlki dəyəri 20, yer dəyişmədən sonra 10-dur.

    //1 2
    public void ChangePlaceOfVars(int a, int b)
    {
        Console.WriteLine($"Daxil olunan dəyərlər: \n a:{a} \n b:{b} \n Yeni dəyərlər a:{b} \n b:{a} ");
    }

    public void ChangePlaceOfVars(int a, int b, int c)
    {
        Console.WriteLine($"Daxil olunan dəyərlər: \n a:{a} \n b:{b} c:{c} \n Yeni dəyərlər a:{b} \n b:{a} ");
    }

    // Tapşırıq 5:
    // Daxil edilən üç tam ədədin cəmi və ədədi ortasını hesablayıb çap edən proqramı yazın.
    public void NumbersSum(int a, int b, int c)
    {
        Console.WriteLine((a + b + c));
    }

    public void NumbersAvarage(int a, int b, int c)
    {
        Console.WriteLine((a + b + c) / 3);
    }

    // Tapşırıq 6:
    // İstifadəçidən daxil edilən dördrəqəmli ədədin rəqəmlərinin cəmini hesablayıb çap edən proqramı yazın.
    public void SumOfFourDegree()
    {
        // int number = Int32.Parse(Console.ReadLine());
        Console.Write("Ezyetden keçib 4 mertebeli eded daxil et:");
        string? number = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(number) || number.Length != 4)
        {
            Console.WriteLine("Eded 4 mertebeli olmalidir ay agilli !");
            return;
        }

        int a = int.Parse(number);
        Console.WriteLine($"Ededin reqemlerinin cemi : {(a / 1000) + ((a / 100) % 10) + ((a / 10) % 10) + (a % 10)}");
    }

    // Tapşırıq 7:
    // İstifadəçidən alınan ədədin cüt və ya tək olduğunu yoxlayan və çap edən proqramı yazın.
    public void TekCutCheck()
    {
        Console.Write("Eded daxil et:");
        string? number = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(number))
        {
            Console.WriteLine("Bos birsey daxil ede bilmersen !");
        }
        else
        {
            Console.WriteLine(int.Parse(number) % 2 == 0 ? "Daxil etdiyin eded cutdur" : "Daxil etdiyin eded tekdir");
        }
    }

    // Tapşırıq 8:
    // İstifadəçinin daxil etdiyi iki ədədi müqayisə edib, hansı ədədin böyük olduğunu çap edən proqram yazın.
    public void CompareNums()
    {
        Console.WriteLine("Ezyetden kecib day 2 eded daxil et zehmet olmasa :");
        string? num1 = Console.ReadLine();
        string? num2 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(num1) || string.IsNullOrWhiteSpace(num2))
        {
            Console.WriteLine("Qardawim bos deyer daxil eleme !");
        }
        else
        {
            switch (int.Parse(num1))
            {
                case var n when n > int.Parse(num2):
                    Console.WriteLine($"{num1} boyukdur");
                    break;
                case var n when n < int.Parse(num2):
                    Console.WriteLine($"{num2} boyukdur");
                    break;
                case var n when n == int.Parse(num2):
                    Console.WriteLine("her ikisi beraberdir");
                    break;
            }
        }
    }


    // Tapşırıq 9:
    // İstifadəçinin daxil etdiyi ədədin müsbət, mənfi və ya sıfır olduğunu yoxlayan və çap edən proqramı yazın.
    public void CheckMusbetMenfi()
    {
        Console.WriteLine("Eded daxil et :");
        string? num1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(num1))
        {
            Console.WriteLine("Qardawim bos deyer daxil eleme !");
            return;
        }

        switch (int.Parse(num1))
        {
            case var n when n > 0:
                Console.WriteLine($"{num1} musbetdir");
                break;
            case var n when n < 0:
                Console.WriteLine($"{num1} menfidir");
                break;
            case var n when n == 0:
                Console.WriteLine("sifira beraberdir");
                break;
        }
    }

    // Tapşırıq 10:
    // İstifadəçidən alınan ədədin həm 3-ə həm də 5-ə bölünüb-bölünmədiyini yoxlayan və çap edən proqramı yazın.
    public void ThreeAndFiveDiv()
    {
        Console.WriteLine("Eded daxil et :");
        string? num = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(num))
        {
            Console.WriteLine("Qardawim bos deyer daxil eleme !");
        }
        else
        {
            if (int.Parse(num) % 3 == 0 && int.Parse(num) % 5 == 0)
            {
                Console.WriteLine($"{num} 3 ve 5 e birlikte bolunur");
            }
            else
            {
                Console.WriteLine("her ikisine birden bolunmur");
            }
        }
    }

    // Tapşırıq 11:
    // İstifadəçinin daxil etdiyi ədədin 2-yə və ya 3-ə eyni zamanda bölünə bildiyini yoxlayan və çap edən proqramı yazın.

    public void TwoAndThreeDiv()
    {
        Console.WriteLine("Eded daxil et :");
        string? num = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(num))
        {
            Console.WriteLine("Qardawim bos deyer daxil eleme !");
        }
        else
        {
            if (int.Parse(num) % 3 == 0 && int.Parse(num) % 3 == 0)
            {
                Console.WriteLine($"{num} 2 ve 3 e birlikte bolunur");
            }
            else
            {
                Console.WriteLine("her ikisine birden bolunmur");
            }
        }
    }

    // Tapşırıq 12
    // İstifadəçi ayın nömrəsini daxil edir (1-12 arasında). Proqram həmin ayın adını ekrana yazdıran proqramı yazın.
    // (switch-case istifadə edin)

    public void NumberToMonth(int number)
    {
        string month;
        switch (number)
        {
            case 1:
                month = "Yanvar";
                break;
            case 2:
                month = "Fevral";
                break;
            case 3:
                month = "Mart";
                break;
            case 4:
                month = "Aprel";
                break;
            case 5:
                month = "May";
                break;
            case 6:
                month = "Iyun";
                break;
            case 7:
                month = "Iyul";
                break;
            case 8:
                month = "Avqust";
                break;
            case 9:
                month = "Sentyabr";
                break;
            case 10:
                month = "OKtyabr";
                break;
            case 11:
                month = "Noyabr";
                break;
            case 12:
                month = "Dekabr";
                break;
            default:
                month = "Brat bele ay hele ixtira olunmuyub !";
                break;
        }

        Console.WriteLine(month);
    }

    // Tapşırıq 13:
    // İstifadəçi daxil etdiyi bal əsasında qiymət çap edən proqramı yazın.(istənilən bal sistemi)
    public void Gpa(int value)
    {
        string result;
        switch (value)
        {
            case >= 0 and < 51:
                result = "Xeyir olsun kesildin";
                break;
            case >= 51 and < 60:
                result = "E alibsan";
                break;
            case >= 61 and < 70:
                result = "D alibsan";
                break;
            case >= 71 and < 80:
                result = "C alibsan";
                break;
            case >= 81 and < 90:
                result = "B alibsan";
                break;
            case >= 91 and <= 100:
                result = "A alibsan halaldi";
                break;
            default:
                result = "Bele GPA yoxdu !";
                break;
        }

        Console.WriteLine(result);
    }

    // Tapşırıq 14:
    // İstifadəçi iki ədəd və bir əməliyyat işarəsi daxil edir. Nəticəni hesablayan və çap edən proqramı yazın. (+, -, *, /)
    public void Calculate(int a, int b, string op)
    {
        switch (op)
        {
            case "+":
                Console.WriteLine($"{a} + {b} = {a + b}");
                break;
            case "-":
                Console.WriteLine($"{a} - {b} = {a - b}");
                break;
            case "*":
                Console.WriteLine($"{a} * {b} = {a * b}");
                break;
            case "/":
                Console.WriteLine($"{a} / {b} = {a / b}");
                break;
            default:
                Console.WriteLine("Operator sehv daxil edildi");
                break;
        }
    }

    // Tapşırıq 15: 
    // İstifadəçinin daxil etdiyi məbləğə əsasən endirim edən və aşağıdaki şəkildə nəticəni çap edən proqramı yazın.
    //
    //     Məbləğ 100 AZN və ya daha çoxdursa, 10% endirim.
    //
    //     Məbləğ 50-99 AZN arasında olsa, 5% endirim.
    //
    //     Məbləğ 50 AZN-dən aşağıdırsa, endirim yoxdur.
    //
    //     Endirimli qiymət: Alınan məhsulun dəyəri 120 AZN. Ödəyəcəyiniz məbləğ 108 AZN (10% endirim tətbiq edildi)    
    public void DiscountCalculator(int count)
    {
        switch (count)
        {
            case var n when n >= 100:
                Console.WriteLine(
                    $"{count} manata uygun olaraq hesablanacaq endirim 10%-dir : Yeni qiymet :{count * 10 / 100}");
                break;
            case var n when n >= 50 && n <= 100:
                Console.WriteLine(
                    $"{count} manata uygun olaraq hesablanacaq endirim 5%-dir : Yeni qiymet :{count * 5 / 100}");
                break;
            case var n when n >= 1 && n <= 50:
                Console.WriteLine($"Tesufki {count} manata uygun endirim hesablanmir");
                break;
            default:
                Console.WriteLine("Dogru qiymet daxil edilmedi");
                break;
        }
    }

    // Tapşırıq 16:
    // İstifadəçi adını və şifrəsini daxil edir. Əvvəldən təyin olunmuş istifadəçi adı və şifrəyə uyğun olarsa
    // girişə icazə verən
    // və nəticəni çap edən proqramı yazın.
    //Qeyd: əvvəlcədən istifadəçi adı "admin", şifrə "2222" olsun.
    public void LoginUser(string param1, string param2)
    {
        string username = "admin";
        string password = "2222";

        if (String.IsNullOrEmpty(param1) || String.IsNullOrEmpty(param2))
        {
            Console.WriteLine("Do not enter empty fields");
        }
        else if (!username.Equals(param1) || !password.Equals(param2))
        {
            Console.WriteLine("Wrong username or password");
        }
        else
        {
            Console.WriteLine("Login successful !");
        }
    }

    // Tapşırıq 17:
    // AZN-dən USD və ya USD-dən AZN-ə məzənnə çevrilməsi həyata keçirən və nəticəni çap edən proqram yazın.
    // (sabit məzənnə təyin edin).
    public void CurrencyCalculator(double value, string currency)
    {
        double toDollar = value / 1.70;
        double toManat = value * 1.70;
        switch (currency)
        {
            case var _ when currency.Equals("USD") || currency.Equals("usd"):
                Console.WriteLine($"{value} dollar :{toManat} manata beraberdir");
                break;
            case var _ when currency.Equals("azn") || currency.Equals("azn"):
                Console.WriteLine($"{value} manat : {toDollar} dollara beraberdir");
                break;
            default:
                Console.WriteLine("Duzgun deyer daxil et");
                break;
        }
    }

    // Tapşırıq 18: 
    // İstifadəçinin boyunu (metr ilə) və çəkisini (kg ilə) alıb BMI (Body Mass Index) hesablayın və nəticəyə uyğun olaraq aşağıdakı mesajlardan birini çap edən proqramı yazın:
    //
    // BMI Aralığı	Çap olunacaq məlumat
    // 0-18.5		Çəki azlığı
    // 18.5-24.9	Normal çəki
    // 25-29.9		Artıq çəki
    // 30 və daha çox	Piylənmə

    public void BmıCalculator(double weight, double height)
    {
        double bmiResult = weight / (height * height);

        switch (bmiResult)
        {
            case var _ when bmiResult > 0 && bmiResult < 19:
                Console.WriteLine("Cekin cox azdir,kokel");
                break;
            case var _ when bmiResult > 19 && bmiResult < 25:
                Console.WriteLine("Cekin normaldi");
                break;
            case var _ when bmiResult > 25 && bmiResult < 30:
                Console.WriteLine("Cekin cox artiqdi");
                break;
            case var _ when bmiResult > 30:
                Console.WriteLine("Cekin cox artiqdi piylenme gedir.");
                break;
            default:
                Console.WriteLine("Ceki veya boy yalnis daxil edildi !");
                break;
        }
    }

    // Tapşırıq 19:
    // Aşağıdaki funksionallıqlara sahib olan ATM proqramı yazılsın.
    //     İstifadəçinin ilkin balansı müəyyən edilsin.
    //     İstifadəçi balansı yoxlaya bilsin, vəsait əlavə edə bilsin, pul çıxara bilsin.
    // (məbləğ mənfi olmamalı, çıxarılan məbləğ balansdan çox olmamalıdır və s. yoxlamalar aparın).
    //Bu task ATM clasidir.

    // Tapşırıq 20:
    // Yaratmış olduğunuz massivin elementlərini ekrana çap edən proqram yazın.

    public void PrintIntArrayElems(params int[] arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }

    public void PrintIntArrayElems(params string[] arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }

    // Tapşırıq 21:
    // Yaratmış olduğunuz massivin bütün elementlərin cəmini hesablayıb nəticəni çap edən proqramı yazın.

    public void ArrayElemsSum(params int[] arr)
    {
        int total = 0;
        foreach (var item in arr)
        {
            total += item;
        }

        Console.WriteLine(total);
    }

    // Tapşırıq 23:
    // Yaratmış olduğunuz integer massivdə olan ən böyük və ən kiçik elementləri index-i ilə birgə çap edən proqramı yazın.

    public void CheckGreaterNumber(params int[] arr)
    {
        int boyuk = 0;
        int kicik = 0; //23  -23

        foreach (var item in arr)
        {
            if (item > boyuk)
            {
                boyuk = item;
                kicik = 0 - item;
            }

            if (0 - item <= kicik)
            {
                kicik = item;
            }
        }

        Console.WriteLine($"En boyuk element : {boyuk}\nEn kicik element : {kicik}");
    }

    // Tapşırıq 24:
    // Yaratmış olduğunuz integer massivdə olan cüt ədədləri çap edən proqramı yazın.

    public void CheckCutElements(params int[] arr)
    {
        Console.WriteLine("Cut elementler:");
        foreach (int item in arr)
        {
            if (item % 2 == 0)
            {
                Console.WriteLine(item);
            }
        }
    }

    // Tapşırıq 25:
    // Yaratmış olduğunuz massivdəki elementləri əks sıralama ilə yeni massivə əlavə edib nəticəni çap edən proqramı yazın.

    public void ReverseSameArray(params int[] arr)
    {
        int[] newArray = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            newArray[i] = arr[arr.Length - 1 - i];
            Console.WriteLine(newArray[i]);
        }
    }

    // Tapşırıq 26:
    // Massivdə konkret ədədin olub-olmadığını yoxlayan və indexini çap edən proqramı yazın.(yoxdursa -1)
    public void NumIsHave(int elem, params int[] arr)
    {
        foreach (int i in arr)
        {
            if (i == elem)
            {
                Console.WriteLine($"Bu element massive daxildir:{i}");
            }
        }
    }

    // Tapşırıq 27:
    // Massivdə təkrarlanan elementləri tapıb, nəticəni çap edən proqramı yazın.(bütün təkrarlanan ədədlər)

    public void CheckSameElementsIArray(params int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    Console.WriteLine($"{array[i]} elementi tekrarlanir");
                }
            }
        }
    }

    //Tapşırıq 28:
    // Massivdəki ikinci ən böyük elementi tapan və nəticəni çap edən proqramı yazın.

    public void CheckMaxNumber(params int[] arr)
    {
        int maxFirst = 0;
        int maxSecond = 0;
        foreach (int i in arr)
        {
            if (i > maxFirst)
            {
                maxSecond = maxFirst;
                maxFirst = i;
            }
        }

        Console.WriteLine($"Ilk en boyuk element : {maxFirst}\nIkinci en boyuk element : {maxSecond}");
    }

    // Tapşırıq 29:
    // Verilmiş N rəqəmli ədədin rəqəmləri cəmini tapan və nəticəni çap edən proqramı yazın.

    public void EdedinReqemlerininCemi(int number)
    {
        //123  
        Console.WriteLine($"{number / 100 + (number / 10) % 10 + number % 10}");
    }

    // Tapşırıq 30:
    // Verilmiş N rəqəmli ədədin rəqəmlərinin sayını tapan və nəticəni çap edən proqramı yazın.

    public void EdedinReqemlerininSayi(int number)
    {
        string str = number.ToString();
        if (number == 0)
        {
            Console.WriteLine($"0 reqeminde sadece istifade olunmusdur");
            return;
        }

        Console.WriteLine($"{number} ededindeki reqem sayi : {str.Length}");
    }

    // Tapşırıq 31:
    // Verilmiş N rəqəmli ədədin sadə və ya mürəkkəb olduğunu tapan və nəticəni çap edən proqramı yazın.

    public void SadeVeMurekkeb(int number)
    {
        //Max 2 boluneni olduqda sade
        int count = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        if (count == 2)
        {
            Console.WriteLine($"{number} bu eded sadedir");
        }
        else
        {
            Console.WriteLine($"{number} bu eded murekkebdir");
        }
    }

    // Tapşırıq 32:
    // Verilmiş N rəqəmli ədədin Palindrome olub-olmamasını yoxlayan və nəticəni çap edən proqramı yazın.
    //232  121  505

    public void CheckPolindrom(int number)
    {
        string str = number.ToString();
        int trueCount = 0;

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = str.Length - 1; j > i; j--)
            {
                // Console.WriteLine(str[i]);
                // Console.WriteLine(str[j]);
                if (str[i] == str[j])
                {
                    // Console.WriteLine(true);
                    trueCount++;
                    i++;
                }
                else break;
            }
        }

        if (str.Length == 3 && trueCount > 0 || str.Length > 3 && trueCount > 1)
        {
            Console.WriteLine($"{number} bu eded palindromdur");
        }
        else
        {
            Console.WriteLine($"{number} bu eded palindrom deyil");
        }
    }

    // Tapşırıq 33:
    // Fibonaçi ədədlərindən ilk N həddini tapan və çap edən proqramı yazın.

    public void Fibonacci(int number)
    {
        int i = 0;
        int firstNumber = 0;
        int secondNumber = 1;
        int nextNumber;
        Console.Write($"{firstNumber};{secondNumber};");
        while (i < number)
        {
            nextNumber = firstNumber + secondNumber;
            Console.Write($"{nextNumber};");
            firstNumber = secondNumber;
            secondNumber = nextNumber;
            i++;
        }
    }
}