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
    /// Contains information about a keystroke.
    /// </summary>
    /// /// <remarks>
    /// <para>
    /// Future devices may return HID codes and virtual key values that are not supported on current
    /// devices, and are currently undefined. Applications should ignore these unexpected values.
    /// </para>
    /// <para>
    /// A virtual-key code is a byte value that represents a particular physical key on the keyboard,
    /// not the character or characters (possibly none) that the key can be mapped to based on
    /// keyboard state. The keyboard state at the time a virtual key is pressed modifies the
    /// character reported. For example, VK_4 might represent a "4" or a "$", depending on the state
    /// of the SHIFT key.
    /// </para>
    /// <para>
    /// A reported keyboard event includes the virtual key that caused the event, whether the key
    /// was pressed or released (or is repeating), and the state of the keyboard at the time of
    /// the event. The keyboard state includes information about whether any CTRL, ALT, or SHIFT
    /// keys are down.
    /// </para>
    /// <para>
    /// If the keyboard event represents a Unicode character (for example, pressing the "A" key),
    /// the Unicode member will contain that character. Otherwise, Unicode will contain the value
    /// zero.
    /// </para>
    /// </remarks>
    public readonly struct Keystroke
    {
        /// <summary>
        /// Gets a value indicating the virtual-key.
        /// </summary>
        public VirtualKeys VirtualKey { get; }

        /// <summary>
        /// This field is unused and the value is zero.
        /// </summary>
        public char Unicode { get; }

        /// <summary>
        /// Gets a value indicating the gamepad state at the time of the input event.
        /// </summary>
        public KeystrokeFlags Flags { get; }

        /// <summary>
        /// Gets a value indicating the index of the device associated with the keystroke.
        /// </summary>
        public byte UserIndex { get; }

        /// <summary>
        /// Gets a value indicating an HID code corresponding to the input.
        /// <para>
        /// If there is no corresponding HID code, this value is zero.
        /// </para>
        /// </summary>
        public byte HidCode { get; }
    }
}
