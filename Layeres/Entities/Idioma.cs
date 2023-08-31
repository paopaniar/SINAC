﻿using SINAC.Layeres.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAC.Layeres.Entities
{
  public static class Idioma
    {
       public static Dictionary<string, string> info = new Dictionary<string, string>();
       private static void cargar(string archivo)
        {
            info.Clear();
            foreach (string linea in File.ReadLines("lang\\" + archivo))
            {
                if (linea.Contains("="))
                {
                    string[] s = linea.Split(new char[] { '=' });
                    info.Add(s[0], s[1]);
                }
            }

        }
    public static void cambiarIdioma(string archivo)
        {
            Properties.Settings config = new Properties.Settings();
            config.lang = archivo;
            config.Save();
            cargar(archivo);
        }

        //static public void Controles(FrmLogIn f)
        //{
        //    foreach  (string control in info.Keys)
        //    {
                
        //        f.Controls[control].Text= info[control];
        //    }
        //}
        
           
        
    }
}
