using System;
using static System.Console;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            MonsterHead();
            GhostBody();
            BugFeet();
        }

        BuildACreature(string head, string body, string feet)
        {
            switch (head)
            {

            }

        }

        static void GhostHead()
        {
            WriteLine("     ..-..");
            WriteLine("    ( o o )");
            WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            WriteLine("    |     |");
            WriteLine("    |     |");
            WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            WriteLine("    |     |");
            WriteLine("    |     |");
            WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            WriteLine("     /   \\");
            WriteLine("     \\. ./");
            WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            WriteLine("  --|  |  |--");
            WriteLine("  --|  |  |--");
            WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            WriteLine("     v   v");
            WriteLine("     *****");
        }

        static void MonsterHead()
        {
            WriteLine("     _____");
            WriteLine(" .-,;='';_),-.");
            WriteLine("  \\_\\(),()/_/");
            WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            WriteLine("   ,-/`~`\\-,___");
            WriteLine("  / /).:.('--._)");
            WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            WriteLine("    |  Y  |");
            WriteLine("   /   |   \\");
            WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
