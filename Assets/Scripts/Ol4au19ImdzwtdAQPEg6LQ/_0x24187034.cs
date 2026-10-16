using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x24187034 : MonoBehaviour
{
    private const float MinOutlineWidth = 0.01f;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x9b3b103d != null)
            return;
        GameObject _0xb03927d5 = new GameObject(_0xe9ff19e8._0xc2d1eaee(new byte[16] { 227, 218, 199, 244, 216, 217, 195, 197, 214, 196, 195, 240, 194, 214, 197, 211 }, 183));
        _0xb03927d5.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xb03927d5);
        _0x9b3b103d = _0xb03927d5.AddComponent<_0x24187034>();
    }

    private const float MinRatio = 4.5f;
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xa534a0d9(Object _0xa8242875)
    {
        TMP_Text _0x298b0eb1 = _0xa8242875 as TMP_Text;
        if (_0x298b0eb1 != null)
            this._0x314862af.Add(_0x298b0eb1);
    }

    private void OnDisable()
    {
        if (this._0x9ae9bc68 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x9ae9bc68);
    }

    private static float Linear(float _0xd617ecea)
    {
        _0xd617ecea = Mathf.Clamp01(_0xd617ecea);
        return _0xd617ecea <= 0.03928f ? _0xd617ecea / 12.92f : Mathf.Pow((_0xd617ecea + 0.055f) / 1.055f, 2.4f);
    }

    private readonly HashSet<TMP_Text> _0x314862af = new HashSet<TMP_Text>();
    private const float TargetRatio = 7f;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x9c60e244)
    {
        return 0.2126f * Linear(_0x9c60e244.r) + 0.7152f * Linear(_0x9c60e244.g) + 0.0722f * Linear(_0x9c60e244.b);
    }

    private void LateUpdate()
    {
        if (this._0x314862af.Count == 0)
            return;
        this._0xea8ef2ca.Clear();
        this._0xea8ef2ca.AddRange(this._0x314862af);
        this._0x314862af.Clear();
        for (int _0xa5cdead4 = 0; _0xa5cdead4 < this._0xea8ef2ca.Count; _0xa5cdead4++)
            Fix(this._0xea8ef2ca[_0xa5cdead4]);
    }

    private static float Ratio(Color _0x769df4fb, Color _0x17ae77d6)
    {
        float _0x4d5c299d = Luminance(_0x769df4fb);
        float _0xf0ed9249 = Luminance(_0x17ae77d6);
        return (Mathf.Max(_0x4d5c299d, _0xf0ed9249) + 0.05f) / (Mathf.Min(_0x4d5c299d, _0xf0ed9249) + 0.05f);
    }

    private void OnEnable()
    {
        if (this._0x9ae9bc68 == null)
            this._0x9ae9bc68 = _0xd06ef816 => this._0xa534a0d9(_0xd06ef816);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x9ae9bc68);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x9ae9bc68;
    private static _0x24187034 _0x9b3b103d;
    private static void Fix(TMP_Text _0xc58b7934)
    {
        if (_0xc58b7934 == null || !_0xc58b7934.isActiveAndEnabled)
            return;
        Material _0xc394f3ef = _0xc58b7934.fontSharedMaterial;
        if (_0xc394f3ef == null || !_0xc394f3ef.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xc394f3ef.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xc394f3ef.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x3a50a0f6 = _0xc58b7934.color;
        if (_0x3a50a0f6.a <= 0f)
            return;
        Color _0x4b3de969 = _0xc394f3ef.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x3a50a0f6, _0x4b3de969) >= MinRatio)
            return;
        Color _0x38269583 = Luminance(_0x4b3de969) < 0.5f ? Color.white : Color.black;
        Color _0xfe96d0c0;
        if (Ratio(_0x38269583, _0x4b3de969) < TargetRatio)
        {
            _0xfe96d0c0 = _0x38269583;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x275ef845 = 0f;
            float _0xfc15ff0c = 1f;
            for (int _0x79b1b0f8 = 0; _0x79b1b0f8 < 20; _0x79b1b0f8++)
            {
                float _0xcbb6132e = (_0x275ef845 + _0xfc15ff0c) * 0.5f;
                if (Ratio(Color.Lerp(_0x3a50a0f6, _0x38269583, _0xcbb6132e), _0x4b3de969) >= TargetRatio)
                    _0xfc15ff0c = _0xcbb6132e;
                else
                    _0x275ef845 = _0xcbb6132e;
            }

            _0xfe96d0c0 = Color.Lerp(_0x3a50a0f6, _0x38269583, _0xfc15ff0c);
        }

        _0xfe96d0c0.a = _0x3a50a0f6.a;
        _0xc58b7934.color = _0xfe96d0c0;
    }

    private readonly List<TMP_Text> _0xea8ef2ca = new List<TMP_Text>();
}

internal static class _0xe9ff19e8
{
    internal static string _0xc2d1eaee(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}