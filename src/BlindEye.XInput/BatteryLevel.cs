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
    /// Specifies constants that represent a device's battery charge level.
    /// </summary>
    public enum BatteryLevel
    {
        /// <summary>
        /// Indicates the battery has no charge.
        /// </summary>
        Empty = 0x0,

        /// <summary>
        /// Indicates the battery is holding a low charge.
        /// </summary>
        Low = 0x1,

        /// <summary>
        /// Indicates the battery is holding a medium charge.
        /// </summary>
        Medium = 0x2,

        /// <summary>
        /// Indiciates the battery is fully charged.
        /// </summary>
        Full = 0x3
    }
}