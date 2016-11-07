using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SlideScript : MonoBehaviour
{

    public Sprite[] gallery;
    public Image displayImage;
    public Button nextImg;
    public Button prevImg;
    public Button i1;
    public Button i2;
    public Button i3;
    public int i = 0;

    public void BtnNext()
    {
        if (i + 1 < gallery.Length)
        {
            i++;
            Debug.Log("BtnNext");
        }
    }

    public void BtnPrev()
    {
        if (i - 1 >= 0)
        {
            i--;
            Debug.Log("BtnPrev");
        }
    }

    public void Kat1()
    {
        i = 0;
    }
    public void Kat2()
    {
        i = 1;
    }
    public void Kat3()
    {
        i = 2;
    }
    public void Kat4()
    {
        i = 3;
    }
    public void Kat5()
    {
        i = 4;
    }
    public void Kat6()
    {
        i = 5;
    }

    void Update()
    {
        Sprite currentSprite = gallery[i];
        displayImage.sprite = currentSprite;

    }
}