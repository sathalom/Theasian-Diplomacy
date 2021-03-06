﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theasian_Diplomacy.GameLogic
{
    class Faction
    {
        #region variable
        private string factionName;
        private List<Character> members;
        private Character leader;
        private int gold;
        #endregion

        public Faction(string _factionName)
        {
            factionName = _factionName;
            members = new List<Character>();
            gold = 0;
        }

        #region general methods
        /// <summary>
        /// Adds a member to the list
        /// </summary>
        /// <param name="_newMember"> The member to add </param>
        /// <param name="_isNewLeader"> If the added member should be set as the new leader </param>
        public void addMember(Character _newMember, bool _isNewLeader = false)
        {
            members.Add(_newMember);

            if (_isNewLeader)
            {
                leader = _newMember;
            }
        }

        public override string ToString()
        {
            return factionName;
        }
        #endregion

        #region properties
        public string FactionName
        {
            get { return factionName; }
        }

        public List<Character> Members
        {
            get { return members; }
        }

        public Character Leader
        {
            get { return leader; }
        }

        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }
        #endregion
    }
}