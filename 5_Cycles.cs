using System;

namespace Cycles {
    class Program {
        static void Main() {
            for (int i = 0; i < 10; i++) {
                /*
                Это цикл for, он будет выполняться пока не дойдет до определенного условия, к примеру здесь
                объявлен инкремент i int i = 0; это объявление инкремента, один проход цикла называется
                иттерация. int i = 0 означает что инкремент начинается с 0, то есть 0, 1, 2, 3 и т.д. i < 10
                означает что цикл будет выполнятся пока i не будет равна 10, включительно То есть в данном
                случае цикл выполнится 10 раз i++ Увеличивает инкремент i на 1 каждую иттерацию В итоге цикл
                выведет в консоль числа от 0 до 9
                */
                Console.WriteLine(i);
            }
            int x = 0;
            while (x <= 10) {
                /*
                По факту то же самое что и цикл for, однако имеет в себе лишь условие
                Увеличение инкремента пишется уже в самом цикле
                */
                Console.WriteLine(x);
                x++;
            }
            do {
                /*
                По факту тот же цикл while, но отличается тем что выполнится 1 раз 100%
                Пишется в такой форме do{цикл}условие
                */
                x++;
                Console.WriteLine(x);
            } while (x < 0);
        }
    }
}