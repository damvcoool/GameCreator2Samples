using System;
using UnityEngine.InputSystem;
using GameCreator.Runtime.Common;

namespace SimpleExtentions.Runtime.Common
{
    [Title("Sprint")]
    [Category("Usage/Sprint")]
    
    [Description("Cross-device support for the 'Sprint' input: Left Mouse Click or and the pressing L1 on most Gamepads")]
    [Image(typeof(IconCharacterRun), ColorTheme.Type.Purple)]

    [Serializable]
    public class InputButtonSprint : TInputButtonInputAction
    {
        // MEMBERS: -------------------------------------------------------------------------------

        [NonSerialized] private InputAction m_InputAction;
        
        // PROPERTIES: ----------------------------------------------------------------------------

        public override InputAction InputAction
        {
            get
            {
                if (this.m_InputAction == null)
                {
                    this.m_InputAction = new InputAction(
                        "Sprint",
                        InputActionType.Button
                    );

                    this.m_InputAction.AddBinding("<Keyboard>/leftShift");
                    this.m_InputAction.AddBinding("<Gamepad>/leftStickPress");
                }

                return this.m_InputAction;
            }
        }
        
        // PROTECTED OVERRIDE METHODS: ------------------------------------------------------------

        protected override void ExecuteEventStart(InputAction.CallbackContext context)
        {
            this.ExecuteEventStart();
        }

        protected override void ExecuteEventCancel(InputAction.CallbackContext context)
        {
            this.ExecuteEventCancel();
        }

        protected override void ExecuteEventPerform(InputAction.CallbackContext context)
        {
            this.ExecuteEventPerform();
        }

        // PUBLIC METHODS: ------------------------------------------------------------------------

        public static InputPropertyButton Create()
        {
            return new InputPropertyButton(
                new InputButtonSprint()
            );
        }
    }
}