using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonObjectPanel : ObjectPanelInfo 
{
    [SerializeField]
    private Button LevelUpButton;
    private void Start()
    {
        LevelUpButton.onClick.AddListener(() =>
        {
            Debug.Log("LevelUp!!!");
        }

        );
    }
    
}
