using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscPhone discPhone = new DiscPhone();
            discPhone.Call();
            PushButtonPhone pushButtonPhone = new PushButtonPhone();
            pushButtonPhone.Call();
            BlackAndWhitePhone blackAndWhitePhone = new BlackAndWhitePhone();
            blackAndWhitePhone.Call();
            ColorScreenPhone colorScreenPhone = new ColorScreenPhone();
            colorScreenPhone.Call();
            IPhone iphone = new IPhone();
            iphone.Call();
            GoogleGlass googleGlass = new GoogleGlass();
            googleGlass.Call();

            Console.ReadKey();
        }
    }

    class DiscPhone
    {
        public string InputDevice { get; protected set; }
        public virtual void Call()
        {
            Console.WriteLine("Call you from DiscPhone");
        }
    }

    class PushButtonPhone : DiscPhone
    {
        public override void Call()
        {
            Console.WriteLine("Call you from Push-button phone");
        }

        public int Antenna { get; protected set; }
    }

    class BlackAndWhitePhone : PushButtonPhone
    {
        public override void Call()
        {
            Console.WriteLine("Call you from Black-White phone");
        }

        public int Screen { get; protected set; }
    }

    class ColorScreenPhone : BlackAndWhitePhone
    {
        public override void Call()
        {
            Console.WriteLine("Call you from Color screen phone");
        }

        public int Color { get; protected set; }
    }

    class IPhone : ColorScreenPhone
    {
        public override void Call()
        {
            Console.WriteLine("Call you from Iphone");
        }

        public string Apple { get; protected set; }
    }

    class GoogleGlass : IPhone
    {

        public override void Call()
        {
            Console.WriteLine("Call you from Google Glass");
        }

        public int Glass { get; protected set; }
    }
}
