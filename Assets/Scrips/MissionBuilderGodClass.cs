using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionBuilderGodClass : MonoBehaviour
{
    public WitchMission WM;
    public Option Op;
    public SaveGodClass SGC;
    [Header("InputFields")]
    public InputField MInput;
    public InputField[] QInputs = new InputField[21];
    public InputField[] IInputs01 = new InputField[21];
    public InputField[] IInputs02 = new InputField[21];
    public InputField[] IInputs03 = new InputField[21];
    public InputField[] IInputs04 = new InputField[21];
    public InputField[] IInputs05 = new InputField[21];
    public InputField[] IInputs06 = new InputField[21];
    public InputField[] CInputs01 = new InputField[21];
    public AudioSource AudioSorce;
    public AudioClip Type;
    [Space(10)]
    [Header("Questions")]
    public string[] Qes1 = new string[21];
    public string[] Qes2 = new string[21];
    public string[] Qes3 = new string[21];
    public string[] Qes4 = new string[21];
    public string[] Qes5 = new string[21];
    public string[] Qes6 = new string[21];
    public string[] Qes7 = new string[21];
    public string[] Qes8 = new string[21];
    public string[] Qes9 = new string[21];
    public string[] Qes10 = new string[21];
    public string[] Qes11 = new string[21];
    public string[] Qes12 = new string[21];
    public string[] Qes13 = new string[21];
    public string[] Qes14 = new string[21];
    public string[] Qes15 = new string[21];
    public string[] Qes16 = new string[21];
    public string[] Qes17 = new string[21];
    public string[] Qes18 = new string[21];
    public string[] Qes19 = new string[21];
    public string[] Qes20 = new string[21];
    [Space (10)]
    [Header ("Option0")] // First Option. I messed up earlier calling it Option0
    public string[] Opt00S01 = new string[21];
    public string[] Opt00S02 = new string[21];
    public string[] Opt00S03 = new string[21];
    public string[] Opt00S04 = new string[21];
    public string[] Opt00S05 = new string[21];
    public string[] Opt00S06 = new string[21];
    public string[] Opt00S07 = new string[21];
    public string[] Opt00S08 = new string[21];
    public string[] Opt00S09 = new string[21];
    public string[] Opt00S010 = new string[21];
    public string[] Opt00S011 = new string[21];
    public string[] Opt00S012 = new string[21];
    public string[] Opt00S013 = new string[21];
    public string[] Opt00S014 = new string[21];
    public string[] Opt00S015 = new string[21];
    public string[] Opt00S016 = new string[21];
    public string[] Opt00S017 = new string[21];
    public string[] Opt00S018 = new string[21];
    public string[] Opt00S019 = new string[21];
    public string[] Opt00S020 = new string[21];
    [Space(10)]
    [Header("Option1")]
    public string[] Opt01S01 = new string[21];
    public string[] Opt01S02 = new string[21];
    public string[] Opt01S03 = new string[21];
    public string[] Opt01S04 = new string[21];
    public string[] Opt01S05 = new string[21];
    public string[] Opt01S06 = new string[21];
    public string[] Opt01S07 = new string[21];
    public string[] Opt01S08 = new string[21];
    public string[] Opt01S09 = new string[21];
    public string[] Opt01S010 = new string[21];
    public string[] Opt01S011 = new string[21];
    public string[] Opt01S012 = new string[21];
    public string[] Opt01S013 = new string[21];
    public string[] Opt01S014 = new string[21];
    public string[] Opt01S015 = new string[21];
    public string[] Opt01S016 = new string[21];
    public string[] Opt01S017 = new string[21];
    public string[] Opt01S018 = new string[21];
    public string[] Opt01S019 = new string[21];
    public string[] Opt01S020 = new string[21];
    [Space(10)]
    [Header("Option2")]
    public string[] Opt02S01 = new string[21];
    public string[] Opt02S02 = new string[21];
    public string[] Opt02S03 = new string[21];
    public string[] Opt02S04 = new string[21];
    public string[] Opt02S05 = new string[21];
    public string[] Opt02S06 = new string[21];
    public string[] Opt02S07 = new string[21];
    public string[] Opt02S08 = new string[21];
    public string[] Opt02S09 = new string[21];
    public string[] Opt02S010 = new string[21];
    public string[] Opt02S011 = new string[21];
    public string[] Opt02S012 = new string[21];
    public string[] Opt02S013 = new string[21];
    public string[] Opt02S014 = new string[21];
    public string[] Opt02S015 = new string[21];
    public string[] Opt02S016 = new string[21];
    public string[] Opt02S017 = new string[21];
    public string[] Opt02S018 = new string[21];
    public string[] Opt02S019 = new string[21];
    public string[] Opt02S020 = new string[21];
    [Space(10)]
    [Header("Option3")]
    public string[] Opt03S01 = new string[21];
    public string[] Opt03S02 = new string[21];
    public string[] Opt03S03 = new string[21];
    public string[] Opt03S04 = new string[21];
    public string[] Opt03S05 = new string[21];
    public string[] Opt03S06 = new string[21];
    public string[] Opt03S07 = new string[21];
    public string[] Opt03S08 = new string[21];
    public string[] Opt03S09 = new string[21];
    public string[] Opt03S010 = new string[21];
    public string[] Opt03S011 = new string[21];
    public string[] Opt03S012 = new string[21];
    public string[] Opt03S013 = new string[21];
    public string[] Opt03S014 = new string[21];
    public string[] Opt03S015 = new string[21];
    public string[] Opt03S016 = new string[21];
    public string[] Opt03S017 = new string[21];
    public string[] Opt03S018 = new string[21];
    public string[] Opt03S019 = new string[21];
    public string[] Opt03S020 = new string[21];
    [Space(10)]
    [Header("Option4")]
    public string[] Opt04S01 = new string[21];
    public string[] Opt04S02 = new string[21];
    public string[] Opt04S03 = new string[21];
    public string[] Opt04S04 = new string[21];
    public string[] Opt04S05 = new string[21];
    public string[] Opt04S06 = new string[21];
    public string[] Opt04S07 = new string[21];
    public string[] Opt04S08 = new string[21];
    public string[] Opt04S09 = new string[21];
    public string[] Opt04S010 = new string[21];
    public string[] Opt04S011 = new string[21];
    public string[] Opt04S012 = new string[21];
    public string[] Opt04S013 = new string[21];
    public string[] Opt04S014 = new string[21];
    public string[] Opt04S015 = new string[21];
    public string[] Opt04S016 = new string[21];
    public string[] Opt04S017 = new string[21];
    public string[] Opt04S018 = new string[21];
    public string[] Opt04S019 = new string[21];
    public string[] Opt04S020 = new string[21];
    [Space(10)]
    [Header("Option5")]
    public string[] Opt05S01 = new string[21];
    public string[] Opt05S02 = new string[21];
    public string[] Opt05S03 = new string[21];
    public string[] Opt05S04 = new string[21];
    public string[] Opt05S05 = new string[21];
    public string[] Opt05S06 = new string[21];
    public string[] Opt05S07 = new string[21];
    public string[] Opt05S08 = new string[21];
    public string[] Opt05S09 = new string[21];
    public string[] Opt05S010 = new string[21];
    public string[] Opt05S011 = new string[21];
    public string[] Opt05S012 = new string[21];
    public string[] Opt05S013 = new string[21];
    public string[] Opt05S014 = new string[21];
    public string[] Opt05S015 = new string[21];
    public string[] Opt05S016 = new string[21];
    public string[] Opt05S017 = new string[21];
    public string[] Opt05S018 = new string[21];
    public string[] Opt05S019 = new string[21];
    public string[] Opt05S020 = new string[21];
    [Space(10)]
    [Header("Option6")]
    public string[] Opt06S01 = new string[21];
    public string[] Opt06S02 = new string[21];
    public string[] Opt06S03 = new string[21];
    public string[] Opt06S04 = new string[21];
    public string[] Opt06S05 = new string[21];
    public string[] Opt06S06 = new string[21];
    public string[] Opt06S07 = new string[21];
    public string[] Opt06S08 = new string[21];
    public string[] Opt06S09 = new string[21];
    public string[] Opt06S010 = new string[21];
    public string[] Opt06S011 = new string[21];
    public string[] Opt06S012 = new string[21];
    public string[] Opt06S013 = new string[21];
    public string[] Opt06S014 = new string[21];
    public string[] Opt06S015 = new string[21];
    public string[] Opt06S016 = new string[21];
    public string[] Opt06S017 = new string[21];
    public string[] Opt06S018 = new string[21];
    public string[] Opt06S019 = new string[21];
    public string[] Opt06S020 = new string[21];
    [Space(10)]
    [Header("Correct Inputs")]
    public int[] Crct01 = new int[21];
    public int[] Crct02 = new int[21];
    public int[] Crct03 = new int[21];
    public int[] Crct04 = new int[21];
    public int[] Crct05 = new int[21];
    public int[] Crct06 = new int[21];
    public int[] Crct07 = new int[21];
    public int[] Crct08 = new int[21];
    public int[] Crct09 = new int[21];
    public int[] Crct010 = new int[21];
    public int[] Crct011 = new int[21];
    public int[] Crct012 = new int[21];
    public int[] Crct013 = new int[21];
    public int[] Crct014 = new int[21];
    public int[] Crct015 = new int[21];
    public int[] Crct016 = new int[21];
    public int[] Crct017 = new int[21];
    public int[] Crct018 = new int[21];
    public int[] Crct019 = new int[21];
    public int[] Crct020 = new int[21];

    // Start is called before the first frame update
    void Start()
    {
        WM = FindObjectOfType<WitchMission>();
        Op = FindObjectOfType<Option>();
        TempEditorSaver();
        SGC = FindObjectOfType<SaveGodClass>();
        SGC.LoadMissionBuilder();
        AudioSorce = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //print("Qes1[2] = " + Qes1[2]);
        print("Qes1[3] = " + Qes1[3]);
        //Qes1[1] = QInputs[1].text;
        // print(QInputs[1].text);
        //print(Qes1[1]);

    }
    public void QuestionInput(int QNum) // Num means witch slide
    {
        if (QNum == 1)
        {
            Qes1[WM.WitchLevel] = QInputs[1].text; //Qes1 Will turn into whatever the input is for the text inputfeild
            Op.Q0Slide1 = Qes1[WM.WitchLevel];  //The projected slide will turn into whatever Qes1 is
           print("Function QNum Qes1[3] = " + Qes1[3]);
        }                                       // When Saveing class is added, Save Qes1 not Q0Slide1
        if (QNum == 2)
        {
            Qes2[WM.WitchLevel] = QInputs[2].text;
            Op.Q0Slide2 = Qes2[WM.WitchLevel];
        }
        if (QNum == 3)
        {
            Qes3[WM.WitchLevel] = QInputs[3].text;
            Op.Q0Slide3 = Qes3[WM.WitchLevel];
        }
        if (QNum == 4)
        {
            Qes4[WM.WitchLevel] = QInputs[4].text;
            Op.Q0Slide4 = Qes4[WM.WitchLevel];
        }
        if (QNum == 5)
        {
            Qes5[WM.WitchLevel] = QInputs[5].text;
            Op.Q0Slide5 = Qes5[WM.WitchLevel];
        }
        if (QNum == 6)
        {
            Qes6[WM.WitchLevel] = QInputs[6].text;
            Op.Q0Slide6 = Qes6[WM.WitchLevel];

        }
        if (QNum == 7)
        {
            Qes7[WM.WitchLevel] = QInputs[7].text;
            Op.Q0Slide7 = Qes7[WM.WitchLevel];
        }
        if (QNum == 8)
        {
            Qes8[WM.WitchLevel] = QInputs[8].text;
            Op.Q0Slide8 = Qes8[WM.WitchLevel];
        }
        if (QNum == 9)
        {
            Qes9[WM.WitchLevel] = QInputs[9].text;
            Op.Q0Slide9 = Qes9[WM.WitchLevel];
        }
        if (QNum == 10)
        {
            Qes10[WM.WitchLevel] = QInputs[10].text;
            Op.Q0Slide10 = Qes10[WM.WitchLevel];
        }
        if (QNum == 11)
        {
            Qes11[WM.WitchLevel] = QInputs[11].text;
            Op.Q0Slide11 = Qes11[WM.WitchLevel];
        }
        if (QNum == 12)
        {
            Qes12[WM.WitchLevel] = QInputs[12].text;
            Op.Q0Slide12 = Qes12[WM.WitchLevel];
        }
        if (QNum == 13)
        {
            Qes13[WM.WitchLevel] = QInputs[13].text;
            Op.Q0Slide13 = Qes13[WM.WitchLevel];
        }
        if (QNum == 14)
        {
            Qes14[WM.WitchLevel] = QInputs[14].text;
            Op.Q0Slide14 = Qes14[WM.WitchLevel];
        }
        if (QNum == 15)
        {
            Qes15[WM.WitchLevel] = QInputs[15].text;
            Op.Q0Slide15 = Qes15[WM.WitchLevel];
        }
        if (QNum == 16)
        {
            Qes16[WM.WitchLevel] = QInputs[16].text;
            Op.Q0Slide16 = Qes16[WM.WitchLevel];
        }
        if (QNum == 17)
        {
            Qes17[WM.WitchLevel] = QInputs[17].text;
            Op.Q0Slide17 = Qes17[WM.WitchLevel];
        }
        if (QNum == 18)
        {
            Qes18[WM.WitchLevel] = QInputs[18].text;
            Op.Q0Slide18 = Qes18[WM.WitchLevel];
        }
        if (QNum == 19)
        {
            Qes19[WM.WitchLevel] = QInputs[19].text;
            Op.Q0Slide19 = Qes19[WM.WitchLevel];
        }
        if (QNum == 20)
        {
            Qes20[WM.WitchLevel] = QInputs[20].text;
            Op.Q0Slide20 = Qes20[WM.WitchLevel];
        }
        Op.TextChange();
        AudioSorce.clip = Type;
        AudioSorce.Play();
    }
   public void Option01Input(int INum) // Num means witch slide
    {
        if (INum == 1)
        {
            Opt00S01[WM.WitchLevel] = IInputs01[1].text;
            Op.O0Slide1 = Opt00S01[WM.WitchLevel];
        }
        if (INum == 2)
        {
            Opt00S02[WM.WitchLevel] = IInputs01[2].text;
            Op.O0Slide2 = Opt00S02[WM.WitchLevel];
        }
        if (INum == 3)
        {
            Opt00S03[WM.WitchLevel] = IInputs01[3].text;
            Op.O0Slide3 = Opt00S03[WM.WitchLevel];
        }
        if (INum == 4)
        {
            Opt00S04[WM.WitchLevel] = IInputs01[4].text;
            Op.O0Slide4 = Opt00S04[WM.WitchLevel];
        }
        if (INum == 5)
        {
            Opt00S05[WM.WitchLevel] = IInputs01[5].text;
            Op.O0Slide5 = Opt00S05[WM.WitchLevel];
        }
        if (INum == 6)
        {
            Opt00S06[WM.WitchLevel] = IInputs01[6].text;
            Op.O0Slide6 = Opt00S06[WM.WitchLevel];
        }
        if (INum == 7)
        {
            Opt00S07[WM.WitchLevel] = IInputs01[7].text;
            Op.O0Slide7 = Opt00S07[WM.WitchLevel];
        }
        if (INum == 8)
        {
            Opt00S08[WM.WitchLevel] = IInputs01[8].text;
            Op.O0Slide8 = Opt00S08[WM.WitchLevel];
        }
        if (INum == 9)
        {
            Opt00S09[WM.WitchLevel] = IInputs01[9].text;
            Op.O0Slide9 = Opt00S09[WM.WitchLevel];
        }
        if (INum == 10)
        {
            Opt00S010[WM.WitchLevel] = IInputs01[10].text;
            Op.O0Slide10 = Opt00S010[WM.WitchLevel];
        }
        if (INum == 11)
        {
            Opt00S011[WM.WitchLevel] = IInputs01[11].text;
            Op.O0Slide11 = Opt00S011[WM.WitchLevel];
        }
        if (INum == 12)
        {
            Opt00S012[WM.WitchLevel] = IInputs01[12].text;
            Op.O0Slide12 = Opt00S012[WM.WitchLevel];
        }
        if (INum == 13)
        {
            Opt00S013[WM.WitchLevel] = IInputs01[13].text;
            Op.O0Slide13 = Opt00S013[WM.WitchLevel];
        }
        if (INum == 14)
        {
            Opt00S014[WM.WitchLevel] = IInputs01[14].text;
            Op.O0Slide14 = Opt00S014[WM.WitchLevel];
        }
        if (INum == 15)
        {
            Opt00S015[WM.WitchLevel] = IInputs01[15].text;
            Op.O0Slide15 = Opt00S015[WM.WitchLevel];
        }
        if (INum == 16)
        {
            Opt00S016[WM.WitchLevel] = IInputs01[16].text;
            Op.O0Slide16 = Opt00S016[WM.WitchLevel];
        }
        if (INum == 17)
        {
            Opt00S017[WM.WitchLevel] = IInputs01[17].text;
            Op.O0Slide17 = Opt00S017[WM.WitchLevel];
        }
        if (INum == 18)
        {
            Opt00S018[WM.WitchLevel] = IInputs01[18].text;
            Op.O0Slide18 = Opt00S018[WM.WitchLevel];
        }
        if (INum == 19)
        {
            Opt00S019[WM.WitchLevel] = IInputs01[19].text;
            Op.O0Slide19 = Opt00S019[WM.WitchLevel];
        }
        if (INum == 20)
        {
            Opt00S020[WM.WitchLevel] = IInputs01[20].text;
            Op.O0Slide20 = Opt00S020[WM.WitchLevel];
        }
        Op.TextChange();
        AudioSorce.clip = Type;
        AudioSorce.Play();
    }
    public void Option02Input(int INum)
    {
        if (INum == 1) 
        {
            Opt01S01[WM.WitchLevel] = IInputs02[1].text; // opt01 is option 2
            Op.O1Slide1 = Opt01S01[WM.WitchLevel];            
        }
        if (INum == 2)
        {
            Opt01S02[WM.WitchLevel] = IInputs02[2].text; // opt01 is option 2
            Op.O1Slide2 = Opt01S02[WM.WitchLevel];
        }
        if (INum == 3)
        {
            Opt01S03[WM.WitchLevel] = IInputs02[3].text; // opt01 is option 2
            Op.O1Slide3 = Opt01S03[WM.WitchLevel];
        }
        if (INum == 4)
        {
            Opt01S04[WM.WitchLevel] = IInputs02[4].text; // opt01 is option 2
            Op.O1Slide4 = Opt01S04[WM.WitchLevel];
        }
        if (INum == 5)
        {
            Opt01S05[WM.WitchLevel] = IInputs02[5].text; // opt01 is option 2
            Op.O1Slide5 = Opt01S05[WM.WitchLevel];
        }
        if (INum == 6)
        {
            Opt01S06[WM.WitchLevel] = IInputs02[6].text; // opt01 is option 2
            Op.O1Slide6 = Opt01S06[WM.WitchLevel];
        }
        if (INum == 7)
        {
            Opt01S07[WM.WitchLevel] = IInputs02[7].text; // opt01 is option 2
            Op.O1Slide7 = Opt01S07[WM.WitchLevel];
        }
        if (INum == 8)
        {
            Opt01S08[WM.WitchLevel] = IInputs02[8].text; // opt01 is option 2
            Op.O1Slide8 = Opt01S08[WM.WitchLevel];
        }
        if (INum == 9)
        {
            Opt01S09[WM.WitchLevel] = IInputs02[9].text; // opt01 is option 2
            Op.O1Slide9 = Opt01S09[WM.WitchLevel];
        }
        if (INum == 10)
        {
            Opt01S010[WM.WitchLevel] = IInputs02[10].text; // opt01 is option 2
            Op.O1Slide10 = Opt01S010[WM.WitchLevel];
        }
        if (INum == 11)
        {
            Opt01S011[WM.WitchLevel] = IInputs02[11].text; // opt01 is option 2
            Op.O1Slide11 = Opt01S011[WM.WitchLevel];
        }
        if (INum == 12)
        {
            Opt01S012[WM.WitchLevel] = IInputs02[12].text; // opt01 is option 2
            Op.O1Slide12 = Opt01S012[WM.WitchLevel];
        }
        if (INum == 13)
        {
            Opt01S013[WM.WitchLevel] = IInputs02[13].text; // opt01 is option 2
            Op.O1Slide13 = Opt01S013[WM.WitchLevel];
        }
        if (INum == 14)
        {
            Opt01S014[WM.WitchLevel] = IInputs02[14].text; // opt01 is option 2
            Op.O1Slide14 = Opt01S014[WM.WitchLevel];
        }
        if (INum == 15)
        {
            Opt01S015[WM.WitchLevel] = IInputs02[15].text; // opt01 is option 2
            Op.O1Slide15 = Opt01S015[WM.WitchLevel];
        }
        if (INum == 16)
        {
            Opt01S016[WM.WitchLevel] = IInputs02[16].text; // opt01 is option 2
            Op.O1Slide16 = Opt01S016[WM.WitchLevel];
        }
        if (INum == 17)
        {
            Opt01S017[WM.WitchLevel] = IInputs02[17].text; // opt01 is option 2
            Op.O1Slide17 = Opt01S017[WM.WitchLevel];
        }
        if (INum == 18)
        {
            Opt01S018[WM.WitchLevel] = IInputs02[18].text; // opt01 is option 2
            Op.O1Slide18 = Opt01S018[WM.WitchLevel];
        }
        if (INum == 19)
        {
            Opt01S019[WM.WitchLevel] = IInputs02[19].text; // opt01 is option 2
            Op.O1Slide19 = Opt01S019[WM.WitchLevel];
        }
        if (INum == 20)
        {
            Opt01S020[WM.WitchLevel] = IInputs02[20].text; // opt01 is option 2
            Op.O1Slide20 = Opt01S020[WM.WitchLevel];
        }

        Op.TextChange();
        AudioSorce.clip = Type;
        AudioSorce.Play();
    }
    public void Option03Input(int INum)
    {
        if (INum == 1) 
        {
            Opt02S01[WM.WitchLevel] = IInputs03[1].text; 
            Op.O2Slide1 = Opt02S01[WM.WitchLevel];
        }
        if (INum == 2)
        {
            Opt02S02[WM.WitchLevel] = IInputs03[2].text;
            Op.O2Slide2 = Opt02S02[WM.WitchLevel];
        }
        if (INum == 3)
        {
            Opt02S03[WM.WitchLevel] = IInputs03[3].text;
            Op.O2Slide3 = Opt02S03[WM.WitchLevel];
        }
        if (INum == 4)
        {
            Opt02S04[WM.WitchLevel] = IInputs03[4].text;
            Op.O2Slide4 = Opt02S04[WM.WitchLevel];
        }
        if (INum == 5)
        {
            Opt02S05[WM.WitchLevel] = IInputs03[5].text;
            Op.O2Slide5 = Opt02S05[WM.WitchLevel];
        }
        if (INum == 6)
        {
            Opt02S06[WM.WitchLevel] = IInputs03[6].text;
            Op.O2Slide6 = Opt02S06[WM.WitchLevel];
        }
        if (INum == 7)
        {
            Opt02S07[WM.WitchLevel] = IInputs03[7].text;
            Op.O2Slide7 = Opt02S07[WM.WitchLevel];
        }
        if (INum == 8)
        {
            Opt02S08[WM.WitchLevel] = IInputs03[8].text;
            Op.O2Slide8 = Opt02S08[WM.WitchLevel];
        }
        if (INum == 9)
        {
            Opt02S09[WM.WitchLevel] = IInputs03[9].text;
            Op.O2Slide9 = Opt02S09[WM.WitchLevel];
        }
        if (INum == 10)
        {
            Opt02S010[WM.WitchLevel] = IInputs03[10].text;
            Op.O2Slide10 = Opt02S010[WM.WitchLevel];
        }
        if (INum == 11)
        {
            Opt02S011[WM.WitchLevel] = IInputs03[11].text;
            Op.O2Slide11 = Opt02S011[WM.WitchLevel];
        }
        if (INum == 12)
        {
            Opt02S012[WM.WitchLevel] = IInputs03[12].text;
            Op.O2Slide12 = Opt02S012[WM.WitchLevel];
        }
        if (INum == 13)
        {
            Opt02S01[WM.WitchLevel] = IInputs03[1].text;
            Op.O2Slide1 = Opt02S01[WM.WitchLevel];
        }
        if (INum == 14)
        {
            Opt02S014[WM.WitchLevel] = IInputs03[14].text;
            Op.O2Slide14 = Opt02S014[WM.WitchLevel];
        }
        if (INum == 15)
        {
            Opt02S015[WM.WitchLevel] = IInputs03[15].text;
            Op.O2Slide15 = Opt02S015[WM.WitchLevel];
        }
        if (INum == 16)
        {
            Opt02S016[WM.WitchLevel] = IInputs03[16].text;
            Op.O2Slide16 = Opt02S016[WM.WitchLevel];
        }
        if (INum == 17)
        {
            Opt02S017[WM.WitchLevel] = IInputs03[17].text;
            Op.O2Slide17 = Opt02S017[WM.WitchLevel];
        }
        if (INum == 18)
        {
            Opt02S018[WM.WitchLevel] = IInputs03[18].text;
            Op.O2Slide18 = Opt02S018[WM.WitchLevel];
        }
        if (INum == 19)
        {
            Opt02S019[WM.WitchLevel] = IInputs03[19].text;
            Op.O2Slide19 = Opt02S019[WM.WitchLevel];
        }
        if (INum == 20)
        {
            Opt02S020[WM.WitchLevel] = IInputs03[20].text;
            Op.O2Slide20 = Opt02S020[WM.WitchLevel];
        }
        Op.TextChange();
        AudioSorce.clip = Type;
        AudioSorce.Play();
    }
    public void Option04Input(int INum)
    {
        if (INum == 1)
        {
            Opt03S01[WM.WitchLevel] = IInputs04[1].text;
            Op.O3Slide1 = Opt03S01[WM.WitchLevel];
        }
        if (INum == 2)
        {
            Opt03S02[WM.WitchLevel] = IInputs04[2].text;
            Op.O3Slide2 = Opt03S02[WM.WitchLevel];
        }
        if (INum == 3)
        {
            Opt03S03[WM.WitchLevel] = IInputs04[3].text;
            Op.O3Slide3 = Opt03S03[WM.WitchLevel];
        }
        if (INum == 4)
        {
            Opt03S04[WM.WitchLevel] = IInputs04[4].text;
            Op.O3Slide4 = Opt03S04[WM.WitchLevel];
        }
        if (INum == 5)
        {
            Opt03S05[WM.WitchLevel] = IInputs04[5].text;
            Op.O3Slide5 = Opt03S05[WM.WitchLevel];
        }
        if (INum == 6)
        {
            Opt03S06[WM.WitchLevel] = IInputs04[6].text;
            Op.O3Slide6 = Opt03S06[WM.WitchLevel];
        }
        if (INum == 7)
        {
            Opt03S07[WM.WitchLevel] = IInputs04[7].text;
            Op.O3Slide7 = Opt03S07[WM.WitchLevel];
        }
        if (INum == 8)
        {
            Opt03S08[WM.WitchLevel] = IInputs04[8].text;
            Op.O3Slide8 = Opt03S08[WM.WitchLevel];
        }
        if (INum == 9)
        {
            Opt03S09[WM.WitchLevel] = IInputs04[9].text;
            Op.O3Slide9 = Opt03S09[WM.WitchLevel];
        }
        if (INum == 10)
        {
            Opt03S010[WM.WitchLevel] = IInputs04[10].text;
            Op.O3Slide10 = Opt03S010[WM.WitchLevel];
        }
        if (INum == 11)
        {
            Opt03S011[WM.WitchLevel] = IInputs04[11].text;
            Op.O3Slide11 = Opt03S011[WM.WitchLevel];
        }
        if (INum == 12)
        {
            Opt03S012[WM.WitchLevel] = IInputs04[12].text;
            Op.O3Slide12 = Opt03S012[WM.WitchLevel];
        }
        if (INum == 13)
        {
            Opt03S013[WM.WitchLevel] = IInputs04[13].text;
            Op.O3Slide13 = Opt03S013[WM.WitchLevel];
        }
        if (INum == 14)
        {
            Opt03S014[WM.WitchLevel] = IInputs04[14].text;
            Op.O3Slide14 = Opt03S014[WM.WitchLevel];
        }
        if (INum == 15)
        {
            Opt03S015[WM.WitchLevel] = IInputs04[15].text;
            Op.O3Slide15 = Opt03S015[WM.WitchLevel];
        }
        if (INum == 16)
        {
            Opt03S016[WM.WitchLevel] = IInputs04[16].text;
            Op.O3Slide16 = Opt03S016[WM.WitchLevel];
        }
        if (INum == 17)
        {
            Opt03S017[WM.WitchLevel] = IInputs04[17].text;
            Op.O3Slide17 = Opt03S017[WM.WitchLevel];
        }
        if (INum == 18)
        {
            Opt03S018[WM.WitchLevel] = IInputs04[18].text;
            Op.O3Slide1 = Opt03S01[WM.WitchLevel];
        }
        if (INum == 19)
        {
            Opt03S019[WM.WitchLevel] = IInputs04[19].text;
            Op.O3Slide19 = Opt03S019[WM.WitchLevel];
        }
        if (INum == 20)
        {
            Opt03S020[WM.WitchLevel] = IInputs04[20].text;
            Op.O3Slide20 = Opt03S020[WM.WitchLevel];
        }
        Op.TextChange();
        AudioSorce.clip = Type;
        AudioSorce.Play();
    }
    public void Option05Input(int INum)
    {
        if (INum == 1)
        {
            Opt04S01[WM.WitchLevel] = IInputs05[1].text;
            Op.O4Slide1 = Opt04S01[WM.WitchLevel];
        }
        if (INum == 2)
        {
            Opt04S02[WM.WitchLevel] = IInputs05[2].text;
            Op.O4Slide2 = Opt04S02[WM.WitchLevel];
        }
        if (INum == 3)
        {
            Opt04S03[WM.WitchLevel] = IInputs05[3].text;
            Op.O4Slide3 = Opt04S03[WM.WitchLevel];
        }
        if (INum == 4)
        {
            Opt04S04[WM.WitchLevel] = IInputs05[4].text;
            Op.O4Slide4 = Opt04S04[WM.WitchLevel];
        }
        if (INum == 5)
        {
            Opt04S05[WM.WitchLevel] = IInputs05[5].text;
            Op.O4Slide5 = Opt04S05[WM.WitchLevel];
        }
        if (INum == 6)
        {
            Opt04S06[WM.WitchLevel] = IInputs05[6].text;
            Op.O4Slide6 = Opt04S06[WM.WitchLevel];
        }
        if (INum == 7)
        {
            Opt04S07[WM.WitchLevel] = IInputs05[7].text;
            Op.O4Slide7 = Opt04S07[WM.WitchLevel];
        }
        if (INum == 8)
        {
            Opt04S08[WM.WitchLevel] = IInputs05[8].text;
            Op.O4Slide8 = Opt04S08[WM.WitchLevel];
        }
        if (INum == 9)
        {
            Opt04S09[WM.WitchLevel] = IInputs05[9].text;
            Op.O4Slide9 = Opt04S09[WM.WitchLevel];
        }
        if (INum == 10)
        {
            Opt04S010[WM.WitchLevel] = IInputs05[10].text;
            Op.O4Slide10 = Opt04S010[WM.WitchLevel];
        }
        if (INum == 11)
        {
            Opt04S011[WM.WitchLevel] = IInputs05[11].text;
            Op.O4Slide11 = Opt04S011[WM.WitchLevel];
        }
        if (INum == 12)
        {
            Opt04S012[WM.WitchLevel] = IInputs05[12].text;
            Op.O4Slide12 = Opt04S012[WM.WitchLevel];
        }
        if (INum == 13)
        {
            Opt04S013[WM.WitchLevel] = IInputs05[13].text;
            Op.O4Slide13 = Opt04S013[WM.WitchLevel];
        }
        if (INum == 14)
        {
            Opt04S014[WM.WitchLevel] = IInputs05[14].text;
            Op.O4Slide14 = Opt04S014[WM.WitchLevel];
        }
        if (INum == 15)
        {
            Opt04S015[WM.WitchLevel] = IInputs05[15].text;
            Op.O4Slide15 = Opt04S015[WM.WitchLevel];
        }
        if (INum == 16)
        {
            Opt04S016[WM.WitchLevel] = IInputs05[16].text;
            Op.O4Slide16 = Opt04S016[WM.WitchLevel];
        }
        if (INum == 17)
        {
            Opt04S017[WM.WitchLevel] = IInputs05[17].text;
            Op.O4Slide17 = Opt04S017[WM.WitchLevel];
        }
        if (INum == 18)
        {
            Opt04S018[WM.WitchLevel] = IInputs05[18].text;
            Op.O4Slide18 = Opt04S018[WM.WitchLevel];
        }
        if (INum == 19)
        {
            Opt04S019[WM.WitchLevel] = IInputs05[19].text;
            Op.O4Slide19 = Opt04S019[WM.WitchLevel];
        }
        if (INum == 20)
        {
            Opt04S020[WM.WitchLevel] = IInputs05[20].text;
            Op.O4Slide20 = Opt04S020[WM.WitchLevel];
        }
        Op.TextChange();
        AudioSorce.clip = Type;
        AudioSorce.Play();
    }
    public void Option06Input(int INum)
    {
        if (INum == 1)
        {
            Opt05S01[WM.WitchLevel] = IInputs06[1].text;
            Op.O5Slide1 = Opt05S01[WM.WitchLevel];
        }
        if (INum == 2)
        {
            Opt05S02[WM.WitchLevel] = IInputs06[2].text;
            Op.O5Slide2 = Opt05S02[WM.WitchLevel];
        }
        if (INum == 3)
        {
            Opt05S03[WM.WitchLevel] = IInputs06[3].text;
            Op.O5Slide3 = Opt05S03[WM.WitchLevel];
        }
        if (INum == 4)
        {
            Opt05S04[WM.WitchLevel] = IInputs06[4].text;
            Op.O5Slide4 = Opt05S04[WM.WitchLevel];
        }
        if (INum == 5)
        {
            Opt05S05[WM.WitchLevel] = IInputs06[5].text;
            Op.O5Slide5 = Opt05S05[WM.WitchLevel];
        }
        if (INum == 6)
        {
            Opt05S06[WM.WitchLevel] = IInputs06[6].text;
            Op.O5Slide6 = Opt05S06[WM.WitchLevel];
        }
        if (INum == 7)
        {
            Opt05S07[WM.WitchLevel] = IInputs06[7].text;
            Op.O5Slide7 = Opt05S07[WM.WitchLevel];
        }
        if (INum == 8)
        {
            Opt05S08[WM.WitchLevel] = IInputs06[8].text;
            Op.O5Slide8 = Opt05S08[WM.WitchLevel];
        }
        if (INum == 9)
        {
            Opt05S09[WM.WitchLevel] = IInputs06[9].text;
            Op.O5Slide9 = Opt05S09[WM.WitchLevel];
        }
        if (INum == 10)
        {
            Opt05S010[WM.WitchLevel] = IInputs06[10].text;
            Op.O5Slide10 = Opt05S010[WM.WitchLevel];
        }
        if (INum == 11)
        {
            Opt05S011[WM.WitchLevel] = IInputs06[11].text;
            Op.O5Slide11 = Opt05S011[WM.WitchLevel];
        }
        if (INum == 12)
        {
            Opt05S012[WM.WitchLevel] = IInputs06[12].text;
            Op.O5Slide12 = Opt05S012[WM.WitchLevel];
        }
        if (INum == 13)
        {
            Opt05S013[WM.WitchLevel] = IInputs06[13].text;
            Op.O5Slide13 = Opt05S013[WM.WitchLevel];
        }
        if (INum == 14)
        {
            Opt05S014[WM.WitchLevel] = IInputs06[14].text;
            Op.O5Slide14 = Opt05S014[WM.WitchLevel];
        }
        if (INum == 15)
        {
            Opt05S015[WM.WitchLevel] = IInputs06[15].text;
            Op.O5Slide15 = Opt05S015[WM.WitchLevel];
        }
        if (INum == 16)
        {
            Opt05S016[WM.WitchLevel] = IInputs06[16].text;
            Op.O5Slide16 = Opt05S016[WM.WitchLevel];
        }
        if (INum == 17)
        {
            Opt05S017[WM.WitchLevel] = IInputs06[17].text;
            Op.O5Slide17 = Opt05S017[WM.WitchLevel];
        }
        if (INum == 18)
        {
            Opt05S018[WM.WitchLevel] = IInputs06[18].text;
            Op.O5Slide18 = Opt05S018[WM.WitchLevel];
        }
        if (INum == 19)
        {
            Opt05S019[WM.WitchLevel] = IInputs06[19].text;
            Op.O5Slide19 = Opt05S019[WM.WitchLevel];
        }
        if (INum == 20)
        {
            Opt05S020[WM.WitchLevel] = IInputs06[20].text;
            Op.O5Slide20 = Opt05S020[WM.WitchLevel];
        }
        Op.TextChange();
        AudioSorce.clip = Type;
        AudioSorce.Play();
    }
    public void CorrectAnswer(int CNum)
    {
        if (CNum == 1)
        {
            if (CInputs01[1].text == "1")
            {
                Crct01[WM.WitchLevel] = 1; 
                Op.CSlide1 = Crct01[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[1].text == "2")
            {
                Crct01[WM.WitchLevel] = 2;
                Op.CSlide1 = Crct01[WM.WitchLevel];
            }
            if (CInputs01[1].text == "3")
            {
                Crct01[WM.WitchLevel] = 3;
                Op.CSlide1 = Crct01[WM.WitchLevel];
            }
            if (CInputs01[1].text == "4")
            {
                Crct01[WM.WitchLevel] = 4;
                Op.CSlide1 = Crct01[WM.WitchLevel];
            }
            if (CInputs01[1].text == "5")
            {
                Crct01[WM.WitchLevel] = 5;
                Op.CSlide1 = Crct01[WM.WitchLevel];
            }
            if (CInputs01[1].text == "6")
            {
                Crct01[WM.WitchLevel] = 6;
                Op.CSlide1 = Crct01[WM.WitchLevel];
            }
            if (CInputs01[1].text == "7")
            {
                Crct01[WM.WitchLevel] = 7;
                Op.CSlide1 = Crct01[WM.WitchLevel];
            }
        }
        if (CNum == 2)
        {
            if (CInputs01[2].text == "1")
            {
                Crct02[WM.WitchLevel] = 1;
                Op.CSlide2 = Crct02[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[2].text == "2")
            {
                Crct02[WM.WitchLevel] = 2;
                Op.CSlide2 = Crct02[WM.WitchLevel];
            }
            if (CInputs01[WM.WitchLevel].text == "3")
            {
                Crct02[2] = 3;
                Op.CSlide2 = Crct02[WM.WitchLevel];
            }
            if (CInputs01[2].text == "4")
            {
                Crct02[WM.WitchLevel] = 4;
                Op.CSlide2 = Crct02[WM.WitchLevel];
            }
            if (CInputs01[2].text == "5")
            {
                Crct02[WM.WitchLevel] = 5;
                Op.CSlide2 = Crct02[WM.WitchLevel];
            }
            if (CInputs01[2].text == "6")
            {
                Crct02[WM.WitchLevel] = 6;
                Op.CSlide2 = Crct02[WM.WitchLevel];
            }
            if (CInputs01[2].text == "7")
            {
                Crct02[WM.WitchLevel] = 7;
                Op.CSlide2 = Crct02[WM.WitchLevel];
            }
        }
        if (CNum == 3)
        {
            if (CInputs01[3].text == "1")
            {
                Crct03[WM.WitchLevel] = 1;
                Op.CSlide3 = Crct03[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[3].text == "2")
            {
                Crct03[WM.WitchLevel] = 2;
                Op.CSlide3 = Crct03[WM.WitchLevel];
            }
            if (CInputs01[3].text == "3")
            {
                Crct03[WM.WitchLevel] = 3;
                Op.CSlide3 = Crct03[WM.WitchLevel];
            }
            if (CInputs01[3].text == "4")
            {
                Crct03[WM.WitchLevel] = 4;
                Op.CSlide3 = Crct03[WM.WitchLevel];
            }
            if (CInputs01[3].text == "5")
            {
                Crct03[WM.WitchLevel] = 5;
                Op.CSlide3 = Crct03[WM.WitchLevel];
            }
            if (CInputs01[3].text == "6")
            {
                Crct03[WM.WitchLevel] = 6;
                Op.CSlide3 = Crct03[WM.WitchLevel];
            }
            if (CInputs01[3].text == "7")
            {
                Crct03[WM.WitchLevel] = 7;
                Op.CSlide3 = Crct03[WM.WitchLevel];
            }
        }
        if (CNum == 4)
        {
            if (CInputs01[4].text == "1")
            {
                Crct04[WM.WitchLevel] = 1;
                Op.CSlide4 = Crct04[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[4].text == "2")
            {
                Crct04[WM.WitchLevel] = 2;
                Op.CSlide4 = Crct04[WM.WitchLevel];
            }
            if (CInputs01[4].text == "3")
            {
                Crct04[WM.WitchLevel] = 3;
                Op.CSlide4 = Crct04[WM.WitchLevel];
            }
            if (CInputs01[4].text == "4")
            {
                Crct04[WM.WitchLevel] = 4;
                Op.CSlide4 = Crct04[WM.WitchLevel];
            }
            if (CInputs01[4].text == "5")
            {
                Crct04[WM.WitchLevel] = 5;
                Op.CSlide4 = Crct04[WM.WitchLevel];
            }
            if (CInputs01[4].text == "6")
            {
                Crct04[WM.WitchLevel] = 6;
                Op.CSlide4 = Crct04[WM.WitchLevel];
            }
            if (CInputs01[4].text == "7")
            {
                Crct04[WM.WitchLevel] = 7;
                Op.CSlide4 = Crct01[WM.WitchLevel];
            }
        }
        if (CNum == 5)
        {
            if (CInputs01[5].text == "1") //I named it Cinputs01 by mistake. It should have been just CInputs. 
            {
                Crct05[WM.WitchLevel] = 1;
                Op.CSlide5 = Crct05[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[5].text == "2")
            {
                Crct05[WM.WitchLevel] = 2;
                Op.CSlide5 = Crct05[WM.WitchLevel];
            }
            if (CInputs01[5].text == "3")
            {
                Crct05[WM.WitchLevel] = 3;
                Op.CSlide5 = Crct05[WM.WitchLevel];
            }
            if (CInputs01[5].text == "4")
            {
                Crct05[WM.WitchLevel] = 4;
                Op.CSlide5 = Crct05[WM.WitchLevel];
            }
            if (CInputs01[5].text == "5")
            {
                Crct05[WM.WitchLevel] = 5;
                Op.CSlide5 = Crct05[WM.WitchLevel];
            }
            if (CInputs01[5].text == "6")
            {
                Crct05[WM.WitchLevel] = 6;
                Op.CSlide5 = Crct05[WM.WitchLevel];
            }
            if (CInputs01[5].text == "7")
            {
                Crct05[WM.WitchLevel] = 7;
                Op.CSlide5 = Crct05[WM.WitchLevel];
            }
        }
        if (CNum == 6)
        {
            if (CInputs01[6].text == "1")
            {
                Crct06[WM.WitchLevel] = 1;
                Op.CSlide6 = Crct06[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[6].text == "2")
            {
                Crct06[WM.WitchLevel] = 2;
                Op.CSlide6 = Crct06[WM.WitchLevel];
            }
            if (CInputs01[6].text == "3")
            {
                Crct06[WM.WitchLevel] = 3;
                Op.CSlide6 = Crct06[WM.WitchLevel];
            }
            if (CInputs01[6].text == "4")
            {
                Crct06[WM.WitchLevel] = 4;
                Op.CSlide6 = Crct06[WM.WitchLevel];
            }
            if (CInputs01[6].text == "5")
            {
                Crct06[WM.WitchLevel] = 5;
                Op.CSlide6 = Crct06[WM.WitchLevel];
            }
            if (CInputs01[6].text == "6")
            {
                Crct06[WM.WitchLevel] = 6;
                Op.CSlide6 = Crct06[WM.WitchLevel];
            }
            if (CInputs01[6].text == "7")
            {
                Crct06[WM.WitchLevel] = 7;
                Op.CSlide6 = Crct06[WM.WitchLevel];
            }
        }
        if (CNum == 7)
        {
            if (CInputs01[7].text == "1")
            {
                Crct07[WM.WitchLevel] = 1;
                Op.CSlide7 = Crct07[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[7].text == "2")
            {
                Crct07[WM.WitchLevel] = 2;
                Op.CSlide7 = Crct07[WM.WitchLevel];
            }
            if (CInputs01[7].text == "3")
            {
                Crct07[WM.WitchLevel] = 3;
                Op.CSlide7 = Crct07[WM.WitchLevel];
            }
            if (CInputs01[7].text == "4")
            {
                Crct07[WM.WitchLevel] = 4;
                Op.CSlide7 = Crct07[WM.WitchLevel];
            }
            if (CInputs01[7].text == "5")
            {
                Crct07[WM.WitchLevel] = 5;
                Op.CSlide7 = Crct07[WM.WitchLevel];
            }
            if (CInputs01[7].text == "6")
            {
                Crct07[WM.WitchLevel] = 6;
                Op.CSlide7 = Crct07[WM.WitchLevel];
            }
            if (CInputs01[7].text == "7")
            {
                Crct07[WM.WitchLevel] = 7;
                Op.CSlide7 = Crct07[WM.WitchLevel];
            }
        }
        if (CNum == 8)
        {
            if (CInputs01[8].text == "1")
            {
                Crct08[WM.WitchLevel] = 1;
                Op.CSlide8 = Crct08[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[8].text == "2")
            {
                Crct08[WM.WitchLevel] = 2;
                Op.CSlide8 = Crct08[WM.WitchLevel];
            }
            if (CInputs01[8].text == "3")
            {
                Crct08[WM.WitchLevel] = 3;
                Op.CSlide8 = Crct08[WM.WitchLevel];
            }
            if (CInputs01[8].text == "4")
            {
                Crct08[WM.WitchLevel] = 4;
                Op.CSlide8 = Crct08[WM.WitchLevel];
            }
            if (CInputs01[8].text == "5")
            {
                Crct08[WM.WitchLevel] = 5;
                Op.CSlide8 = Crct08[WM.WitchLevel];
            }
            if (CInputs01[8].text == "6")
            {
                Crct01[WM.WitchLevel] = 6;
                Op.CSlide8 = Crct08[WM.WitchLevel];
            }
            if (CInputs01[8].text == "7")
            {
                Crct08[WM.WitchLevel] = 7;
                Op.CSlide8 = Crct01[WM.WitchLevel];
            }
        }
        if (CNum == 9)
        {
            if (CInputs01[9].text == "1")
            {
                Crct09[WM.WitchLevel] = 1;
                Op.CSlide9 = Crct09[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[9].text == "2")
            {
                Crct09[WM.WitchLevel] = 2;
                Op.CSlide9 = Crct09[WM.WitchLevel];
            }
            if (CInputs01[9].text == "3")
            {
                Crct09[WM.WitchLevel] = 3;
                Op.CSlide9 = Crct09[WM.WitchLevel];
            }
            if (CInputs01[9].text == "4")
            {
                Crct09[WM.WitchLevel] = 4;
                Op.CSlide9 = Crct09[WM.WitchLevel];
            }
            if (CInputs01[9].text == "5")
            {
                Crct09[WM.WitchLevel] = 5;
                Op.CSlide9 = Crct09[WM.WitchLevel];
            }
            if (CInputs01[9].text == "6")
            {
                Crct09[WM.WitchLevel] = 6;
                Op.CSlide9 = Crct09[WM.WitchLevel];
            }
            if (CInputs01[9].text == "7")
            {
                Crct09[WM.WitchLevel] = 7;
                Op.CSlide9 = Crct09[WM.WitchLevel];
            }
        }
        if (CNum == 10)
        {
            if (CInputs01[10].text == "1")
            {
                Crct010[WM.WitchLevel] = 1;
                Op.CSlide10 = Crct010[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[10].text == "2")
            {
                Crct010[WM.WitchLevel] = 2;
                Op.CSlide10 = Crct010[WM.WitchLevel];
            }
            if (CInputs01[10].text == "3")
            {
                Crct010[WM.WitchLevel] = 3;
                Op.CSlide10 = Crct010[WM.WitchLevel];
            }
            if (CInputs01[10].text == "4")
            {
                Crct010[WM.WitchLevel] = 4;
                Op.CSlide10 = Crct010[WM.WitchLevel];
            }
            if (CInputs01[10].text == "5")
            {
                Crct010[WM.WitchLevel] = 5;
                Op.CSlide10 = Crct010[WM.WitchLevel];
            }
            if (CInputs01[10].text == "6")
            {
                Crct010[WM.WitchLevel] = 6;
                Op.CSlide10 = Crct010[WM.WitchLevel];
            }
            if (CInputs01[10].text == "7")
            {
                Crct010[WM.WitchLevel] = 7;
                Op.CSlide10 = Crct010[WM.WitchLevel];
            }
        }
        if (CNum == 11)
        {
            if (CInputs01[11].text == "1")
            {
                Crct011[WM.WitchLevel] = 1;
                Op.CSlide11 = Crct011[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[11].text == "2")
            {
                Crct011[WM.WitchLevel] = 2;
                Op.CSlide11 = Crct011[WM.WitchLevel];
            }
            if (CInputs01[11].text == "3")
            {
                Crct011[WM.WitchLevel] = 3;
                Op.CSlide11 = Crct011[WM.WitchLevel];
            }
            if (CInputs01[11].text == "4")
            {
                Crct011[WM.WitchLevel] = 4;
                Op.CSlide11 = Crct011[WM.WitchLevel];
            }
            if (CInputs01[11].text == "5")
            {
                Crct011[WM.WitchLevel] = 5;
                Op.CSlide11 = Crct011[WM.WitchLevel];
            }
            if (CInputs01[11].text == "6")
            {
                Crct011[WM.WitchLevel] = 6;
                Op.CSlide11 = Crct011[WM.WitchLevel];
            }
            if (CInputs01[11].text == "7")
            {
                Crct011[WM.WitchLevel] = 7;
                Op.CSlide11 = Crct011[WM.WitchLevel];
            }
        }
        if (CNum == 12)
        {
            if (CInputs01[12].text == "1")
            {
                Crct012[WM.WitchLevel] = 1;
                Op.CSlide12 = Crct012[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[12].text == "2")
            {
                Crct012[WM.WitchLevel] = 2;
                Op.CSlide12 = Crct012[WM.WitchLevel];
            }
            if (CInputs01[12].text == "3")
            {
                Crct012[WM.WitchLevel] = 3;
                Op.CSlide12 = Crct012[WM.WitchLevel];
            }
            if (CInputs01[12].text == "4")
            {
                Crct012[WM.WitchLevel] = 4;
                Op.CSlide12 = Crct012[WM.WitchLevel];
            }
            if (CInputs01[12].text == "5")
            {
                Crct012[WM.WitchLevel] = 5;
                Op.CSlide12 = Crct012[WM.WitchLevel];
            }
            if (CInputs01[12].text == "6")
            {
                Crct012[WM.WitchLevel] = 6;
                Op.CSlide12 = Crct012[WM.WitchLevel];
            }
            if (CInputs01[12].text == "7")
            {
                Crct012[WM.WitchLevel] = 7;
                Op.CSlide12 = Crct012[WM.WitchLevel];
            }
        }
        if (CNum == 13)
        {
            if (CInputs01[13].text == "1")
            {
                Crct013[WM.WitchLevel] = 1;
                Op.CSlide13 = Crct013[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[13].text == "2")
            {
                Crct013[WM.WitchLevel] = 2;
                Op.CSlide13 = Crct013[WM.WitchLevel];
            }
            if (CInputs01[13].text == "3")
            {
                Crct013[WM.WitchLevel] = 3;
                Op.CSlide13 = Crct013[WM.WitchLevel];
            }
            if (CInputs01[13].text == "4")
            {
                Crct013[WM.WitchLevel] = 4;
                Op.CSlide13 = Crct013[WM.WitchLevel];
            }
            if (CInputs01[13].text == "5")
            {
                Crct013[WM.WitchLevel] = 5;
                Op.CSlide13 = Crct013[WM.WitchLevel];
            }
            if (CInputs01[13].text == "6")
            {
                Crct013[WM.WitchLevel] = 6;
                Op.CSlide13 = Crct013[WM.WitchLevel];
            }
            if (CInputs01[14].text == "7")
            {
                Crct014[WM.WitchLevel] = 7;
                Op.CSlide14 = Crct014[WM.WitchLevel];
            }
        }
        if (CNum == 15)
        {
            if (CInputs01[15].text == "1")
            {
                Crct015[WM.WitchLevel] = 1;
                Op.CSlide15 = Crct015[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[15].text == "2")
            {
                Crct015[WM.WitchLevel] = 2;
                Op.CSlide15 = Crct015[WM.WitchLevel];
            }
            if (CInputs01[15].text == "3")
            {
                Crct015[WM.WitchLevel] = 3;
                Op.CSlide15 = Crct015[WM.WitchLevel];
            }
            if (CInputs01[15].text == "4")
            {
                Crct015[WM.WitchLevel] = 4;
                Op.CSlide15 = Crct015[WM.WitchLevel];
            }
            if (CInputs01[15].text == "5")
            {
                Crct01[WM.WitchLevel] = 5;
                Op.CSlide15 = Crct015[WM.WitchLevel];
            }
            if (CInputs01[15].text == "6")
            {
                Crct015[WM.WitchLevel] = 6;
                Op.CSlide15 = Crct015[WM.WitchLevel];
            }
            if (CInputs01[15].text == "7")
            {
                Crct015[WM.WitchLevel] = 7;
                Op.CSlide15 = Crct015[WM.WitchLevel];
            }
        }
        if (CNum == 16)
        {
            if (CInputs01[16].text == "1")
            {
                Crct016[WM.WitchLevel] = 1;
                Op.CSlide16 = Crct016[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[16].text == "2")
            {
                Crct016[WM.WitchLevel] = 2;
                Op.CSlide16 = Crct016[WM.WitchLevel];
            }
            if (CInputs01[16].text == "3")
            {
                Crct016[WM.WitchLevel] = 3;
                Op.CSlide16 = Crct016[WM.WitchLevel];
            }
            if (CInputs01[16].text == "4")
            {
                Crct016[WM.WitchLevel] = 4;
                Op.CSlide16 = Crct016[WM.WitchLevel];
            }
            if (CInputs01[16].text == "5")
            {
                Crct016[WM.WitchLevel] = 5;
                Op.CSlide16 = Crct016[WM.WitchLevel];
            }
            if (CInputs01[16].text == "6")
            {
                Crct016[WM.WitchLevel] = 6;
                Op.CSlide16 = Crct016[WM.WitchLevel];
            }
            if (CInputs01[16].text == "7")
            {
                Crct016[WM.WitchLevel] = 7;
                Op.CSlide16 = Crct016[WM.WitchLevel];
            }
        }
        if (CNum == 17)
        {
            if (CInputs01[17].text == "1")
            {
                Crct017[WM.WitchLevel] = 1;
                Op.CSlide17 = Crct017[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[17].text == "2")
            {
                Crct017[WM.WitchLevel] = 2;
                Op.CSlide17 = Crct017[WM.WitchLevel];
            }
            if (CInputs01[17].text == "3")
            {
                Crct017[WM.WitchLevel] = 3;
                Op.CSlide17 = Crct017[WM.WitchLevel];
            }
            if (CInputs01[17].text == "4")
            {
                Crct017[WM.WitchLevel] = 4;
                Op.CSlide17 = Crct017[WM.WitchLevel];
            }
            if (CInputs01[17].text == "5")
            {
                Crct017[WM.WitchLevel] = 5;
                Op.CSlide17 = Crct017[WM.WitchLevel];
            }
            if (CInputs01[17].text == "6")
            {
                Crct017[WM.WitchLevel] = 6;
                Op.CSlide17 = Crct017[WM.WitchLevel];
            }
            if (CInputs01[17].text == "7")
            {
                Crct017[WM.WitchLevel] = 7;
                Op.CSlide17 = Crct017[WM.WitchLevel];
            }
        }
        if (CNum == 18)
        {
            if (CInputs01[18].text == "1")
            {
                Crct018[WM.WitchLevel] = 1;
                Op.CSlide18 = Crct018[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[18].text == "2")
            {
                Crct018[WM.WitchLevel] = 2;
                Op.CSlide18 = Crct018[WM.WitchLevel];
            }
            if (CInputs01[19].text == "3")
            {
                Crct019[WM.WitchLevel] = 3;
                Op.CSlide19 = Crct019[WM.WitchLevel];
            }
            if (CInputs01[19].text == "4")
            {
                Crct019[WM.WitchLevel] = 4;
                Op.CSlide19 = Crct019[WM.WitchLevel];
            }
            if (CInputs01[19].text == "5")
            {
                Crct019[WM.WitchLevel] = 5;
                Op.CSlide19 = Crct019[WM.WitchLevel];
            }
            if (CInputs01[19].text == "6")
            {
                Crct019[WM.WitchLevel] = 6;
                Op.CSlide19 = Crct019[WM.WitchLevel];
            }
            if (CInputs01[19].text == "7")
            {
                Crct019[WM.WitchLevel] = 7;
                Op.CSlide19 = Crct019[WM.WitchLevel];
            }
        }
        if (CNum == 20)
        {
            if (CInputs01[20].text == "1")
            {
                Crct020[WM.WitchLevel] = 1;
                Op.CSlide20 = Crct020[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[20].text == "2")
            {
                Crct020[WM.WitchLevel] = 2;
                Op.CSlide20 = Crct020[WM.WitchLevel];
            }
            if (CInputs01[20].text == "3")
            {
                Crct020[WM.WitchLevel] = 3;
                Op.CSlide20 = Crct020[WM.WitchLevel];
            }
            if (CInputs01[20].text == "4")
            {
                Crct020[WM.WitchLevel] = 4;
                Op.CSlide20 = Crct020[WM.WitchLevel];
            }
            if (CInputs01[20].text == "5")
            {
                Crct020[WM.WitchLevel] = 5;
                Op.CSlide20 = Crct020[WM.WitchLevel];
            }
            if (CInputs01[20].text == "6")
            {
                Crct020[WM.WitchLevel] = 6;
                Op.CSlide20 = Crct020[WM.WitchLevel];
            }
            if (CInputs01[20].text == "7")
            {
                Crct020[WM.WitchLevel] = 7;
                Op.CSlide20 = Crct020[WM.WitchLevel];
            }
        }
        if (CNum == 19)
        {
            if (CInputs01[19].text == "1")
            {
                Crct019[WM.WitchLevel] = 1;
                Op.CSlide19 = Crct019[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[19].text == "2")
            {
                Crct019[WM.WitchLevel] = 2;
                Op.CSlide19 = Crct019[WM.WitchLevel];
            }
            if (CInputs01[19].text == "3")
            {
                Crct019[WM.WitchLevel] = 3;
                Op.CSlide19 = Crct019[WM.WitchLevel];
            }
            if (CInputs01[19].text == "4")
            {
                Crct019[WM.WitchLevel] = 4;
                Op.CSlide19 = Crct019[WM.WitchLevel];
            }
            if (CInputs01[19].text == "5")
            {
                Crct019[WM.WitchLevel] = 5;
                Op.CSlide19 = Crct019[WM.WitchLevel];
            }
            if (CInputs01[19].text == "6")
            {
                Crct019[WM.WitchLevel] = 6;
                Op.CSlide19 = Crct019[WM.WitchLevel];
            }
            if (CInputs01[19].text == "7")
            {
                Crct019[WM.WitchLevel] = 7;
                Op.CSlide19 = Crct019[WM.WitchLevel];
            }
        }
        if (CNum == 14)
        {
            if (CInputs01[14].text == "1")
            {
                Crct014[WM.WitchLevel] = 1;
                Op.CSlide14 = Crct014[WM.WitchLevel];               //Change Crct01 +1 and CSlide1 +1   
            }
            if (CInputs01[14].text == "2")
            {
                Crct014[WM.WitchLevel] = 2;
                Op.CSlide14 = Crct014[WM.WitchLevel];
            }
            if (CInputs01[14].text == "3")
            {
                Crct014[WM.WitchLevel] = 3;
                Op.CSlide14 = Crct014[WM.WitchLevel];
            }
            if (CInputs01[14].text == "4")
            {
                Crct014[WM.WitchLevel] = 4;
                Op.CSlide14 = Crct014[WM.WitchLevel];
            }
            if (CInputs01[14].text == "5")
            {
                Crct014[WM.WitchLevel] = 5;
                Op.CSlide14 = Crct014[WM.WitchLevel];
            }
            if (CInputs01[14].text == "6")
            {
                Crct014[WM.WitchLevel] = 6;
                Op.CSlide14 = Crct014[WM.WitchLevel];
            }
            if (CInputs01[14].text == "7")
            {
                Crct014[WM.WitchLevel] = 7;
                Op.CSlide14 = Crct014[WM.WitchLevel];
            }
        }
        AudioSorce.clip = Type;
        AudioSorce.Play();
    }
    public void WMInput()
    {
        if (MInput.text == "1")
        {
            WM.WitchLevel = 1;
        }
        if (MInput.text == "2")
        {
            WM.WitchLevel = 2;
        }
        if (MInput.text == "3")
        {
            print("MissionChange Should be 3");
            WM.WitchLevel = 3;
        }
        if (MInput.text == "4")
        {
            WM.WitchLevel = 4;
        }
        if (MInput.text == "5")
        {
            WM.WitchLevel = 5;
        }
        if (MInput.text == "5")
        {
            WM.WitchLevel = 5;
        }
        if (MInput.text == "6")
        {
            WM.WitchLevel = 6;
        }
        if (MInput.text == "7")
        {
            WM.WitchLevel = 7;
        }
        if (MInput.text == "8")
        {
            WM.WitchLevel = 8;
        }
        if (MInput.text == "9")
        {
            WM.WitchLevel = 9;
        }
        if (MInput.text == "10")
        {
            WM.WitchLevel = 10;
        }
        SGC.LoadMissionBuilder();
        TempEditorSaver();
        Op.TextChange();
        AudioSorce.clip = Type;
        AudioSorce.Play();
    }
    void TempEditorSaver() //Goes up to 10 slides
    {
        Op.Q0Slide1 = Qes1[WM.WitchLevel];
        Op.Q0Slide2 = Qes2[WM.WitchLevel];
        Op.Q0Slide3 = Qes3[WM.WitchLevel];
        Op.Q0Slide4 = Qes4[WM.WitchLevel];
        Op.Q0Slide5 = Qes5[WM.WitchLevel];
        Op.Q0Slide6 = Qes6[WM.WitchLevel];
        Op.Q0Slide7 = Qes7[WM.WitchLevel];
        Op.Q0Slide8 = Qes8[WM.WitchLevel];
        Op.Q0Slide9 = Qes9[WM.WitchLevel];
        Op.O0Slide1 = Opt00S01[WM.WitchLevel];
        Op.O0Slide2 = Opt00S02[WM.WitchLevel];
        Op.O0Slide3 = Opt00S03[WM.WitchLevel];
        Op.O0Slide4 = Opt00S04[WM.WitchLevel];
        Op.O0Slide5 = Opt00S05[WM.WitchLevel];
        Op.O0Slide6 = Opt00S06[WM.WitchLevel];
        Op.O0Slide7 = Opt00S07[WM.WitchLevel];
        Op.O0Slide8 = Opt00S08[WM.WitchLevel];
        Op.O0Slide9 = Opt00S09[WM.WitchLevel];
        Op.O0Slide10 = Opt00S010[WM.WitchLevel];
        Op.O1Slide1 = Opt01S01[WM.WitchLevel];
        Op.O1Slide2 = Opt01S02[WM.WitchLevel];
        Op.O1Slide3 = Opt01S03[WM.WitchLevel];
        Op.O1Slide4 = Opt01S04[WM.WitchLevel];
        Op.O1Slide5 = Opt01S05[WM.WitchLevel];
        Op.O1Slide6 = Opt01S06[WM.WitchLevel];
        Op.O1Slide7 = Opt01S07[WM.WitchLevel];
        Op.O1Slide8 = Opt01S08[WM.WitchLevel];
        Op.O1Slide9 = Opt01S09[WM.WitchLevel];
        Op.O1Slide10 = Opt01S010[WM.WitchLevel];
        Op.O2Slide1 = Opt02S01[WM.WitchLevel];
        Op.O2Slide2 = Opt02S02[WM.WitchLevel];
        Op.O2Slide3 = Opt02S03[WM.WitchLevel];
        Op.O2Slide4 = Opt02S04[WM.WitchLevel];
        Op.O2Slide5 = Opt02S05[WM.WitchLevel];
        Op.O2Slide6 = Opt02S06[WM.WitchLevel];
        Op.O2Slide7 = Opt02S07[WM.WitchLevel];
        Op.O2Slide8 = Opt02S08[WM.WitchLevel];
        Op.O2Slide9 = Opt02S09[WM.WitchLevel];
        Op.O2Slide10 = Opt02S010[WM.WitchLevel];
        Op.O3Slide1 = Opt03S01[WM.WitchLevel];
        Op.O3Slide2 = Opt03S02[WM.WitchLevel];
        Op.O3Slide3 = Opt03S03[WM.WitchLevel];
        Op.O3Slide4 = Opt03S04[WM.WitchLevel];
        Op.O3Slide5 = Opt03S05[WM.WitchLevel];
        Op.O3Slide6 = Opt03S06[WM.WitchLevel];
        Op.O3Slide7 = Opt03S07[WM.WitchLevel];
        Op.O3Slide8 = Opt03S08[WM.WitchLevel];
        Op.O3Slide9 = Opt03S09[WM.WitchLevel];
        Op.O3Slide10 = Opt03S010[WM.WitchLevel];
        Op.O4Slide1 = Opt04S01[WM.WitchLevel];
        Op.O4Slide2 = Opt04S02[WM.WitchLevel];
        Op.O4Slide3 = Opt04S03[WM.WitchLevel];
        Op.O4Slide4 = Opt04S04[WM.WitchLevel];
        Op.O4Slide5 = Opt04S05[WM.WitchLevel];
        Op.O4Slide6 = Opt04S06[WM.WitchLevel];
        Op.O4Slide7 = Opt04S07[WM.WitchLevel];
        Op.O4Slide8 = Opt04S08[WM.WitchLevel];
        Op.O4Slide9 = Opt04S09[WM.WitchLevel];
        Op.O4Slide10 = Opt04S010[WM.WitchLevel];
        Op.O5Slide1 = Opt05S01[WM.WitchLevel];
        Op.O5Slide2 = Opt05S02[WM.WitchLevel];
        Op.O5Slide3 = Opt05S03[WM.WitchLevel];
        Op.O5Slide4 = Opt05S04[WM.WitchLevel];
        Op.O5Slide5 = Opt05S05[WM.WitchLevel];
        Op.O5Slide6 = Opt05S06[WM.WitchLevel];
        Op.O5Slide7 = Opt05S07[WM.WitchLevel];
        Op.O5Slide8 = Opt05S08[WM.WitchLevel];
        Op.O5Slide9 = Opt05S09[WM.WitchLevel];
        Op.O5Slide10 = Opt05S010[WM.WitchLevel];
        Op.O6Slide1 = Opt06S01[WM.WitchLevel];
        Op.O6Slide2 = Opt06S02[WM.WitchLevel];
        Op.O6Slide3 = Opt06S03[WM.WitchLevel];
        Op.O6Slide4 = Opt06S04[WM.WitchLevel];
        Op.O6Slide5 = Opt06S05[WM.WitchLevel];
        Op.O6Slide6 = Opt06S06[WM.WitchLevel];
        Op.O6Slide7 = Opt06S07[WM.WitchLevel];
        Op.O6Slide8 = Opt06S08[WM.WitchLevel];
        Op.O6Slide9 = Opt06S09[WM.WitchLevel];
        Op.O6Slide10 = Opt06S010[WM.WitchLevel];
        Op.CSlide1 = Crct01[WM.WitchLevel];
        Op.CSlide2 = Crct02[WM.WitchLevel];
        Op.CSlide3 = Crct03[WM.WitchLevel];
        Op.CSlide4 = Crct04[WM.WitchLevel];
        Op.CSlide5 = Crct05[WM.WitchLevel];
        Op.CSlide6 = Crct06[WM.WitchLevel];
        Op.CSlide7 = Crct07[WM.WitchLevel];
        Op.CSlide8 = Crct08[WM.WitchLevel];
        Op.CSlide9 = Crct09[WM.WitchLevel];
        Op.CSlide10 = Crct010[WM.WitchLevel];
        Op.CSlide11 = Crct011[WM.WitchLevel];
        Op.CSlide12 = Crct012[WM.WitchLevel];
        Op.CSlide13 = Crct013[WM.WitchLevel];
        Op.CSlide14 = Crct014[WM.WitchLevel];
        Op.CSlide15 = Crct015[WM.WitchLevel];
        Op.CSlide16 = Crct016[WM.WitchLevel];
        Op.CSlide17 = Crct017[WM.WitchLevel];
        Op.CSlide18 = Crct018[WM.WitchLevel];
        Op.CSlide19 = Crct019[WM.WitchLevel];
        Op.CSlide20 = Crct020[WM.WitchLevel];
    }
}
