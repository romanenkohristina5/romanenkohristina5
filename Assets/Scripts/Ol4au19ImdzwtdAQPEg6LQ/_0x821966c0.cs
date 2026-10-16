using UnityEngine;

// Colour vocabulary of this game. Every colour used anywhere comes from here, so a
// single edit retones the whole app. Text colours are the light end of the ramp only:
// the font material outlines with Deep, so a dark face would merge with its own
// outline (rule C.14). Primary and DangerFill are FILL/BORDER colours - never text.
public static class _0x821966c0
{
    public static readonly Color Primary = Rgb(0x68, 0x4F, 0xD6);
    public static readonly Color Deep = Rgb(0x15, 0x12, 0x26);
    // The accent that belongs to a track index (0..2). Used by the menu rails, the
    // track card border and the select sheet so a track swap repaints the whole frame.
    public static Color TrackAccent(int _0xb78a9436)
    {
        if (_0xb78a9436 <= 0)
        {
            return Primary;
        }

        if (_0xb78a9436 == 1)
        {
            return Secondary;
        }

        return Reward;
    }

    public static readonly Color TextPrimary = Rgb(0xFF, 0xF0, 0xD8);
    public static readonly Color Secondary = Rgb(0x32, 0xBD, 0xD0);
    public static Color Alpha(Color _0x752452f0, float _0x4e900be5)
    {
        return new Color(_0x752452f0.r, _0x752452f0.g, _0x752452f0.b, _0x4e900be5);
    }

    public static readonly Color TextMuted = Rgb(0x9A, 0x8F, 0xD0);
    public static readonly Color Raised = Rgb(0x2A, 0x22, 0x50);
    public static Color Rgb(int _0x71576ad1, int _0xe4d93cf5, int _0xb2a61122)
    {
        return new Color(_0x71576ad1 / 255f, _0xe4d93cf5 / 255f, _0xb2a61122 / 255f, 1f);
    }

    public static readonly Color Surface = Rgb(0x1C, 0x17, 0x38);
    public static readonly Color DangerFill = Rgb(0xE7, 0x47, 0x67);
    public static readonly Color Reward = Rgb(0xF0, 0xC5, 0x42);
    public static readonly Color DangerText = Rgb(0xFF, 0x80, 0x97);
}