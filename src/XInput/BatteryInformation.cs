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
    /// Contains information on a device's battery type and charge state.
    /// </summary>
    public readonly struct BatteryInformation
    {
        /// <summary>
        /// Gets a value indicating the device's battery type.
        /// </summary>
        public BatteryType BatteryType { get; }

        /// <summary>
        /// Gets a value indicating the device's battery charge level.
        /// </summary>
        public BatteryLevel BatteryLevel { get; }
    }
}
