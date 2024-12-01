using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] string personName = "";
    [SerializeField] int q = 0;
    [SerializeField] int p = 0;
    [SerializeField] int X = 0;
    [SerializeField] int Y = 0;
    

    [SerializeField] TMP_Text contadorvictoriasqUI;
    [SerializeField] TMP_Text contadorvictoriaspUI;
    [SerializeField] TMP_Text qPressingsUI;
    [SerializeField] TMP_Text pPressingsUI;
    [SerializeField] GameObject qwinsUI;
    [SerializeField] GameObject pwinsUI;
    [SerializeField] GameObject continuarUI;
    private const int Valormaximo = 10;
    void Start()
    {

        //print("Hi, " + name);
        //int result = numberA / numberB;
        //print( numberA + "/" + numberB + "=" + result);
        
     

       
    }

     
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            p++;
            PrintValues();

            if (p == Valormaximo)
            {
                PrintValues();
                p = Valormaximo; 
                Debug.Log("Victoria P");
                Victoria();
                continuar();

            }
            if (p == 0)
            {
               
                pwinsUI.SetActive(false);
                qwinsUI.SetActive(false);
               
                p = 0;
                q = 0; 
            }
;       }
      
        if (Input.GetKeyDown(KeyCode.Q))
        {
            q++;
            PrintValues();
            if (q == Valormaximo)
            {
                PrintValues();
                q = Valormaximo;
                Victoria();
                continuar();


                Debug.Log("Victoria Q");
            }
            if (q == 0)
            {
                p = 0;
                q = 0;
                
                pwinsUI.SetActive(false);
                qwinsUI.SetActive(false);             
                
                



            }
           
            

        }
        if (q > p)
        {
            qPressingsUI.fontSize = 100;
            pPressingsUI.fontSize = 80;

        }
        if (q < p)
        {
            qPressingsUI.fontSize = 80;
            pPressingsUI.fontSize = 100;

        }
        if (q == p)
        {
            qPressingsUI.fontSize = 80;
            pPressingsUI.fontSize = 80;

        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            q = 0;
            p = 0;
            qPressingsUI.text = q.ToString();
            pPressingsUI.text = p.ToString();
            continuarUI.SetActive(false);
            pwinsUI.SetActive(false);
            qwinsUI.SetActive(false);
        }


    }
    void Victoria()
    {
      if (p == 10)
        {
            pwinsUI.SetActive(true);
            
        }
      else  if ( q == 10)
        {
            qwinsUI.SetActive(true);
        }
    }
    void continuar()
    {
        
        PrintValues();
        if (p == 10)
        {
            continuarUI.SetActive(true);
            X++;
            PrintValues1();
            

            
            p = 10;
            Debug.Log("pulsa g para reiniciar");
            
        }
        else if (q == 10)
        {
            continuarUI.SetActive(true);
            Y++;
             PrintValues1();
             PrintValues();
            q = 10;
            Debug.Log("pulsa g para reiniciar");
            
        }
    }
    
    void PrintValues()
    {
        print("q: " + q + " p:" + p);
        qPressingsUI.text = q.ToString();
        pPressingsUI.text = p.ToString();
        
       
        
        
        


    }
    void PrintValues1()
    {
        print("x:" + q + "y:" + p);
        contadorvictoriasqUI.text = X.ToString();
        contadorvictoriaspUI.text = Y.ToString();
    }
   
}   
      
