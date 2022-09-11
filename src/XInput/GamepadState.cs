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
    public readonly struct GamepadState
    {
        /// <summary>
        /// Gets a value indicating the state packet number of the gamepad.
        /// <para>
        /// The packet number indicates whether there have been any changes in the state of the
        /// gamepad. If the number is the same in sequentially returned <see cref="GamepadState"/>
        /// structures, the gamepad state has not changed. This value is persistent and will not be
        /// purged upon terminating the process or disconnecting the device.
        /// </para>
        /// </summary>
        public uint PacketNumber { get; }

        /// <summary>
        /// Gets a <see cref="BlindEye.XInput.Gamepad"/> structure containing information on the
        /// state of the gamepad.
        /// </summary>
        public Gamepad Gamepad { get; }
    }
}
