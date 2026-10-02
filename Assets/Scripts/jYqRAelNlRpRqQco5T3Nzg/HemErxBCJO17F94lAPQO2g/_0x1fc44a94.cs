using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x1fc44a94
{
    public static class _0xac09a5ba
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x9d1bd943
    {
        public static int _0x9c696c79
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x6f8823ae._0x270df7fe(new byte[5] { 124, 80, 86, 81, 76 }, 63)))
                    PlayerPrefs.SetInt(_0x6f8823ae._0x270df7fe(new byte[5] { 24, 52, 50, 53, 40 }, 91), 0);
                return PlayerPrefs.GetInt(_0x6f8823ae._0x270df7fe(new byte[5] { 228, 200, 206, 201, 212 }, 167));
            }

            set
            {
                PlayerPrefs.SetInt(_0x6f8823ae._0x270df7fe(new byte[5] { 238, 194, 196, 195, 222 }, 173), value);
                _0x7267b4eb.Instance._0xf9248276();
            }
        }
    }

    public static class _0x517a5fb9
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0x98dd0d5d
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public class _0xf562e0d0
    {
        private static readonly _0xf562e0d0 _0x5c4f10cb = new();
        public static readonly _0xf562e0d0[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x5c4f10cb,
            _0x5c4f10cb,
            _0x5c4f10cb,
        };
        private int _0xb0733b34 => 0;
        private int _0xa2cd26c2 => 10;
        private string _0x7bd3a6fa => _0x6f8823ae._0x270df7fe(new byte[4] { 125, 85, 94, 69 }, 48);
        private string _0xb24508e3 => _0x6f8823ae._0x270df7fe(new byte[8] { 18, 27, 8, 27, 18, 37, 110, 35 }, 94);

        private int _0x5c3c7dcb
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x6f8823ae._0x270df7fe(new byte[25] { 158, 168, 175, 175, 184, 179, 169, 154, 177, 178, 191, 188, 177, 158, 181, 188, 173, 169, 184, 175, 148, 179, 185, 184, 165 }, 221)))
                    PlayerPrefs.SetInt(_0x6f8823ae._0x270df7fe(new byte[25] { 32, 22, 17, 17, 6, 13, 23, 36, 15, 12, 1, 2, 15, 32, 11, 2, 19, 23, 6, 17, 42, 13, 7, 6, 27 }, 99), 0);
                return PlayerPrefs.GetInt(_0x6f8823ae._0x270df7fe(new byte[25] { 3, 53, 50, 50, 37, 46, 52, 7, 44, 47, 34, 33, 44, 3, 40, 33, 48, 52, 37, 50, 9, 46, 36, 37, 56 }, 64));
            }

            set => PlayerPrefs.SetInt(_0x6f8823ae._0x270df7fe(new byte[25] { 254, 200, 207, 207, 216, 211, 201, 250, 209, 210, 223, 220, 209, 254, 213, 220, 205, 201, 216, 207, 244, 211, 217, 216, 197 }, 189), value);
        }

        public int _0x3487e5dc
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x7bd3a6fa}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x7bd3a6fa}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x7bd3a6fa}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x7bd3a6fa}CurrentLevelIndex", value);
        }

        public int _0xaeb58d8d
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x7bd3a6fa}BestScore"))
                    this._0xaeb58d8d = 0;
                return PlayerPrefs.GetInt($"{this._0x7bd3a6fa}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x7bd3a6fa}BestScore", value);
        }

        public bool _0xb72b17dc
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x7bd3a6fa}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x7bd3a6fa}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x7bd3a6fa}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x7bd3a6fa}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }
}

internal static class _0x6f8823ae
{
    internal static string _0x270df7fe(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}