﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeForBattle.Models
{
    public class Character
    {
        private int _characterId;
        private string _characterName;
        private string _characterDescription;
        private string _characterType;

        public int CharacterId { get => _characterId; set => _characterId = value; }
        public string CharacterName { get => _characterName; set => _characterName = value; }
        public string CharacterDescription { get => _characterDescription; set => _characterDescription = value; }
        public string CharacterType { get => _characterType; set => _characterType = value; }

        public Character()
        {

        }
    }
}
