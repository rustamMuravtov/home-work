Console.Write("Введите число или символ 'q'");
int input = Console.ReadLine();

void StopQ(){
    while(true){
        if(input == "q" && input % 2 == 0){
            Console.Write("Stop");
            break;
        }
    }
}
 
int CheckValue(){
    int number = 0;
    if (int.TryParse(input, out number)){
        int sum = 0;
        while(number>0){
            sum += number % 10;
            number /= 10;
        }
        while(true)
        {
            if (sum % 2 == 0){
                Console.Write("Stop");
                break;
            }
        }
    }
    else{
        Console.Write("Введенные данные некоректны. Введите целое число для продолжения или q доля выхода");
    }
    return number;
}

StopQ();
CheckValue();