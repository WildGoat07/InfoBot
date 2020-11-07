﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Infobot
{
    public class Settings
    {
        #region Public Fields

        public static Settings CurrentSettings;
        public int[] oldHash;
        public TimeSpan? timetableDelay;
        public string[] timetableUrls;

        #endregion Public Fields

        #region Public Properties

        public static Settings Default
        {
            get
            {
                var result = new Settings();
                result.oldHash = new int[] { 0, 0, 0, 0, 0, 0 };
                result.timetableUrls = new string[] { "", "", "", "", "", "" };
                result.timetableDelay = TimeSpan.FromHours(2);
                return result;
            }
        }

        #endregion Public Properties

        #region Public Methods

        public void CheckIntegrity()
        {
            var defaultSettings = Default;
            if (oldHash == null)
            {
                Program.Logger.Warning("Missing Settings.oldHash");
                oldHash = defaultSettings.oldHash;
            }
            if (timetableUrls == null)
            {
                Program.Logger.Warning("Missing Settings.timeTableUrls");
                timetableUrls = defaultSettings.timetableUrls;
            }
            if (timetableDelay == null)
            {
                Program.Logger.Warning("Missing Settings.timetableDelay");
                timetableDelay = defaultSettings.timetableDelay;
            }
        }

        #endregion Public Methods
    }
}