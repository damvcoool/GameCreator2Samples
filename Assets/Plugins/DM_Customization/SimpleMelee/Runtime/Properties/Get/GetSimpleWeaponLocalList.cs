using System;
using UnityEngine;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Variables;

namespace DM_Customization.Runtime.SimpleMelee
{
    [Title("Local List Variable")]
    [Category("Variables/Local List Variable")]
    
    [Image(typeof(IconListVariable), ColorTheme.Type.Teal)]
    [Description("Returns the SimpleMeleeWeapon value of a Local List Variable")]

    [Serializable] [HideLabelsInEditor]
    public class GetSimpleWeaponLocalList : PropertyTypeGetSimpleWeapon
    {
        [SerializeField]
        protected FieldGetLocalList m_Variable = new FieldGetLocalList(SimpleMeleeWeaponValue.TYPE_ID);

        public override SimpleMeleeWeapon Get(Args args) => this.m_Variable.Get<SimpleMeleeWeapon>();
        public override SimpleMeleeWeapon Get(GameObject gameObject) => this.m_Variable.Get<SimpleMeleeWeapon>();

        public override string String => this.m_Variable.ToString();
    }
}