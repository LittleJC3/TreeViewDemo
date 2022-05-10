using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewUtilitiesNamespace
{
    public class TreeViewUtilities
    {
        public static void Clear(TreeView tv)
        {
            tv.Nodes.Clear();
        }

        public static void Init(TreeView tv)
        {
            // Add 4 nodes to the TreeView control. 4 Indiana Basketball Players
            AddName(tv, "Calbert Cheaney");
            AddName(tv, "Damon Bailey");
            AddName(tv, "Eric Anderson");
            AddName(tv, "Lydon Jones");
        }

        public static void AddName(TreeView tv, String playerName)
        {
            foreach (TreeNode tn in tv.Nodes)
            {
                if (tn.Text == playerName) { return; } // This player name is already in the tree.  
            }
            tv.Nodes.Add(playerName);
        }

        public static void AddNumber(TreeView tv, String playerNumber)
        {
            tv.SelectedNode.Nodes.Add(playerNumber);
        }
    }
}
