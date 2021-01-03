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
      SkillManager.instance.activateSkill = transform.GetComponent<Skill>();
      skillImage.sprite = SkillManager.instance.skills[skillButtonID].skillSprite;
      skillNameText.text = SkillManager.instance.skills[skillButtonID].skillName;
      skillDesText.text = SkillManager.instance.skills[skillButtonID].skillDes;
      skillCostText.text = SkillManager.instance.skills[skillButtonID].skillCostString;
    }
}
