using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Trainer.Classes.Text
{
    // Represents a non-extended ASCII character used in Dead Rising
    // While DR uses UTF-16 (32? 24?), full encoding information is not available at this time
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct DRChar
    {
        private byte a; // ??
        private byte b; // ??
        public short CharValue;
        public byte Width;
        private byte terminator;
        public bool Terminator
        {
            get
            {
                return terminator >= 4;
            }
        }

        private static Dictionary<short, char> charMap = new Dictionary<short, char>
        {
            {0x0, ' ' },
            {0x2, '!' },
            {0x4, '\"' },
            {0x6, '$' },
            {0x8, '%' },
            {0x0A, '&' },
            {0x0C, '\'' },
            {0x0E, '('},
            {0x10, ')' },
            {0x12, '*' },
            {0x14, '+'},
            {0x16, ',' },
            {0x18, '-' },
            {0x1A, '.' },
            {0x1C, '/' },
            {0x1E, '0' },
            {0x20, '1' },
            {0x22, '2' },
            {0x24, '3' },
            {0x26, '4' },
            {0x28, '5' },
            {0x2A, '6' },
            {0x2C, '7' },
            {0x2E, '8' },
            {0x30, '9' },
            {0x32, ':' },
            {0x34, ';' },
            {0x36, '<' },
            {0x38, '=' },
            {0x3A, '>' },
            {0x3C, '?' },
            {0x3E, '@' },
            {0x40, 'A' },
            {0x42, 'B' },
            {0x44, 'C' },
            {0x46, 'D' },
            {0x48, 'E' },
            {0x4A, 'F' },
            {0x4C, 'G' },
            {0x4E, 'H' },
            {0x50, 'I' },
            {0x52, 'J' },
            {0x54, 'K' },
            {0x56, 'L' },
            {0x58, 'M' },
            {0x5A, 'N' },
            {0x5C, 'O' },
            {0x5E, 'P' },
            {0x60, 'Q' },
            {0x62, 'R' },
            {0x64, 'S' },
            {0x66, 'T' },
            {0x68, 'U' },
            {0x6A, 'V' },
            {0x6C, 'W' },
            {0x6E, 'X' },
            {0x70, 'Y' },
            {0x72, 'Z' },
            {0x74, '[' },
            {0x76, '\\' },
            {0x78, ']' },
            {0x7A, '_' },
            {0x7C, 'a' },
            {0x7E, 'b' },
            {0x80, 'c' },
            {0x82, 'd' },
            {0x84, 'e' },
            {0x86, 'f' },
            {0x88, 'g' },
            {0x8A, 'h' },
            {0x8C, 'i' },
            {0x8E, 'j' },
            {0x90, 'k' },
            {0x92, 'l' },
            {0x94, 'm' },
            {0x96, 'n' },
            {0x98, 'o' },
            {0x9A, 'p' },
            {0x9C, 'q' },
            {0x9E, 'r' },
            {0xA0, 's' },
            {0xA2, 't' },
            {0xA4, 'u' },
            {0xA6, 'v' },
            {0xA8, 'w' },
            {0xAA, 'x' },
            {0xAC, 'y' },
            {0xAE, 'z' },
            {0xB0, '|' },
            {0xB2, '~' }
        };

        private static Dictionary<char, short> valueMap = new Dictionary<char, short>
        {
            {' ', 0x00 },
            {'!', 0x02 },
            {'\"', 0x04 },
            {'$', 0x06 },
            {'%', 0x08 },
            {'&', 0x0A },
            {'\'', 0x0C },
            {'(', 0x0E },
            {')', 0x10 },
            {'*', 0x12 },
            {'+', 0x14 },
            {',', 0x16 },
            {'-', 0x18 },
            {'.', 0x1A },
            {'/', 0x1C },
            {'0', 0x1E },
            {'1', 0x20 },
            {'2', 0x22 },
            {'3', 0x24 },
            {'4', 0x26 },
            {'5', 0x28 },
            {'6', 0x2A },
            {'7', 0x2C },
            {'8', 0x2E },
            {'9', 0x30 },
            {':', 0x32 },
            {';', 0x34 },
            {'<', 0x36 },
            {'=', 0x38 },
            {'>', 0x3A },
            {'?', 0x3C },
            {'@', 0x3E },
            {'A', 0x40 },
            {'B', 0x42 },
            {'C', 0x44 },
            {'D', 0x46 },
            {'E', 0x48 },
            {'F', 0x4A },
            {'G', 0x4C },
            {'H', 0x4E },
            {'I', 0x50 },
            {'J', 0x52 },
            {'K', 0x54 },
            {'L', 0x56 },
            {'M', 0x58 },
            {'N', 0x5A },
            {'O', 0x5C },
            {'P', 0x5E },
            {'Q', 0x60 },
            {'R', 0x62 },
            {'S', 0x64 },
            {'T', 0x66 },
            {'U', 0x68 },
            {'V', 0x6A },
            {'W', 0x6C },
            {'X', 0x6E },
            {'Y', 0x70 },
            {'Z', 0x72 },
            {'[', 0x74 },
            {'\\', 0x76 },
            {']', 0x78 },
            {'_', 0x7A },
            {'a', 0x7C },
            {'b', 0x7E },
            {'c', 0x80 },
            {'d', 0x82 },
            {'e', 0x84 },
            {'f', 0x86 },
            {'g', 0x88 },
            {'h', 0x8A },
            {'i', 0x8C },
            {'j', 0x8E },
            {'k', 0x90 },
            {'l', 0x92 },
            {'m', 0x94 },
            {'n', 0x96 },
            {'o', 0x98 },
            {'p', 0x9A },
            {'q', 0x9C },
            {'r', 0x9E },
            {'s', 0xA0 },
            {'t', 0xA2 },
            {'u', 0xA4 },
            {'v', 0xA6 },
            {'w', 0xA8 },
            {'x', 0xAA },
            {'y', 0xAC },
            {'z', 0xAE },
            {'|', 0xB0 },
            {'~', 0xB2 }
        };
        public static DRChar StringTerminator = new DRChar(' ', true);

        public DRChar(char character, bool terminator = false, CharWidth width = CharWidth.Default)
        {
            a = 0;
            b = 0;
            
            if (!valueMap.ContainsKey(character))
            {
                CharValue = 0x3C;
            }
            else
            {
                CharValue = valueMap[character];
            }

            this.terminator = (byte)(terminator ? 0x4 : 0x0);

            switch (width)
            {
                default:
                    Width = 0x4F;
                    break;
            }
        }

        public char ToChar()
        {
            if (this.Terminator) { return (char)0x00; }
            if (!charMap.ContainsKey(this.CharValue)) { return '�'; }

            return charMap[this.CharValue];
        }
    }
}
