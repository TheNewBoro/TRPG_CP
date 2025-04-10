using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanWarzone.Scene
{
    public class Underground : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("당신은 현재 지하철역에 있습니다.");
            Console.WriteLine("현재 서울의 지상은 온갖 무법자들과 그리고 군인들이 도사리며 살아남기 위해 서로 죽이고 약탈하는 대혼돈의 아수라장이 펼쳐져 있습니다.");
            Console.WriteLine("당신은 이곳 지하철역을 빠져나와 서울을 탈출해야 합니다.");
            Console.WriteLine("당신의 앞에는 3개의 통로가 보입니다.");
            Console.WriteLine("하나는 지하철의 바로 윗층으로 향하는 계단이 보입니다.");
            Console.WriteLine("두 번째로 깨진 스크린도어가 보입니다. 현재 지하철을 운용하지 않기에 통로를 지나갈 수 있을 것처럼 보입니다.");
            Console.WriteLine("마지막으로 아직은 작동하는 엘레베이터가 보입니다. 다만 조금 불안정해 보입니다.\n");
            Console.WriteLine("당신이 들어갈 통로를 정해주세요");
            Console.WriteLine("1. 계단, 2. 스크린 도어, 3.엘레베이터");
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
            switch(input)
                {
                case ConsoleKey.D1:

                }
        }
    }
}
