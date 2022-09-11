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
    /// Contains information on a device's capabilities and bus information.
    /// </summary>
    public readonly struct DeviceInformation
    {
        /// <summary>
        /// Gets a <see cref="BlindEye.XInput.Capabilities"/> structure containing information on
        /// the device's capabilities.
        /// </summary>
        public Capabilities Capabilities { get; }

        /// <summary>
        /// Gets a <see cref="BlindEye.XInput.BusInformation"/> structure containing bus
        /// information reported by the device's enumerator.
        /// </summary>
        public BusInformation BusInformation { get; }

        /// <summary>
        /// Gets a value indicating the instance ID reported by the device's enumerator.
        /// </summary>
        public uint InstanceID { get; }
    }
}
