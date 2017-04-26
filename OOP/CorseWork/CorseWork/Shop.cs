using System.Collections.Generic;

namespace CorseWork
{
    public static class Shop
    {
        public static Dictionary<string,GardenComponent> Asortiment = new Dictionary<string, GardenComponent>();
        static Shop()
        {
            Asortiment.Add("Apple "+AppleTree.SORT.AMERICAN.ToString(), new AppleTree(AppleTree.SORT.AMERICAN));
            Asortiment.Add("Apple " + AppleTree.SORT.GOLDEN.ToString(), new AppleTree(AppleTree.SORT.GOLDEN));
            Asortiment.Add("Cherry " + CherryTree.SORT.CHINE.ToString(), new CherryTree(CherryTree.SORT.CHINE));
            Asortiment.Add("Cherry " + CherryTree.SORT.QEEN.ToString(), new CherryTree(CherryTree.SORT.QEEN));
            Asortiment.Add("Pear " + PearTree.SORT.GOLD.ToString(), new PearTree(PearTree.SORT.GOLD));
            Asortiment.Add("Pear " + PearTree.SORT.WILD.ToString(), new PearTree(PearTree.SORT.WILD));
            Asortiment.Add("Plum " + PlumTree.SORT.BIG.ToString(), new PlumTree(PlumTree.SORT.BIG));
            Asortiment.Add("Plum " + PlumTree.SORT.BLUE.ToString(), new PlumTree(PlumTree.SORT.BLUE));
            Asortiment.Add("Herbs 1", new Herbs(1));
            Asortiment.Add("Herbs 2", new Herbs(2));
        }
        public static GardenComponent bought(string tree)
        {            
            return (GardenComponent)Asortiment[tree].Clone();
        }
    }
}
