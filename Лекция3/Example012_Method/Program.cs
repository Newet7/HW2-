// вид 1

void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();

// вид 2

void Method2 (string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "текст сообщения");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    
    }
}
//Method2_1(msg: "текст без мсж", count: 3);

//ВИД 3

int Method3()
{
    return DateTime.Now.Year;

}
int year = Method3();
//Console.WriteLine(year);

// ВИД 4

//string Method4(int count, string text)
//{
//    int i = 0;
//    string result = String.Empty;
//    while(i<count)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}
//string res = Method4(10, "sos");
//Console.WriteLine(res);


string Method4(int count, string text)
{
    
    string result = String.Empty;
    for (int i = 0; i<count; i++)
    {
        result = result + text;
        
    }
    return result;
}
string res = Method4(10, "sos");
//Console.WriteLine(res);


// цикл в цикле

//for (int i=2; i <= 10; i++)
//{
//    for(int j=2; j <= 10; j++)
//    {
//        Console.WriteLine($"{i}*{j} = {i*j} ");
//    }
//    Console.WriteLine();
//}


//===========Работа с текстом

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             0123...
// s[3]  // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i=0; i<length; i++) 
    {
        if(text[i]==oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replace(newText, 'к', 'К');
//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replace(newText, 'с', 'С');
//Console.WriteLine(newText);


//алгорит сортировки методом выбора

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for ()
}