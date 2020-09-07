using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_new
{
    //Opret en ny klasse i dit projekt, ved at højre-klikke på dit projekt i ”Solution Explorer”, 
    //kald klassen Square. Tjek at din klasse er sat til public.
    public class Square
    {
        private float side;
        //Inde i klassen oprettes derfor kun et felt (det skal være private), du kan kalde attributten 
        //side eller a, du vælger selv datatypen (Tip: Det kan ikke være en string)
        public float Side //nu er jeg i proberties, properties skrives altid med stort
        {
            get { return this.side; }
            set { this.side = value; }
        }
        //Opret en konstruktør, som tager side med som parameter. Inde i konstruktøren kan du ved brug af this, 
        //initialisere din attribut
        public Square(float side)
        {
            this.side = side;
        }
        //Opret en tom konstruktør – default konstruktør. Der skal ikke være nogen parametre
        private Square() //man må have så mange konstruktører man vil, så længe at de har forskellige variabler. 
        {}
    }

    public class Make_Constructor //starter med at lave en ny klasse 
    {
        public Make_Constructor ();

    }

}

