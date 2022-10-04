// Пример работы зубчатого массива
string[][] activeDebuffs = new string [4][];
activeDebuffs[0] = new string [3];
activeDebuffs[1] = new string [0];
activeDebuffs[2] = new string [2];
activeDebuffs[3] = new string [1];

activeDebuffs[0][0] = "Чудовищние отравление";
activeDebuffs[0][1] = "Сильные спазмы";
activeDebuffs[0][2] = "Ужасающий страх";

activeDebuffs[2][0] = "Легкое содрагание";
activeDebuffs[2][1] = "Сломанный щит";

activeDebuffs[3][0] = "Низкая самооценка";

string[] firstDebuffs = activeDebuffs[0];

for (int i =0; i < activeDebuffs.Length; i++)
{
    string[] debuffs = activeDebuffs[i];

    Console.WriteLine("\nУ пользователя {0} такие дебафы", i);
    foreach(string d in debuffs)
    {
        Console.WriteLine("{0} ", d);
    }
}