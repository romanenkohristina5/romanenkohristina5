using UnityEngine;

// Every tunable number of the run in one place. Nothing here is a "looks about right"
// pixel value - the world sizes live in PulseLayout and are derived from the camera.
public static class _0xd04e59fe
{
    public const float BreakFlashSeconds = 0.20f;
    public static int ComboMultiplier(int _0xe35ce0c8)
    {
        if (_0xe35ce0c8 >= 45)
        {
            return 4;
        }

        if (_0xe35ce0c8 >= 25)
        {
            return 3;
        }

        if (_0xe35ce0c8 >= 10)
        {
            return 2;
        }

        return 1;
    }

    public const float PauseAutoResumeSeconds = 10f;
    public const int GenerateAttempts = 20;
    public static float MissCostAt(float _0xa5bff2e5)
    {
        return ReferenceMissCost * (_0xa5bff2e5 / ReferenceInterval);
    }

    public const float BeamSegmentGain = 0.55f; // per 0.25 s held, at most 4 of them
    public const int NotesPerFloor = 4; // 4 clean notes lift the car a floor
    public const float GoodGain = 1.20f;
    public const float LowEnergyShare = 0.30f; // bar turns red below this
    public static string RankFor(float _0x1d46eacc)
    {
        if (_0x1d46eacc >= RankSAccuracy)
        {
            return _0x234b825f._0x38b773a1(new byte[1] { 116 }, 39);
        }

        if (_0x1d46eacc >= RankAAccuracy)
        {
            return _0x234b825f._0x38b773a1(new byte[1] { 114 }, 51);
        }

        if (_0x1d46eacc >= ClearAccuracy)
        {
            return _0x234b825f._0x38b773a1(new byte[1] { 191 }, 253);
        }

        return _0x234b825f._0x38b773a1(new byte[1] { 223 }, 156);
    }

    public const int GoodScore = 70;
    public const int BeamSegmentsMax = 4;
    public const float BeamMaxSeconds = 2.0f;
    public const int ChargePerScore = 10; // CHARGE awarded = score / 10
    public const float MinNoteGap = 0.20f; // keeps the game one-fingered
    public const float ReferenceMissCost = 1.00f;
    // ---- pacing -----------------------------------------------------------------
    public const float IntroSeconds = 3.5f; // 4 count-in rings before note one
    public const float BeamGoodShare = 0.50f;
    public const float BreakPenalty = 2.00f; // every 5th miss IN A ROW
    public const float BeamPerfectShare = 0.80f; // held >= 80% of the beam
    public const float PassiveDrainPerSecond = 0.15f;
    // ---- judgement windows ------------------------------------------------------
    public const float PerfectWindow = 0.090f;
    public const float BeamSegmentSeconds = 0.25f;
    public const float BurstSeconds = 0.28f;
    public const float PerfectGain = 2.20f;
    public const float RankAAccuracy = 92f;
    public const float GoodWindow = 0.180f;
    public const float ToastSeconds = 1.4f;
    // ---- scoring ----------------------------------------------------------------
    public const int PerfectScore = 120;
    // ---- chart generation -------------------------------------------------------
    public const float IntervalJitter = 0.12f; // +/- 12 % of the track interval
    public const float ReferenceInterval = 1.25f; // the interval MissCost is pinned to
    public const float ClearAccuracy = 85f; // the brief's pass mark
    public const float BeamMinSeconds = 1.0f;
    public const int BreakMissStreak = 5;
    public const float RankSAccuracy = 97f;
    public const float BeamShare = 0.22f; // lands inside the 18..26 % window
    public const float HintFadedAlpha = 0.35f;
    public const int EasyOpeningNotes = 6; // first six are SPARK, lanes alternate
    // ---- presentation timings ---------------------------------------------------
    public const float HintVisibleSeconds = 20f; // covers the whole review window
    // "12480" -> "12 480". The atlas is ASCII, so the separator is a plain space.
    public static string Grouped(int _0xe23d6b5c)
    {
        string _0x3c251ae3 = Mathf.Abs(_0xe23d6b5c).ToString();
        string _0x1ac7b2c7 = "";
        for (int _0xe650f399 = 0; _0xe650f399 < _0x3c251ae3.Length; _0xe650f399++)
        {
            if (_0xe650f399 > 0 && (_0x3c251ae3.Length - _0xe650f399) % 3 == 0)
            {
                _0x1ac7b2c7 += _0x234b825f._0x38b773a1(new byte[1] { 35 }, 3);
            }

            _0x1ac7b2c7 += _0x3c251ae3[_0xe650f399];
        }

        return _0xe23d6b5c < 0 ? _0x234b825f._0x38b773a1(new byte[1] { 111 }, 66) + _0x1ac7b2c7 : _0x1ac7b2c7;
    }

    public const int MaxSameLaneRun = 3;
    // ---- energy -----------------------------------------------------------------
    // Rule C.5: a run with ZERO successful taps has to outlive the capture window.
    //   miss drain  = (1 / interval) * MissCostAt(interval) = 1 / 1.25 = 0.800 / s
    //   break drain = (miss rate / 5) * BreakPenalty        = 0.320 / s
    //   idle drain  = PassiveDrainPerSecond                 = 0.150 / s
    //   total 1.270 / s  ->  (100 - 3.5 * 0.15) / 1.270 + 3.5 = 81.8 s, on every track.
    public const float EnergyMax = 100f;
    public const int BeamSegmentScore = 40;
    public const float ApproachSeconds = 1.6f; // spawn -> hit line, fixed
}

internal static class _0x234b825f
{
    internal static string _0x38b773a1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}