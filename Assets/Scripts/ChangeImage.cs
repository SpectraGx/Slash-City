using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class ChangeImage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image target;
    public Sprite clickSprite;
    public Sprite normalSprite;

    public void ChanngeOnClick()
    {
        target.sprite = clickSprite;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        target.sprite = clickSprite;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        target.sprite = clickSprite;
    }
}
