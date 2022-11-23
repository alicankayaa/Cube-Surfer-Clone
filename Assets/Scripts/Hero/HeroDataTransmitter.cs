using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeroDataTransmitter : MonoBehaviour
{
    [SerializeField] private HeroInputController heroInputController;


    public float GetHeroHorizontalValue()
    {
        return heroInputController.HorizontalValue;
    }
}
