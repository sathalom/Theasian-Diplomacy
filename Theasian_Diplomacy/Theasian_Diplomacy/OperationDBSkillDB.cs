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
    
    public partial class OperationDBSkillDB
    {
        public int OperationDBSkillDBID { get; set; }
        public int osOperationDBID { get; set; }
        public int osSkillDBID { get; set; }
    
        public virtual OperationDB OperationDB { get; set; }
        public virtual SkillDB SkillDB { get; set; }
    }
}
