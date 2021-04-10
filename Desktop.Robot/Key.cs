using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Desktop.Robot
{
    public enum Key
    {

        //Characters
        [Keycode(Platform = "OSX", Keycode = 0x00)]
        [Keycode(Platform = "Windows", Keycode = 0x41)]
        A,

        [Keycode(Platform = "Windows", Keycode = 0x42)]
        B,

        [Keycode(Platform = "Windows", Keycode = 0x43)]
        C,

        [Keycode(Platform = "OSX", Keycode = 0x02)]
        [Keycode(Platform = "Windows", Keycode = 0x44)]
        D,

        [Keycode(Platform = "Windows", Keycode = 0x45)]
        E,

        [Keycode(Platform = "Windows", Keycode = 0x46)]
        F,

        [Keycode(Platform = "Windows", Keycode = 0x47)]
        G,

        [Keycode(Platform = "Windows", Keycode = 0x48)]
        H,

        [Keycode(Platform = "Windows", Keycode = 0x49)]
        I,

        [Keycode(Platform = "Windows", Keycode = 0x4A)]
        J,

        [Keycode(Platform = "Windows", Keycode = 0x4B)]
        K,

        [Keycode(Platform = "Windows", Keycode = 0x4C)]
        L,

        [Keycode(Platform = "Windows", Keycode = 0x4D)]
        M,

        [Keycode(Platform = "Windows", Keycode = 0x4E)]
        N,

        [Keycode(Platform = "Windows", Keycode = 0x4F)]
        O,

        [Keycode(Platform = "Windows", Keycode = 0x50)]
        P,

        [Keycode(Platform = "Windows", Keycode = 0x51)]
        Q,

        [Keycode(Platform = "Windows", Keycode = 0x52)]
        R,

        [Keycode(Platform = "OSX", Keycode = 0x01)]
        [Keycode(Platform = "Windows", Keycode = 0x53)]
        S,

        [Keycode(Platform = "Windows", Keycode = 0x54)]
        T,

        [Keycode(Platform = "Windows", Keycode = 0x55)]
        U,

        [Keycode(Platform = "Windows", Keycode = 0x56)]
        V,

        [Keycode(Platform = "Windows", Keycode = 0x57)]
        W,

        [Keycode(Platform = "Windows", Keycode = 0x58)]
        X,

        [Keycode(Platform = "Windows", Keycode = 0x59)]
        Y,

        [Keycode(Platform = "Windows", Keycode = 0x5A)]
        Z,

        //Numbers
        Zero,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,

        //Symbols
        [Keycode(Platform = "Windows", Keycode = 0xBC)]
        Comma,

        [Keycode(Platform = "Windows", Keycode = 0x5A)]
        Colon,
        Semicolon,
        Dot,
        Dollar,
        Slash,
        Backslash,
        Percent,
        LessThan,
        GreaterThan,
        QuotationMark,
        OpenParenthesis,
        CloseParenthesis,
        OpenBracket,
        CloseBracked,
        OpenBrace,
        CloseBrace,
        Interrogation,

        [Keycode(Platform = "OSX", Keycode = 0x37)]
        Command,

        [Keycode(Platform = "OSX", Keycode = 0x30)]
        [Keycode(Platform = "Windows", Keycode = 0x09, ScanCode = 0x8F)]
        Tab,
        
        [Keycode(Platform = "OSX", Keycode = 0x33)]
        [Keycode(Platform = "Windows", Keycode = 0x2E)]
        Delete,
        
        [Keycode(Platform = "OSX", Keycode = 0x35)]
        [Keycode(Platform = "Windows", Keycode = 0x1B)]
        Esc,
        
        [Keycode(Platform = "OSX", Keycode = 0x38)]
        [Keycode(Platform = "Windows", Keycode = 0xA0, ScanCode = 0xAA)]
        Shift,

        [Keycode(Platform = "OSX", Keycode = 0x3A)]
        Option,
        
        [Keycode(Platform = "OSX", Keycode = 0x3B)]
        [Keycode(Platform = "Windows", Keycode = 0xA2, ScanCode = 0x9D)]
        Control,

        [Keycode(Platform = "OSX", Keycode = 0x39)]
        [Keycode(Platform = "Windows", Keycode = 0x14)]
        CapsLock,

        [Keycode(Platform = "Windows", Keycode = 0x12, ScanCode = 0xB8)]
        Alt,

        [Keycode(Platform = "Windows", Keycode = 0x2D)]
        Insert,

        [Keycode(Platform = "OSX", Keycode = 0x73)]
        [Keycode(Platform = "Windows", Keycode = 0xAC)]
        Home,

        [Keycode(Platform = "OSX", Keycode = 0x77)]
        [Keycode(Platform = "Windows", Keycode = 0x23)]
        End,

        [Keycode(Platform = "OSX", Keycode = 0x74)]
        [Keycode(Platform = "Windows", Keycode = 0x21)]
        PageUp,

        [Keycode(Platform = "OSX", Keycode = 0x79)]
        [Keycode(Platform = "Windows", Keycode = 0x22)]
        PageDown,

        [Keycode(Platform = "Windows", Keycode = 0x08, ScanCode = 0x8E)]
        Backspace,

        [Keycode(Platform = "OSX", Keycode = 0x45)]
        [Keycode(Platform = "Windows", Keycode = 0xBB)]
        Plus,

        [Keycode(Platform = "OSX", Keycode = 0x4E)]
        [Keycode(Platform = "Windows", Keycode = 0xBD)]
        Minus,

        [Keycode(Platform = "Windows", Keycode = 0x2C)]
        PrintScreen,

        [Keycode(Platform = "Windows", Keycode = 0x91)]
        ScrollLock,

        [Keycode(Platform = "Windows", Keycode = 0x90)]
        NumLock,

        [Keycode(Platform = "Windows", Keycode = 0x13)]
        Pause,

        [Keycode(Platform = "OSX", Keycode = 0x7A)]
        [Keycode(Platform = "Windows", Keycode = 0x70)]
        F1,

        [Keycode(Platform = "OSX", Keycode = 0x78)]
        [Keycode(Platform = "Windows", Keycode = 0x71)]
        F2,

        [Keycode(Platform = "OSX", Keycode = 0x63)]
        [Keycode(Platform = "Windows", Keycode = 0x72)]
        F3,

        [Keycode(Platform = "OSX", Keycode = 0x76)]
        [Keycode(Platform = "Windows", Keycode = 0x73)]
        F4,

        [Keycode(Platform = "OSX", Keycode = 0x60)]
        [Keycode(Platform = "Windows", Keycode = 0x74)]
        F5,

        [Keycode(Platform = "OSX", Keycode = 0x61)]
        [Keycode(Platform = "Windows", Keycode = 0x75)]
        F6,

        [Keycode(Platform = "OSX", Keycode = 0x62)]
        [Keycode(Platform = "Windows", Keycode = 0x76)]
        F7,

        [Keycode(Platform = "OSX", Keycode = 0x64)]
        [Keycode(Platform = "Windows", Keycode = 0x77)]
        F8,

        [Keycode(Platform = "OSX", Keycode = 0x65)]
        [Keycode(Platform = "Windows", Keycode = 0x78)]
        F9,

        [Keycode(Platform = "OSX", Keycode = 0x6D)]
        [Keycode(Platform = "Windows", Keycode = 0x79)]
        F10,
        
        [Keycode(Platform = "OSX", Keycode = 0x67)]
        [Keycode(Platform = "Windows", Keycode = 0x7A)]
        F11,

        [Keycode(Platform = "OSX", Keycode = 0x6F)]
        [Keycode(Platform = "Windows", Keycode = 0x7B)]
        F12,
    }

    public static class KeysExtensions 
    {
        public static ushort GetKeycode(this Key key)
        {
            var enumType = typeof(Key);
            var memberInfos = enumType.GetMember(key.ToString());
            var enumValueMemberInfo = memberInfos.FirstOrDefault(m => m.DeclaringType == enumType);
            var valueAttributes = enumValueMemberInfo
                .GetCustomAttributes(typeof(KeycodeAttribute), false)
                .Cast<KeycodeAttribute>()
                .ToList();
            try
            {
                var keycode = valueAttributes
                    .First(k => RuntimeInformation.IsOSPlatform(OSPlatform.Create(k.Platform)));
                return (ushort)keycode.Keycode;
            }
            catch
            {
                throw new PlatformNotSupportedException();
            }
        }

        public static ushort GetScanCode(this Key key)
        {
            var enumType = typeof(Key);
            var memberInfos = enumType.GetMember(key.ToString());
            var enumValueMemberInfo = memberInfos.FirstOrDefault(m => m.DeclaringType == enumType);
            var valueAttributes = enumValueMemberInfo
                .GetCustomAttributes(typeof(KeycodeAttribute), false)
                .Cast<KeycodeAttribute>()
                .ToList();
            try
            {
                var keycode = valueAttributes
                    .First(k => RuntimeInformation.IsOSPlatform(OSPlatform.Create(k.Platform)));
                return (ushort)keycode.ScanCode;
            }
            catch
            {
                throw new PlatformNotSupportedException();
            }
        }

    }
}