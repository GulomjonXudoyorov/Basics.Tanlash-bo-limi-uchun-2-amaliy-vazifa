//1st task

// Console.Write("Daqiqani kiriting: ");
// int minutes = Convert.ToInt32(Console.ReadLine());
// int hour = (minutes)/60;
// int minute = minutes%60;

// Console.WriteLine($"{hour}:{minute}");

//2nd task

// Console.Write("Yoshinggizni kiriting: ");
// int age = Convert.ToInt32(Console.ReadLine());

// if(age > 0 && age <= 12){
//     Console.WriteLine("Bola");
// }else if(age >= 13 && age <= 19){
//     Console.WriteLine("O'smir");
// }else if(age >= 20 && age <= 59 ){
//     Console.WriteLine("Kattalar");
// }else if(age >= 60){
//     Console.WriteLine("Katta");
// }

//3rd task

// Console.Write("Matematika 0 dan 100 gacha ball kiriting:");
// int math = Convert.ToInt32(Console.ReadLine());

// Console.Write("Fizika 0 dan 100 gacha ball kiriting:");
// int physics = Convert.ToInt32(Console.ReadLine());

// Console.Write("Ingiliz tili 0 dan 100 gacha ball kiriting:");
// int english = Convert.ToInt32(Console.ReadLine());

// int result = (math + physics + english)/3;

// Console.WriteLine($"O'rtacha ball: {result}");

// if(result >= 80 && result <= 100){
//     Console.WriteLine("A'lo");
// }else if(result >=60 && result <= 69){
//     Console.WriteLine("O'rtacha");
// }else if(result >=40 && result <=59){
//     Console.WriteLine("Qoniqarli");
// }else if(result < 40 ){
//     Console.WriteLine("Qoniqarsiz");
// }



  Random random = new Random();
        int sirliRaqam = random.Next(1, 101); 
        int taxmin = 0;

        Console.WriteLine("1 dan 100 gacha bo'lgan raqamni toping!");

        while (taxmin != sirliRaqam)
        {
            Console.Write("Raqamingizni kiriting: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out taxmin))
            {
                Console.WriteLine(taxmin < sirliRaqam 
                    ? "Katta!" 
                    : taxmin > sirliRaqam 
                        ? "Kichik!" 
                        : "Tabriklaymiz, topdingiz!");
            }
            else
            {
                Console.WriteLine("Iltimos, faqat raqam kiriting!");
            }
        }