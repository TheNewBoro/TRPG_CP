using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanWarzone.Scene
{
    public class TitleScene : BaseScene
    {
        private ConsoleKey input;
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
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            
        }

        public override void Result()
        {
            Game.ChangeScene("UnderGround");
        }
    }
}
