using System;
using System.Collections.Generic;

namespace Models
{
    public class Seat
    {
        private DateTime date;
        private String name;
        private List<Account> account = new List<Account>();
        private String hashSeat;

        public DateTime _Date { get => date; set => date = value; }
        public List<Account> _Account { get => account; set => account = value; }
        public string _Name { get => name; set => name = value; }
        public String _HashSeat { get => hashSeat; set => hashSeat = Miner.CalculateHash(value); }

        public Seat(DateTime date, String name, List<Account> account)
        {
            _Date = date;
            _Name = name;
            _Account = account;
            _HashSeat = Miner.CalculateHash(name);
        }

        public Seat()
        {
        }
    }
}