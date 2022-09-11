/*==============================================================================
(c) 2022 BlindEye Softworks. All rights reserved.

This is free software, you can redistribute it and/or modify it under the terms
of the Blind License v1.0 (BLv1).

You should have received a copy of the BLv1 license with this source code. If
not, visit https://github.com/BlindEyeSoftworks/Blind-License-V1/blob/main/LICENSE.

If you have any questions in regards to this license you may contact:
licensing@blindeyesoftworks.com
===============================================================================*/

namespace BlindEye.XInput
{
    /// <summary>
    /// Contains information on a gamepad's state.
    /// </summary>
    public readonly struct Gamepad
    {
        /// <summary>
        /// Gets a value indicating all of the <see cref="GamepadButtons"/> activated on the
        /// gamepad.
        /// </summary>
        public GamepadButtons Buttons { get; }

        /// <summary>
        /// Gets a value indicating the position of the left trigger analog control.
        /// <para>
        /// Each of the trigger members is a signed value between 0 and 255 describing the
        /// position of the trigger. A value of 0 signifies at rest while a value of 255
        /// signifies fully depressed. The constant <see cref="XInput.TriggerThreshold"/> may be
        /// used as the value which the trigger must be greater than to register as pressed. This
        /// is optional, but often desirable.
        /// </para>
        /// </summary>
        public byte LeftTrigger { get; }

        /// <summary>
        /// Gets a value indicating the position of the right trigger analog control.
        /// <para>
        /// Each of the trigger members is a signed value between 0 and 255 describing the
        /// position of the trigger. A value of 0 signifies at rest while a value of 255
        /// signifies fully depressed. The constant <see cref="XInput.TriggerThreshold"/> may be
        /// used as the value which the trigger must be greater than to register as pressed. This
        /// is optional, but often desirable.
        /// </para>
        /// </summary>
        public byte RightTrigger { get; }

        /// <summary>
        /// Gets a value indicating the position of the left thumbstick on its x-axis.
        /// <para>
        /// Each of the thumbstick axis members is a signed value between -32,768 and 32,767
        /// describing the position of the thumbstick. Negative values signify down or to the left.
        /// Positive values signify up or to the right. The constants
        /// <see cref="XInput.LeftThumbDeadzone"/> or <see cref="XInput.RightThumbDeadzone"/> can
        /// be used as a positive and negative value to filter a thumbstick's input. This is
        /// optional, but highly recommended for certain controllers.
        /// </para>
        /// </summary>
        public short ThumbLX { get; }

        /// <summary>
        /// Gets a value indicating the position of the left thumbstick on its y-axis.
        /// <para>
        /// Each of the thumbstick axis members is a signed value between -32,768 and 32,767
        /// describing the position of the thumbstick. Negative values signify down or to the left.
        /// Positive values signify up or to the right. The constants
        /// <see cref="XInput.LeftThumbDeadzone"/> or <see cref="XInput.RightThumbDeadzone"/> can
        /// be used as a positive and negative value to filter a thumbstick's input. This is
        /// optional, but highly recommended for certain controllers.
        /// </para>
        /// </summary>
        public short ThumbLY { get; }

        /// <summary>
        /// Gets a value indicating the position of the right thumbstick on its x-axis.
        /// <para>
        /// Each of the thumbstick axis members is a signed value between -32,768 and 32,767
        /// describing the position of the thumbstick. Negative values signify down or to the left.
        /// Positive values signify up or to the right. The constants
        /// <see cref="XInput.LeftThumbDeadzone"/> or <see cref="XInput.RightThumbDeadzone"/> can
        /// be used as a positive and negative value to filter a thumbstick's input. This is
        /// optional, but highly recommended for certain controllers.
        /// </para>
        /// </summary>
        public short ThumbRX { get; }

        /// <summary>
        /// Gets a value indicating the position of the right thumbstick on its y-axis.
        /// <para>
        /// Each of the thumbstick axis members is a signed value between -32,768 and 32,767
        /// describing the position of the thumbstick. Negative values signify down or to the left.
        /// Positive values signify up or to the right. The constants
        /// <see cref="XInput.LeftThumbDeadzone"/> or <see cref="XInput.RightThumbDeadzone"/> can
        /// be used as a positive and negative value to filter a thumbstick's input. This is
        /// optional, but highly recommended for certain controllers.
        /// </para>
        /// </summary>
        public short ThumbRY { get; }
    }
}
