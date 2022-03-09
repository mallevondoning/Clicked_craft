using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBlock : MonoBehaviour
{
    [SerializeField]
    private BlockType _blockType;

    public int _clickDelta { get; set; }

    private float _random;
    private int _clickTimes;
    private int _clickMax = 5;

    private void Awake()
    {
        _clickTimes = _clickMax - _clickDelta;
    }

    private void Update()
    {
        if (_clickTimes <= 0)
        {
            AddResource();
            _clickTimes = _clickMax - _clickDelta;
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _clickTimes--;
            Debug.Log(_clickTimes+" on "+gameObject.name);
        }
    }

    private void AddResource()
    {
        switch (_blockType)
        {
            case BlockType.WoodBlock:
                break;
            case BlockType.StoneBlock:
                break;
            default:
                Debug.Log("Click block ID not set on "+gameObject.name);
                break;
        }
    }
}
