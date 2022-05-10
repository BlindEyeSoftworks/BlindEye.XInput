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
    /// Contains information on a device's capabilities.
    /// </summary>
    public readonly struct Capabilities
    {
        /// <summary>
        /// Gets a value indicating the device's controller type.
        /// </summary>
        public ControllerType ControllerType { get; }

        /// <summary>
        /// Gets a value indicating the device's controller subtype.
        /// </summary>
        public ControllerSubtype ControllerSubtype { get; }

        /// <summary>
        /// Gets a value indicating the device's controller features.
        /// </summary>
        public ControllerFeatures Features { get; }

        /// <summary>
        /// Gets a <see cref="BlindEye.XInput.Gamepad"/> structure containing the device's
        /// available controller features and control resolutions.
        /// </summary>
        public Gamepad Gamepad { get; }

        /// <summary>
        /// Gets a <see cref="BlindEye.XInput.VibrationInformation"/> structure containing the
        /// device's available vibration functionality and resolutions.
        /// </summary>
        public VibrationInformation VibrationInformation { get; }
    }
}