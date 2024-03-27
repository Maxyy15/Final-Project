using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Game
    {
        List<Area> areas = new List<Area>();
        Area currentArea;
        internal bool IsGameOver() => isFinished;
        static bool isFinished;
        static string nextArea = "";

        internal void Add(Area area)
        {
            areas.Add(area);
            if (currentArea == null)
            {
                currentArea = area;
            }
        }

        internal string CurrentAreaDescription => currentArea.CreateDescription();

        internal void ReceiveChoice(string choice)
        {
            currentArea.ReceiveChoice(choice);
            CheckTransition();
        }

        internal static void Transition<T>() where T : Area
        {
            nextArea = typeof(T).Name;
        }

        internal static void Finish()
        {
            isFinished = true;
        }

        internal void CheckTransition()
        {
            foreach (var area in areas)
            {
                if (area.GetType().Name == nextArea)
                {
                    nextArea = "";
                    currentArea = area;
                    break;
                }
            }
        }
    }
}
