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
    /// Specifies constants that represent a device's battery type.
    /// </summary>
    public enum BatteryType : byte
    {
        /// <summary>
        /// Indicates the device is not connected. 
        /// </summary>
        Disconnected = 0x0,

        /// <summary>
        /// Indicates the device is a wired device and does not have a battery.
        /// </summary>
        Wired = 0x1,

        /// <summary>
        /// Indicates the device has an alkaline battery.
        /// </summary>
        Alkaline = 0x2,

        /// <summary>
        /// Indicates the device has a nickel metal hydride battery. 
        /// </summary>
        NIMH = 0x3,

        /// <summary>
        /// Indicates the device has an unknown battery type.
        /// </summary>
        Unknown = 0xFF
    }
}