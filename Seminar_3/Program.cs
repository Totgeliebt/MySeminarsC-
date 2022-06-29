
            int CheckPalindrom(int str)
            {
            int prov = 0;
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str.Substring(i, 1) != (str.Substring(str.Length - 1 - i, 1)))
                {
                    Console.WriteLine($"Число {str} не является палиндромом");
                    break;
                }
                else
                    prov = 1;
            }
            if (prov == 1) Console.WriteLine($"Число {str} является палиндромом");
            }

             Console.WriteLine("Введите число: ");
            string str = Convert.ToInt32(Console.ReadLine());