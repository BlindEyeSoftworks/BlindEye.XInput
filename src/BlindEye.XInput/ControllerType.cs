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
    /// Specifies constants that represent a controller's type.
    /// </summary>
    public enum ControllerType : byte
    {
        /// <summary>
        /// Indicates the controller device is unknown.
        /// </summary>
        Unknown = 0x0,

        /// <summary>
        /// Indicates the controller is a game controller.
        /// </summary>
        Gamepad = 0x1
    }
}
