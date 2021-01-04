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
      UpdatePrice();
    }

    public void UpdateSkill(){
      skillImage.sprite = SkillManager.instance.skills[skillButtonID].skillSprite;
      skillNameText.text = SkillManager.instance.skills[skillButtonID].skillName;
      skillDesText.text = SkillManager.instance.skills[skillButtonID].skillDes;
      UpdatePrice();
    }

    void UpdatePrice(){
      if (SkillManager.instance.skills[skillButtonID].counter==SkillManager.instance.skills[skillButtonID].timesBuyable) {
        skillCostText.text = "Max Update";
      } else{
        skillCostText.text = SkillManager.instance.skills[skillButtonID].skillCost.ToString();
      }
    }
}
