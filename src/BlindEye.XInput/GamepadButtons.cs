/*==============================================================================
(c) 2022 BlindEye Softworks. All rights reserved.

This is free software, you can redistribute it and/or modify it under the terms
of the GNU GPL License v3.0 (GPLv3).

You should have received a copy of the GPLv3 license with this source code. If
not, visit https://www.gnu.org/licenses/gpl-3.0.en.html.

If you have any questions in regards to this license you may contact:
licensing@blindeyesoftworks.com
===============================================================================*/

namespace BlindEye.XInput
{
    /// <summary>
    /// Specifies constants that represent a device's gamepad buttons.
    /// </summary>
    [System.Flags]
    public enum GamepadButtons : ushort
    {
        /// <summary>
        /// Indicates no buttons.
        /// </summary>
        None = 0x0,

        /// <summary>
        /// Indicates the button is the up button on the directional-pad.
        /// </summary>
        PadUp = 0x1,

        /// <summary>
        /// Indicates the button is the down button on the directional-pad.
        /// </summary>
        PadDown = 0x2,

        /// <summary>
        /// Indicates the button is the left button on the directional-pad.
        /// </summary>
        PadLeft = 0x4,

        /// <summary>
        /// Indicates the button is the right button on the directional-pad.
        /// </summary>
        PadRight = 0x8,

        /// <summary>
        /// Indicates the button is the start button.
        /// </summary>
        Start = 0x10,

        /// <summary>
        /// Indicates the button is the back button.
        /// </summary>
        Back = 0x20,

        /// <summary>
        /// Indicates the button is the left thumb button.
        /// </summary>
        LeftThumb = 0x40,

        /// <summary>
        /// Indicates the button is the right thumb button.
        /// </summary>
        RightThumb = 0x80,

        /// <summary>
        /// Indicates the button is the left shoulder button.
        /// </summary>
        LeftShoulder = 0x100,

        /// <summary>
        /// Indicates the button is the right shoulder button.
        /// </summary>
        RightShoulder = 0x200,

        /// <summary>
        /// Indicates the button is the right shoulder button.
        /// </summary>
        Guide = 0x400,

        /// <summary>
        /// Indicates the button is the A button.
        /// </summary>
        A = 0x1000,

        /// <summary>
        /// Indicates the button is the B button.
        /// </summary>
        B = 0x2000,

        /// <summary>
        /// Indicates the button is the X button.
        /// </summary>
        X = 0x4000,

        /// <summary>
        /// Indicates the button is the Y button.
        /// </summary>
        Y = 0x8000
    }
}