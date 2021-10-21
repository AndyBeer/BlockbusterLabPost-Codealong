using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class VHS : Movie
    {
        public VHS(string Title, string Category, int Runtime, string Scenes) : base(Title, Category, Runtime, Scenes) { }
     
        public int CurrentTime { get; set; } = 0;
        public override void Play()
        {
            int sceneDivide = Runtime / SceneList.Count;
            
            for (int i = 0; i < SceneList.Count; i++)
            {
                Console.WriteLine($"{CurrentTime} mins: {SceneList[i]}\n");
                CurrentTime += sceneDivide;
            }

        }
        public void Rewind(VHS Title)
        {
            Title.CurrentTime = 0;
            Console.WriteLine("This tape is rewinding.  Current time reset to 0.");
        }
    }
    
}
