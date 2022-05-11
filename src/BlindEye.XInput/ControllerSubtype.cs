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
    /// Specifies constants that represent a controller's subtype.
    /// </summary>
    public enum ControllerSubtype : byte
    {
        /// <summary>
        /// Indicates the subtype of the controller is unknown.
        /// </summary>
        Unknown = 0x0,

        /// <summary>
        /// Indicates the controller is a gamepad controller.
        /// <para>
        /// Includes Left and Right Sticks, Left and Right Triggers, Directional Pad, and all
        /// standard buttons (A, B, X, Y, START, BACK, LB, RB, LSB, RSB).
        /// </para>
        /// </summary>
        Gamepad = 0x1,

        /// <summary>
        /// Indicates the controller is a racing wheel controller.
        /// <para>
        /// Left Stick X reports the wheel rotation, Right Trigger is the acceleration pedal, and
        /// Left Trigger is the brake pedal. Includes Directional Pad and most standard buttons
        /// (A, B, X, Y, START, BACK, LB, RB). LSB and RSB are optional.
        /// </para>
        /// </summary>
        Wheel = 0x2,

        /// <summary>
        /// Indicates the controller is an arcade stick controller.
        /// <para>
        /// Includes a Digital Stick that reports as a DPAD (up, down, left, right), and most
        /// standard buttons (A, B, X, Y, START, BACK). The Left and Right Triggers are implemented
        /// as digital buttons and report either 0 or 0xFF. LB, LSB, RB, and RSB are optional.
        /// </para>
        /// </summary>
        ArcadeStick = 0x3,

        /// <summary>
        /// Indicates the controller is a flight stick controller.
        /// <para>
        /// Includes a pitch and roll stick that reports as the Left Stick, a POV Hat which reports
        /// as the Right Stick, a rudder (handle twist or rocker) that reports as Left Trigger, and
        /// a throttle control as the Right Trigger. Includes support for a primary weapon (A),
        /// secondary weapon (B), and other standard buttons (X, Y, START, BACK). LB, LSB, RB, and
        /// RSB are optional.
        /// </para>
        /// </summary>
        FlightStick = 0x4,

        /// <summary>
        /// Indicates the controller is a dance pad controller.
        /// <para>
        /// Includes the Directional Pad and standard buttons (A, B, X, Y) on the pad, plus BACK
        /// and START.
        /// </para>
        /// </summary>
        DancePad = 0x5,

        /// <summary>
        /// Indicates the controller is a guitar controller.
        /// <para>
        /// The strum bar maps to DPAD (up and down), and the frets are assigned to A (green), B
        /// (red), Y (yellow), X (blue), and LB (orange). Right Stick Y is associated with a
        /// vertical orientation sensor; Right Stick X is the whammy bar. Includes support for
        /// BACK, START, DPAD (left, right). Left Trigger (pickup selector), Right Trigger, RB, LSB
        /// (fret modifier), RSB are optional.
        /// </para>
        /// </summary>
        Guitar = 0x6,

        /// <summary>
        /// Indicates the controller is an alternate guitar controller.
        /// <para>
        /// Supports a larger range of movement for the vertical orientation sensor.
        /// </para>
        /// </summary>
        GuitarAlternate = 0x7,

        /// <summary>
        /// Indicates the controller is a drum controller.
        /// <para>
        /// The drum pads are assigned to buttons: A for green (Floor Tom), B for red (Snare Drum),
        /// X for blue (Low Tom), Y for yellow (High Tom), and LB for the pedal (Bass Drum).
        /// Includes Directional-Pad, BACK, and START. RB, LSB, and RSB are optional.
        /// </para>
        /// </summary>
        DrumKit = 0x8,

        /// <summary>
        /// Indicates the controller is a bass guitar controller.
        /// <para>
        /// Identical to Guitar, with the distinct subtype to simplify setup.
        /// </para>
        /// </summary>
        GuitarBass = 0xB,

        /// <summary>
        /// Indicates the controller is an arcade pad controller.
        /// <para>
        /// Includes Directional Pad and most standard buttons (A, B, X, Y, START, BACK, LB, RB).
        /// The Left and Right Triggers are implemented as digital buttons and report either 0 or
        /// 0xFF. Left Stick, Right Stick, LSB, and RSB are optional.
        /// </para>
        /// </summary>
        ArcadePad = 0x13
    }
}
