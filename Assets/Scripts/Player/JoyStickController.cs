using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class JoyStickController : MonoBehaviour, IDragHandler,IPointerUpHandler,IPointerDownHandler
{
    private Image JoystickBG;
    private Image Joystick;
    private Vector2 inputVect;

    void Start()
    {
        JoystickBG = GetComponent<Image>();
        Joystick = transform.GetChild(0).GetComponent<Image>();
        
    }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        inputVect = Vector2.zero;
        Joystick.rectTransform.anchoredPosition =  Vector2.zero;
    }
    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(JoystickBG.rectTransform,ped.position,ped.pressEventCamera,out pos))
        {
            pos.x = (pos.x / JoystickBG.rectTransform.sizeDelta.x);
            pos.y = (pos.y / JoystickBG.rectTransform.sizeDelta.y);

            inputVect = new Vector2(pos.x*2 , pos.y*2 );
            inputVect = (inputVect.magnitude > 1.0f) ? inputVect.normalized : inputVect;
            Joystick.rectTransform.anchoredPosition = new Vector2(inputVect.x * (JoystickBG.rectTransform.sizeDelta.x/2 ), inputVect.y * (JoystickBG.rectTransform.sizeDelta.y /2));

        }

    }
    public float Horizontal()
    {
        if (inputVect.x!=0)
        {
            return inputVect.x;
        }
        else
        {
            return Input.GetAxisRaw("Horizontal");
        }
    }
    public float Vertical()
    {
        if (inputVect.y != 0)
        {
            return inputVect.y;
        }
        else
        {
            return Input.GetAxisRaw("Vertical");
        }
    }
}
