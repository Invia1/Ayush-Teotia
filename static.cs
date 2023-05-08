using System;
class example {
    static int count=0;
    static void notMain() {
        incrementcount();
        incrementcount();
        incrementcount();
        Console.WriteLine(count);
    }
    static void incrementcount(){
        count++;
    }
}