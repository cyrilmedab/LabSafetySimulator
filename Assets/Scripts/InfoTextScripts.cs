using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InfoTextScripts : MonoBehaviour
{
    [SerializeField] private GameObject leftCanvas;
    [SerializeField] private GameObject middleCanvas;
    [SerializeField] private GameObject rightCanvas;

    private TextMeshProUGUI _leftHeader;
    public TextMeshProUGUI _leftBody;
    
    private TextMeshProUGUI _middleHeader;
    private TextMeshProUGUI _middleBody;
    
    private TextMeshProUGUI _rightHeader;
    private TextMeshProUGUI _rightBody;
    
    // Start is called before the first frame update
    void Start()
    {
        string sharpsLeftText = "\nUsed for disposal of biohazardous sharps" +
                                "such as contaminated needles, scalpels, broken" +
                                " glass, pipette tips, etc. \n" +
                                "Meets OSHA Bloodborne Pathogens Standard for " +
                                "puncture resistant containers.\n" +
                                "Replaced when it reaches 3/4 full.\n" +
                                "Labeled in accordance with OSHA Bloodborne Pathogens" +
                                "Standard.\n" +
                                "Leakproof on the sides and bottom.\n" +
                                "Discarded in UN3291 Regulated Medical Waste cardboard " +
                                "boxes for off-site incineration.";
        string sharpsRightText = "\nUsed for disposal of non-hazardous glass such as " +
                                "broken or unwanted glassware and other properly" +
                                " decontaminated sharps. \n" +
                                "Has Limited puncture resistance, especially when wet. \n" +
                                "Replaced before it's too heavy too lift, even if not full. \n" +
                                "Has limited leak resistance (The inner plastic bag can be easily punctured).\n" +
                                "Limited sturdiness - bottom may fall out if container is overfilled. \n" +
                                "Discarded in dumpster as regular landfill waste. \n";

        _leftHeader = leftCanvas.transform.GetChild(1).GetChild(2).GetChild(0).GetComponent<TextMeshProUGUI>();
        _leftBody = leftCanvas.transform.GetChild(1).GetChild(2).GetChild(1).GetComponent<TextMeshProUGUI>();
        
        _middleHeader = middleCanvas.transform.GetChild(1).GetChild(2).GetChild(0).GetComponent<TextMeshProUGUI>();
        _middleBody = middleCanvas.transform.GetChild(1).GetChild(2).GetChild(1).GetComponent<TextMeshProUGUI>();
        
        _rightHeader = rightCanvas.transform.GetChild(1).GetChild(2).GetChild(0).GetComponent<TextMeshProUGUI>();
        _rightBody = rightCanvas.transform.GetChild(1).GetChild(2).GetChild(1).GetComponent<TextMeshProUGUI>();

        _leftHeader.text = "BIOHAZARDOUS SHARPS CONTAINERS";
        _leftBody.text = sharpsLeftText;

        _rightHeader.text = "BROKEN GLASS CONTAINERS";
        _rightBody.text = sharpsRightText;

        _middleHeader.text = "WELCOME TO YOUR LAB SAFETY SIMULATION";
        _middleBody.text = "Here you can explore some safety guidelines and familiarize yourself with " +
                           "the best safety practices for lab work. It's critical to follow these guidelines" +
                           "to keep both you and the others around you safe, and to achieve results without" +
                           " endangering the environment and health of the population!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
