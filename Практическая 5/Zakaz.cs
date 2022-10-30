namespace Pract5
{
    internal class Zakaz
    {
        private List<Podpunkt> forms, sizes, vkuses, counts, glazures, decors;
        private Podpunkt? form, size, vkus, count, glazur, decor;

        public Zakaz()
        {
            forms = new List<Podpunkt>();
            Podpunkt form1 = new Podpunkt("Круг", 500);
            Podpunkt form2 = new Podpunkt("Квадрат", 550);
            Podpunkt form3 = new Podpunkt("Прямоугольник", 550);
            Podpunkt form4 = new Podpunkt("Сердце", 700);
            forms.Add(form1);
            forms.Add(form2);
            forms.Add(form3);
            forms.Add(form4);

            sizes = new List<Podpunkt>();
            Podpunkt size1 = new Podpunkt("Маленький", 1000);
            Podpunkt size2 = new Podpunkt("Обычный", 1200);
            Podpunkt size3 = new Podpunkt("Большой", 2000);
            sizes.Add(size1);
            sizes.Add(size2);
            sizes.Add(size3);

            vkuses = new List<Podpunkt>();
            Podpunkt vkus1 = new Podpunkt("Ванильный", 100);
            Podpunkt vkus2 = new Podpunkt("Шоколадный", 100);
            Podpunkt vkus3 = new Podpunkt("Карамельный", 150);
            Podpunkt vkus4 = new Podpunkt("Ягодный", 200);
            Podpunkt vkus5 = new Podpunkt("Кокосовый", 250);
            vkuses.Add(vkus1);
            vkuses.Add(vkus2);
            vkuses.Add(vkus3);
            vkuses.Add(vkus4);
            vkuses.Add(vkus5);

            counts = new List<Podpunkt>();
            Podpunkt count1 = new Podpunkt("1 корж", 200);
            Podpunkt count2 = new Podpunkt("2 коржа", 400);
            Podpunkt count3 = new Podpunkt("3 коржа", 600);
            Podpunkt count4 = new Podpunkt("4 коржа", 800);
            counts.Add(count1);
            counts.Add(count2);
            counts.Add(count3);
            counts.Add(count4);

            glazures = new List<Podpunkt>();
            Podpunkt glazur1 = new Podpunkt("Шоколад", 100);
            Podpunkt glazur2 = new Podpunkt("Крем", 100);
            Podpunkt glazur3 = new Podpunkt("Бизе", 150);
            Podpunkt glazur4 = new Podpunkt("Драже", 150);
            Podpunkt glazur5 = new Podpunkt("Ягоды", 200);
            glazures.Add(glazur1);
            glazures.Add(glazur2);
            glazures.Add(glazur3);
            glazures.Add(glazur4);
            glazures.Add(glazur5);

            decors = new List<Podpunkt>();
            Podpunkt decor1 = new Podpunkt("Свечи", 150);
            Podpunkt decor2 = new Podpunkt("Шоколадная надпись", 200);
            Podpunkt decor3 = new Podpunkt("Свежие ягоды", 450);
            decors.Add(decor1);
            decors.Add(decor2);
            decors.Add(decor3);
        }

        public void Create()
        {
            int position = 0;
            ConsoleKeyInfo key;
            bool sformirovan = false;
            while (!sformirovan)
            {
                ShowMainMenu(position);
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        position -= 1;
                        if (position < 0)
                        {
                            position = 6;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        position += 1;
                        if (position > 6)
                        {
                            position = 0;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (position == 6)
                        {
                            sformirovan = true;
                        }
                        else if (position == 0)
                        {
                            form = SelectPodpunct(forms);
                        }
                        else if (position == 1)
                        {
                            size = SelectPodpunct(sizes);
                        }
                        else if (position == 2)
                        {
                            vkus = SelectPodpunct(vkuses);
                        }
                        else if (position == 3)
                        {
                            count = SelectPodpunct(counts);
                        }
                        else if (position == 4)
                        {
                            glazur = SelectPodpunct(glazures);
                        }
                        else if (position == 5)
                        {
                            decor = SelectPodpunct(decors);
                        }
                        break;
                }
            }
            Console.Clear();
        }

        private void ShowMainMenu(int position)
        {
            Console.Clear();
            Console.WriteLine("Заказ тортов");
            Console.WriteLine("Соберите свой уникальный торт!");
            Console.WriteLine("-------------");
            Console.WriteLine("  Форма");
            Console.WriteLine("  Размер");
            Console.WriteLine("  Вкус");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Сформировать заказ");
            Console.WriteLine("");

            int price = Price();
            string info = Info();
            Console.WriteLine($"Цена: {price}");
            Console.WriteLine($"Ваш торт: {info}");

            Console.SetCursorPosition(0, position + 3);
            Console.WriteLine("->");
        }

        private Podpunkt? SelectPodpunct(List<Podpunkt> podpuncts)
        {
            int position = 0;
            ConsoleKeyInfo key;
            bool vibran = false;
            while (!vibran) {
                ShowPodpuncts(podpuncts, position);
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        position -= 1;
                        if (position < 0)
                        {
                            position = podpuncts.Count - 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        position += 1;
                        if (position > podpuncts.Count - 1)
                        {
                            position = 0;
                        }
                        break;
                    case ConsoleKey.Escape:
                        vibran = true;
                        break;
                    case ConsoleKey.Enter:
                        return podpuncts[position];
                }

                Console.Clear();
            }

            return null;
        }

        private void ShowPodpuncts(List<Podpunkt> podpuncts, int position)
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт");
            Console.WriteLine("-------------");
            foreach (Podpunkt podpunct in podpuncts)
            {
                Console.WriteLine($"  {podpunct.desc} - {podpunct.price}");
            }

            Console.SetCursorPosition(0, position + 3);
            Console.WriteLine("->");
        }

        public string Info()
        {
            string info = "";
            if (form != null)
            {
                info += $"{form.desc} - {form.price}";
            }
            if (size != null)
            {
                if (info != "")
                {
                    info += ", ";
                }
                info += $"{size.desc} - {size.price}";
            }
            if (vkus != null)
            {
                if (info != "")
                {
                    info += ", ";
                }
                info += $"{vkus.desc} - {vkus.price}";
            }
            if (count != null)
            {
                if (info != "")
                {
                    info += ", ";
                }
                info += $"{count.desc} - {count.price}";
            }
            if (glazur != null)
            {
                if (info != "")
                {
                    info += ", ";
                }
                info += $"{glazur.desc} - {glazur.price}";
            }
            if (decor != null)
            {
                if (info != "")
                {
                    info += ", ";
                }
                info += $"{decor.desc} - {decor.price}";
            }

            return info;
        }

        public int Price()
        {
            int price = 0;

            if (form != null)
            {
                price += form.price;
            }
            if (size != null)
            {
                price += size.price;
            }
            if (vkus != null)
            {
                price += vkus.price;
            }
            if (count != null)
            {
                price += count.price;
            }
            if (glazur != null)
            {
                price += glazur.price;
            }
            if (decor != null)
            {
                price += decor.price;
            }

            return price;
        }

        public void SaveToFile(string path)
        {
            DateTime date = DateTime.Now;
            string info = Info();
            int price = Price();
            string zakazTxt = $"Заказ от {date}:\n\tЗаказ: {info}\n\tЦена: {price}\n";
            File.AppendAllText(path, zakazTxt);
        }
    }
}
