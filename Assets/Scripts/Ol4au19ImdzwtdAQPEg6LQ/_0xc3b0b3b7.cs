using System.Collections.Generic;
using UnityEngine;

// The chart is DEALT, not written down (rule C.11): the design document supplies the
// counts, the seed supplies the shape. Two runs in a row differ in lane pattern, beam
// placement and the micro-jitter of every interval.
//
// The beams are CONSTRUCTED into legal slots rather than drawn and re-drawn until the
// result happens to be legal - a rare forced outcome never arrives by rejection
// sampling. IsPlayable then re-checks the finished chart, and a hard-wired spread
// exists only as a last-resort net.
public static class _0xc3b0b3b7
{
    public static bool IsPlayable(List<_0x7b26b63d> _0x24aa751d, _0x1729546e _0x4bfed2ba)
    {
        if (_0x24aa751d == null || _0x24aa751d.Count != _0x4bfed2ba._0x0af37c7a)
        {
            return false;
        }

        int _0x7e7d4891 = 0;
        int _0x177a57eb = -1;
        int _0xeb12daaf = 0;
        for (int _0x9346b33f = 0; _0x9346b33f < _0x24aa751d.Count; _0x9346b33f++)
        {
            _0x7b26b63d _0x9763b444 = _0x24aa751d[_0x9346b33f];
            // 4. the opening has to be gentle: sparks only, sectors alternating.
            if (_0x9346b33f < _0xd04e59fe.EasyOpeningNotes)
            {
                if (_0x9763b444._0x88d48175 || _0x9763b444._0x32d0badb != _0x9346b33f % _0x38c6998c.LaneCount)
                {
                    return false;
                }
            }

            // 2. beams stay inside the declared length band.
            if (_0x9763b444._0x88d48175)
            {
                _0x7e7d4891++;
                if (_0x9763b444._0xb347cee3 < _0xd04e59fe.BeamMinSeconds - 0.001f || _0x9763b444._0xb347cee3 > _0xd04e59fe.BeamMaxSeconds + 0.001f)
                {
                    return false;
                }
            }

            // 1. at most ONE note is live at any instant, with a real gap after it.
            if (_0x9346b33f > 0)
            {
                float _0x52298136 = _0x9763b444._0x4a19d5f7 - _0x24aa751d[_0x9346b33f - 1]._0xe91fd7a8;
                if (_0x52298136 < _0xd04e59fe.MinNoteGap - 0.001f)
                {
                    return false;
                }
            }

            // 3. never more than MaxSameLaneRun notes in the same sector.
            _0xeb12daaf = _0x9763b444._0x32d0badb == _0x177a57eb ? _0xeb12daaf + 1 : 1;
            _0x177a57eb = _0x9763b444._0x32d0badb;
            if (_0xeb12daaf > _0xd04e59fe.MaxSameLaneRun)
            {
                return false;
            }
        }

        float _0x8e9ca257 = (float)_0x7e7d4891 / _0x24aa751d.Count;
        return _0x8e9ca257 >= 0.18f && _0x8e9ca257 <= 0.26f;
    }

    public static List<_0x7b26b63d> Build(int _0x70c8a7c2, int _0xc5e7423e, _0x1729546e _0x7ff01d7e)
    {
        int _0xd8b943dc = (_0x70c8a7c2 * 7919) ^ (_0xc5e7423e * 104729);
        System.Random _0x40160904 = new System.Random(_0xd8b943dc);
        List<_0x7b26b63d> _0x69064a54 = Generate(_0x40160904, _0x7ff01d7e);
        for (int _0x9826e403 = 0; _0x9826e403 < _0xd04e59fe.GenerateAttempts && !IsPlayable(_0x69064a54, _0x7ff01d7e); _0x9826e403++)
        {
            _0x69064a54 = Generate(_0x40160904, _0x7ff01d7e);
        }

        bool _0x393b5c73 = IsPlayable(_0x69064a54, _0x7ff01d7e);
        if (!_0x393b5c73)
        {
            _0x69064a54 = Fallback(_0x7ff01d7e);
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x98f8dc36._0x45040473(new byte[13] { 249, 193, 202, 195, 208, 214, 255, 130, 209, 199, 199, 198, 159 }, 162) + _0xd8b943dc + _0x98f8dc36._0x45040473(new byte[7] { 249, 173, 171, 184, 186, 178, 228 }, 217) + _0x70c8a7c2 + _0x98f8dc36._0x45040473(new byte[7] { 54, 120, 121, 98, 115, 101, 43 }, 22) + _0x69064a54.Count + _0x98f8dc36._0x45040473(new byte[10] { 216, 136, 148, 153, 129, 153, 154, 148, 157, 197 }, 248) + _0x393b5c73);
            }
#endif
        }

        return _0x69064a54;
    }

    private static List<_0x7b26b63d> Generate(System.Random _0x1beea678, _0x1729546e _0x85327a2d)
    {
        int _0xe1a6b289 = _0x85327a2d._0x0af37c7a;
        bool[] _0xa8e1fd83 = PlanBeamSlots(_0x1beea678, _0xe1a6b289);
        int[] _0xb7f2623c = PlanLanes(_0x1beea678, _0xe1a6b289);
        List<_0x7b26b63d> _0xa472a852 = new List<_0x7b26b63d>(_0xe1a6b289);
        float _0x0f8eba19 = _0xd04e59fe.IntroSeconds;
        for (int _0xeecc3024 = 0; _0xeecc3024 < _0xe1a6b289; _0xeecc3024++)
        {
            float _0x6a0a5a14 = 0f;
            if (_0xa8e1fd83[_0xeecc3024])
            {
                float _0x78605f8c = _0xd04e59fe.BeamMaxSeconds - _0xd04e59fe.BeamMinSeconds;
                _0x6a0a5a14 = _0xd04e59fe.BeamMinSeconds + (float)_0x1beea678.NextDouble() * _0x78605f8c;
            }

            _0xa472a852.Add(new _0x7b26b63d(_0x0f8eba19, _0x6a0a5a14, _0xb7f2623c[_0xeecc3024]));
            float _0xc5aa051b = 1f + ((float)_0x1beea678.NextDouble() * 2f - 1f) * _0xd04e59fe.IntervalJitter;
            float _0xfff30124 = _0x85327a2d._0x52b53586 * _0xc5aa051b;
            // Whatever the jitter says, the next note starts at least MinNoteGap after
            // this one ENDS - that is what keeps the game playable with one finger.
            float _0xbc6a1560 = _0x6a0a5a14 + _0xd04e59fe.MinNoteGap + 0.05f;
            _0x0f8eba19 += Mathf.Max(_0xfff30124, _0xbc6a1560);
        }

        return _0xa472a852;
    }

    // Beams go into evenly spaced windows with a random offset inside each window, so
    // consecutive beams are always at least two notes apart and the share is exact.
    private static bool[] PlanBeamSlots(System.Random _0x8e0edbd7, int _0xd997f2eb)
    {
        bool[] _0x2d4047d0 = new bool[_0xd997f2eb];
        int _0xfbf23841 = _0xd04e59fe.EasyOpeningNotes;
        int _0x83ccfd7d = _0xd997f2eb - _0xfbf23841;
        if (_0x83ccfd7d <= 0)
        {
            return _0x2d4047d0;
        }

        int _0xa2f014d3 = Mathf.RoundToInt(_0xd997f2eb * _0xd04e59fe.BeamShare);
        _0xa2f014d3 = Mathf.Clamp(_0xa2f014d3, 1, _0x83ccfd7d / 2);
        int _0x942ca05a = _0x83ccfd7d / _0xa2f014d3;
        if (_0x942ca05a < 2)
        {
            _0x942ca05a = 2;
        }

        int _0x997c66e0 = Mathf.Max(0, _0x942ca05a - 2);
        for (int _0xf2960b6e = 0; _0xf2960b6e < _0xa2f014d3; _0xf2960b6e++)
        {
            int _0x10fc2884 = _0xfbf23841 + _0xf2960b6e * _0x942ca05a + (_0x997c66e0 > 0 ? _0x8e0edbd7.Next(0, _0x997c66e0 + 1) : 0);
            if (_0x10fc2884 >= _0xd997f2eb)
            {
                break;
            }

            _0x2d4047d0[_0x10fc2884] = true;
        }

        return _0x2d4047d0;
    }

    // A net, not a game: a flat alternating spread with one beam every fifth note.
    private static List<_0x7b26b63d> Fallback(_0x1729546e _0xe2dbdc07)
    {
        List<_0x7b26b63d> _0xe2a7b393 = new List<_0x7b26b63d>(_0xe2dbdc07._0x0af37c7a);
        float _0x17761a12 = _0xd04e59fe.IntroSeconds;
        for (int _0x987741d1 = 0; _0x987741d1 < _0xe2dbdc07._0x0af37c7a; _0x987741d1++)
        {
            bool _0xb9030302 = _0x987741d1 >= _0xd04e59fe.EasyOpeningNotes && _0x987741d1 % 5 == 0;
            float _0xb560064f = _0xb9030302 ? 1.4f : 0f;
            _0xe2a7b393.Add(new _0x7b26b63d(_0x17761a12, _0xb560064f, _0x987741d1 % _0x38c6998c.LaneCount));
            _0x17761a12 += Mathf.Max(_0xe2dbdc07._0x52b53586, _0xb560064f + _0xd04e59fe.MinNoteGap + 0.05f);
        }

        return _0xe2a7b393;
    }

    // The opening six cycle through the sectors so the first bars read themselves;
    // after that lanes are drawn, with a hard stop at MaxSameLaneRun in a row.
    private static int[] PlanLanes(System.Random _0x6528f202, int _0x7bcf042d)
    {
        int[] _0xd8a952e7 = new int[_0x7bcf042d];
        int _0x8d44a31a = -1;
        int _0xae0aedb7 = 0;
        for (int _0xb18d8077 = 0; _0xb18d8077 < _0x7bcf042d; _0xb18d8077++)
        {
            int _0x7a73799d;
            if (_0xb18d8077 < _0xd04e59fe.EasyOpeningNotes)
            {
                _0x7a73799d = _0xb18d8077 % _0x38c6998c.LaneCount;
            }
            else
            {
                _0x7a73799d = _0x6528f202.Next(0, _0x38c6998c.LaneCount);
                if (_0x7a73799d == _0x8d44a31a && _0xae0aedb7 >= _0xd04e59fe.MaxSameLaneRun)
                {
                    _0x7a73799d = (_0x7a73799d + 1 + _0x6528f202.Next(0, _0x38c6998c.LaneCount - 1)) % _0x38c6998c.LaneCount;
                }
            }

            _0xae0aedb7 = _0x7a73799d == _0x8d44a31a ? _0xae0aedb7 + 1 : 1;
            _0x8d44a31a = _0x7a73799d;
            _0xd8a952e7[_0xb18d8077] = _0x7a73799d;
        }

        return _0xd8a952e7;
    }
}

internal static class _0x98f8dc36
{
    internal static string _0x45040473(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}