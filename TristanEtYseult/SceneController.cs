using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TristanEtYseult
{
    class SceneController
    {
        public void loadScene(int path, int sceneNum)
        {
            Console.WriteLine("\n \n \n"); //SCENE BUFFER
            switch(path)
            {
                default:
                    Console.WriteLine("null input in loadScene");
                    break;
                case 1:
                    switch (sceneNum)
                    {
                        case 1:
                            Console.WriteLine("First Scene: Fight the Dragon"); //path 1, 2
                            break;
                        case 2:
                            Console.WriteLine("Second Scene: Help Ysuelt \n ");
                            Console.WriteLine("Option A: Don't Help");//path 1, 3
                            Console.WriteLine("Option B: Help her!"); //path 2, 1
                            break;
                        case 3:
                            Console.WriteLine("Third Scene: Do you give into your temptations? \n");
                            Console.WriteLine("Option A: Yes!"); //path 3 , 1
                            Console.WriteLine("Option B: No, I am a good knight!"); //path 1, 4
                            break;
                        case 4:
                            Console.WriteLine("Fourth Scene: Tristan tries to exile, but rumors go around and the king is hunting him! \n");
                            Console.WriteLine("Option A: Talk to the king and convince him that the person is lying and nothing is going on!"); // game win!
                            Console.WriteLine("Option B: Run away with Yseult"); // path 1, 5
                            Console.WriteLine("Option C: Fight the king!!!"); //path fight scene
                            break;
                        case 5:
                            Console.WriteLine("Fifth Scene: In the cabin for years \n ");
                            Console.WriteLine("Option A: Be a good knight!"); //path 1, 6
                            Console.WriteLine("Option B: Sin everyday!"); //path dead
                            Console.WriteLine("Option C: Kill Ysuelt"); //path 
                            break;
                        case 6:
                            Console.WriteLine("Sixth Scene: Fight Number 2! \n");
                            //loadFightScene!
                            break;
                        case 7:
                            Console.WriteLine("Seventh Scene: Yseult is called \n");
                            Console.WriteLine("Option A: You die because your wife is a liar");
                            Console.WriteLine("Option B: Kill your wife and eat her");
                            Console.WriteLine("Option C: Be a strong knight!");
                            break;
                    }
                    break;
            }
        }
    }
}
