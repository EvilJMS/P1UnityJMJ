using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillButton : MonoBehaviour
{
    public Image skillImage;
    public Text skillNameText;
    public Text skillDesText;
    public Text skillCostText;

    public int skillButtonID;

    public void PressSkillButton(){
      skillImage.sprite = SkillManager.instance.skills[skillButtonID].skillSprite;
    }
}
