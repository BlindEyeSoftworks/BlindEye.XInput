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
    /// Specifies constants that represent a device's controller features.
    /// </summary>
    [System.Flags]
    public enum ControllerFeatures : ushort
    {
        /// <summary>
        /// Indicates the device supports force feedback functionality.
        /// <para>
        /// Note that these force-feedback features beyond rumble are not currently supported by
        /// through XInput API on Windows and can be found exclusively in the DirectInput API as
        /// well for the Windows.Gaming.Input namespace for developers targeting the Universal
        /// Windows Platform (UWP).
        /// </para>
        /// </summary>
        FFBSupport = 0x1,

        /// <summary>
        /// Indicates the device can be used wirelessly.
        /// </summary>
        Wireless = 0x2,

        /// <summary>
        /// Indicates the device has an integrated voice device.
        /// </summary>
        VoiceSupport = 0x4,

        /// <summary>
        /// Indicates the device supports plug-in-modules.
        /// <para>
        /// Note that plug-in modules like the text input device (TID) are not currently supported
        /// through the XInput API on Windows.
        /// </para>
        /// </summary>
        PMDSupport = 0x8,

        /// <summary>
        /// Indicates the device lacks menu navigation buttons (START, BACK, DPAD).
        /// </summary>
        NoNavigation = 0x10
    }
}
