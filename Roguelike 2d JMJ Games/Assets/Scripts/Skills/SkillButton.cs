using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkillButton : MonoBehaviour
{
    public Animator animator;
    public Image skillImage;
    public TextMeshProUGUI skillNameText;
    public TextMeshProUGUI skillDesText;
    public TextMeshProUGUI skillCostText;

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
