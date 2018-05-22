using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Text;
using System.IO;

public class UIController : MonoBehaviour
{

    public GameObject SettingUI;
    public Dropdown[] Dropdowns;//Language VoiceInput
    public Text ModelPath;
    Dictionary<String, String> Configs = new Dictionary<String, String>();

    void Start()
    {
        StreamReader SR = new StreamReader("Config.ini", Encoding.Default);
        String line;
        while ((line = SR.ReadLine()) != null)
        {
            String[] cline = line.Split('=');
            Configs.Add(cline[0], cline[1]);
        }
        SR.Close();
        switch (Configs["Language"])
        {
            case "Chinese":
                {
                    Dropdowns[0].value = 0;
                    break;
                }
            case "Japanese":
                {
                    Dropdowns[0].value = 1;
                    break;
                }
        }
        switch (Configs["VoiceInput"])
        {
            case "on":
                {
                    Dropdowns[1].value = 0;
                    break;
                }
            case "off":
                {
                    Dropdowns[1].value = 1;
                    break;
                }
        }
        switch (Configs["DefaultModel"])
        {
            case "true":
                {
                    Dropdowns[2].value = 0;
                    break;
                }
            case "false":
                {
                    Dropdowns[2].value = 1;
                    break;
                }
        }

        ModelPath.text = Configs["ModelPath"];
    }

    public void ShowSettings()
    {
        SettingUI.SetActive(true);
    }

    public void HideSettings()
    {
        SettingUI.SetActive(false);
    }

    public void ChangeSettings()
    {
        switch (Dropdowns[0].value)
        {
            case 0:
                {
                    Configs["Language"] = "Chinese";
                    break;
                }
            case 1:
                {
                    Configs["Language"] = "Japanese";
                    break;
                }
        }
        switch (Dropdowns[1].value)
        {
            case 0:
                {
                    Configs["VoiceInput"] = "on";
                    break;
                }
            case 1:
                {
                    Configs["VoiceInput"] = "off";
                    break;
                }
        }
        switch (Dropdowns[2].value)
        {
            case 0:
                {
                    Configs["DefaultModel"] = "true";
                    break;
                }
            case 1:
                {
                    Configs["DefaultModel"] = "false";
                    break;
                }
        }
    }

    public void ConfirmSettings()
    {
        Configs["ModelPath"] = ModelPath.text;
        StreamWriter SW = new StreamWriter("Config.ini", false);
        for (int i = 0; i < Configs.Keys.Count; i++)
        {

            String line = Configs.Keys.ElementAt(i) + "=" + Configs.Values.ElementAt(i);
            SW.WriteLine(line);
        }
        SW.Close();
        HideSettings();
    }
}