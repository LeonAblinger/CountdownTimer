/****************************************************************************************************************************
Project:    CountdownTimer
File:       FileHandler.cs
Author:     Leon Ablinger / AblL
Version:    1.0.0.2
Created:    08/03/2022
Updated:    10/03/2022

Copyright (c) 2022 - Leon Ablinger / AblL
****************************************************************************************************************************/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CountdownTimer
{
    public class FileHandler
    {
        private static readonly String DocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static readonly String SettingsFilePath = DocumentsPath + "\\CountdownTimer";
        private static readonly String SettingsFile = SettingsFilePath + "\\settings.ini";
        FileStream SettingsFileStream = null;
        

        public FileHandler()
        {
            if (!File.Exists(SettingsFile))
            {
                Directory.CreateDirectory(SettingsFilePath);
                SettingsFileStream = File.Create(SettingsFile);
                SettingsFileStream.Close();
            }
        }
        /*
        public List<Countdown> ReadCountdowns()
        {
            
        }*/

        public bool Add(Countdown countdown)
        {
            try
            {
                SettingsFileStream = new FileStream(SettingsFile, FileMode.Append, FileAccess.Write, FileShare.Read);
                Byte[] TextBytes = new UTF8Encoding(true).GetBytes(countdown.Name + ";" + countdown.DateTime + ";\n");
                SettingsFileStream.WriteAsync(TextBytes, 0, TextBytes.Length).Wait();
                SettingsFileStream.FlushAsync().Wait();
                SettingsFileStream.Close();
            }
            catch (Exception ex)
            {

            }
            return true;
        }
    }
}
