//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Theasian_Diplomacy
{
    using System;
    using System.Collections.Generic;
    
    public partial class CharacterDB
    {
        public CharacterDB()
        {
            this.AgentDB = new HashSet<AgentDB>();
            this.ArmyDB = new HashSet<ArmyDB>();
            this.CharacterDBLetterDB = new HashSet<CharacterDBLetterDB>();
            this.CharacterDBSkillDB = new HashSet<CharacterDBSkillDB>();
            this.FactionDB2 = new HashSet<FactionDB>();
            this.GoalDB = new HashSet<GoalDB>();
            this.LetterDB = new HashSet<LetterDB>();
            this.RelationDB = new HashSet<RelationDB>();
            this.RelationDB1 = new HashSet<RelationDB>();
        }
    
        public string firstName { get; set; }
        public Nullable<System.DateTime> birthDate { get; set; }
        public string sex { get; set; }
        public Nullable<int> charisma { get; set; }
        public int CharacterDBID { get; set; }
        public Nullable<int> honor { get; set; }
        public Nullable<int> cruelty { get; set; }
        public int cleaderFactionDBID { get; set; }
        public int cLocationDBID { get; set; }
        public Nullable<int> cArmyDBID { get; set; }
        public Nullable<int> cmemberFactionDBID { get; set; }
    
        public virtual ICollection<AgentDB> AgentDB { get; set; }
        public virtual ICollection<ArmyDB> ArmyDB { get; set; }
        public virtual ArmyDB ArmyDB1 { get; set; }
        public virtual ICollection<CharacterDBLetterDB> CharacterDBLetterDB { get; set; }
        public virtual FactionDB FactionDB { get; set; }
        public virtual LocationDB LocationDB { get; set; }
        public virtual FactionDB FactionDB1 { get; set; }
        public virtual ICollection<CharacterDBSkillDB> CharacterDBSkillDB { get; set; }
        public virtual ICollection<FactionDB> FactionDB2 { get; set; }
        public virtual ICollection<GoalDB> GoalDB { get; set; }
        public virtual ICollection<LetterDB> LetterDB { get; set; }
        public virtual ICollection<RelationDB> RelationDB { get; set; }
        public virtual ICollection<RelationDB> RelationDB1 { get; set; }
    }
}
