//1. Получаем произвольное число
//Input num

int num = Convert.ToInt32(Console.ReadLine());


//2. Определить длину , кол-во циферек)
// get number length in digits
//2.1
int countOfDigits = 0;
int tmp = num;
while(tmp > 0)
{
    num /= 10;
    countOfDigits++;
}

//2.2
//countOfDigits = num.ToString().Length();

//3.  завести сам (создали) массив, с необходимым размером
// create array with required size

//int [] digits = new int [countOfDigits];
int [] digits;
digits = new int [countOfDigits];

//4. поместить цифры в массив.
// fill array digits

