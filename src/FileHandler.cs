/****************************************************************************************************************************
Project:    CountdownTimer
File:       FileHandler.cs
Author:     Leon Ablinger / AblL
Version:    1.0.0.2
Created:    08/03/2022
Updated:    11/03/2022

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
        private static readonly String SettingsFile = SettingsFilePath + "\\savedCountdowns.ini";
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
        
        public List<Countdown> ReadCountdowns()
        {
            if (!File.Exists(SettingsFile)) return null;

            SettingsFileStream = File.OpenRead(SettingsFile);
            byte[] ReadBytes = new byte[500];
            SettingsFileStream.Read(ReadBytes, 0, (int)SettingsFileStream.Length);

            String ReadString = Encoding.UTF8.GetString(ReadBytes);
            String[] ReadValues = ReadString.Split(new char[] { ';' });

            SettingsFileStream.Close();

            List<Countdown> RetVal = new List<Countdown>();
            for (int i = 0; i < ReadValues.Length;)
            {
                if (ReadValues[i].Contains("\0")) break;

                RetVal.Add(new Countdown(ReadValues[i++], DateTime.Parse(ReadValues[i++])));
            }

            return RetVal;
        }

        public bool Add(Countdown countdown)
        {
            try
            {
                SettingsFileStream = new FileStream(SettingsFile, FileMode.Append, FileAccess.Write, FileShare.Read);
                Byte[] TextBytes = new UTF8Encoding(true).GetBytes(countdown.Name + ";" + countdown.DateTime + ";");
                SettingsFileStream.WriteAsync(TextBytes, 0, TextBytes.Length).Wait();
                SettingsFileStream.FlushAsync().Wait();
                SettingsFileStream.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
