using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStation.Model;

namespace ServiceStation.ListOf
{
    public delegate bool IsValidClient(Client client);
    public class ClientList<T> where T : Client
    {
        private readonly List<T> _list;
        public ClientList()
        {
            _list = new List<T>();
        }

        public void AddRange(IEnumerable<T> item)
        {
            _list.AddRange(item);
        }

        public List<T> Read()
        { 
            return _list.ToList();
        }

        public void RemoveInvalidClients(Predicate<Client> isValidCustomer)
        {
            foreach (var client in _list.ToList())
            {
                /*if (!isValidClient(client))
                {
                    _list.Remove(client);
                }*/
            }
        }
    }
}
