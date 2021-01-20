using UnityEngine;
using UnityEngine.UI;

public class I18nTextTranslator : MonoBehaviour
{
    public string TextId;
    private Text text;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        if (text != null)
            if(TextId == "ISOCode")
                text.text = I18n.GetLanguage();
            else
                text.text = I18n.Fields[TextId];
    }

    // Update is called once per frame
    void Update()
    {
        text.text = I18n.Fields[TextId];
    }

    public void ChangeLanguage(){
        if (I18n.language == "en")
        {
            I18n.SetLanguage("ja");
        }
        else
        {
            I18n.SetLanguage("en");
        }
    }
}