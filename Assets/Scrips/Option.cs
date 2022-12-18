using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Option : MonoBehaviour
{
    GameObject Option00;
    GameObject Option01;
    GameObject Option02;
    GameObject Option03;
    GameObject Option04;
    GameObject Option05;
    GameObject Option06;
    GameObject Question;
    GameObject Next;
    WitchSlide WS;
    Play Play;
    MissionBuilderGodClass MBC;
    WitchMission WM;
    EconomyAdder EA;
    GoldParticleControll GPC;
    public AudioSource AudioSorce;
    public AudioClip CorectAnswer;
    public AudioClip WrongAnswer;
    [Header("QuestionText")]
    public string Q0Slide1;
    public string Q0Slide2;
    public string Q0Slide3;
    public string Q0Slide4;
    public string Q0Slide5;
    public string Q0Slide6;
    public string Q0Slide7;
    public string Q0Slide8;
    public string Q0Slide9;
    public string Q0Slide10;
    public string Q0Slide11;
    public string Q0Slide12;
    public string Q0Slide13;
    public string Q0Slide14;
    public string Q0Slide15;
    public string Q0Slide16;
    public string Q0Slide17;
    public string Q0Slide18;
    public string Q0Slide19;
    public string Q0Slide20;
    [Space(10)]
    [Header("Option00Text")]
    public string O0Slide1;
    public string O0Slide2;
    public string O0Slide3;
    public string O0Slide4;
    public string O0Slide5;
    public string O0Slide6;
    public string O0Slide7;
    public string O0Slide8;
    public string O0Slide9;
    public string O0Slide10;
    public string O0Slide11;
    public string O0Slide12;
    public string O0Slide13;
    public string O0Slide14;
    public string O0Slide15;
    public string O0Slide16;
    public string O0Slide17;
    public string O0Slide18;
    public string O0Slide19;
    public string O0Slide20;
    [Space(10)]
    [Header("Option01Text")]
    public string O1Slide1;
    public string O1Slide2;
    public string O1Slide3;
    public string O1Slide4;
    public string O1Slide5;
    public string O1Slide6;
    public string O1Slide7;
    public string O1Slide8;
    public string O1Slide9;
    public string O1Slide10;
    public string O1Slide11;
    public string O1Slide12;
    public string O1Slide13;
    public string O1Slide14;
    public string O1Slide15;
    public string O1Slide16;
    public string O1Slide17;
    public string O1Slide18;
    public string O1Slide19;
    public string O1Slide20;
    [Space(10)]
    [Header("Option02Text")]
    public string O2Slide1;
    public string O2Slide2;
    public string O2Slide3;
    public string O2Slide4;
    public string O2Slide5;
    public string O2Slide6;
    public string O2Slide7;
    public string O2Slide8;
    public string O2Slide9;
    public string O2Slide10;
    public string O2Slide11;
    public string O2Slide12;
    public string O2Slide13;
    public string O2Slide14;
    public string O2Slide15;
    public string O2Slide16;
    public string O2Slide17;
    public string O2Slide18;
    public string O2Slide19;
    public string O2Slide20;
    [Space(10)]
    [Header("Option03Text")]
    public string O3Slide1;
    public string O3Slide2;
    public string O3Slide3;
    public string O3Slide4;
    public string O3Slide5;
    public string O3Slide6;
    public string O3Slide7;
    public string O3Slide8;
    public string O3Slide9;
    public string O3Slide10;
    public string O3Slide11;
    public string O3Slide12;
    public string O3Slide13;
    public string O3Slide14;
    public string O3Slide15;
    public string O3Slide16;
    public string O3Slide17;
    public string O3Slide18;
    public string O3Slide19;
    public string O3Slide20;
    [Space(10)]
    [Header("Option04Text")]
    public string O4Slide1;
    public string O4Slide2;
    public string O4Slide3;
    public string O4Slide4;
    public string O4Slide5;
    public string O4Slide6;
    public string O4Slide7;
    public string O4Slide8;
    public string O4Slide9;
    public string O4Slide10;
    public string O4Slide11;
    public string O4Slide12;
    public string O4Slide13;
    public string O4Slide14;
    public string O4Slide15;
    public string O4Slide16;
    public string O4Slide17;
    public string O4Slide18;
    public string O4Slide19;
    public string O4Slide20;
    [Space(10)]
    [Header("Option05Text")]
    public string O5Slide1;
    public string O5Slide2;
    public string O5Slide3;
    public string O5Slide4;
    public string O5Slide5;
    public string O5Slide6;
    public string O5Slide7;
    public string O5Slide8;
    public string O5Slide9;
    public string O5Slide10;
    public string O5Slide11;
    public string O5Slide12;
    public string O5Slide13;
    public string O5Slide14;
    public string O5Slide15;
    public string O5Slide16;
    public string O5Slide17;
    public string O5Slide18;
    public string O5Slide19;
    public string O5Slide20;
    [Space(10)]
    [Header("Option06Text")]
    public string O6Slide1;
    public string O6Slide2;
    public string O6Slide3;
    public string O6Slide4;
    public string O6Slide5;
    public string O6Slide6;
    public string O6Slide7;
    public string O6Slide8;
    public string O6Slide9;
    public string O6Slide10;
    public string O6Slide11;
    public string O6Slide12;
    public string O6Slide13;
    public string O6Slide14;
    public string O6Slide15;
    public string O6Slide16;
    public string O6Slide17;
    public string O6Slide18;
    public string O6Slide19;
    public string O6Slide20;
    [Space(10)]
    [Header("Option07Text")]
    public string O7Slide1;
    [Header("CorectAnswer")]
    public int CSlide0;
    public int CSlide1;
    public int CSlide2;
    public int CSlide3;
    public int CSlide4;
    public int CSlide5;
    public int CSlide6;
    public int CSlide7;
    public int CSlide8;
    public int CSlide9;
    public int CSlide10;
    public int CSlide11;
    public int CSlide12;
    public int CSlide13;
    public int CSlide14;
    public int CSlide15;
    public int CSlide16;
    public int CSlide17;
    public int CSlide18;
    public int CSlide19;
    public int CSlide20;
    //[Space(10)]


    // Start is called before the first frame update
    void Start()
    {
        Play = FindObjectOfType<Play>();
        WS = FindObjectOfType<WitchSlide>();
        Next = GameObject.Find("NextSlide");
        Next.SetActive(false);
        Option00 = GameObject.Find("Option00");
        Option01 = GameObject.Find("Option00 (1)");
        Option02 = GameObject.Find("Option00 (2)");
        Option03 = GameObject.Find("Option00 (3)");
        Option04 = GameObject.Find("Option00 (4)");
        Option05 = GameObject.Find("Option00 (5)");
        Option06 = GameObject.Find("Option00 (6)");
        Question = GameObject.Find("TextChanging");
        MBC = FindObjectOfType<MissionBuilderGodClass>();       
        TextChange();
        AudioSorce = GetComponent<AudioSource>();
        EA = FindObjectOfType<EconomyAdder>();
        GPC = FindObjectOfType<GoldParticleControll>();
    }

    // Update is called once per frame
    void Update()
    {
        print("CSlide01 = " + CSlide1);
    }
    public void TextChange()
    {
        if (WS.SlideNumber == 1)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide1;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide1;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide1;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide1;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide1;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide1;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide1;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide1;
        }
        if (WS.SlideNumber == 2)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide2;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide2;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide2;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide2;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide2;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide2;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide2;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide2;
        }
        if (WS.SlideNumber == 3)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide3;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide3;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide3;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide3;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide3;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide3;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide3;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide3;
        }
        if (WS.SlideNumber == 4)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide4;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide4;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide4;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide4;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide4;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide4;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide4;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide4;
        }
        if (WS.SlideNumber == 5)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide5;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide5;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide5;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide5;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide5;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide5;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide5;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide5;
        }
        if (WS.SlideNumber == 6)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide6;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide6;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide6;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide6;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide6;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide6;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide6;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide6;
        }
        if (WS.SlideNumber == 7)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide7;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide7;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide7;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide7;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide7;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide7;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide7;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide7;
        }
        if (WS.SlideNumber == 8)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide8;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide8;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide8;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide8;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide8;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide8;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide8;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide8;
        }
        if (WS.SlideNumber == 9)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide9;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide9;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide9;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide9;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide9;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide9;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide9;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide9;
        }
        if (WS.SlideNumber == 10)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide10;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide10;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide10;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide10;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide10;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide10;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide10;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide10;
        }
        if (WS.SlideNumber == 11)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide11;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide11;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide11;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide11;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide11;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide11;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide11;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide11;
        }
        if (WS.SlideNumber == 12)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide12;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide12;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide12;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide12;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide12;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide12;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide12;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide12;
        }
        if (WS.SlideNumber == 13)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide13;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide13;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide13;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide13;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide13;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide13;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide13;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide13;
        }
        if (WS.SlideNumber == 14)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide14;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide14;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide14;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide14;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide14;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide14;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide14;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide14;
        }
        if (WS.SlideNumber == 15)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide15;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide15;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide15;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide15;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide15;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide15;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide15;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide15;
        }
        if (WS.SlideNumber == 16)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide16;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide16;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide16;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide16;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide16;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide16;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide16;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide16;
        }
        if (WS.SlideNumber == 17)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide17;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide17;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide17;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide17;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide17;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide17;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide17;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide17;
        }
        if (WS.SlideNumber == 18)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide18;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide18;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide18;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide18;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide18;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide18;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide18;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide18;
        }
        if (WS.SlideNumber == 19)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide19;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide19;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide19;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide19;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide19;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide19;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide19;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide19;
        }
        if (WS.SlideNumber == 20)
        {
            Question.GetComponent<TextMeshProUGUI>().text = Q0Slide20;
            Option00.GetComponent<TextMeshProUGUI>().text = O0Slide20;
            Option01.GetComponent<TextMeshProUGUI>().text = O1Slide20;
            Option02.GetComponent<TextMeshProUGUI>().text = O2Slide20;
            Option03.GetComponent<TextMeshProUGUI>().text = O3Slide20;
            Option04.GetComponent<TextMeshProUGUI>().text = O4Slide20;
            Option05.GetComponent<TextMeshProUGUI>().text = O5Slide20;
            Option06.GetComponent<TextMeshProUGUI>().text = O6Slide20;
        }
        if (WS.SlideNumber == 21)
        {
            Question.GetComponent<TextMeshProUGUI>().text = "Finished you got "  + " correct out of 20";
            Next.SetActive(true);
        }
        if (WS.SlideNumber == 21)
        {
            WS.SlideNumber = 1;
        }

    }
    public void OptionPicked(int Num)
    {
        Next.SetActive(true);
        if (WS.SlideNumber == 1)
        {
            print("Num = " + (Num+1) + " Cslide = " + CSlide1);
            if ((Num+1)  == CSlide1)
            {
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                print("Correct");
                EA.AddGold(20);
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
           if (Num+1 != CSlide1)
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 2)
        {
            if (Num+1 == CSlide2)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 3)
        {
            if (Num+1 == CSlide3)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 4)
        {
            if (Num+1 == CSlide4)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 5)
        {
            if (Num+1 == CSlide5)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 6)
        {
            if (Num+1 == CSlide6)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 7)
        {
            if (Num+1 == CSlide7)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 8)
        {
            if (Num+1 == CSlide8)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 9)
        {
            if (Num+1 == CSlide9)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 10)
        {
            if (Num+1 == CSlide10)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 11)
        {
            if (Num+1 == CSlide11)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 12)
        {
            if (Num+1 == CSlide12)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 13)
        {
            if (Num+1 == CSlide13)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 14)
        {
            if (Num+1 == CSlide14)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 15)
        {
            if (Num+1 == CSlide15)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 16)
        {
            if (Num+1 == CSlide16)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 17)
        {
            if (Num+1 == CSlide17)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 18)
        {
            if (Num+1 == CSlide18)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 19)
        {
            if (Num+1 == CSlide19)
            {
                EA.AddGold(20);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        if (WS.SlideNumber == 20)
        {
            if (Num+1 == CSlide20)
            {
                EA.AddGold(80);
                Question.GetComponent<TextMeshProUGUI>().text = "Correct";
                //WS.SlideNumber += 1;
                AudioSorce.clip = CorectAnswer;
                AudioSorce.Play();
                GPC.PlayGoldOnece();
            }
            else
            {
                Question.GetComponent<TextMeshProUGUI>().text = "InCorrect! The correct answer is " + CorrectSlide();
                AudioSorce.clip = WrongAnswer;
                AudioSorce.Play();
            }
        }
        

    }
    public string CorrectSlide()
    {
        if (WS.SlideNumber == 1)
        {
            if (CSlide1 == 0)
            {
                return (O0Slide1);
            }

            if (CSlide1 == 1)
            {
                return (O1Slide1);
            }
            if (CSlide1 == 2)
            {
                return (O2Slide1);
            }
            if (CSlide1 == 3)
            {
                return (O3Slide1);
            }
            if (CSlide1 == 4)
            {
                return (O4Slide1);
            }
            if (CSlide1 == 5)
            {
                return (O5Slide1);
            }
            if (CSlide1 == 6)
            {
                return (O6Slide1);
            }
            
        }
        return ("Error");
    }
    public void NextSlide()
    {
        WS.SlideNumber += 1;
        Play.SLideBilbord(WS.SlideNumber);
        TextChange();
        Next.SetActive(false);
    }
}
