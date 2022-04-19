// Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше

int randomnumber = new Random().Next(1, 1000);
// Console.WriteLine(randomnumber); //Для проверка убрать слэш
Console.WriteLine("Я загадал число от 1 до 1000. Твоя задача угадать с 3 попыток. Погнали");
int number = Convert.ToInt32(Console.ReadLine());
Comparison(randomnumber, number);

void Comparison(int mynumber, int younumber)
{
    int count = 2;
    while(count >= 0)
    {
        if(mynumber == younumber)
        {
            Console.WriteLine("Поздравляю, ты угадал.");
            break;
        }
        else
        {
            if(count == 0)
            {
                Console.WriteLine("Увы ты проиграл. Число было: " + mynumber);
                break;
            }
            if(mynumber > younumber)
            {
                Console.WriteLine("Не верно. Загаданное число больше. У тебя осталось попыток: " + count);
                younumber = Convert.ToInt32(Console.ReadLine());
            }
            if(mynumber < younumber)
            {
                Console.WriteLine("Не верно. Загаданное число меньше. У тебя осталось попыток: " + count);
                Convert.ToInt32(Console.ReadLine());
            }
            count--;
        }
    }
}