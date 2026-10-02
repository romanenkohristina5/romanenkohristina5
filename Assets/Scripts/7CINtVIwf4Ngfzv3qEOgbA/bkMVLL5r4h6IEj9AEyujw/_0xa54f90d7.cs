using UnityEngine;

public class _0xa54f90d7 : MonoBehaviour
{
    public bool IsLevelSelectorEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xa54f90d7>();
            DontDestroyOnLoad(this.gameObject);
            this._0xf75b9775();
        }
        else
        {
            this._0x97f4d7a9();
            Destroy(this.gameObject);
        }
    }

    public bool IsLevelIncrementOnWin;
    public bool IsOnlyWinGameEndEnabled;
    private void _0xf75b9775()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsTimerEnabled;
    public bool IsTutorialEnabled;
    public bool IsStoryEnabled;
    public bool IsBestScoreEnabled;
    public bool IsCheckScoreEnabled;
    public static _0xa54f90d7 Instance;
    private void _0x97f4d7a9()
    {
    }

    public bool IsSkipSplashEnabled;
}