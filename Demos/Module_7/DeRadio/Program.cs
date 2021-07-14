using System;

namespace DeRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            RadioStation r538 = new RadioStation();

            r538.Subscribers += ViaEther;
            r538.Subscribers += ViaMail;
            r538.Subscribers += ViaMail;
            r538.Subscribers += ViaSMS;
            r538.Subscribers += ViaEther;
            r538.Subscribers += ViaMail;
            r538.Subscribers += ViaMail;
            r538.Subscribers += ViaSMS;
            r538.Subscribers += ViaEther;
            r538.Subscribers += ViaMail;
            r538.Subscribers += ViaMail;
            r538.Subscribers += ViaSMS;
            r538.Subscribers += ViaEther;
            r538.Subscribers += ViaMail;
            r538.Subscribers -= ViaMail;
            r538.Subscribers += ViaSMS;
            r538.Subscribers += ViaEther;
            r538.Subscribers += ViaMail;
            r538.Subscribers += ViaMail;
            r538.Subscribers += ViaSMS;


           // r538.Subscribers("Moewhahaha");

            r538.Broadcast();
        }

        static void ViaEther(string msg)
        {
            Console.WriteLine($"Via de ether: {msg}");
        }
        static void ViaMail(string msg)
        {
            Console.WriteLine($"Via de mail: {msg}");
        }
        static void ViaSMS(string msg)
        {
            Console.WriteLine($"Via de sms: {msg}");
        }
        static void ViaPostduif(string msg)
        {
            Console.WriteLine($"Via de postduif: {msg}");
        }
    }
}
