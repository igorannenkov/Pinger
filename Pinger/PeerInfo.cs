using System;
using System.Drawing;
using System.Collections.Generic;

namespace Pinger
{
    class PeerInfo : IComparable<PeerInfo>
    {
        public string Name;
        public string IP;
        public string Comment;
        public Point Location;
        public PeerInfo(string Name, string IP, string Comment, Point Location)
        {
            this.Name = Name;
            this.IP = IP;
            this.Comment = Comment;
            this.Location = Location;
        }
        public override string ToString()
        {
            return Name + ";" + IP + ";" + Comment + ";" + Location.X + ";" + Location.Y ;
        }
        public int CompareTo(PeerInfo p)
        {
            if (p is null)
            {
                throw new ArgumentException("Некорректное значение параметра.");
            }
            return Name.CompareTo(p.Name);
        }

        public static bool HasDuplicate(List<PeerInfo> values, string name)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
