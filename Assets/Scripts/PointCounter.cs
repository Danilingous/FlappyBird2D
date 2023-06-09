using TMPro;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textPointsValue;
    private int _pointsValue = 0;


    public void AddPoint()
    {
        _pointsValue++;
        _textPointsValue.text = _pointsValue.ToString();
    }


}
