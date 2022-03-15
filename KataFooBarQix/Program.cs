using KataFooBarQix;

FooBarQixGenerator fooBarQixGenerator = new FooBarQixGenerator();

for (int i = 1; i <= 10; i++)
{
    Console.Write(fooBarQixGenerator.DetermineValueOf(i) + " ");
}