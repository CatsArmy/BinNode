using GenericNode.Utills;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinNode
{
    internal class BintNode
    {
        BinNode<int> intNode; 
        public BintNode()
        {
            intNode = BuildList();
        }
        public BinNode<int> BuildList()
        {
            BinNode<int> duList = new BinNode<int>(InputHandler.instance.TryParseInt());
            BinNode<int> last = duList;
            while (InputHandler.instance.YesOrNoInput("Continue?"))
            {
                Console.WriteLine("Input a int value");
                BinNode<int> p = new BinNode<int>(InputHandler.instance.TryParseInt());
                last.SetRight(p);
                p.SetLeft(last);
            }
            return duList;
        }

    }
}
