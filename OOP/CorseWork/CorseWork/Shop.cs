using System;
using System.Collections.Generic;

namespace CorseWork
{
    public static class Shop
    {
        public static Dictionary<string,GardenComponent> Asortiment = new Dictionary<string, GardenComponent>();
        public static Dictionary<string, int> idSort = new Dictionary<string, int>();
        public static string[] names = new string[10];
        static Shop()
        {
            names[0] = "Apple " + AppleTree.SORT.AMERICAN.ToString();
            names[1] = "Apple " + AppleTree.SORT.GOLDEN.ToString();
            names[2] = "Cherry " + CherryTree.SORT.CHINE.ToString();
            names[3] = "Cherry " + CherryTree.SORT.QEEN.ToString();
            names[4] = "Pear " + PearTree.SORT.GOLD.ToString();
            names[5] = "Pear " + PearTree.SORT.WILD.ToString();
            names[6] = "Plum " + PlumTree.SORT.BIG.ToString();
            names[7] = "Plum " + PlumTree.SORT.BLUE.ToString();
            names[8] = "Herbs 1";
            names[9] = "Herbs 2";
            for (int i = 0; i < 10; i++)
                idSort.Add(names[i], i);
            SFML.System.Vector2f tmp = new SFML.System.Vector2f(0, 0);
            Asortiment.Add("Apple "+AppleTree.SORT.AMERICAN.ToString(), new AppleTree(AppleTree.SORT.AMERICAN, tmp));
            Asortiment.Add("Apple " + AppleTree.SORT.GOLDEN.ToString(), new AppleTree(AppleTree.SORT.GOLDEN, tmp));
            Asortiment.Add("Cherry " + CherryTree.SORT.CHINE.ToString(), new CherryTree(CherryTree.SORT.CHINE, tmp));
            Asortiment.Add("Cherry " + CherryTree.SORT.QEEN.ToString(), new CherryTree(CherryTree.SORT.QEEN, tmp));
            Asortiment.Add("Pear " + PearTree.SORT.GOLD.ToString(), new PearTree(PearTree.SORT.GOLD, tmp));
            Asortiment.Add("Pear " + PearTree.SORT.WILD.ToString(), new PearTree(PearTree.SORT.WILD, tmp));
            Asortiment.Add("Plum " + PlumTree.SORT.BIG.ToString(), new PlumTree(PlumTree.SORT.BIG, tmp));
            Asortiment.Add("Plum " + PlumTree.SORT.BLUE.ToString(), new PlumTree(PlumTree.SORT.BLUE, tmp));
            Asortiment.Add("Herbs 1", new Herbs(1, tmp));
            Asortiment.Add("Herbs 2", new Herbs(2, tmp));
            
        }
        public static GardenComponent bought(string tree)
        {
            return (GardenComponent)Asortiment[tree].Clone();

        }
    }
}
