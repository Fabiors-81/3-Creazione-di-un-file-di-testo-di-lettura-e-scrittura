using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilediTesto
{
    internal class HtmlGenera
    {
        public string testa(string titolo)
        {
            string result = "";
            result = "<html>";
            result += "<head>";
            result += "<title>"+titolo+"</title>";
            result += "</head>";
            return result;

        }

        public string body()
        {
            string result = "";
            //Corpo dell'html
            result += "<body>";

            //Collegamento a youtube
            result += "<iframe src='http://www.ecowebhosting.co.uk'></iframe>";

            result += "<iframe src='helloworld.html' frameborder='0'></iframe>";
            result += "<iframe width='569' height='315'";

            //Collegamento a youtube
            result += "src='http://www.youtube.com/embed/IjS950fumU8?rel=0' frameborder='0'";

            result += "allowfullscreen></iframe>";
            result += "<iframe width='560' height='315' src='https://www.youtube.com/embed/jLozON01eRM'";
            result += "frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' ";
            result += "allowfullscreen></iframe>";
            result += "<iframe width='560' height='315' src='https://www.youtube.com/embed/yksM7Ym2yTU?start=61'";
            result += "frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture'";
            result += "Saveallowfullscreen></iframe>>";
            result += "</body>";
            return result;
        }

        public string close()
        {
            string result = "";
            result += "</html>";
            return result;
        }
    }
}

