/*==============================================================================
(c) 2022 BlindEye Softworks. All rights reserved.

This is free software, you can redistribute it and/or modify it under the terms
of the GNU GPL License v3.0 (GPLv3).

You should have received a copy of the GPLv3 license with this source code. If
not, visit https://www.gnu.org/licenses/gpl-3.0.en.html.

If you have any questions in regards to this license you may contact:
licensing@blindeyesoftworks.com
===============================================================================*/

using System.Runtime.InteropServices;

namespace BlindEye.XInput
{
    /// <summary>
    /// Static class containing several methods and constants for interacting with XInput devices.
    /// </summary>
    public static class XInput
    {
        /// <summary>
        /// Represents the maximum number of XInput device's that can be connected
        /// simultaneously.
        /// </summary>
        public const uint MaxUserCount = 4;

        /// <summary>
        /// Represents a value indicating any user.
        /// </summary>
        public const uint AnyUser = 0xFF;

        /// <summary>
        /// Represents the deadzone for a gamepad's left thumbstick.
        /// </summary>
        public const short LeftThumbDeadzone = 7849;

        /// <summary>
        /// Represents the deadzone for a gamepad's right thumbstick.
        /// </summary>
        public const short RightThumbDeadzone = 8689;

        /// <summary>
        /// Represents the threshold for a gamepad's triggers.
        /// </summary>
        public const byte TriggerThreshold = 30;

        private static bool inputEnabled;

        /// <summary>
        /// Gets or sets the reporting state of XInput.
        /// <para>
        /// If set to <see langword="false"/>, XInput will only return neutral data in response to
        /// calling <see cref="GetState(uint, ref GamepadState)"/> (all buttons up, thumbsticks
        /// centered, and triggers at 0) and will also stop all vibration effects currently
        /// playing. In addition, calls to <see cref="SendVibration(uint, ref Vibration)"/> will
        /// continue to be registered but not sent to the controller. Otherwise; if set to
        /// <see langword="true"/>, reading and writing functionality will be restored to normal
        /// and will also cause the last registered vibration request (even if it is 0) to be sent
        /// to the controller.
        /// </para>
        /// <para>
        /// This is meant to be used when an application gains or loses focus. Using this also
        /// negates the need to change the XInput query loop in your application as neutral data
        /// will always be returned if XInput is disabled.
        /// </para>
        /// </summary>
        public static bool Enabled
        {
            get { return inputEnabled; }
            set
            {
                inputEnabled = value;
                Enable(false); 
            }
        }

        /// <summary>
        /// Sends a vibration request to a connected device.
        /// </summary>
        /// <param name="userIndex">
        /// Index of the user's controller. Can be a value from 0 to
        /// <see cref="MaxUserCount"/> - 1.
        /// </param>
        /// <param name="vibration">
        /// Reference to a <see cref="Vibration"/> structure containing the vibration information
        /// to be sent with the request.
        /// </param>
        /// <returns>
        /// <para>
        /// A 32-bit unsigned integer with the value of ERROR_SUCCESS (0 = 0x0) if the method
        /// succeeds or ERROR_DEVICE_NOT_CONNECTED (1167 = 0x48F) if the specified controller
        /// is not connected. Otherwise; a
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/system-error-codes">
        /// System Error Code</see> defined in
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/winerror/">WinError.h
        /// </see>.
        /// </para>
        /// <para>
        /// This method does not use
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/errhandlingapi/nf-errhandlingapi-setlasterror">
        /// SetLastError</see> to set the calling thread's
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/last-error-code">
        /// Last-Error Code</see>.
        /// </para>
        /// </returns>
        [DllImport("XInput1_4", EntryPoint = "#3")]
        public static extern uint SendVibration(
            uint userIndex, ref Vibration vibration);

        /// <summary>
        /// Gets the capabilities and features of a specified controller.
        /// </summary>
        /// <param name="userIndex">
        /// Index of the user's controller. Can be a value from 0 to
        /// <see cref="MaxUserCount"/> - 1.
        /// </param>
        /// <param name="queryType">
        /// The controller <see cref="QueryType"/> to be included in the request.
        /// </param>
        /// <param name="capabilities">
        /// Reference to a <see cref="Capabilities"/> structure that should receive the
        /// specified device's controller capabilities from XInput once the request has been completed.
        /// </param>
        /// <remarks>
        /// The legacy XInput 9.1.0 version (included in Windows Vista and later) always returned a
        /// fixed set of capabilities regardless of the attached controller.
        /// </remarks>
        /// <returns>
        /// <para>
        /// A 32-bit unsigned integer with the value of ERROR_SUCCESS (0 = 0x0) if the method
        /// succeeds or ERROR_DEVICE_NOT_CONNECTED (1167 = 0x48F) if the specified controller
        /// is not connected. Otherwise; a
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/system-error-codes">
        /// System Error Code</see> defined in
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/winerror/">WinError.h
        /// </see>.
        /// </para>
        /// <para>
        /// This method does not use
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/errhandlingapi/nf-errhandlingapi-setlasterror">
        /// SetLastError</see> to set the calling thread's
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/last-error-code">
        /// Last-Error Code</see>.
        /// </para>
        /// </returns>
        [DllImport("XInput1_4", EntryPoint = "#4")]
        public static extern uint GetCapabilities(
            uint userIndex, QueryType queryType, ref Capabilities capabilities);

        /// <summary>
        /// Gets the battery type and charge status of a specified controller.
        /// </summary>
        /// <param name="userIndex">
        /// Index of the user's controller. Can be a value from 0 to
        /// <see cref="MaxUserCount"/> - 1.
        /// </param>
        /// <param name="deviceType">
        /// The <see cref="DeviceType"/> associated with <paramref name="userIndex"/> in which
        /// should be queried.
        /// </param>
        /// <param name="batteryInformation">
        /// Reference to a <see cref="BatteryInformation"/> structure that should receive the
        /// specified device's battery information from XInput once the request has been completed.
        /// </param>
        /// <returns>
        /// <para>
        /// A 32-bit unsigned integer with the value of ERROR_SUCCESS (0 = 0x0) if the method
        /// succeeds or ERROR_DEVICE_NOT_CONNECTED (1167 = 0x48F) if the specified controller
        /// is not connected. Otherwise; a
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/system-error-codes">
        /// System Error Code</see> defined in
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/winerror/">WinError.h
        /// </see>.
        /// </para>
        /// <para>
        /// This method does not use
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/errhandlingapi/nf-errhandlingapi-setlasterror">
        /// SetLastError</see> to set the calling thread's
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/last-error-code">
        /// Last-Error Code</see>.
        /// </para>
        /// </returns>
        [DllImport("XInput1_4", EntryPoint = "#7")]
        public static extern uint GetBatteryInformation(
            uint userIndex, DeviceType deviceType, ref BatteryInformation batteryInformation);

        /// <summary>
        /// Gets a gamepad input event for a specified controller.
        /// </summary>
        /// <param name="userIndex">
        /// Index of the user's controller. Can be a value from 0 to
        /// <see cref="MaxUserCount"/> - 1, or <see cref="AnyUser"/> to fetch the next available
        /// input event from any user.
        /// </param>
        /// <param name="reserved">
        /// This parameter is reserved.
        /// </param>
        /// <param name="keystroke">
        /// A reference to a <see cref="Keystroke"/> structure that should receive the specified
        /// device's keystroke information from XInput once the request has been completed.
        /// </param>
        /// <remarks>
        /// Wireless controllers are not considered active upon system startup, and calls to any of
        /// the XInput methods before a wireless controller is made active return
        /// ERROR_DEVICE_NOT_CONNECTED (1167 = 0x48F). Developers shipping code for Xbox must
        /// examine the
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/system-error-codes">
        /// System Error Code</see> returned by applicable methods and be prepared to handle this
        /// condition. Wired controllers are automatically activated when they are inserted.
        /// Wireless controllers are activated when the user presses and holds either the START or
        /// Xbox Guide button to power on the controller.
        /// </remarks>
        /// <returns>
        /// <para>
        /// A 32-bit unsigned integer with the value of ERROR_SUCCESS (0 = 0x0) if the method
        /// succeeds, ERROR_DEVICE_NOT_CONNECTED (1167 = 0x48F) if the specified controller is
        /// not connected, or ERROR_EMPTY (4306 = 0x10D2) if no new keys have been pressed.
        /// Otherwise; a
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/system-error-codes">
        /// System Error Code</see> defined in
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/winerror/">WinError.h
        /// </see>.
        /// </para>
        /// <para>
        /// This method does not use
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/errhandlingapi/nf-errhandlingapi-setlasterror">
        /// SetLastError</see> to set the calling thread's
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/last-error-code">
        /// Last-Error Code</see>.
        /// </para>
        /// </returns>
        [DllImport("XInput1_4", EntryPoint = "#8")]
        public static extern uint GetKeystroke(
            uint userIndex, uint reserved, ref Keystroke keystroke);

        /// <summary>
        /// Gets the current state of a specified controller.
        /// </summary>
        /// <param name="userIndex">
        /// Index of the user's controller. Can be a value from 0 to
        /// <see cref="MaxUserCount"/> - 1.
        /// </param>
        /// <param name="gamepadState">
        /// Reference to a <see cref="GamepadState"/> structure that should receive the specified
        /// device's gamepad state information from XInput once the request has been completed.
        /// </param>
        /// <remarks>
        /// When this method is used to retrieve a controller's state, the left and right triggers
        /// are both reported separately. For legacy reasons, when DirectInput retrieves a
        /// controller's state, the two triggers share the same axis. The legacy behavior is
        /// noticeable in the current Game Device Control Panel, which uses DirectInput API for
        /// controller state.
        /// </remarks>
        /// <returns>
        /// <para>
        /// A 32-bit unsigned integer with the value of ERROR_SUCCESS (0 = 0x0) if the method
        /// succeeds or ERROR_DEVICE_NOT_CONNECTED (1167 = 0x48F) if the specified controller
        /// is not connected. Otherwise; a
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/system-error-codes">
        /// System Error Code</see> defined in
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/winerror/">WinError.h
        /// </see>.
        /// </para>
        /// <para>
        /// This method does not use
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/errhandlingapi/nf-errhandlingapi-setlasterror">
        /// SetLastError</see> to set the calling thread's
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/last-error-code">
        /// Last-Error Code</see>.
        /// </para>
        /// </returns>
        [DllImport("XInput1_4", EntryPoint = "#100")]
        public static extern uint GetState(uint userIndex, ref GamepadState gamepadState);

        /// <summary>
        /// Blocks the calling thread until the <see cref="GamepadButtons.Guide"/> button has
        /// been pressed. Useful for creating overlays or temporarily suspending the game-loop
        /// upon controller disconnection.
        /// </summary>
        /// <param name="userIndex">
        /// Index of the user's controller. Can be a value from 0 to
        /// <see cref="MaxUserCount"/> - 1.
        /// </param>
        /// <param name="reserved">
        /// This parameter is reserved for future uses.
        /// </param>
        /// <param name="deviceState">
        /// Reference to a <see cref="DeviceState"/> structure that should receive specified
        /// device's state information from XInput once the request has been completed.
        /// </param>
        /// <returns>
        /// <para>
        /// A 32-bit unsigned integer with the value of ERROR_SUCCESS (0 = 0x0) if the method
        /// succeeds or ERROR_DEVICE_NOT_CONNECTED (1167 = 0x48F) if the specified controller
        /// is not connected. Otherwise; a
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/system-error-codes">
        /// System Error Code</see> defined in
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/winerror/">WinError.h
        /// </see>.
        /// </para>
        /// <para>
        /// This method does not use
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/errhandlingapi/nf-errhandlingapi-setlasterror">
        /// SetLastError</see> to set the calling thread's
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/last-error-code">
        /// Last-Error Code</see>.
        /// </para>
        /// </returns>
        [DllImport("XInput1_4", EntryPoint = "#101")]
        public static extern uint WaitForGuideButton(
            uint userIndex, uint reserved, ref DeviceState deviceState);

        /// <summary>
        /// Promptly lifts the block on the calling thread that sent a
        /// <see cref="WaitForGuideButton(uint, uint, ref DeviceState)"/> request.
        /// </summary>
        /// <param name="userIndex">
        /// Index of the user's controller. Can be a value from 0 to
        /// <see cref="MaxUserCount"/> - 1.
        /// </param>
        /// <returns>
        /// <para>
        /// A 32-bit unsigned integer with the value of ERROR_SUCCESS (0 = 0x0) if the method
        /// succeeds or ERROR_DEVICE_NOT_CONNECTED (1167 = 0x48F) if the specified controller
        /// is not connected. Otherwise; a
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/system-error-codes">
        /// System Error Code</see> defined in
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/winerror/">WinError.h
        /// </see>.
        /// </para>
        /// <para>
        /// This method does not use
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/errhandlingapi/nf-errhandlingapi-setlasterror">
        /// SetLastError</see> to set the calling thread's
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/last-error-code">
        /// Last-Error Code</see>.
        /// </para>
        /// </returns>
        [DllImport("XInput1_4", EntryPoint = "#102")]
        public static extern uint CancelWaitForGuideButton(uint userIndex);

        /// <summary>
        /// Sends a request to power off a specified controller.
        /// </summary>
        /// <param name="userIndex">
        /// Index of the user's controller. Can be a value from 0 to
        /// <see cref="MaxUserCount"/> - 1.
        /// </param>
        /// <remarks>
        /// Calling this method for a wired controller will not disconnect or disable the
        /// controller and the response from XInput will report the operation as being
        /// completed successfully.
        /// </remarks>
        /// <returns>
        /// <para>
        /// A 32-bit unsigned integer with the value of ERROR_SUCCESS (0 = 0x0) if the method
        /// succeeds or ERROR_DEVICE_NOT_CONNECTED (1167 = 0x48F) if the specified controller
        /// is not connected. Otherwise; a
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/system-error-codes">
        /// System Error Code</see> defined in
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/winerror/">WinError.h
        /// </see>.
        /// </para>
        /// <para>
        /// This method does not use
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/errhandlingapi/nf-errhandlingapi-setlasterror">
        /// SetLastError</see> to set the calling thread's
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/last-error-code">
        /// Last-Error Code</see>.
        /// </para>
        /// </returns>
        [DllImport("XInput1_4", EntryPoint = "#103")]
        public static extern uint PowerOffController(uint userIndex);

        /// <summary>
        /// Gets the bus information of a specified controller.
        /// </summary>
        /// <param name="userIndex">
        /// Index of the user's controller. Can be a value from 0 to
        /// <see cref="MaxUserCount"/> - 1.
        /// </param>
        /// <param name="busInformation">
        /// Reference to a <see cref="BusInformation"/> structure that should receive the specified
        /// device's bus information from XInput once the request has been completed.
        /// </param>
        /// <remarks>
        /// The specified device's <see cref="DeviceInformation"/> must first be requested prior to
        /// calling this method, not doing so will trigger an invalid response from XInput.
        /// </remarks>
        /// <returns>
        /// <para>
        /// A 32-bit unsigned integer with the value of ERROR_SUCCESS (0 = 0x0) if the method
        /// succeeds or ERROR_DEVICE_NOT_CONNECTED (1167 = 0x48F) if the specified controller
        /// is not connected. Otherwise; a
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/system-error-codes">
        /// System Error Code</see> defined in
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/winerror/">WinError.h
        /// </see>.
        /// </para>
        /// <para>
        /// This method does not use
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/errhandlingapi/nf-errhandlingapi-setlasterror">
        /// SetLastError</see> to set the calling thread's
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/last-error-code">
        /// Last-Error Code</see>.
        /// </para>
        /// </returns>
        [DllImport("XInput1_4", EntryPoint = "#104")]
        public static extern uint GetBusInformation(
            uint userIndex, ref BusInformation busInformation);

        /// <summary>
        /// Gets the device information of a specified controller.
        /// </summary>
        /// <param name="reserved">
        /// This parameter is reserved for future uses.
        /// </param>
        /// <param name="userIndex">
        /// Index of the user's controller. Can be a value from 0 to
        /// <see cref="MaxUserCount"/> - 1.
        /// </param>
        /// <param name="queryType">
        /// The controller <see cref="QueryType"/> to be included in the request.
        /// </param>
        /// <param name="deviceInformation">
        /// Reference to a <see cref="DeviceInformation"/> structure that should receive the specified
        /// device's information from XInput once the request has been completed.
        /// </param>
        /// <returns>
        /// <para>
        /// A 32-bit unsigned integer with the value of ERROR_SUCCESS (0 = 0x0) if the method
        /// succeeds or ERROR_DEVICE_NOT_CONNECTED (1167 = 0x48F) if the specified controller
        /// is not connected. Otherwise; a
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/system-error-codes">
        /// System Error Code</see> defined in
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/winerror/">WinError.h
        /// </see>.
        /// </para>
        /// <para>
        /// This method does not use
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/api/errhandlingapi/nf-errhandlingapi-setlasterror">
        /// SetLastError</see> to set the calling thread's
        /// <see href="https://docs.microsoft.com/en-us/windows/win32/debug/last-error-code">
        /// Last-Error Code</see>.
        /// </para>
        /// </returns>
        [DllImport("XInput1_4", EntryPoint = "#108")]
        public static extern uint GetDeviceInformation(
            uint reserved, uint userIndex, QueryType queryType,
            ref DeviceInformation deviceInformation);

        [DllImport("XInput1_4", EntryPoint = "#5")]
        private static extern void Enable(bool enabled);
    }
}
