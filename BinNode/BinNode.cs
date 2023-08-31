using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BinNode
{
    internal class BinNode<T>
    {
        private T Value;
        private BinNode<T> Left;
        private BinNode<T> Right;
        public BinNode(T value, BinNode<T> left = null, BinNode<T> right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
        public T GetValue() => Value;
        public BinNode<T> GetLeft() => Left;
        public BinNode<T> GetRight() => Right;
        public bool HasLeft() => Left != null;
        public bool HasRight() => Right != null;
        public void SetValue(T value) => Value = value;
        public void SetLeft(BinNode<T> left) => Left = left;
        public void SetRight(BinNode<T> right) => Right = right;

        public void RemoveNode(BinNode<T> p)
        {
            BinNode<T> node = this;
            if (p == node)
            {
                node = node.GetRight();
                node.SetLeft(null);
                p.SetRight(null);
            }
            else
            {
                BinNode<T> leftP = p.GetLeft();
                BinNode<T> rightP = p.GetRight();
                leftP.SetRight(rightP);
                if (rightP != null)
                    rightP.SetLeft(leftP);
                p.ConnectNodes(null);
            }
        }
        public bool AddBinNode(BinNode<T> add, int index = -1)
        {
            BinNode<T> node = this;
            if (index < 0)
            {
                while (node.HasRight())// Defualt case = last index
                    node = node.GetRight();
                node.ConnectNodes(add);
                return true;
            }
            for (int i = 0; i < index && node.HasRight(); i++)
                node = node.GetRight();
            node.ConnectNodes(add);
            return true;
        }
        private void ConnectNodes(BinNode<T> node)
        {
            this.SetRight(node);
            node.SetLeft(this);
        }

        public void Insert(BinNode<double> node)
        {

        }
    }
}
