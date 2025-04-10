using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanWarzone.Scene
{
    public class TitleScene : BaseScene
    {
        public override void Render()
        {
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("&&&&&&&&&&&&&                    &&&&&&&&&&&&&&&");
            Console.WriteLine("&&&&&&&&&&&&&                    &&&&&&&&&&&&&&&");
            Console.WriteLine("&&&&&&&&&&&&&      Seoul DMZ     &&&&&&&&&&&&&&&");
            Console.WriteLine("&&&&&&&&&&&&&                    &&&&&&&&&&&&&&&");
            Console.WriteLine("&&&&&&&&&&&&&                    &&&&&&&&&&&&&&&");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&\n");
            Console.WriteLine("Press Any key");
        }
        public override void Input()
        {
            Console.ReadKey(true);
        }

        public override void Update()
        {
            
        }

        public override void Result()
        {
            
        }
    }
}
