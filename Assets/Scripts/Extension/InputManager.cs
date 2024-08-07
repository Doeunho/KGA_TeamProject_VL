using System.ComponentModel;
using UnityEngine;
using UnityEngine.InputSystem;

public static class InputManager
{   
    static Vector2 _moveVector2_Left;
    static float _rotateValue;

    static bool _isLMouseBtnClick;
    static bool _isRMouseBtnClick;
    static bool _isLControlBtnClick;
    static bool _isTapBtnClick;

    public static Vector2 MoveVector2_Left
    {
        get { return _moveVector2_Left; }
        set
        {
            if (_moveVector2_Left != value)
            {
                _moveVector2_Left = value;
                OnPropertyChanged(nameof(MoveVector2_Left));
            }
        }
    }

    public static float RotateValue
    {
        get { return _rotateValue; }
        set
        {
            if (_rotateValue != value)
            {
                _rotateValue = value;
                OnPropertyChanged(nameof(RotateValue));
            }
        }
    }

    public static bool IsLMouseBtnClick
    {
        get { return _isLMouseBtnClick; }
        set
        {
            if (_isLMouseBtnClick != value)
            {
                _isLMouseBtnClick = value;
                OnPropertyChanged(nameof(IsLMouseBtnClick));
            }
        }
    }

    public static bool IsRMouseBtnClick
    {
        get { return _isRMouseBtnClick; }
        set
        {
            if (_isRMouseBtnClick != value)
            {
                _isRMouseBtnClick = value;
                OnPropertyChanged(nameof(IsRMouseBtnClick));
            }
        }
    }

    public static bool IsLControlBtnClick
    {
        get { return _isLControlBtnClick; }
        set
        {
            if (_isLControlBtnClick != value)
            {
                _isLControlBtnClick = value;
                OnPropertyChanged(nameof(IsLControlBtnClick));
            }
        }
    }

    public static bool IsTapBtnClick
    {
        get { return _isTapBtnClick; }
        set
        {
            if (_isTapBtnClick != value)
            {
                _isTapBtnClick = value;
                OnPropertyChanged(nameof(IsTapBtnClick));
            }
        }
    }

    #region PropChanged
    public static event PropertyChangedEventHandler PropertyChanged;

    public static void OnPropertyChanged(string propertyName)//���� ����Ǿ��� �� �̺�Ʈ�� �߻���Ű�� ���� �뵵 (������ ���ε�)
    {
        PropertyChanged?.Invoke(null, new PropertyChangedEventArgs(propertyName));
    }
    #endregion

    static void OnMove(InputValue inputValue) // �̵�(WASD)
    {
        MoveVector2_Left = inputValue.Get<Vector2>();
    }

    static void OnAtk(InputValue value) // ���콺 ��Ŭ��
    {
        IsLMouseBtnClick = value.Get<bool>();
    }

    static void OnSkill(InputValue value)//���콺 ��Ŭ��
    {
        IsRMouseBtnClick = value.Get<bool>();
    }

    static void OnBacuum(InputValue value)//���� ��Ʈ�� Ŭ��
    {
        IsLControlBtnClick = value.Get<bool>();
    }

    static void OnInventory(InputValue value)//�� ��ư Ŭ��
    {
        IsTapBtnClick = value.Get<bool>();
    }

    static void OnRotate(InputValue value)
    {
        RotateValue = value.Get<float>();
    }
}
