using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject personalData;
    public GameObject reports;
    public GameObject analysis;
    public GameObject bodyPart;
    public float bodyPartHeight;
    public float bodyPartWidth;
    public UnityEngine.UI.Image bodyPartDisplay;
    public RectTransform bodyPartDisplayTransform;
    public TextMeshProUGUI bodyPartTitle;
    public TMP_InputField bodyPartNotes;
    public TMP_InputField ageInput;
    public TMP_InputField sexInput;
    public TMP_InputField conditionInput;
    public TextMeshProUGUI editButtonText;

    public void OpenMainMenu()
    {
        mainMenu.SetActive(true);
        personalData.SetActive(false);
        reports.SetActive(false);
        analysis.SetActive(false);
        bodyPart.SetActive(false);
    }

    public void OpenPersonalData()
    {
        personalData.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void OpenReports()
    {
        reports.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void OpenAnalysis()
    {
        analysis.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void OpenBodyPart(GameObject selectedBodyPart)
    {
        bodyPartNotes.text = "";
        bodyPart.SetActive(true);
        mainMenu.SetActive(false);
        bodyPartTitle.text = selectedBodyPart.name;
        bodyPartHeight = selectedBodyPart.GetComponent<RectTransform>().sizeDelta.y;
        bodyPartWidth = selectedBodyPart.GetComponent<RectTransform>().sizeDelta.x;
        bodyPartDisplayTransform.sizeDelta = new Vector2(bodyPartWidth, bodyPartHeight);
        bodyPartDisplay.sprite = selectedBodyPart.GetComponent<UnityEngine.UI.Image>().sprite;
    }

    public void EditPersonalInfo()
    {
        if (ageInput.interactable)
        {
            ageInput.interactable = false;
            sexInput.interactable = false;
            conditionInput.interactable = false;
            editButtonText.text = "Edit Info";
        }
        else
        {
            ageInput.interactable = true;
            sexInput.interactable = true;
            conditionInput.interactable = true;
            editButtonText.text = "Save Info";
        }
    }
}
