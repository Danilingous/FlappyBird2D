using UnityEngine;

public class GameMode : MonoBehaviour
{
    public static GameMode Instance;
    private const float _speedBarrierSlowMode = 3f;
    private const float _speedBarrierRapidMode = 5f;

    private float _speedBarrierForwardMove = _speedBarrierSlowMode;
    private NamesGameMode _curentNamesGameMode = NamesGameMode.Easy; 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else Destroy(gameObject);
    }

    public float GetCurentSpeedBarrierForwardMove() => _speedBarrierForwardMove;
    public NamesGameMode GetCurentNameGameMode() => _curentNamesGameMode;






    public void SetEasyMode()
    {
        _speedBarrierForwardMove = _speedBarrierSlowMode;
        _curentNamesGameMode = NamesGameMode.Easy;
    }
    public void SetHardMode()
    {
        _speedBarrierForwardMove = _speedBarrierSlowMode;
        _curentNamesGameMode = NamesGameMode.Hard;
    }
    public void SetVeryHardMode()
    {
        _speedBarrierForwardMove = _speedBarrierRapidMode;
        _curentNamesGameMode = NamesGameMode.VeryHard;
    }

}
