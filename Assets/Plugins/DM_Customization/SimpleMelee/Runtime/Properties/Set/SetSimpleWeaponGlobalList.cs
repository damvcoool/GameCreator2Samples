using System;
using UnityEngine;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Variables;

namespace DM_Customization.Runtime.SimpleMelee
{
    [Title("Global List Variable")]
    [Category("Global List Variable")]
    
    [Description("Sets the Simple Weapon value on a Global List Variable")]
    [Image(typeof(IconListVariable), ColorTheme.Type.Teal, typeof(OverlayDot))]

    [Serializable] [HideLabelsInEditor]
    public class SetSimpleWeaponGlobalList : PropertyTypeSetSimpleWeapon
    {
        [SerializeField]
        protected FieldSetGlobalList m_Variable = new FieldSetGlobalList(SimpleMeleeWeaponValue.TYPE_ID);

        public override void Set(SimpleMeleeWeapon value, Args args) => this.m_Variable.Set(value);
        public override void Set(SimpleMeleeWeapon value, GameObject gameObject) => this.m_Variable.Set(value);

        public override SimpleMeleeWeapon Get(Args args) => this.m_Variable.Get() as SimpleMeleeWeapon;
        public override SimpleMeleeWeapon Get(GameObject gameObject) => this.m_Variable.Get() as SimpleMeleeWeapon;
        
        public static PropertySetSimpleWeapon Create => new PropertySetSimpleWeapon(
            new SetSimpleWeaponGlobalList()
        );
        
        public override string String => this.m_Variable.ToString();
    }
}