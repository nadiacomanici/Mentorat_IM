using System;
using System.Collections.Generic;
using System.Linq;

namespace IndexerSample_Army.Classes
{
    public class Army
    {
        private List<Soldier> _allSoldiers;
        private List<Officer> _allOfficers;
        private int nextId = 1;

        public Army()
        {
            _allOfficers = new List<Officer>();
            _allSoldiers = new List<Soldier>();
        }

        public Soldier EnrollSoldier(string firstName, string lastName)
        {
            var soldier = new Soldier(nextId++, firstName, lastName);
            _allSoldiers.Add(soldier);
            return soldier;
        }

        public Officer EnrollOfficer(string firstName, string lastName)
        {
            var officer = new Officer(nextId++, firstName, lastName);
            _allOfficers.Add(officer);
            return officer;
        }

        public EnrolledSoldier this[int id]
        {
            get
            {
                var soldier = _allSoldiers.SingleOrDefault(s => s.Id == id);
                if (soldier != null)
                {
                    return soldier;
                }

                var officer = _allOfficers.SingleOrDefault(s => s.Id == id);
                if (officer != null)
                {
                    return officer;
                }

                throw new ArgumentException("There is no enrolled soldier with that id.");
            }
        }

        public IEnumerable<EnrolledSoldier> this[string lastName]
        {
            get
            {
                var result = new List<EnrolledSoldier>();
                result.AddRange(_allSoldiers.Where(s => s.LastName.ToLower() == lastName.ToLower()));
                result.AddRange(_allOfficers.Where(s => s.LastName.ToLower() == lastName.ToLower()));
                return result;
            }
        }
    }
}
