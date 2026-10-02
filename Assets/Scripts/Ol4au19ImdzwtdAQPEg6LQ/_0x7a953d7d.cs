using UnityEngine;

// The three ascents, plus the small amount of progress that persists between runs.
// Progress lives in PlayerPrefs under keys that are plain strings chosen here, so
// symbol renaming cannot move them.
public static class _0x7a953d7d
{
    // Rule C.11: two runs in a row must not be the same chart. The counter advances
    // on every run start and feeds the chart seed.
    public static int NextAttempt()
    {
        int _0x19e0cb19 = PlayerPrefs.GetInt(AttemptKey, 0) + 1;
        PlayerPrefs.SetInt(AttemptKey, _0x19e0cb19);
        PlayerPrefs.Save();
        return _0x19e0cb19;
    }

    private static readonly _0x1729546e[] _0xbc2a94f8 =
    {
        new _0x1729546e(_0x01bf0473._0x43edbb48(new byte[12] { 204, 211, 213, 214, 223, 206, 186, 201, 210, 219, 220, 206 }, 154), 110, 18, 72, 1.25f),
        new _0x1729546e(_0x01bf0473._0x43edbb48(new byte[10] { 157, 135, 159, 144, 254, 140, 151, 141, 155, 140 }, 222), 128, 24, 96, 1.05f),
        new _0x1729546e(_0x01bf0473._0x43edbb48(new byte[11] { 167, 171, 164, 163, 180, 198, 165, 180, 169, 177, 168 }, 230), 144, 30, 120, 0.92f),
    };
    public static int BestAccuracy(int _0x00f7a267)
    {
        return PlayerPrefs.GetInt(BestPrefix + _0x00f7a267, 0);
    }

    private static readonly string BestPrefix = _0x01bf0473._0x43edbb48(new byte[14] { 23, 50, 43, 52, 34, 19, 53, 38, 36, 44, 5, 34, 52, 51 }, 71);
    public static void RecordAccuracy(int _0x265dd536, int _0x2b87f776)
    {
        if (_0x2b87f776 > BestAccuracy(_0x265dd536))
        {
            PlayerPrefs.SetInt(BestPrefix + _0x265dd536, _0x2b87f776);
            PlayerPrefs.Save();
        }
    }

    public static int _0x60b01583
    {
        get
        {
            return _0xbc2a94f8.Length;
        }
    }

    private static readonly string AttemptKey = _0x01bf0473._0x43edbb48(new byte[15] { 36, 1, 24, 7, 17, 38, 1, 26, 53, 0, 0, 17, 25, 4, 0 }, 116);
    private static readonly string ClearedKey = _0x01bf0473._0x43edbb48(new byte[18] { 134, 163, 186, 165, 179, 130, 164, 183, 181, 189, 165, 149, 186, 179, 183, 164, 179, 178 }, 214);
    private static readonly string ChosenKey = _0x01bf0473._0x43edbb48(new byte[16] { 185, 156, 133, 154, 140, 189, 155, 136, 138, 130, 170, 129, 134, 154, 140, 135 }, 233);
    // Track 1 is always open; each further track opens once the one before it cleared.
    public static int _0x593e68d5
    {
        get
        {
            return PlayerPrefs.GetInt(ClearedKey, 0);
        }
    }

    public static _0x1729546e Row(int _0x74902170)
    {
        return _0xbc2a94f8[Mathf.Clamp(_0x74902170, 0, _0xbc2a94f8.Length - 1)];
    }

    public static bool IsUnlocked(int _0x24e90b27)
    {
        return _0x24e90b27 <= 0 || _0x593e68d5 >= _0x24e90b27;
    }

    public static int _0x10895542
    {
        get
        {
            int _0xebf682ef = PlayerPrefs.GetInt(ChosenKey, 0);
            return IsUnlocked(_0xebf682ef) ? Mathf.Clamp(_0xebf682ef, 0, _0xbc2a94f8.Length - 1) : 0;
        }

        set
        {
            PlayerPrefs.SetInt(ChosenKey, Mathf.Clamp(value, 0, _0xbc2a94f8.Length - 1));
            PlayerPrefs.Save();
        }
    }

    public static void MarkCleared(int _0x65991bc9)
    {
        if (_0x65991bc9 + 1 > _0x593e68d5)
        {
            PlayerPrefs.SetInt(ClearedKey, _0x65991bc9 + 1);
            PlayerPrefs.Save();
        }
    }
}

internal static class _0x01bf0473
{
    internal static string _0x43edbb48(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}