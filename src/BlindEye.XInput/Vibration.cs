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
    /// Contains properties for modifying a device's vibration state.
    /// </summary>
    public struct Vibration
    {
        /// <summary>
        /// Gets or sets a value indicating the device's left motor speed.
        /// </summary>
        public ushort LeftMotorSpeed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the device's right motor speed.
        /// </summary>
        public ushort RightMotorSpeed { get; set; }
    }
}
