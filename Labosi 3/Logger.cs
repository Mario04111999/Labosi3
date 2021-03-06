﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labosi_3
{
    class Logger
    {
        private string fileName = "cvs.txt";
        private static Logger instance;
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public void SetFileName(string fileName)
        {
            this.fileName = fileName;
        }
        public void LogToFile(string information)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName, true))
            {
                writer.WriteLine(information);
            }
        }

    }
}
