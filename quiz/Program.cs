using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP4_NARAG__Part_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice, answer1, answer2, answer3, answer4, answer5;
            string zodiacsign, name, seescore;
            int score;

            Console.WriteLine("Do you know want to know info about your zodiac or do you want to take a quiz?");
            Console.WriteLine("A. Zodiac   B. Quiz");
            Console.Write("Answer: ");
            choice = char.Parse(Console.ReadLine());

            if (choice == 'a' || choice == 'A')
            {
                Console.Write($"What is your Zodiac Sign: ");
                zodiacsign = Console.ReadLine();
                Console.WriteLine();

                if (zodiacsign == "Aries" || zodiacsign == "aries")
                {
                    Console.WriteLine("FACTS");
                    Console.WriteLine("First sign of the Zodiac");
                    Console.WriteLine("Always up for a challenge");
                    Console.WriteLine();
                    Console.WriteLine("HOROSCOPE FOR TODAY");
                    Console.WriteLine("Daily Horoscope Prediction says, you are proficient in troubleshooting");
                    Console.WriteLine();
                    Console.WriteLine("Lucky Color: Red");
                    Console.WriteLine("Lucky Number: 5");
                    Console.WriteLine();
                    Console.WriteLine("SIGN COMPATIBILITY");
                    Console.WriteLine("Good: Aries, Libra");
                    Console.WriteLine("Neutral: Taurus, Virgo, Scorpio, Pisces");
                    Console.WriteLine("Bad: Cancer, Capricorn");
                }
                else if (zodiacsign == "Taurus" || zodiacsign == "taurus")
                {
                    Console.WriteLine("FACTS");
                    Console.WriteLine("likes to be left alone sometimes");
                    Console.WriteLine("one of the most grounded signs in the zodiac");
                    Console.WriteLine();
                    Console.WriteLine("HOROSCOPE FOR TODAY");
                    Console.WriteLine("Daily Horoscope Prediction says, you love sailing through tides");
                    Console.WriteLine();
                    Console.WriteLine("Lucky Color: Pink");
                    Console.WriteLine("Lucky Number: 6");
                    Console.WriteLine();
                    Console.WriteLine("SIGN COMPATIBILITY");
                    Console.WriteLine("Good: Taurus, Scorpio");
                    Console.WriteLine("Neutral: Aries, Gemini, Libra, Sagittarius");
                    Console.WriteLine("Bad: Leo, Aquarius");
                }
                else if (zodiacsign == "Gemini" || zodiacsign == "gemini")
                {
                    Console.WriteLine("FACTS");
                    Console.WriteLine("They're social butterflies! ");
                    Console.WriteLine("They're very genuine");
                    Console.WriteLine();
                    Console.WriteLine("HOROSCOPE FOR TODAY");
                    Console.WriteLine("Daily Horoscope Prediction says, Enjoy the day trouble-free");
                    Console.WriteLine();
                    Console.WriteLine("Lucky Color: Silver");
                    Console.WriteLine("Lucky Number: 7");
                    Console.WriteLine();
                    Console.WriteLine("SIGN COMPATIBILITY");
                    Console.WriteLine("Good: Gemini, Sagittarius");
                    Console.WriteLine("Neutral: Taurus, Cancer, Scorpio, Capricorn");
                    Console.WriteLine("Bad: Virgo, Pisces");
                }
                else if (zodiacsign == "Cancer" || zodiacsign == "cancer")
                {
                    Console.WriteLine("FACTS");
                    Console.WriteLine("Protective");
                    Console.WriteLine("Artistic");
                    Console.WriteLine();
                    Console.WriteLine("HOROSCOPE FOR TODAY");
                    Console.WriteLine("Daily Horoscope Prediction says, stand by your decision");
                    Console.WriteLine();
                    Console.WriteLine("Lucky Color: White");
                    Console.WriteLine("Lucky Number: 2");
                    Console.WriteLine();
                    Console.WriteLine("SIGN COMPATIBILITY");
                    Console.WriteLine("Good: Cancer, Capricorn");
                    Console.WriteLine("Neutral: Gemini, Leo, Sagittarius, Aquarius");
                    Console.WriteLine("Bad: Aries, Libra");
                }
                else if (zodiacsign == "Leo" || zodiacsign == "leo")
                {
                    Console.WriteLine("FACTS");
                    Console.WriteLine("Extremely Loyal");
                    Console.WriteLine("Self-concious");
                    Console.WriteLine();
                    Console.WriteLine("HOROSCOPE FOR TODAY");
                    Console.WriteLine("Daily Horoscope Prediction says, Hey, your life is your choice");
                    Console.WriteLine();
                    Console.WriteLine("Lucky Color: Golden");
                    Console.WriteLine("Lucky Number: 19");
                    Console.WriteLine();
                    Console.WriteLine("SIGN COMPATIBILITY");
                    Console.WriteLine("Good: Leo, Aquarius");
                    Console.WriteLine("Neutral: Cancer, Virgo, Capricorn, Pisces");
                    Console.WriteLine("Bad: Taurus, Scorpio");
                }
                else if (zodiacsign == "Virgo" || zodiacsign == "virgo")
                {
                    Console.WriteLine("FACTS");
                    Console.WriteLine("organized, analytical minds");
                    Console.WriteLine("curious people and have a natural gift for research");
                    Console.WriteLine();
                    Console.WriteLine("HOROSCOPE FOR TODAY");
                    Console.WriteLine("Daily Horoscope Prediction says, self-confidence is your key attribute");
                    Console.WriteLine();
                    Console.WriteLine("Lucky Color: Gray");
                    Console.WriteLine("Lucky Number: 7");
                    Console.WriteLine();
                    Console.WriteLine("SIGN COMPATIBILITY");
                    Console.WriteLine("Good: Virgo, Pisces");
                    Console.WriteLine("Neutral: Aries, Leo, Libra, Aquarius");
                    Console.WriteLine("Bad: Gemini, Sagittarius");
                }
                else if (zodiacsign == "Libra" || zodiacsign == "libra")
                {
                    Console.WriteLine("FACTS");
                    Console.WriteLine("nurturing and caring");
                    Console.WriteLine("always in search of balance, harmony and justice");
                    Console.WriteLine();
                    Console.WriteLine("HOROSCOPE FOR TODAY");
                    Console.WriteLine("Daily Horoscope Prediction says, You love troubles");
                    Console.WriteLine();
                    Console.WriteLine("Lucky Color: Brown");
                    Console.WriteLine("Lucky Number: 3");
                    Console.WriteLine();
                    Console.WriteLine("SIGN COMPATIBILITY");
                    Console.WriteLine("Good: Aries, Libra");
                    Console.WriteLine("Neutral: Taurus, Virgo, Scorpio, Pisces");
                    Console.WriteLine("Bad: Cancer, Capricorn");
                }
                else if (zodiacsign == "Scorpio" || zodiacsign == "scorpio")
                {
                    Console.WriteLine("FACTS");
                    Console.WriteLine("You find it hard to trust people and fall in love");
                    Console.WriteLine("one of the most intense and passionate signs");
                    Console.WriteLine();
                    Console.WriteLine("HOROSCOPE FOR TODAY");
                    Console.WriteLine("Daily Horoscope Prediction says, –You have a happy life today");
                    Console.WriteLine();
                    Console.WriteLine("Lucky Color: Purple, Black");
                    Console.WriteLine("Lucky Number: 4");
                    Console.WriteLine();
                    Console.WriteLine("SIGN COMPATIBILITY");
                    Console.WriteLine("Good: Taurus, Scorpio");
                    Console.WriteLine("Neutral: Aries, Gemini, Libra, Sagittarius");
                    Console.WriteLine("Bad: Leo, Aquarius");
                }
                else if (zodiacsign == "Sagittarius" || zodiacsign == "sagittarius")
                {
                    Console.WriteLine("FACTS");
                    Console.WriteLine("Impatient");
                    Console.WriteLine("Full of Energy");
                    Console.WriteLine();
                    Console.WriteLine("HOROSCOPE FOR TODAY");
                    Console.WriteLine("Daily Horoscope Prediction says, You love mysteries");
                    Console.WriteLine();
                    Console.WriteLine("Lucky Color: Light Blue");
                    Console.WriteLine("Lucky Number: 6");
                    Console.WriteLine();
                    Console.WriteLine("SIGN COMPATIBILITY");
                    Console.WriteLine("Good: Gemini, Sagittarius");
                    Console.WriteLine("Neutral: Taurus, Cancer, Scorpio, Capricorn");
                    Console.WriteLine("Bad: Virgo, Pisces");
                }
                else if (zodiacsign == "Capricorn" || zodiacsign == "capricorn")
                {
                    Console.WriteLine("FACTS");
                    Console.WriteLine("Ambitious");
                    Console.WriteLine("Conservative");
                    Console.WriteLine();
                    Console.WriteLine("HOROSCOPE FOR TODAY");
                    Console.WriteLine("Daily Horoscope Prediction says, capricorn will do heroic acts");
                    Console.WriteLine();
                    Console.WriteLine("Lucky Color: Grey");
                    Console.WriteLine("Lucky Number: 4");
                    Console.WriteLine();
                    Console.WriteLine("SIGN COMPATIBILITY");
                    Console.WriteLine("Good: Cancer, Capricorn");
                    Console.WriteLine("Neutral: Gemini, Leo, Sagittarius, Aquarius");
                    Console.WriteLine("Bad: Aries, Libra");
                }
                else if (zodiacsign == "Aquarius" || zodiacsign == "aquarius")
                {
                    Console.WriteLine("FACTS");
                    Console.WriteLine("Very easy-going");
                    Console.WriteLine("Very Emotional");
                    Console.WriteLine();
                    Console.WriteLine("HOROSCOPE FOR TODAY");
                    Console.WriteLine("Daily Horoscope Prediction says, Today is a Blank Slate, Write Your own Destiny!");
                    Console.WriteLine();
                    Console.WriteLine("Lucky Color: Navy Blue");
                    Console.WriteLine("Lucky Number: 22");
                    Console.WriteLine();
                    Console.WriteLine("SIGN COMPATIBILITY");
                    Console.WriteLine("Good: Leo, Aquarius");
                    Console.WriteLine("Neutral: Cancer, Virgo, Capricorn, Pisces");
                    Console.WriteLine("Bad: Taurus, Scorpio");
                }
                else if (zodiacsign == "Pisces" || zodiacsign == "pisces")
                {
                    Console.WriteLine("FACTS");
                    Console.WriteLine("Loves to Help others");
                    Console.WriteLine("Creative Geniuses");
                    Console.WriteLine();
                    Console.WriteLine("HOROSCOPE FOR TODAY");
                    Console.WriteLine("Daily Horoscope Prediction says, no challenge will pressure you");
                    Console.WriteLine();
                    Console.WriteLine("Lucky Color: Purple");
                    Console.WriteLine("Lucky Number: 11");
                    Console.WriteLine();
                    Console.WriteLine("SIGN COMPATIBILITY");
                    Console.WriteLine("Good: Virgo, Pisces");
                    Console.WriteLine("Neutral: Aries, Leo, Libra, Aquarius");
                    Console.WriteLine("Bad: Gemini, Sagittarius");
                }
                else
                {
                    Console.WriteLine("Unknown Zodiac Sign");
                }
            }
            else if (choice == 'B' || choice == 'b')
            {
                score = 0;
                Console.Write("What is your name: ");
                name = Console.ReadLine();

                Console.WriteLine("What is 8 times 9?");
                Console.WriteLine("A) 80   B) 72   C) 88   D) 64");
                Console.Write("Answer: ");
                answer1 = char.Parse(Console.ReadLine());


                if (answer1 == 'B' || answer1 == 'b')
                {
                    score++;
                }
                else if (answer1 == 'A' || answer1 == 'C' || answer1 == 'D' || answer1 == 'a' || answer1 == 'c' || answer1 == 'd')
                { 

                }
                else
                {
                    Console.WriteLine("Not one of the Choices");
                }

                Console.WriteLine("What is 13 times 6?");
                Console.WriteLine("A) 65   B) 52   C) 78   D) 91");
                Console.Write("Answer: ");
                answer2 = char.Parse(Console.ReadLine());

                if (answer2 == 'C' || answer2 == 'c')
                {
                    score++;
                }
                else if (answer2 == 'A' || answer2 == 'B' || answer2 == 'D' || answer2 == 'a' || answer2 == 'b' || answer2 == 'd')
                {
                    

                }
                else
                {
                    Console.WriteLine("Not one of the Choices");
                }

                Console.WriteLine("What is 8 plus 28?");
                Console.WriteLine("A) 36   B) 34   C) 46   D) 38");
                Console.Write("Answer: ");
                answer3 = char.Parse(Console.ReadLine());

                if (answer3 == 'A' || answer3 == 'a')
                {
                    score++;
                }
                else if (answer3 == 'B' || answer3 == 'b' || answer3 == 'C' || answer3 == 'c' || answer3 == 'D' || answer3 == 'd')
                {

                }
                else
                {
                    Console.WriteLine("Not one of the Choices");
                }

                Console.WriteLine("What is 144 divided by 12?");
                Console.WriteLine("A) 11   B) 12   C) 13   D) 14");
                Console.Write("Answer: ");
                answer4 = char.Parse(Console.ReadLine());

                if (answer4 == 'B' || answer4 == 'b')
                {
                    score++;
                }
                else if (answer4 == 'A' || answer4 == 'C' || answer4 == 'D' || answer4 == 'a' || answer4 == 'c' || answer4 == 'd')
                {
                    
                }
                else
                {
                    Console.WriteLine("Not one of the Choices");
                }

                Console.WriteLine("What is 36 times 12?");
                Console.WriteLine("A) 360   B) 396   C) 432   D) 436");
                Console.Write("Answer: ");
                answer5 = char.Parse(Console.ReadLine());

                if (answer5 == 'C' || answer5 == 'c')
                {
                    score++;
                }
                else if (answer5 == 'A' || answer5 == 'B' || answer5 == 'D' || answer5 == 'a' || answer5 == 'b' || answer5 == 'd')
                {

                }
                else
                {
                    Console.WriteLine("Not one of the Choices");
                }

                Console.Write("Do you want to see your score?: ");
                seescore = Console.ReadLine();

                if (seescore == "yes" || seescore == "YES" || seescore == "Yes")
                {
                    Console.WriteLine($"The score of {name} is {score}/5");
                }
                else if (seescore == "no" || seescore == "NO" || seescore == "No")
                {
                    Console.WriteLine("Thank you for answering the quiz");
                }
            }
            Console.ReadKey();
        }
    }
}
