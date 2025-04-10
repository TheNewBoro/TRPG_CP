using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanWarzone
{
    public static class Game
    {


        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;

        private static bool gameOver;


        public static void Run()
        {
            Start();
            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }

            End();
        }

        //게임 시작
        private static void Start()
        {
            // 게임 설정
            gameOver = false;

            // 씬 설정
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new Scene.TitleScene());

            curScene = sceneDic["Title"];
        }

        private static void End()
        {

        }
    }

}
