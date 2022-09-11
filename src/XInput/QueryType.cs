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
