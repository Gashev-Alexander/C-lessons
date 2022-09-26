string Text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нвшего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string Text, char oldValue, char nemValue)
{
    string result = String.Empty;

    int length = Text.Length;
    for (int i = 0; i < length; i++)
    {
        if (Text[i] == oldValue) result = result + $"{nemValue}";
        else result = result + $"{Text[i]}";
    }

    return result;

}

string newText = Replace(Text, ' ', '|');
Console.WriteLine(newText);