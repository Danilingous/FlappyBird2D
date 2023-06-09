using UnityEngine;

public class GameMode : MonoBehaviour
{
    public static GameMode Instance;
    private const float _speedBarrierSlowMode = 3f;
    private const float _speedBarrierRapidMode = 5f;

    private bool _isMute;
    private float _curentSpeedBarrierForwardMove = _speedBarrierSlowMode;
    private NamesGameMode _curentNamesGameMode = NamesGameMode.Easy;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            LoadPlayerPrefs();
        }
        else Destroy(gameObject);
    }

    private void LoadPlayerPrefs()
    {

        if (PlayerPrefs.HasKey("GameMode"))
        {
            _curentNamesGameMode = (NamesGameMode)PlayerPrefs.GetInt("GameMode");
            if ((int)_curentNamesGameMode > 1) _curentSpeedBarrierForwardMove = _speedBarrierRapidMode;
        }
        if (PlayerPrefs.HasKey("isMute"))
        {
            _isMute = System.Convert.ToBoolean(PlayerPrefs.GetInt("isMute"));
        }
    }



    public float GetCurentSpeedBarrierForwardMove() => _curentSpeedBarrierForwardMove;
    public NamesGameMode GetCurentNameGameMode() => _curentNamesGameMode;
    public bool GetMuteStatus() => _isMute;

    public void SetEasyMode()
    {
        _curentSpeedBarrierForwardMove = _speedBarrierSlowMode;
        _curentNamesGameMode = NamesGameMode.Easy;
    }
    public void SetHardMode()
    {
        _curentSpeedBarrierForwardMove = _speedBarrierSlowMode;
        _curentNamesGameMode = NamesGameMode.Hard;
    }
    public void SetVeryHardMode()
    {
        _curentSpeedBarrierForwardMove = _speedBarrierRapidMode;
        _curentNamesGameMode = NamesGameMode.VeryHard;
    }

}
