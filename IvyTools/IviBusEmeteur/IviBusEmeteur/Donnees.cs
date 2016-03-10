using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IviBusEmeteur
{
    public class Donnees
    {

      
        public string envoiDonneesX()
        {
              Random r = new Random();
            /*int x = 1;
            for (int i = 0; i < 10; i++)
            {
                x += 5;
            }*/
            int posX = r.Next(0, 360);
         //  return " ---Time : 12951360388501 INFO : SPIDER : Posx reelle : "+ posX  +" Position calcul " + (posX+20);
            return "---Time : 12951360388625 INFO : ENVOI BLUETOOTH : ST";
        }

        public string envoiDonneesY()
        {
            int y = 1;
            for (int i = 0; i < 10; i++)
            {
                y += 10;
            }

            //return "Y = " + y.ToString();
            return "---Time : 12951360390425 INFO : RECU BLUETOOTH : AR0,0740,0058";
        }

        public string orientationChanged()
        {
            Random r = new Random();

            int posX = r.Next(0, 360);
            int robot = r.Next(1, 4);

            return "OrientationChanged " + " Robot " + robot + ' ' + " orientation : " + posX + " degrees" ;
        }

        public string positionChanger()
        {
            
            Random r = new Random();

            int posX = r.Next(0,500);
            int posY = r.Next(0,250);
            int robot = r.Next(1, 4);
          
            return "PositionChanged " + " Robot " + robot + ' ' + " posX : " + posX + ' '  + " posY : " + posY;
        }
    }
}
