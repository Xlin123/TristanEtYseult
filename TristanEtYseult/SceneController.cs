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
                            Console.WriteLine("Option A: Don't Help");//path 2, 1
                            Console.WriteLine("Option B: Help her!"); //path 1, 3
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
                            Console.WriteLine("Option C: Kill Ysuelt"); //path 4, 1
                            break;
                        case 6:
                            Console.WriteLine("Sixth Scene: Fight Number 2! \n");
                            //loadFightScene!
                            //win -> win!
                            //poisinneded -> path 1, 7
                            //lose - lose!
                            break;
                        case 7:
                            Console.WriteLine("Seventh Scene: Yseult is called \n");
                            Console.WriteLine("Option A: You die because your wife is a liar"); //normal ending
                            Console.WriteLine("Option B: Kill your wife and eat her"); //canibal ending
                            Console.WriteLine("Option C: Be a strong knight!"); //strong knight ending!
                            break;
                    }
                    break;


                //Oops didn't help Yseult.
                case 2:
                    switch (sceneNum)
                    {

                        case 1:
                            Console.WriteLine("Third Scene, Alternate ending: Didn't help Yseult \n");
                            Console.WriteLine("Option A: Lie to the king"); // fight ireland w or loss.... path 2, 2
                            Console.WriteLine("Option B: Apologize!"); //imprisioned 
                            break;
                        case 2:
                            Console.WriteLine("Fight Ireland!\n");
                            //fight
                            break;
                    }
                    break;


                //Sinner's path
                case 3:
                    switch(sceneNum)
                    {
                        case 1:
                            Console.WriteLine("Fourth Scene Alternate ending 2: Sinner. \n");
                            Console.WriteLine("Option A: Kill the king!"); // path 3, 2
                            Console.WriteLine("Option B: Apologize."); //killed by the king;\
                            break;
                        case 2:
                            Console.WriteLine("FIGHT THE KING!");
                            //win loss
                            break;
                     }
                    break;

                //Scardy Cat Win
                case 4:
                    Console.WriteLine("You ran away, good job");
                    break;

                //Cannibal Loss.
                case 5:
                    Console.WriteLine("Eat everyone and fight!");
                    break;
            }
        }
    }
}
