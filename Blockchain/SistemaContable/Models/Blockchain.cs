using System;
using System.Collections.Generic;
using System.IO;
using Models;
using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;

namespace Models
{
    [Serializable]
    public class Blockchain
    {
        private List<Block> blocks = new List<Block>();
        private List<Seat> tempAccount = new List<Seat>();

        public List<Block> Blocks { get => blocks; set => blocks = value; }
        public List<Seat> _TempAccount { get => tempAccount; set => tempAccount = value; }

        public Blockchain()
        {
        }

        public Blockchain(List<Block> blocks, List<Seat> tempAccount)
        {
            Blocks = blocks;
            _TempAccount = tempAccount;
        }


    }
}