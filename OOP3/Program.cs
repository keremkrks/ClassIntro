using System;
namespace OOP3
{
  class Program
    {

        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();        //interface referansı tutabilir                                                                                   //İhtiyacKrediManager yazsak da aynı IKrediManagerda.
            IKrediManager tasitKrediManager = new TasitKrediManager();           
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManagger();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { new DatabaseLoggerService(), new SmsLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}