using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilediTesto
{
    public class GestioneFile
    {
        //Metodo per la scrittura file di testo
        public void scrivi_fileditesto(string testo, string dirName, string fileName, string estensioneFile)
        {
            StreamWriter sw = null;
            string pathFile = dirName + @"\" + fileName + "." + estensioneFile;
            try
            {
                sw = File.CreateText(pathFile);//Creazione file di testo
                sw.WriteLine(testo);//Scrittura file di testo
                sw.Close();//Chiusura file di testo
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Il file non può essere scritto, perchè è utilizzato da un altro processo", "ATTENZIONE");
            }
            catch(Exception ex)//Gestire un'eccezione
            {
                MessageBox.Show(ex.Message, "ATTENZIONE"); //("Directory non trovata", "ERRORE"); 
            }

        }
        //Metodo per la lettura file di testo
        public string leggi_fileditesto(string dirName, string fileName, string estensioneFile)
        {
            string pathFile = dirName + @"\" + fileName + "." + estensioneFile;
            StreamReader sr = new StreamReader(pathFile);
            return sr.ReadToEnd();
        }
    }
}
