﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core
{
    class CapWords
    {
                public static string FirstCharToUpper(string input)
            {
                if (String.IsNullOrEmpty(input))
                    throw new ArgumentException("WTF!");
                return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }
    }


