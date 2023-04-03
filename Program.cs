using System;
using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        //Penélope Marques Verdi
        /*Aqui estamos criando as threads e chamando os metodos de teste*/
        Thread thread01 = new Thread(MensagemTesteThread1);
        Thread thread02 = new Thread(MensagemTesteThread2);
        Thread thread03 = new Thread(MensagemTesteThread3);

        /*Aqui estamos inicializando as threads*/
        thread01.Start();
        thread01.Join();
        thread02.Start();
        thread02.Join();
        thread03.Start();
        thread03.Join();

        Console.ReadKey();

        /*metodos de teste para checar a ordem de impressão da thread
        após executar várias vezes dá para perceber que a ordem de impressão da mensagem muda a cada execução
        e as threads se misturam
        para resolver isso, usamos o join que bloqueia a thread até que seja concluída*/
    }
    static void MensagemTesteThread1 ()
    {
        for (int i=0; i<=10; i++)
        {
            Console.WriteLine("1º teste de thread número: {0}", i);
            /*aqu o for imprimi uma mensagem de teste*/
        }
    }
    static void MensagemTesteThread2 ()
    {
        for (int i=0; i<=10; i++)
        {
            Console.WriteLine("2º teste de thread número: {0}", i);
            /*aqu o for imprime uma mensagem de teste*/
        }
    }
    static void MensagemTesteThread3 ()
    {
        for (int i=0; i<=10; i++)
        {
            Console.WriteLine("3º teste de thread número: {0}", i);
            /*aqu o for imprime uma mensagem de teste*/
        }
    }
}