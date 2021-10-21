using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class DVD : Movie
    {
        public DVD(string Title, string Category, int Runtime, string Scenes) : base(Title, Category, Runtime, Scenes)
        {
            
        }
        public override void Play()
        {
            Blockbuster bb = new Blockbuster();

            Console.WriteLine($"Scene selection for {Title}:\n");
            bb.PrintScenes(SceneList);
            bool playDVD = true;
            while (playDVD)
            {
                try
                {
                    int userSelect = int.Parse(Console.ReadLine());
                    if (userSelect > 0 && userSelect < SceneList.Count)
                    {
                        Console.WriteLine($"Playing {Title} from scene {userSelect}: {SceneList[userSelect]}.  Runtime starting at {(Runtime / SceneList.Count) * (userSelect - 1)}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"That is not a valid scene for {Title}.  Please select a scene between 1 and {SceneList.Count}.");
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Please input a number from 1 to {SceneList.Count} to continue");
                    continue;
                }
            }
            
        }
    }
    

}
