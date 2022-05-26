using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace Pinger
{
    class PeerFileHandler
    {
       
        public static void SavePeers(List<PeerInfo> peers, string filename)
        {
            StreamWriter writer = new StreamWriter(filename, false, Encoding.UTF8);
            for (int i = 0; i < peers.Count; i++)
            {
                writer.WriteLine(peers[i].Name + ";" + peers[i].IP + ";" + peers[i].Comment + ";" + peers[i].Location.X.ToString() + ";" + peers[i].Location.Y.ToString());
            }

            writer.Close();
        }
        public static List<PeerInfo> ReadPeers(string filename)
        {
            List<PeerInfo> peers = new List<PeerInfo>();
            StreamReader reader = new StreamReader(filename);

            string temp = "";
            while (temp != null)
            {
                temp = reader.ReadLine();
                if (temp != null)
                {
                    string[] lines = temp.Split(';');
                    peers.Add(new PeerInfo(lines[0], lines[1], lines[2], new Point(int.Parse(lines[3]), int.Parse(lines[4]))));
                }
            }
            reader.Close();
            return peers;
        }
    }
}
