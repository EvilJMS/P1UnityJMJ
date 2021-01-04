using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillButton : MonoBehaviour
{
    public Animator animator;
    public Image skillImage;
    public Text skillNameText;
    public Text skillDesText;
    public Text skillCostText;

    public int skillButtonID;

    public void PressSkillButton(){
      animator.SetBool("isOpen", true);
      SkillManager.instance.activateSkill = transform.GetComponent<Skill>();
      skillImage.sprite = SkillManager.instance.skillList[skillButtonID].skillSprite;
      skillNameText.text = SkillManager.instance.skillList[skillButtonID].skillName;
      skillDesText.text = SkillManager.instance.skillList[skillButtonID].skillDes;
      UpdatePrice();
    }

    public void UpdateSkill(){
      skillImage.sprite = SkillManager.instance.skillList[skillButtonID].skillSprite;
      skillNameText.text = SkillManager.instance.skillList[skillButtonID].skillName;
      skillDesText.text = SkillManager.instance.skillList[skillButtonID].skillDes;
      UpdatePrice();
    }

    void UpdatePrice(){
      if (SkillManager.instance.skillList[skillButtonID].counter==SkillManager.instance.skillList[skillButtonID].timesBuyable) {
        skillCostText.text = "Max Update";
      } else{
        skillCostText.text = SkillManager.instance.skillList[skillButtonID].skillCost.ToString();
      }
    }
}
