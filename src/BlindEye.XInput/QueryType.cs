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
    /// Specifies constants that represent query types.
    /// </summary>
    public enum QueryType : uint
    {
        /// <summary>
        /// Indicates that a query should not be limited.
        /// </summary>
        All = 0,

        /// <summary>
        /// Indicates that a query should be limited to gamepads.
        /// </summary>
        Gamepads = 1
    }
}